using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;   // For DLL importing 

/*
 * TODO
 * 
 * - Add auto-restart and stop if restart fails 3 times
 * - Add update button
 * - Add GUI server add/remove/edit
 * - Add colored text to the ONLINE/OFFLINE
 * - Not all servers still hiding
 * 
*/

/*
 * Changelog 0.3 (25th August 2015)
 * + Moved "About" to the new "Help" tab.
 * + Moved Reload settings under Servers tab.
 * + Fixed timer error where it didn't reset and stopped servers after 3 crashes no matter what.
 * + Fixed log "All servers has been stopped" repeating for each server shut down when shutting all.
 * 
 * Changelog 0.2 (10th May 2015)
 * 
 * + Added "About" button
 * + Added auto-restart if server crashed.
 * + Added log at bottom of program and console.log file in root folder
 * + Added question when starting or stopping all questions.
 * + Removed resize of window as it messes it up
 * + Cleaned the source code and classes
 * + Fixed runtime error when trying to start server when none is selected
 * + Fixed that restarting a server poped up two message boxes after eachother
 * 
 * Changelog 0.1 (6th March 2015)
 * + Initial Release
*/


namespace Server_Manager
{
    public partial class Form1 : Form
    {

        /* ========================================================= */
        /*                  SYTEM AND FORM INIT
        /* ========================================================= */


        // Importing functioanlity used for window hiding
        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);

        // Variables
        string version = "0.2";
        string logFile = "console.log";
        int totalServers = 0;
        int onlineServers = 0;

        Server selectedServer = null;
        List<Server> servers = new List<Server>();

        // The constructor and initilizer
        public Form1()
        {
            InitializeComponent();
            loadSettings();
            writeServerList();
            updateOnlineServers();

            logAdd("_________________________________________");
            logAdd("Server Manager has started.");
            logAdd("_________________________________________");
        }

