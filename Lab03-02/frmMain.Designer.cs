namespace Lab03_02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuMain = new MenuStrip();
            menuSystem = new ToolStripMenuItem();
            systemNewPage = new ToolStripMenuItem();
            systemOpenFile = new ToolStripMenuItem();
            systemSaveFile = new ToolStripMenuItem();
            menuFormat = new ToolStripMenuItem();
            formatFont = new ToolStripMenuItem();
            rtbText = new RichTextBox();
            toolMain = new ToolStrip();
            btnNewPage = new ToolStripButton();
            btnSave = new ToolStripButton();
            btnOpen = new ToolStripButton();
            cmbFont = new ToolStripComboBox();
            cmbSizes = new ToolStripComboBox();
            btnBold = new ToolStripButton();
            btnItalic = new ToolStripButton();
            btnUnderline = new ToolStripButton();
            btnColor = new ToolStripButton();
            systemExit = new ToolStripMenuItem();
            menuMain.SuspendLayout();
            toolMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { menuSystem, menuFormat });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(878, 28);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            menuSystem.DropDownItems.AddRange(new ToolStripItem[] { systemNewPage, systemOpenFile, systemSaveFile, systemExit });
            menuSystem.Name = "menuSystem";
            menuSystem.Size = new Size(85, 24);
            menuSystem.Text = "Hệ thống";
            // 
            // systemNewPage
            // 
            systemNewPage.Name = "systemNewPage";
            systemNewPage.ShortcutKeys = Keys.Control | Keys.N;
            systemNewPage.Size = new Size(224, 26);
            systemNewPage.Text = "New";
            systemNewPage.Click += systemNewPage_Click;
            // 
            // systemOpenFile
            // 
            systemOpenFile.Name = "systemOpenFile";
            systemOpenFile.ShortcutKeys = Keys.Control | Keys.O;
            systemOpenFile.Size = new Size(224, 26);
            systemOpenFile.Text = "Open";
            systemOpenFile.Click += systemOpenFile_Click;
            // 
            // systemSaveFile
            // 
            systemSaveFile.Name = "systemSaveFile";
            systemSaveFile.ShortcutKeys = Keys.Control | Keys.S;
            systemSaveFile.Size = new Size(224, 26);
            systemSaveFile.Text = "Save";
            systemSaveFile.Click += systemSaveFile_Click;
            // 
            // menuFormat
            // 
            menuFormat.DropDownItems.AddRange(new ToolStripItem[] { formatFont });
            menuFormat.Name = "menuFormat";
            menuFormat.Size = new Size(94, 24);
            menuFormat.Text = "Định Dạng";
            // 
            // formatFont
            // 
            formatFont.Name = "formatFont";
            formatFont.Size = new Size(121, 26);
            formatFont.Text = "Font";
            // 
            // rtbText
            // 
            rtbText.Dock = DockStyle.Fill;
            rtbText.HideSelection = false;
            rtbText.Location = new Point(0, 56);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(878, 461);
            rtbText.TabIndex = 1;
            rtbText.Text = "";
            // 
            // toolMain
            // 
            toolMain.ImageScalingSize = new Size(20, 20);
            toolMain.Items.AddRange(new ToolStripItem[] { btnNewPage, btnSave, btnOpen, cmbFont, cmbSizes, btnBold, btnItalic, btnUnderline, btnColor });
            toolMain.Location = new Point(0, 28);
            toolMain.Name = "toolMain";
            toolMain.Size = new Size(878, 28);
            toolMain.TabIndex = 2;
            toolMain.Text = "toolStrip1";
            // 
            // btnNewPage
            // 
            btnNewPage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNewPage.Image = (Image)resources.GetObject("btnNewPage.Image");
            btnNewPage.ImageTransparentColor = Color.Magenta;
            btnNewPage.Name = "btnNewPage";
            btnNewPage.Size = new Size(29, 25);
            btnNewPage.Text = "toolStripButton1";
            btnNewPage.ToolTipText = "btnNewPage";
            btnNewPage.Click += btnNewPage_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = Properties.Resources.Save_icon_icons_com_73702;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(29, 25);
            btnSave.Text = "toolStripButton2";
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpen.Image = Properties.Resources.Reports_25409;
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(29, 25);
            btnOpen.Text = "toolStripButton2";
            btnOpen.Click += btnOpen_Click;
            // 
            // cmbFont
            // 
            cmbFont.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFont.Name = "cmbFont";
            cmbFont.Size = new Size(121, 28);
            cmbFont.SelectedIndexChanged += cmbFont_SelectedIndexChanged;
            // 
            // cmbSizes
            // 
            cmbSizes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSizes.Name = "cmbSizes";
            cmbSizes.Size = new Size(121, 28);
            cmbSizes.SelectedIndexChanged += cmbSizes_SelectedIndexChanged;
            // 
            // btnBold
            // 
            btnBold.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBold.Image = Properties.Resources.alphabet_letter_b_icon_260577;
            btnBold.ImageTransparentColor = Color.Magenta;
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(29, 25);
            btnBold.Click += btnBold_Click;
            // 
            // btnItalic
            // 
            btnItalic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnItalic.Image = Properties.Resources.alphabet_letter_i_icon_260578;
            btnItalic.ImageTransparentColor = Color.Magenta;
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(29, 25);
            btnItalic.Text = "toolStripButton2";
            btnItalic.Click += btnItalic_Click;
            // 
            // btnUnderline
            // 
            btnUnderline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUnderline.Image = Properties.Resources.alphabet_letter_u_icon_260584;
            btnUnderline.ImageTransparentColor = Color.Magenta;
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(29, 25);
            btnUnderline.Text = "toolStripButton2";
            btnUnderline.Click += btnUnderline_Click;
            // 
            // btnColor
            // 
            btnColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnColor.Image = (Image)resources.GetObject("btnColor.Image");
            btnColor.ImageTransparentColor = Color.Magenta;
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(29, 25);
            btnColor.Text = "toolStripButton1";
            btnColor.Click += btnColor_Click;
            // 
            // systemExit
            // 
            systemExit.Name = "systemExit";
            systemExit.ShortcutKeys = Keys.Alt | Keys.Space;
            systemExit.Size = new Size(224, 26);
            systemExit.Text = "Exit";
            systemExit.Click += systemExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 517);
            Controls.Add(rtbText);
            Controls.Add(toolMain);
            Controls.Add(menuMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuMain;
            Name = "frmMain";
            Text = "Word Fake";
            Load += frmMain_Load;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            toolMain.ResumeLayout(false);
            toolMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuMain;
        private ToolStripMenuItem menuSystem;
        private ToolStripMenuItem systemNewPage;
        private ToolStripMenuItem systemOpenFile;
        private ToolStripMenuItem systemSaveFile;
        private ToolStripMenuItem menuFormat;
        private ToolStripMenuItem formatFont;
        private RichTextBox rtbText;
        private ToolStrip toolMain;
        private ToolStripButton btnNewPage;
        private ToolStripButton btnSave;
        private ToolStripButton btnOpen;
        private ToolStripComboBox cmbFont;
        private ToolStripComboBox cmbSizes;
        private ToolStripButton btnBold;
        private ToolStripButton btnItalic;
        private ToolStripButton btnUnderline;
        private ToolStripButton btnColor;
        private ToolStripMenuItem systemExit;
    }
}
