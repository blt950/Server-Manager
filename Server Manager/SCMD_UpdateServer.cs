using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server_Manager
{
    public partial class SCMD_UpdateServer : Form
    {
        private string path;

        public SCMD_UpdateServer(string path)
        {
            this.path = path;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var assemblyPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            Process cmd = new Process();
            cmd.StartInfo.FileName = assemblyPath + "/steamcmd/steamcmd.exe";
            cmd.StartInfo.Arguments = "+login anonymous +force_install_dir " + path + " +app_update " + appID.Text + " validate +quit";
            cmd.Start();

            MessageBox.Show("Closing the CMD Window could break your Installation!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }

        private void btnValveList_Click(object sender, EventArgs e)
        {
            Process.Start("https://developer.valvesoftware.com/wiki/Dedicated_Servers_List");
        }
    }
}