        // When the form initialy loads
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " " + version;
        }

        // If user presses X on the form to close it.
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Disable default cancel, let our own function do this.
            exitProgram();
        }

        // Function called when closing the program - closes all servers if exit.
        private void exitProgram()
        {
            DialogResult result = MessageBox.Show("Terminating the program will close all servers.", "Terminate", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                stopAllServers(false);
                System.Environment.Exit(1);
            }
        }

        /* ========================================================= */
        /*                      SERVER GRID
        /* ========================================================= */

        // When a row is selected on the grid view.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                Server s = getServer(id);
                selectedServer = s;
                toolStripStatusServer.Text = "[" + id + "] " + s.getName();
            }
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                Server s = getServer(id);
                selectedServer = s;
                toolStripStatusServer.Text = "[" + id + "] " + s.getName();

                // Show the window when double clicked
                if (selectedServer.proccessAlive() && selectedServer.getOnline())
                {
                    int hWnd = selectedServer.getProcess().MainWindowHandle.ToInt32();
                    ShowWindow(hWnd, 1);
                    selectedServer.setHidden(false);
                }
               
            }
        }

        // Function to update the grid view according to settings.
        private void writeServerList()
        {

            // Delete the grid so we can re-create it.
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            foreach(Server s in servers){

                string online = "OFFLINE";
                if (s.getOnline()) { online = "ONLINE"; }

                int row = dataGridView.Rows.Add(s.getID(), online, s.getName(), s.getPath() + "\\" + s.getExecute(), s.getArguments());
                s.setRow(row);

            }

        }



        /* ========================================================= */
        /*                    LOGGING SYSTEM
        /* ========================================================= */

        // Function to add text to log
        private void logAdd(String text)
        {
       
            DateTime time = DateTime.Now;
            String logText = "["+time+"] "+ text + "\r\n";

            // Write to textbox
            logBox.Text += logText;

            // Write to file
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(logFile, true))
            {
                file.Write(logText);
            }

            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
            
        }

        /* ========================================================= */
        /*                   SETTING SYSTEM
        /* ========================================================= */

        // Function to load settings from file and put them in list
        private void loadSettings()
        {

            try
            {
                int counter = 0;
                string[] lines = System.IO.File.ReadAllLines("servers.cfg");

                for (int i = 0; i < lines.Length; i++)
                {
                    // server.cfg format:
                    // ID | Name | Path | Execute | Arguments

                    String[] args = lines[i].Split('|');

                    if (getServer(Int32.Parse(args[0])) == null)
                    {
                        // Add new server object if ID does not exist.
                        servers.Add(new Server(false, args[0], args[1], args[2], args[3], args[4]));
                    }
                    else
                    {
                       // Edit the server object if it exists
                        Server s = getServer(Int32.Parse(args[0]));
                        s.setName(args[1]);
                        s.setPath(args[2]);
                        s.setExecute(args[3]);
                        s.setArguments(args[4]);

                    }

                    counter++;
                }

                totalServers = counter;

                logAdd("All settings have been reloaded.");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Could not find servers.cfg file in root folder.\nCreate or place one and try again.", "Setting not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Environment.Exit(1);
            }

        }

        /* ========================================================= */
        /*                     SERVER FUNCTIONS
        /* ========================================================= */

        // Return the server from servers list based on ID
        private Server getServer(int id)
        {
            foreach (Server s in servers)
            {
                if (s.getID() == id) { return s; }
            }
            return null;
        }

        // Update the amount of online servers
        private void updateOnlineServers()
        {
            int counter = 0;
            foreach (Server s in servers)
            {
                if (s.getOnline()) { counter++; }
            }

            onlineServers = counter;
            toolStripStatusServers.Text = onlineServers + "/" + totalServers + " servers online";

        }

        // Start SELECTED server
        public void startServer(bool message)
        {
            if (!selectedServer.getOnline())
            {
                try
                {
                    ProcessStartInfo _processStartInfo = new ProcessStartInfo();
                    _processStartInfo.WorkingDirectory = selectedServer.getPath();
                    _processStartInfo.FileName = selectedServer.getExecute();
                    _processStartInfo.Arguments = selectedServer.getArguments();
                    _processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;

                    Process p = Process.Start(_processStartInfo);
                    selectedServer.setProcess(p);

                    selectedServer.setOnline(true);
                    dataGridView["Status", dataGridView.CurrentCell.RowIndex].Value = "ONLINE";

                    updateOnlineServers();

                    if (message)
                    {
                        String msg = "Started " + selectedServer.getName() + " with PID: " + p.Id;
                        MessageBox.Show(msg, "Server started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        logAdd(msg);
                    }
                }
                catch (Win32Exception e)
                {
                    MessageBox.Show("The server you tried to launched failed to launch.\n" + e.Message, "Failed to launch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("This server is already on!", "Already online", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Stop SELECTED server
        public void stopServer(bool message)
        {
            if (selectedServer.getOnline())
            {
                if (selectedServer.getProcess() != null)
                {

                    try
                    {
                        selectedServer.getProcess().Kill();

                        selectedServer.setOnline(false);
                        dataGridView["Status", dataGridView.CurrentCell.RowIndex].Value = "OFFLINE";

                        updateOnlineServers();

                        if (message)
                        {
                            String msg = selectedServer.getName() + " has been stopped!";
                            MessageBox.Show(msg, "Server stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            logAdd(msg);
                        }
                        
                    }
                    catch (InvalidOperationException e)
                    {
                        dataGridView["Status", dataGridView.CurrentCell.RowIndex].Value = "ERROR";
                        selectedServer.setOnline(false);
                        updateOnlineServers();
                        MessageBox.Show(selectedServer.getName() + " has failed to stop!\n" + e.Message, "Server stop failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(selectedServer.getName() + " was failed to stop! Are you sure it started in the first place?", "Server stop failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("This server is already off!", "Already offline", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Restart SELECTED server
        public void restartServer()
        {
            if (selectedServer.getOnline())
            {
                if (selectedServer.getProcess() != null)
                {
                    stopServer(false);
                    startServer(false);

                    

                    String msg = selectedServer.getName() + " has been restarted with new PID: " + selectedServer.getProcess().Id;
                    logAdd(msg);
                    MessageBox.Show(msg, "Server restarted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This server is already offline or crashed. Use Start/Stop button to start it again.", "Server offline", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("This server is already offline or crashed. Use Start/Stop button to start it again.", "Server offline", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // Start ALL servers
        public void startAllServers(bool message)
        {
            foreach (Server s in servers)
            {
                if (!s.getOnline())
                {
                    try
                    {
                        ProcessStartInfo _processStartInfo = new ProcessStartInfo();
                        _processStartInfo.WorkingDirectory = s.getPath();
                        _processStartInfo.FileName = s.getExecute();
                        _processStartInfo.Arguments = s.getArguments();
                        _processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;

                        Process p = Process.Start(_processStartInfo);
                        s.setProcess(p);

                        s.setOnline(true);
                        dataGridView["Status", dataGridView.CurrentCell.RowIndex].Value = "ONLINE";

                        logAdd("All servers have been started.");

                        if (message)
                        {
                            MessageBox.Show("Started " + s.getName() + " with PID: " + p.Id, "Server started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    catch (Win32Exception e)
                    {
                        String msg = s.getName() + " has failed to launch!\n" + e.Message;
                        MessageBox.Show(msg, "Failed to launch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        logAdd(msg);
                    }

                }
            }
            updateOnlineServers();
        }


        // Stop ALL servers
        public void stopAllServers(bool message)
        {
            foreach (Server s in servers)
            {
                if (s.getOnline())
                {
                    try
                    {
                        s.getProcess().Kill();
                        s.setOnline(false);

                        dataGridView["Status", s.getRow()].Value = "OFFLINE";

                        updateOnlineServers();


                        if (message)
                        {
                            MessageBox.Show(s.getName() + " has been stopped!", "Server stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (InvalidOperationException e)
                    {
                        dataGridView["Status", s.getRow()].Value = "ERROR";
                        s.setOnline(false);

                        if (message)
                        {
                            String msg = s.getName() + " has failed to stop!\n" + e.Message;
                            MessageBox.Show(msg, "Server stop failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            logAdd(msg);
                        }
                    }
                }
            }
            logAdd("All servers have been stopped.");
            updateOnlineServers();
        }


        /* ========================================================= */
        /*                      MENU STRIP
        /* ========================================================= */


        // File > Reload Settings
        private void reloadSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadSettings();
            writeServerList();
            updateOnlineServers();
            MessageBox.Show("Settings updated. Server restart is required for changes to take effect.", "Settings updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // File > About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server Manager\r\n\r\nDeveloped by\r\nDaniel \"Blt950\" Lange\r\n\rhttps://github.com/blt950/server-manager", "About", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        // File > Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitProgram();
        }




        // Server > Start/Stop
        private void startStopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (selectedServer != null)
            {
                if (!selectedServer.getOnline())
                {
                    startServer(true);
                }
                else
                {
                    stopServer(true);
                }
            }
            else
            {
                MessageBox.Show("You did not select any server. Select and try again.", "No selected server", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        // Server > Restart
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restartServer();
        }





        // All Servers > Start All
        private void startAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to start ALL servers?", "Starting all servers", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                startAllServers(false);
            }
            
        }

        // All Servers > Stop All
        private void stopAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to terminate ALL servers?", "Stopping all servers", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                stopAllServers(false);
            }
           
        }

        // All Servers > Hide All
        private void hideAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Server s in servers)
            {
                if (!s.getHidden())
                {
                    if (s.proccessAlive() && s.getOnline()) {
                        int hWnd = s.getProcess().MainWindowHandle.ToInt32();
                        ShowWindow(hWnd, 0);
                        selectedServer.setHidden(true);
                    }
                }
            }
        }

        /* ========================================================= */
        /*                      AUTO RESTART
        /* ========================================================= */

        int crashTick = 0;
        private void crashTimer_Tick(object sender, EventArgs e)
        {
            foreach (Server s in servers)
            {

                if (s.getOnline() == true && s.proccessAlive() == false)
                {
                    try
                    {

                        logAdd(s.restartedAmount + " && " + s.lastCrashTick);

                        // Add restart to server. IF true, then server has crashed 3 times.
                        if (s.restartCheck(crashTick))
                        {
                                logAdd(s.getName() + " has crashed for third time in short period. Stopping server.");

                                s.setOnline(false);
                                dataGridView["Status", s.getRow()].Value = "CRASHED";
                                updateOnlineServers();
                                return;
                        }

                        ProcessStartInfo _processStartInfo = new ProcessStartInfo();
                        _processStartInfo.WorkingDirectory = s.getPath();
                        _processStartInfo.FileName = s.getExecute();
                        _processStartInfo.Arguments = s.getArguments();
                        _processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;

                        Process p = Process.Start(_processStartInfo);
                        s.setProcess(p);

                        s.setOnline(true);
                        dataGridView["Status", s.getRow()].Value = "ONLINE";

                        updateOnlineServers();

                        logAdd(s.getName() + " has crashed, and has been restarted with PID: " + p.Id);                        

                    }
                    catch (Win32Exception err)
                    {
                        s.setOnline(false);
                        dataGridView["Status", s.getRow()].Value = "ERROR";
                        logAdd(s.getName() + " has crashed, but failed to restart. ("+err+")");
                    }

                }
            }

            crashTick++;

        }

       

    }
}
