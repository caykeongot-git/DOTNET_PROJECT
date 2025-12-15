namespace Lab04_01.GUI
{
    partial class frmFaculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaculty));
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnExit = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtGS = new TextBox();
            label5 = new Label();
            txtFacultyName = new TextBox();
            label3 = new Label();
            txtFacultyID = new TextBox();
            label2 = new Label();
            dgvFaculty = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFaculty).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(1398, 65);
            label1.TabIndex = 0;
            label1.Text = "Quản lý thông tin Khoa";
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(1404, 661);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvFaculty, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 101);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1398, 558);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtGS);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFacultyName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFacultyID);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(44, 38);
            groupBox1.Margin = new Padding(44, 38, 44, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(331, 408);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Khoa";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLight;
            btnDelete.Location = new Point(284, 301);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 36);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlLight;
            btnExit.Location = new Point(157, 365);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 36);
            btnExit.TabIndex = 3;
            btnExit.Text = "Đóng";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlLight;
            btnUpdate.Location = new Point(157, 301);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 36);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLight;
            btnAdd.Location = new Point(24, 301);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 36);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtGS
            // 
            txtGS.Location = new Point(114, 200);
            txtGS.Margin = new Padding(3, 2, 3, 2);
            txtGS.Name = "txtGS";
            txtGS.Size = new Size(267, 29);
            txtGS.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 202);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 0;
            label5.Text = "Tổng Số GS";
            // 
            // txtFacultyName
            // 
            txtFacultyName.Location = new Point(114, 125);
            txtFacultyName.Margin = new Padding(3, 2, 3, 2);
            txtFacultyName.Name = "txtFacultyName";
            txtFacultyName.Size = new Size(267, 29);
            txtFacultyName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 128);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 0;
            label3.Text = "Tên Khoa";
            // 
            // txtFacultyID
            // 
            txtFacultyID.Location = new Point(114, 54);
            txtFacultyID.Margin = new Padding(3, 2, 3, 2);
            txtFacultyID.Name = "txtFacultyID";
            txtFacultyID.Size = new Size(267, 29);
            txtFacultyID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 0;
            label2.Text = "Mã Khoa";
            // 
            // dgvFaculty
            // 
            dgvFaculty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFaculty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFaculty.Dock = DockStyle.Fill;
            dgvFaculty.Location = new Point(422, 2);
            dgvFaculty.Margin = new Padding(3, 2, 3, 2);
            dgvFaculty.Name = "dgvFaculty";
            dgvFaculty.RowHeadersWidth = 51;
            dgvFaculty.Size = new Size(973, 554);
            dgvFaculty.TabIndex = 1;
            dgvFaculty.CellClick += dgvFaculty_CellClick;
            // 
            // frmFaculty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 661);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmFaculty";
            Text = "Quản lý thông tin các Khoa  ";
            Load += frmFaculty_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFaculty).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtFacultyName;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtGS;
        private Label label5;
        private Label label3;
        private TextBox txtFacultyID;
        private Label label2;
        private DataGridView dgvFaculty;
        private Button btnExit;
    }
}