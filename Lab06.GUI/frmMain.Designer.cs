namespace Lab06.GUI
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            txtTimKiem = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            cmbLoaiSach = new ComboBox();
            label5 = new Label();
            txtNamXB = new TextBox();
            label4 = new Label();
            txtTenSach = new TextBox();
            label3 = new Label();
            txtMaSach = new TextBox();
            hi = new Label();
            dgvSach = new DataGridView();
            menuStrip1 = new MenuStrip();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            thốngKêSáchTheoNămToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tableLayoutPanel1.Size = new Size(1341, 690);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtTimKiem, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 37);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Size = new Size(1335, 650);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1329, 65);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THÔNG TIN SÁCH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = DockStyle.Right;
            txtTimKiem.Location = new Point(1049, 68);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(283, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(dgvSach, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 100);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1329, 547);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cmbLoaiSach);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNamXB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenSach);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaSach);
            groupBox1.Controls.Add(hi);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Margin = new Padding(20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 507);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN SÁCH";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Gainsboro;
            btnSua.Location = new Point(159, 439);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 41);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Gainsboro;
            btnXoa.Location = new Point(307, 439);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 41);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Gainsboro;
            btnThem.Location = new Point(6, 439);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 41);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cmbLoaiSach
            // 
            cmbLoaiSach.BackColor = Color.Gainsboro;
            cmbLoaiSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiSach.FormattingEnabled = true;
            cmbLoaiSach.Location = new Point(138, 324);
            cmbLoaiSach.Name = "cmbLoaiSach";
            cmbLoaiSach.Size = new Size(281, 33);
            cmbLoaiSach.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 327);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 0;
            label5.Text = "Thể Loại";
            // 
            // txtNamXB
            // 
            txtNamXB.Location = new Point(138, 236);
            txtNamXB.Name = "txtNamXB";
            txtNamXB.Size = new Size(98, 31);
            txtNamXB.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 239);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 0;
            label4.Text = "Năm XB";
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(138, 148);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(281, 31);
            txtTenSach.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 151);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 0;
            label3.Text = "Tên Sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(138, 64);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(281, 31);
            txtMaSach.TabIndex = 1;
            // 
            // hi
            // 
            hi.AutoSize = true;
            hi.Location = new Point(35, 67);
            hi.Name = "hi";
            hi.Size = new Size(80, 25);
            hi.TabIndex = 0;
            hi.Text = "Mã Sách";
            // 
            // dgvSach
            // 
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Dock = DockStyle.Fill;
            dgvSach.Location = new Point(468, 3);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(858, 541);
            dgvSach.TabIndex = 1;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { thốngKêToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1341, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thốngKêSáchTheoNămToolStripMenuItem });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(86, 24);
            thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // thốngKêSáchTheoNămToolStripMenuItem
            // 
            thốngKêSáchTheoNămToolStripMenuItem.Name = "thốngKêSáchTheoNămToolStripMenuItem";
            thốngKêSáchTheoNămToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            thốngKêSáchTheoNămToolStripMenuItem.Size = new Size(303, 26);
            thốngKêSáchTheoNămToolStripMenuItem.Text = "Thống kê sách theo năm";
            thốngKêSáchTheoNămToolStripMenuItem.Click += thốngKêSáchTheoNămToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 690);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "QUẢN LÝ THÔNG TIN SÁCH";
            Load += frmMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox txtTimKiem;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private ComboBox cmbLoaiSach;
        private Label label5;
        private TextBox txtNamXB;
        private Label label4;
        private TextBox txtTenSach;
        private Label label3;
        private TextBox txtMaSach;
        private Label hi;
        private DataGridView dgvSach;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem thốngKêSáchTheoNămToolStripMenuItem;
    }
}