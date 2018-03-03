namespace Server_Manager
{
    partial class SCMD_InstallServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SCMD_InstallServer));
            this.selectedPath = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.appID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValveList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectedPath
            // 
            resources.ApplyResources(this.selectedPath, "selectedPath");
            this.selectedPath.Name = "selectedPath";
            // 
            // btnSelectPath
            // 
            resources.ApplyResources(this.btnSelectPath, "btnSelectPath");
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnAddServer
            // 
            resources.ApplyResources(this.btnAddServer, "btnAddServer");
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // appID
            // 
            resources.ApplyResources(this.appID, "appID");
            this.appID.Name = "appID";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnValveList
            // 
            resources.ApplyResources(this.btnValveList, "btnValveList");
            this.btnValveList.Name = "btnValveList";
            this.btnValveList.UseVisualStyleBackColor = true;
            this.btnValveList.Click += new System.EventHandler(this.btnValveList_Click);
            // 
            // SCMD_InstallServer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnValveList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedPath);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddServer);
            this.Name = "SCMD_InstallServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectedPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox appID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValveList;
    }
}