namespace Lab04_01.GUI
{
    partial class frmSearchStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchStudent));
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvSearch = new DataGridView();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnBack = new Button();
            btnSearch = new Button();
            cbFaculty = new ComboBox();
            label4 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            txtStudentID = new TextBox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1253, 65);
            label1.TabIndex = 0;
            label1.Text = "Tìm Kiếm Thông Tin Sinh Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(1259, 661);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.Controls.Add(dgvSearch, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 68);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1253, 591);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvSearch
            // 
            dgvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearch.Dock = DockStyle.Fill;
            dgvSearch.Location = new Point(3, 297);
            dgvSearch.Margin = new Padding(3, 2, 3, 2);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.RowHeadersWidth = 51;
            dgvSearch.Size = new Size(1247, 292);
            dgvSearch.TabIndex = 3;
            dgvSearch.CellClick += dgvSearch_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(cbFaculty);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(262, 38);
            groupBox1.Margin = new Padding(262, 38, 262, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(729, 249);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLight;
            btnDelete.Location = new Point(453, 214);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 36);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLight;
            btnBack.Location = new Point(601, 214);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 36);
            btnBack.TabIndex = 11;
            btnBack.Text = "Trở Về";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLight;
            btnSearch.Location = new Point(321, 214);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 36);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbFaculty
            // 
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Items.AddRange(new object[] { "Công Nghệ Thông Tin", "Ngôn Ngữ Anh", "Quản Trị Kinh Doanh" });
            cbFaculty.Location = new Point(284, 151);
            cbFaculty.Margin = new Padding(3, 2, 3, 2);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(267, 29);
            cbFaculty.TabIndex = 9;
            cbFaculty.Text = "Công Nghệ Thông Tin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 153);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 4;
            label4.Text = "Khoa";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(284, 92);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(267, 29);
            txtFullName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 94);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 5;
            label3.Text = "Họ Tên";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(284, 38);
            txtStudentID.Margin = new Padding(3, 2, 3, 2);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(267, 29);
            txtStudentID.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 40);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 6;
            label2.Text = "Mã Số SV";
            // 
            // frmSearchStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 661);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSearchStudent";
            Text = "TÌM KIẾM SINH VIÊN ";
            Load += frmSearchStudent_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private DataGridView dgvSearch;
        private ComboBox cbFaculty;
        private Label label4;
        private TextBox txtFullName;
        private Label label3;
        private TextBox txtStudentID;
        private Label label2;
        private Button btnDelete;
        private Button btnBack;
        private Button btnSearch;
    }
}