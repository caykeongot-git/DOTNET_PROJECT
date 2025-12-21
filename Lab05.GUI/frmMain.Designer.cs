namespace Lab05.GUI
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
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            picAvatar = new PictureBox();
            cmbFaculty = new ComboBox();
            btnUploadAvatar = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtAverageScore = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtStudentID = new TextBox();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvStudent = new DataGridView();
            chkUnregister = new CheckBox();
            đăngKýChuyênNgànhToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.3179913F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.68201F));
            tableLayoutPanel1.Size = new Size(1819, 895);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 24.242424F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 75.757576F));
            tableLayoutPanel2.Size = new Size(1813, 140);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1813, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngKýChuyênNgànhToolStripMenuItem });
            chứcNăngToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(111, 29);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 33);
            label1.Name = "label1";
            label1.Size = new Size(1807, 107);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.8833656F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.11664F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 149);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1813, 743);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picAvatar);
            groupBox1.Controls.Add(cmbFaculty);
            groupBox1.Controls.Add(btnUploadAvatar);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtAverageScore);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DodgerBlue;
            groupBox1.Location = new Point(20, 20);
            groupBox1.Margin = new Padding(20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 703);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(158, 343);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(293, 226);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 4;
            picAvatar.TabStop = false;
            // 
            // cmbFaculty
            // 
            cmbFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFaculty.FormattingEnabled = true;
            cmbFaculty.Location = new Point(158, 194);
            cmbFaculty.Name = "cmbFaculty";
            cmbFaculty.Size = new Size(293, 33);
            cmbFaculty.TabIndex = 3;
            // 
            // btnUploadAvatar
            // 
            btnUploadAvatar.Location = new Point(65, 527);
            btnUploadAvatar.Name = "btnUploadAvatar";
            btnUploadAvatar.Size = new Size(64, 42);
            btnUploadAvatar.TabIndex = 2;
            btnUploadAvatar.Text = "...";
            btnUploadAvatar.UseVisualStyleBackColor = true;
            btnUploadAvatar.Click += btnUploadAvatar_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(301, 619);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(18, 619);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 42);
            btnSave.TabIndex = 2;
            btnSave.Text = "Add/Update";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAverageScore
            // 
            txtAverageScore.Location = new Point(158, 270);
            txtAverageScore.Name = "txtAverageScore";
            txtAverageScore.Size = new Size(293, 31);
            txtAverageScore.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(18, 343);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 0;
            label6.Text = "Ảnh Đại Diện";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(18, 273);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 0;
            label5.Text = "Điểm TB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(18, 197);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 0;
            label4.Text = "Khoa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(18, 123);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 0;
            label3.Text = "Họ Tên";
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 120);
            txtName.Name = "txtName";
            txtName.Size = new Size(293, 31);
            txtName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(158, 53);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(293, 31);
            txtStudentID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(18, 56);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 0;
            label2.Text = "MSSV";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dgvStudent, 0, 1);
            tableLayoutPanel4.Controls.Add(chkUnregister, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(526, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 5.21327F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 94.7867355F));
            tableLayoutPanel4.Size = new Size(1284, 737);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // dgvStudent
            // 
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Dock = DockStyle.Fill;
            dgvStudent.Location = new Point(3, 41);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(1278, 693);
            dgvStudent.TabIndex = 1;
            dgvStudent.CellClick += dgvStudent_CellClick;
            // 
            // chkUnregister
            // 
            chkUnregister.Anchor = AnchorStyles.Right;
            chkUnregister.AutoSize = true;
            chkUnregister.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkUnregister.Location = new Point(1013, 4);
            chkUnregister.Name = "chkUnregister";
            chkUnregister.Size = new Size(268, 29);
            chkUnregister.TabIndex = 2;
            chkUnregister.Text = "Chưa Đăng Ký Chuyên Ngành";
            chkUnregister.UseVisualStyleBackColor = true;
            chkUnregister.CheckedChanged += chkUnregister_CheckedChanged;
            // 
            // đăngKýChuyênNgànhToolStripMenuItem
            // 
            đăngKýChuyênNgànhToolStripMenuItem.Name = "đăngKýChuyênNgànhToolStripMenuItem";
            đăngKýChuyênNgànhToolStripMenuItem.ShortcutKeys = Keys.F1;
            đăngKýChuyênNgànhToolStripMenuItem.Size = new Size(317, 30);
            đăngKýChuyênNgànhToolStripMenuItem.Text = "Đăng Ký Chuyên Ngành";
            đăngKýChuyênNgànhToolStripMenuItem.Click += đăngKýChuyênNgànhToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1819, 895);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "QUẢN LÝ SINH VIÊN";
            Load += frmMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TextBox txtAverageScore;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtStudentID;
        private Label label2;
        private Button btnUploadAvatar;
        private Button btnDelete;
        private Button btnSave;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dgvStudent;
        private ComboBox cmbFaculty;
        private PictureBox picAvatar;
        private CheckBox chkUnregister;
        private TextBox txtName;
        private ToolStripMenuItem đăngKýChuyênNgànhToolStripMenuItem;
    }
}