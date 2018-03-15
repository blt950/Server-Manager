namespace Server_Manager
{
    partial class NewServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewServer));
            this.btnAddServer = new System.Windows.Forms.Button();
            this.currentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.btnSelectExecuteable = new System.Windows.Forms.Button();
            this.currentPath = new System.Windows.Forms.TextBox();
            this.currentExecuteable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.additionalArguments = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddServer
            // 
            resources.ApplyResources(this.btnAddServer, "btnAddServer");
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // currentName
            // 
            resources.ApplyResources(this.currentName, "currentName");
            this.currentName.Name = "currentName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnSelectPath
            // 
            resources.ApplyResources(this.btnSelectPath, "btnSelectPath");
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // btnSelectExecuteable
            // 
            resources.ApplyResources(this.btnSelectExecuteable, "btnSelectExecuteable");
            this.btnSelectExecuteable.Name = "btnSelectExecuteable";
            this.btnSelectExecuteable.UseVisualStyleBackColor = true;
            this.btnSelectExecuteable.Click += new System.EventHandler(this.btnSelectExecuteable_Click);
            // 
            // currentPath
            // 
            resources.ApplyResources(this.currentPath, "currentPath");
            this.currentPath.Name = "currentPath";
            // 
            // currentExecuteable
            // 
            resources.ApplyResources(this.currentExecuteable, "currentExecuteable");
            this.currentExecuteable.Name = "currentExecuteable";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // additionalArguments
            // 
            resources.ApplyResources(this.additionalArguments, "additionalArguments");
            this.additionalArguments.Name = "additionalArguments";
            // 
            // NewServer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.additionalArguments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currentExecuteable);
            this.Controls.Add(this.currentPath);
            this.Controls.Add(this.btnSelectExecuteable);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentName);
            this.Controls.Add(this.btnAddServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.TextBox currentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Button btnSelectExecuteable;
        private System.Windows.Forms.TextBox currentPath;
        private System.Windows.Forms.TextBox currentExecuteable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox additionalArguments;
    }
}