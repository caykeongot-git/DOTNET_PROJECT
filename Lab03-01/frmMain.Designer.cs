namespace Lab03_01
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            menuMain = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            fileOpen = new ToolStripMenuItem();
            fileExit = new ToolStripMenuItem();
            statusMain = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            timerMain = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).BeginInit();
            menuMain.SuspendLayout();
            statusMain.SuspendLayout();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            axWindowsMediaPlayer.Dock = DockStyle.Top;
            axWindowsMediaPlayer.Enabled = true;
            axWindowsMediaPlayer.Location = new Point(0, 28);
            axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            axWindowsMediaPlayer.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer.OcxState");
            axWindowsMediaPlayer.Size = new Size(800, 392);
            axWindowsMediaPlayer.TabIndex = 0;
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { menuFile });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(800, 28);
            menuMain.TabIndex = 1;
            menuMain.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { fileOpen, fileExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "File";
            // 
            // fileOpen
            // 
            fileOpen.Name = "fileOpen";
            fileOpen.Size = new Size(224, 26);
            fileOpen.Text = "Open";
            fileOpen.Click += fileOpen_Click;
            // 
            // fileExit
            // 
            fileExit.Name = "fileExit";
            fileExit.Size = new Size(224, 26);
            fileExit.Text = "Exit";
            fileExit.Click += fileExit_Click;
            // 
            // statusMain
            // 
            statusMain.Dock = DockStyle.Fill;
            statusMain.ImageScalingSize = new Size(20, 20);
            statusMain.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusMain.Location = new Point(0, 420);
            statusMain.Name = "statusMain";
            statusMain.Size = new Size(800, 30);
            statusMain.TabIndex = 2;
            statusMain.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 24);
            // 
            // timerMain
            // 
            timerMain.Enabled = true;
            timerMain.Interval = 1000;
            timerMain.Tick += timerMain_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusMain);
            Controls.Add(axWindowsMediaPlayer);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "frmMain";
            Text = "WINDOWS MEDIA PLAYER";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).EndInit();
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            statusMain.ResumeLayout(false);
            statusMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private MenuStrip menuMain;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem fileOpen;
        private ToolStripMenuItem fileExit;
        private StatusStrip statusMain;
        private ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Timer timerMain;
    }
}
