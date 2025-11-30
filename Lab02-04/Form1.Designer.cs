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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1199, 115);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAccNumber
            // 
            txtAccNumber.Location = new Point(428, 127);
            txtAccNumber.Name = "txtAccNumber";
            txtAccNumber.Size = new Size(608, 27);
            txtAccNumber.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(428, 183);
            txtName.Name = "txtName";
            txtName.Size = new Size(608, 27);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(428, 235);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(608, 27);
            txtAddress.TabIndex = 1;
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(428, 290);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(608, 27);
            txtMoney.TabIndex = 1;
            // 
            // lblAccNumber
            // 
            lblAccNumber.AutoSize = true;
            lblAccNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccNumber.Location = new Point(286, 127);
            lblAccNumber.Name = "lblAccNumber";
            lblAccNumber.Size = new Size(121, 28);
            lblAccNumber.TabIndex = 2;
            lblAccNumber.Text = "Số tài khoản";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(261, 179);
            lblName.Name = "lblName";
            lblName.Size = new Size(146, 28);
            lblName.TabIndex = 2;
            lblName.Text = "Tên khách hàng";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(231, 231);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(176, 28);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Địa chỉ khách hàng";
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoney.Location = new Point(194, 286);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(213, 28);
            lblMoney.TabIndex = 2;
            lblMoney.Text = "Số tiền trong tài khoản";
            // 
            // btnAddorUpdate
            // 
            btnAddorUpdate.Location = new Point(428, 343);
            btnAddorUpdate.Name = "btnAddorUpdate";
            btnAddorUpdate.Size = new Size(164, 29);
            btnAddorUpdate.TabIndex = 3;
            btnAddorUpdate.Text = "Thêm / Cập Nhật";
            btnAddorUpdate.UseVisualStyleBackColor = true;
            btnAddorUpdate.Click += btnAddorUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(643, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(795, 343);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lvAccount
            // 
            lvAccount.Columns.AddRange(new ColumnHeader[] { clmSTT, clmAccNumber, clmName, clmAddress, clmMoney });
            lvAccount.FullRowSelect = true;
            lvAccount.GridLines = true;
            lvAccount.Location = new Point(12, 395);
            lvAccount.Name = "lvAccount";
            lvAccount.Size = new Size(1199, 325);
            lvAccount.TabIndex = 4;
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
            txtTotal.Location = new Point(830, 738);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(381, 27);
            txtTotal.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(718, 737);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 28);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Tổng tiền: ";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(942, 343);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(94, 29);
            btnOpenFile.TabIndex = 5;
            btnOpenFile.Text = "Mở File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1223, 777);
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
    }
}
