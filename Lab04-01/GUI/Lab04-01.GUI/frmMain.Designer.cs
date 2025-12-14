namespace Lab04_01.GUI
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnManageFaculty = new Button();
            btnAdd = new Button();
            cbFaculty = new ComboBox();
            txtAverage = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            txtStudentID = new TextBox();
            label2 = new Label();
            dgvData = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKhoaToolStripMenuItem = new ToolStripMenuItem();
            tìmKiếmToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(1874, 889);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvData, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 136);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1868, 750);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnManageFaculty);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cbFaculty);
            groupBox1.Controls.Add(txtAverage);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(50, 50);
            groupBox1.Margin = new Padding(50, 50, 50, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 600);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLight;
            btnDelete.Location = new Point(324, 461);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 48);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlLight;
            btnUpdate.Location = new Point(179, 461);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 48);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLight;
            btnSearch.Location = new Point(253, 535);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 48);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnManageFaculty
            // 
            btnManageFaculty.BackColor = SystemColors.ControlLight;
            btnManageFaculty.Location = new Point(101, 535);
            btnManageFaculty.Name = "btnManageFaculty";
            btnManageFaculty.Size = new Size(111, 48);
            btnManageFaculty.TabIndex = 3;
            btnManageFaculty.Text = "Khoa";
            btnManageFaculty.UseVisualStyleBackColor = false;
            btnManageFaculty.Click += btnManageFaculty_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLight;
            btnAdd.Location = new Point(28, 461);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 48);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbFaculty
            // 
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Items.AddRange(new object[] { "Công Nghệ Thông Tin", "Ngôn Ngữ Anh", "Quản Trị Kinh Doanh" });
            cbFaculty.Location = new Point(130, 262);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(305, 36);
            cbFaculty.TabIndex = 2;
            cbFaculty.Text = "Công Nghệ Thông Tin";
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(130, 356);
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(305, 34);
            txtAverage.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 359);
            label5.Name = "label5";
            label5.Size = new Size(84, 28);
            label5.TabIndex = 0;
            label5.Text = "Điểm TB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 265);
            label4.Name = "label4";
            label4.Size = new Size(57, 28);
            label4.TabIndex = 0;
            label4.Text = "Khoa";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(130, 167);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(305, 34);
            txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 170);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 0;
            label3.Text = "Họ Tên";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(130, 72);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(305, 34);
            txtStudentID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 75);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã Số SV";
            // 
            // dgvData
            // 
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Dock = DockStyle.Fill;
            dgvData.Location = new Point(563, 3);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(1302, 744);
            dgvData.TabIndex = 1;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label1, 0, 1);
            tableLayoutPanel3.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.Size = new Size(1868, 127);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(3, 38);
            label1.Name = "label1";
            label1.Size = new Size(1862, 81);
            label1.TabIndex = 1;
            label1.Text = "Quản lý thông tin Sinh Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1868, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýKhoaToolStripMenuItem, tìmKiếmToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(93, 24);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // quảnLýKhoaToolStripMenuItem
            // 
            quảnLýKhoaToolStripMenuItem.Name = "quảnLýKhoaToolStripMenuItem";
            quảnLýKhoaToolStripMenuItem.ShortcutKeys = Keys.F2;
            quảnLýKhoaToolStripMenuItem.Size = new Size(202, 26);
            quảnLýKhoaToolStripMenuItem.Text = "Quản lý khoa";
            quảnLýKhoaToolStripMenuItem.Click += quảnLýKhoaToolStripMenuItem_Click;
            // 
            // tìmKiếmToolStripMenuItem
            // 
            tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            tìmKiếmToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            tìmKiếmToolStripMenuItem.Size = new Size(202, 26);
            tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            tìmKiếmToolStripMenuItem.Click += tìmKiếmToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1874, 889);
            Controls.Add(tableLayoutPanel1);
            Name = "frmMain";
            Text = "frmMain";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private TextBox txtStudentID;
        private Label label2;
        private TextBox txtAverage;
        private Label label5;
        private Label label4;
        private TextBox txtFullName;
        private Label label3;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cbFaculty;
        private DataGridView dgvData;
        private Button btnSearch;
        private Button btnManageFaculty;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhoaToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmToolStripMenuItem;
    }
}