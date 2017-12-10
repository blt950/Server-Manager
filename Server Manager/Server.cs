using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;   // For DLL importing 

namespace Server_Manager
{
    public class Server
    {
        private bool online = false;
        private bool hidden = false;
        private Process process;
        private int id;
        private int row;
        private string name = "";
        private string path = "";
        private string execute = "";
        private string arguments = "";

        public int restartedAmount;
        public int lastCrashTick = 0;

        public Server(bool online, string id, string name, string path, string execute, string arguments)
        {
            this.online = online;
            this.id = Int32.Parse(id);
            this.name = name;
            this.path = path;
            this.execute = execute;
            this.arguments = arguments;
        }

        public bool getOnline() { return online; }
        public bool getHidden() { return hidden; }
        public int getID() { return id; }
        public int getRow() { return row; }
        public string getName() { return name; }
        public string getPath() { return path; }
        public string getExecute() { return execute; }
        public string getArguments() { return arguments; }
        public Process getProcess() { return process; }

        public void setOnline(bool b) { online = b; }
        public void setProcess(Process process) { this.process = process; }
        public void setHidden(bool b) { this.hidden = b; }
        public void setRow(int row) { this.row = row; }
        public void setName(string name) { this.name = name; }
        public void setPath(string path) { this.path = path; }
        public void setExecute(string execute) { this.execute = execute; }
        public void setArguments(string arguments) { this.arguments = arguments; }

        // Returns true if we need to restart, false if not.
        public bool restartCheck(int curTick)
        {

            if (lastCrashTick == 0 || curTick >= lastCrashTick && curTick < (lastCrashTick + 5))
            {
                if (restartedAmount > 2)
                {
                    restartedAmount = 0;
                    lastCrashTick = 0;
                    return true;
                }
                else
                {
                    lastCrashTick = curTick;
                    restartedAmount++;
                    return false;
                }
            }
            else
            {
                restartedAmount = 0;
                lastCrashTick = 0;
                return false;
            }

        }

        public bool proccessAlive()
        {
            Process p = null;
            try
            {
                p = Process.GetProcessById(process.Id);
            }
            catch (Exception)
            {

            }

            if (p == null) return false; else return true;
        }

    }
}
