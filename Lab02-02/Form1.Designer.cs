namespace Lab02_02
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
            lblTitle = new Label();
            grbInformation = new GroupBox();
            cbFaculty = new ComboBox();
            lblFaculty = new Label();
            txtAvrg = new TextBox();
            lblAvrg = new Label();
            radFemale = new RadioButton();
            radMale = new RadioButton();
            lblSex = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtCode = new TextBox();
            lblCode = new Label();
            btnAddorEdit = new Button();
            btnDelete = new Button();
            grvInformation = new DataGridView();
            lblTotalMale = new Label();
            lblValueMale = new Label();
            lblValueFemale = new Label();
            label2 = new Label();
            btnOpenFile = new Button();
            grbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvInformation).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Highlight;
            lblTitle.Location = new Point(12, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1429, 112);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản Lý Thông Tin Sinh Viên";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // grbInformation
            // 
            grbInformation.Controls.Add(cbFaculty);
            grbInformation.Controls.Add(lblFaculty);
            grbInformation.Controls.Add(txtAvrg);
            grbInformation.Controls.Add(lblAvrg);
            grbInformation.Controls.Add(radFemale);
            grbInformation.Controls.Add(radMale);
            grbInformation.Controls.Add(lblSex);
            grbInformation.Controls.Add(txtName);
            grbInformation.Controls.Add(lblName);
            grbInformation.Controls.Add(txtCode);
            grbInformation.Controls.Add(lblCode);
            grbInformation.Location = new Point(12, 145);
            grbInformation.Name = "grbInformation";
            grbInformation.Size = new Size(597, 326);
            grbInformation.TabIndex = 1;
            grbInformation.TabStop = false;
            grbInformation.Text = "Thông Tin Sinh Viên";
            // 
            // cbFaculty
            // 
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Items.AddRange(new object[] { "Quản Trị Kinh Doanh", "Công Nghệ Thông Tin", "Ngôn Ngữ Anh" });
            cbFaculty.Location = new Point(171, 274);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(224, 28);
            cbFaculty.TabIndex = 10;
            cbFaculty.Text = "Quản Trị Kinh Doanh";
            // 
            // lblFaculty
            // 
            lblFaculty.AutoSize = true;
            lblFaculty.Location = new Point(37, 277);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(105, 20);
            lblFaculty.TabIndex = 9;
            lblFaculty.Text = "Chuyên Ngành";
            // 
            // txtAvrg
            // 
            txtAvrg.Location = new Point(171, 220);
            txtAvrg.Name = "txtAvrg";
            txtAvrg.Size = new Size(97, 27);
            txtAvrg.TabIndex = 8;
            // 
            // lblAvrg
            // 
            lblAvrg.AutoSize = true;
            lblAvrg.Location = new Point(37, 223);
            lblAvrg.Name = "lblAvrg";
            lblAvrg.Size = new Size(66, 20);
            lblAvrg.TabIndex = 7;
            lblAvrg.Text = "Điểm TB";
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Checked = true;
            radFemale.Location = new Point(303, 169);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(50, 24);
            radFemale.TabIndex = 6;
            radFemale.TabStop = true;
            radFemale.Text = "Nữ";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Location = new Point(171, 169);
            radMale.Name = "radMale";
            radMale.Size = new Size(62, 24);
            radMale.TabIndex = 5;
            radMale.Text = "Nam";
            radMale.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(37, 171);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(68, 20);
            lblSex.TabIndex = 4;
            lblSex.Text = "Giới Tính";
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 112);
            txtName.Name = "txtName";
            txtName.Size = new Size(405, 27);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(37, 115);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Họ Tên";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(171, 55);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(224, 27);
            txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(37, 58);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(95, 20);
            lblCode.TabIndex = 0;
            lblCode.Text = "Mã Sinh Viên";
            // 
            // btnAddorEdit
            // 
            btnAddorEdit.Location = new Point(183, 499);
            btnAddorEdit.Name = "btnAddorEdit";
            btnAddorEdit.Size = new Size(125, 29);
            btnAddorEdit.TabIndex = 11;
            btnAddorEdit.Text = "Thêm / Sửa";
            btnAddorEdit.UseVisualStyleBackColor = true;
            btnAddorEdit.Click += btnAddorEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(346, 499);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // grvInformation
            // 
            grvInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvInformation.Location = new Point(642, 159);
            grvInformation.Name = "grvInformation";
            grvInformation.RowHeadersWidth = 51;
            grvInformation.Size = new Size(799, 344);
            grvInformation.TabIndex = 13;
            grvInformation.CellClick += grvInformation_CellClick;
            // 
            // lblTotalMale
            // 
            lblTotalMale.AutoSize = true;
            lblTotalMale.Location = new Point(1124, 553);
            lblTotalMale.Name = "lblTotalMale";
            lblTotalMale.Size = new Size(100, 20);
            lblTotalMale.TabIndex = 11;
            lblTotalMale.Text = "Tổng SV Nam";
            // 
            // lblValueMale
            // 
            lblValueMale.BorderStyle = BorderStyle.Fixed3D;
            lblValueMale.Location = new Point(1230, 552);
            lblValueMale.Name = "lblValueMale";
            lblValueMale.Size = new Size(71, 30);
            lblValueMale.TabIndex = 11;
            lblValueMale.Text = "0";
            // 
            // lblValueFemale
            // 
            lblValueFemale.BorderStyle = BorderStyle.Fixed3D;
            lblValueFemale.Location = new Point(1342, 552);
            lblValueFemale.Name = "lblValueFemale";
            lblValueFemale.Size = new Size(71, 30);
            lblValueFemale.TabIndex = 14;
            lblValueFemale.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1307, 553);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 15;
            label2.Text = "Nữ";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(29, 499);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(125, 29);
            btnOpenFile.TabIndex = 16;
            btnOpenFile.Text = "Mở File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1453, 607);
            Controls.Add(btnOpenFile);
            Controls.Add(lblValueFemale);
            Controls.Add(label2);
            Controls.Add(lblValueMale);
            Controls.Add(lblTotalMale);
            Controls.Add(grvInformation);
            Controls.Add(btnDelete);
            Controls.Add(btnAddorEdit);
            Controls.Add(grbInformation);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "Information Student Manager";
            Load += frmMain_Load;
            grbInformation.ResumeLayout(false);
            grbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grvInformation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grbInformation;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtCode;
        private Label lblCode;
        private Label lblSex;
        private Label lblFaculty;
        private TextBox txtAvrg;
        private Label lblAvrg;
        private RadioButton radFemale;
        private RadioButton radMale;
        private ComboBox cbFaculty;
        private Button btnAddorEdit;
        private Button btnDelete;
        private DataGridView grvInformation;
        private Label lblTotalMale;
        private Label lblValueMale;
        private Label lblValueFemale;
        private Label label2;
        private Button btnOpenFile;
    }
}
