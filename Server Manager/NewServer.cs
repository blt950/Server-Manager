using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Server_Manager
{
    public partial class NewServer : Form
    {
        string configPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/servers.cfg";

        public NewServer()
        {
            InitializeComponent();
        }


        // Let the User pick the Path of his Server Executeable
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            using (var pathDialog = new FolderBrowserDialog())
            {
                pathDialog.Description = "Please select the Folder, where your Executeable File of your Server is located.";
                DialogResult result = pathDialog.ShowDialog();

                if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(pathDialog.SelectedPath))
                {
                    currentPath.Text = pathDialog.SelectedPath;
                    btnSelectExecuteable.Enabled = true;
                }
            }
        }

        // Let the User get his Executeable File (Only 1 File can be choosen, Directory Starts at the Path given above)
        private void btnSelectExecuteable_Click(object sender, EventArgs e)
        {
            using (var execDialog = new OpenFileDialog())
            {
                if(!string.IsNullOrWhiteSpace(currentPath.Text))
                {
                    execDialog.InitialDirectory = currentPath.Text;
                }

                execDialog.Multiselect = false;


                DialogResult result = execDialog.ShowDialog();

                if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(execDialog.SafeFileName))
                {
                    currentExecuteable.Text = execDialog.SafeFileName;
                    btnAddServer.Enabled = true;
                }
            }
        }


        // The Function adding the Server to the servers.cfg
        private void btnAddServer_Click(object sender, EventArgs e)
        {
            // Check if everything is filled out
            if(string.IsNullOrWhiteSpace(currentName.Text))
            {
                MessageBox.Show("Server Name can't be Empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Check if the Executeable is in the given Path. If not, throw an Error. If it is, Create the Server in the Config File
            if(File.Exists(currentPath.Text + "/" + currentExecuteable.Text))
            {
                var newID = File.ReadAllLines(configPath).Length + 1;

                File.AppendAllText(configPath, newID + "|" + currentName.Text + "|" + currentPath.Text + "|" + currentExecuteable.Text + "|" + additionalArguments.Text + Environment.NewLine);

                this.Close();
            } else
            {
                MessageBox.Show(currentExecuteable.Text + " doesnt Exist at:\n" + currentPath.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
