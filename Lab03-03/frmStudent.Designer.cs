namespace Lab03_03
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblFaculty = new Label();
            lblAvg = new Label();
            txtAvg = new TextBox();
            cbbFaculty = new ComboBox();
            btnAdd = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(60, 51);
            lblId.Name = "lblId";
            lblId.Size = new Size(264, 59);
            lblId.TabIndex = 0;
            lblId.Text = "MÃ SỐ SANH ZIÊN";
            lblId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(350, 66);
            txtId.Name = "txtId";
            txtId.Size = new Size(411, 34);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(60, 132);
            lblName.Name = "lblName";
            lblName.Size = new Size(232, 59);
            lblName.TabIndex = 0;
            lblName.Text = "TÊN SANH ZIÊN";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(350, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(411, 34);
            txtName.TabIndex = 1;
            // 
            // lblFaculty
            // 
            lblFaculty.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFaculty.Location = new Point(60, 205);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(232, 59);
            lblFaculty.TabIndex = 0;
            lblFaculty.Text = "KHOA";
            lblFaculty.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAvg
            // 
            lblAvg.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvg.Location = new Point(60, 277);
            lblAvg.Name = "lblAvg";
            lblAvg.Size = new Size(279, 59);
            lblAvg.TabIndex = 0;
            lblAvg.Text = "ĐIỂM TRUNG BÌNH";
            lblAvg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAvg
            // 
            txtAvg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAvg.Location = new Point(350, 292);
            txtAvg.Name = "txtAvg";
            txtAvg.Size = new Size(151, 34);
            txtAvg.TabIndex = 1;
            // 
            // cbbFaculty
            // 
            cbbFaculty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbFaculty.FormattingEnabled = true;
            cbbFaculty.Items.AddRange(new object[] { "CÔNG NGHỆ THÔNG TIN", "NGÔN NGỮ ANH", "QUẢN TRỊ KINH DOANH" });
            cbbFaculty.Location = new Point(350, 220);
            cbbFaculty.Name = "cbbFaculty";
            cbbFaculty.Size = new Size(411, 36);
            cbbFaculty.TabIndex = 2;
            cbbFaculty.Text = "CÔNG NGHỆ THÔNG TIN";
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            btnAdd.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(60, 363);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(279, 75);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "THÊM MỚI";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.FromArgb(255, 128, 128);
            btnExit.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(482, 363);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(279, 75);
            btnExit.TabIndex = 3;
            btnExit.Text = "THOÁT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(cbbFaculty);
            Controls.Add(txtAvg);
            Controls.Add(lblAvg);
            Controls.Add(lblFaculty);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStudent";
            Text = "ADD STUDENT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblName;
        private TextBox txtName;
        private Label lblFaculty;
        private Label lblAvg;
        private TextBox txtAvg;
        private ComboBox cbbFaculty;
        private Button btnAdd;
        private Button btnExit;
    }
}