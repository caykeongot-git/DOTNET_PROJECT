namespace Lab02_04
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
            txtAccNumber = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtMoney = new TextBox();
            lblAccNumber = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblMoney = new Label();
            btnAddorUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            lvAccount = new ListView();
            clmSTT = new ColumnHeader();
            clmAccNumber = new ColumnHeader();
            clmName = new ColumnHeader();
            clmAddress = new ColumnHeader();
            clmMoney = new ColumnHeader();
            txtTotal = new TextBox();
            lblTotal = new Label();
            btnOpenFile = new Button();
            btnNap = new Button();
            btnRut = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(10, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1049, 86);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAccNumber
            // 
            txtAccNumber.Location = new Point(374, 95);
            txtAccNumber.Margin = new Padding(3, 2, 3, 2);
            txtAccNumber.Name = "txtAccNumber";
            txtAccNumber.Size = new Size(532, 23);
            txtAccNumber.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(374, 137);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(532, 23);
            txtName.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(374, 176);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(532, 23);
            txtAddress.TabIndex = 6;
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(374, 218);
            txtMoney.Margin = new Padding(3, 2, 3, 2);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(532, 23);
            txtMoney.TabIndex = 8;
            // 
            // lblAccNumber
            // 
            lblAccNumber.AutoSize = true;
            lblAccNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccNumber.Location = new Point(250, 95);
            lblAccNumber.Name = "lblAccNumber";
            lblAccNumber.Size = new Size(96, 21);
            lblAccNumber.TabIndex = 1;
            lblAccNumber.Text = "Số tài khoản";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(228, 134);
            lblName.Name = "lblName";
            lblName.Size = new Size(117, 21);
            lblName.TabIndex = 3;
            lblName.Text = "Tên khách hàng";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(202, 173);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(141, 21);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Địa chỉ khách hàng";
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoney.Location = new Point(170, 214);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(168, 21);
            lblMoney.TabIndex = 7;
            lblMoney.Text = "Số tiền trong tài khoản";
            // 
            // btnAddorUpdate
            // 
            btnAddorUpdate.Location = new Point(374, 257);
            btnAddorUpdate.Margin = new Padding(3, 2, 3, 2);
            btnAddorUpdate.Name = "btnAddorUpdate";
            btnAddorUpdate.Size = new Size(144, 22);
            btnAddorUpdate.TabIndex = 9;
            btnAddorUpdate.Text = "Thêm / Cập Nhật";
            btnAddorUpdate.UseVisualStyleBackColor = true;
            btnAddorUpdate.Click += btnAddorUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(534, 257);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 22);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(642, 257);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 22);
            btnExit.TabIndex = 11;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lvAccount
            // 
            lvAccount.Columns.AddRange(new ColumnHeader[] { clmSTT, clmAccNumber, clmName, clmAddress, clmMoney });
            lvAccount.FullRowSelect = true;
            lvAccount.GridLines = true;
            lvAccount.Location = new Point(10, 296);
            lvAccount.Margin = new Padding(3, 2, 3, 2);
            lvAccount.Name = "lvAccount";
            lvAccount.Size = new Size(1050, 245);
            lvAccount.TabIndex = 13;
            lvAccount.UseCompatibleStateImageBehavior = false;
            lvAccount.View = View.Details;
            lvAccount.SelectedIndexChanged += lvAccount_SelectedIndexChanged;
            // 
            // clmSTT
            // 
            clmSTT.Text = "STT";
            // 
            // clmAccNumber
            // 
            clmAccNumber.Text = "Mã tài khoản";
            // 
            // clmName
            // 
            clmName.Text = "Tên khách hàng";
            // 
            // clmAddress
            // 
            clmAddress.Text = "Địa chỉ";
            // 
            // clmMoney
            // 
            clmMoney.Text = "Số tiền";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(726, 554);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(334, 23);
            txtTotal.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(628, 553);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(82, 21);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Tổng tiền: ";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(742, 257);
            btnOpenFile.Margin = new Padding(3, 2, 3, 2);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(82, 22);
            btnOpenFile.TabIndex = 12;
            btnOpenFile.Text = "Mở File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnNap
            // 
            btnNap.Location = new Point(839, 257);
            btnNap.Margin = new Padding(3, 2, 3, 2);
            btnNap.Name = "btnNap";
            btnNap.Size = new Size(91, 22);
            btnNap.TabIndex = 14;
            btnNap.Text = "Nạp Tiền";
            btnNap.UseVisualStyleBackColor = true;
            btnNap.Click += btnNap_Click;
            // 
            // btnRut
            // 
            btnRut.Location = new Point(945, 257);
            btnRut.Margin = new Padding(3, 2, 3, 2);
            btnRut.Name = "btnRut";
            btnRut.Size = new Size(91, 22);
            btnRut.TabIndex = 14;
            btnRut.Text = "Rút Tiền";
            btnRut.UseVisualStyleBackColor = true;
            btnRut.Click += btnRut_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1070, 583);
            Controls.Add(btnRut);
            Controls.Add(btnNap);
            Controls.Add(btnOpenFile);
            Controls.Add(lvAccount);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnAddorUpdate);
            Controls.Add(lblTotal);
            Controls.Add(lblMoney);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblAccNumber);
            Controls.Add(txtTotal);
            Controls.Add(txtMoney);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtAccNumber);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMain";
            Text = "ACCOUNT MANAGER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtAccNumber;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtMoney;
        private Label lblAccNumber;
        private Label lblName;
        private Label lblAddress;
        private Label lblMoney;
        private Button btnAddorUpdate;
        private Button btnDelete;
        private Button btnExit;
        private ListView lvAccount;
        private ColumnHeader clmSTT;
        private ColumnHeader clmAccNumber;
        private ColumnHeader clmName;
        private ColumnHeader clmAddress;
        private ColumnHeader clmMoney;
        private TextBox txtTotal;
        private Label lblTotal;
        private Button btnOpenFile;
        private Button btnNap;
        private Button btnRut;
    }
}
