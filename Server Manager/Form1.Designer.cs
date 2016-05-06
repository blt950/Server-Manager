namespace Server_Manager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusServers = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arguments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logBox = new System.Windows.Forms.TextBox();
            this.crashTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.serverToolStripMenuItem,
            this.serversToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStopToolStripMenuItem1,
            this.restartToolStripMenuItem,
            this.toolStripSeparator1,
            this.reloadSettingsToolStripMenuItem1});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // startStopToolStripMenuItem1
            // 
            this.startStopToolStripMenuItem1.Name = "startStopToolStripMenuItem1";
            this.startStopToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.startStopToolStripMenuItem1.Text = "Start/Stop";
            this.startStopToolStripMenuItem1.Click += new System.EventHandler(this.startStopToolStripMenuItem1_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // reloadSettingsToolStripMenuItem1
            // 
            this.reloadSettingsToolStripMenuItem1.Name = "reloadSettingsToolStripMenuItem1";
            this.reloadSettingsToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.reloadSettingsToolStripMenuItem1.Text = "Reload Settings";
            this.reloadSettingsToolStripMenuItem1.Click += new System.EventHandler(this.reloadSettingsToolStripMenuItem_Click);
            // 
            // serversToolStripMenuItem
            // 
            this.serversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAllToolStripMenuItem,
            this.stopAllToolStripMenuItem,
            this.hideAllToolStripMenuItem});
            this.serversToolStripMenuItem.Name = "serversToolStripMenuItem";
            this.serversToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.serversToolStripMenuItem.Text = "All Servers";
            // 
            // startAllToolStripMenuItem
            // 
            this.startAllToolStripMenuItem.Name = "startAllToolStripMenuItem";
            this.startAllToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.startAllToolStripMenuItem.Text = "Start All";
            this.startAllToolStripMenuItem.Click += new System.EventHandler(this.startAllToolStripMenuItem_Click);
            // 
            // stopAllToolStripMenuItem
            // 
            this.stopAllToolStripMenuItem.Name = "stopAllToolStripMenuItem";
            this.stopAllToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.stopAllToolStripMenuItem.Text = "Stop All";
            this.stopAllToolStripMenuItem.Click += new System.EventHandler(this.stopAllToolStripMenuItem_Click);
            // 
            // hideAllToolStripMenuItem
            // 
            this.hideAllToolStripMenuItem.Name = "hideAllToolStripMenuItem";
            this.hideAllToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.hideAllToolStripMenuItem.Text = "Hide All";
            this.hideAllToolStripMenuItem.Click += new System.EventHandler(this.hideAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusServers,
            this.toolStripStatusServer});
            this.statusStrip.Location = new System.Drawing.Point(0, 452);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusServers
            // 
            this.toolStripStatusServers.Name = "toolStripStatusServers";
            this.toolStripStatusServers.Size = new System.Drawing.Size(119, 17);
            this.toolStripStatusServers.Text = "0/0 Servers are online";
            // 
            // toolStripStatusServer
            // 
            this.toolStripStatusServer.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusServer.Name = "toolStripStatusServer";
            this.toolStripStatusServer.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusServer.Text = "No server selected";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Status,
            this.Server,
            this.Path,
            this.Arguments});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 24);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1264, 322);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 25;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Server
            // 
            this.Server.HeaderText = "Server";
            this.Server.Name = "Server";
            this.Server.ReadOnly = true;
            this.Server.Width = 250;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 450;
            // 
            // Arguments
            // 
            this.Arguments.HeaderText = "Arguments";
            this.Arguments.Name = "Arguments";
            this.Arguments.ReadOnly = true;
            this.Arguments.Width = 750;
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logBox.Location = new System.Drawing.Point(0, 352);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(1264, 100);
            this.logBox.TabIndex = 5;
            // 
            // crashTimer
            // 
            this.crashTimer.Enabled = true;
            this.crashTimer.Interval = 5000;
            this.crashTimer.Tick += new System.EventHandler(this.crashTimer_Tick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 474);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Server Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAllToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusServers;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusServer;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startStopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arguments;
        private System.Windows.Forms.ToolStripMenuItem hideAllToolStripMenuItem;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Timer crashTimer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

