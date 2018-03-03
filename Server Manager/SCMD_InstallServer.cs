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
    public partial class SCMD_InstallServer : Form
    {
        public SCMD_InstallServer()
        {
            InitializeComponent();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            using (var pathDialog = new FolderBrowserDialog())
            {
                pathDialog.Description = "Please select the Folder, where you want your Server to be Located.";
                DialogResult result = pathDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(pathDialog.SelectedPath))
                {
                    selectedPath.Text = pathDialog.SelectedPath;
                }
            }
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(selectedPath.Text) || !string.IsNullOrWhiteSpace(appID.Text))
            {
                var assemblyPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

                Process cmd = new Process();
                cmd.StartInfo.FileName = assemblyPath + "/steamcmd/steamcmd.exe";
                cmd.StartInfo.Arguments = "+login anonymous +force_install_dir " + selectedPath.Text + " +app_update " + appID.Text + " validate +quit";
                cmd.Start();

                MessageBox.Show("Closing the CMD Window could break your Installation!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Close();
            } else
            {
                MessageBox.Show("One or More Textboxes are not filled yet!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValveList_Click(object sender, EventArgs e)
        {
            Process.Start("https://developer.valvesoftware.com/wiki/Dedicated_Servers_List");
        }
    }
}
