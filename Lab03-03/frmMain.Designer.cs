namespace Lab03_03
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuMain = new MenuStrip();
            menuFunction = new ToolStripMenuItem();
            functionAdd = new ToolStripMenuItem();
            functionOpenFile = new ToolStripMenuItem();
            functionExit = new ToolStripMenuItem();
            toolMain = new ToolStrip();
            btnAdd = new ToolStripButton();
            lblAdd = new ToolStripLabel();
            lblSearchName = new ToolStripLabel();
            txtSearchName = new ToolStripTextBox();
            btnKick = new ToolStripButton();
            lblKick = new ToolStripLabel();
            dgvData = new DataGridView();
            menuMain.SuspendLayout();
            toolMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { menuFunction });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(1117, 28);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuStrip1";
            // 
            // menuFunction
            // 
            menuFunction.DropDownItems.AddRange(new ToolStripItem[] { functionAdd, functionOpenFile, functionExit });
            menuFunction.Name = "menuFunction";
            menuFunction.Size = new Size(93, 24);
            menuFunction.Text = "Chức năng";
            // 
            // functionAdd
            // 
            functionAdd.Name = "functionAdd";
            functionAdd.ShortcutKeys = Keys.Control | Keys.N;
            functionAdd.Size = new Size(264, 26);
            functionAdd.Text = "Thêm mới";
            functionAdd.Click += functionAdd_Click;
            // 
            // functionOpenFile
            // 
            functionOpenFile.Name = "functionOpenFile";
            functionOpenFile.ShortcutKeys = Keys.Control | Keys.O;
            functionOpenFile.Size = new Size(264, 26);
            functionOpenFile.Text = "Mở file cho nhanh";
            functionOpenFile.Click += functionOpenFile_Click;
            // 
            // functionExit
            // 
            functionExit.Name = "functionExit";
            functionExit.ShortcutKeys = Keys.Alt | Keys.Space;
            functionExit.Size = new Size(264, 26);
            functionExit.Text = "Thoát";
            functionExit.Click += functionExit_Click;
            // 
            // toolMain
            // 
            toolMain.AutoSize = false;
            toolMain.ImageScalingSize = new Size(20, 20);
            toolMain.Items.AddRange(new ToolStripItem[] { btnAdd, lblAdd, lblSearchName, txtSearchName, btnKick, lblKick });
            toolMain.Location = new Point(0, 28);
            toolMain.Name = "toolMain";
            toolMain.Size = new Size(1117, 67);
            toolMain.TabIndex = 1;
            toolMain.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = false;
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageScaling = ToolStripItemImageScaling.None;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 64);
            btnAdd.Text = "Thêm mới";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = false;
            lblAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(250, 64);
            lblAdd.Text = "Thêm mới";
            lblAdd.TextAlign = ContentAlignment.MiddleLeft;
            lblAdd.Click += lblAdd_Click;
            // 
            // lblSearchName
            // 
            lblSearchName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchName.Name = "lblSearchName";
            lblSearchName.Size = new Size(146, 64);
            lblSearchName.Text = "Tìm kiếm tên";
            lblSearchName.Click += lblSearchName_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.AutoSize = false;
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(200, 67);
            txtSearchName.TextChanged += txtSearchName_TextChanged;
            // 
            // btnKick
            // 
            btnKick.AutoSize = false;
            btnKick.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnKick.Image = (Image)resources.GetObject("btnKick.Image");
            btnKick.ImageScaling = ToolStripItemImageScaling.None;
            btnKick.ImageTransparentColor = Color.Magenta;
            btnKick.Name = "btnKick";
            btnKick.Size = new Size(150, 64);
            btnKick.Text = "Đuổi học";
            btnKick.Click += btnKick_Click;
            // 
            // lblKick
            // 
            lblKick.AutoSize = false;
            lblKick.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKick.Name = "lblKick";
            lblKick.Size = new Size(180, 64);
            lblKick.Text = "Đuổi học";
            lblKick.Click += lblKick_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Dock = DockStyle.Fill;
            dgvData.Location = new Point(0, 95);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(1117, 355);
            dgvData.TabIndex = 2;
            dgvData.ColumnHeaderMouseClick += dgvData_ColumnHeaderMouseClick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1117, 450);
            Controls.Add(dgvData);
            Controls.Add(toolMain);
            Controls.Add(menuMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuMain;
            Name = "frmMain";
            Text = "STUDENTS MANAGEMENT";
            Load += frmMain_Load;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            toolMain.ResumeLayout(false);
            toolMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuMain;
        private ToolStripMenuItem menuFunction;
        private ToolStripMenuItem functionAdd;
        private ToolStripMenuItem functionExit;
        private ToolStrip toolMain;
        private ToolStripButton btnAdd;
        private ToolStripLabel lblAdd;
        private ToolStripLabel lblSearchName;
        private ToolStripTextBox txtSearchName;
        private DataGridView dgvData;
        private ToolStripMenuItem functionOpenFile;
        private ToolStripButton btnKick;
        private ToolStripLabel lblKick;
    }
}