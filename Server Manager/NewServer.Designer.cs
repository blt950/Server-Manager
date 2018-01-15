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
            this.btnAddServer.Enabled = false;
            this.btnAddServer.Location = new System.Drawing.Point(313, 207);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(75, 23);
            this.btnAddServer.TabIndex = 0;
            this.btnAddServer.Text = "Add Server";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // currentName
            // 
            this.currentName.Location = new System.Drawing.Point(53, 6);
            this.currentName.Name = "currentName";
            this.currentName.Size = new System.Drawing.Size(335, 20);
            this.currentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Executeable:";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(53, 42);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPath.TabIndex = 7;
            this.btnSelectPath.Text = "Select";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // btnSelectExecuteable
            // 
            this.btnSelectExecuteable.Enabled = false;
            this.btnSelectExecuteable.Location = new System.Drawing.Point(94, 116);
            this.btnSelectExecuteable.Name = "btnSelectExecuteable";
            this.btnSelectExecuteable.Size = new System.Drawing.Size(75, 23);
            this.btnSelectExecuteable.TabIndex = 8;
            this.btnSelectExecuteable.Text = "Select";
            this.btnSelectExecuteable.UseVisualStyleBackColor = true;
            this.btnSelectExecuteable.Click += new System.EventHandler(this.btnSelectExecuteable_Click);
            // 
            // currentPath
            // 
            this.currentPath.Location = new System.Drawing.Point(15, 71);
            this.currentPath.Name = "currentPath";
            this.currentPath.ReadOnly = true;
            this.currentPath.Size = new System.Drawing.Size(373, 20);
            this.currentPath.TabIndex = 9;
            // 
            // currentExecuteable
            // 
            this.currentExecuteable.Location = new System.Drawing.Point(15, 145);
            this.currentExecuteable.Name = "currentExecuteable";
            this.currentExecuteable.ReadOnly = true;
            this.currentExecuteable.Size = new System.Drawing.Size(154, 20);
            this.currentExecuteable.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Additional Arguments (Optional)";
            // 
            // additionalArguments
            // 
            this.additionalArguments.Location = new System.Drawing.Point(12, 207);
            this.additionalArguments.Name = "additionalArguments";
            this.additionalArguments.Size = new System.Drawing.Size(286, 20);
            this.additionalArguments.TabIndex = 12;
            // 
            // NewServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 245);
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
            this.Text = "Create New Server";
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