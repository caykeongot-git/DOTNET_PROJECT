namespace Lab02_03
{
    partial class Form1
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
            label1 = new Label();
            lblTitleCost = new Label();
            lblCost = new Label();
            btnSelect = new Button();
            btnCancel = new Button();
            btnEnd = new Button();
            grbFullButton = new GroupBox();
            btnSeat20 = new Button();
            btnSeat19 = new Button();
            btnSeat18 = new Button();
            btnSeat17 = new Button();
            btnSeat16 = new Button();
            btnSeat15 = new Button();
            btnSeat14 = new Button();
            btnSeat13 = new Button();
            btnSeat12 = new Button();
            btnSeat11 = new Button();
            btnSeat10 = new Button();
            btnSeat9 = new Button();
            btnSeat8 = new Button();
            btnSeat7 = new Button();
            btnSeat6 = new Button();
            btnSeat5 = new Button();
            btnSeat4 = new Button();
            btnSeat3 = new Button();
            btnSeat2 = new Button();
            btnSeat1 = new Button();
            grbFullButton.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(936, 103);
            label1.TabIndex = 1;
            label1.Text = "MÀN ẢNH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleCost
            // 
            lblTitleCost.AutoSize = true;
            lblTitleCost.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleCost.Location = new Point(101, 611);
            lblTitleCost.Name = "lblTitleCost";
            lblTitleCost.Size = new Size(109, 22);
            lblTitleCost.TabIndex = 2;
            lblTitleCost.Text = "Thành Tiền: ";
            // 
            // lblCost
            // 
            lblCost.BorderStyle = BorderStyle.Fixed3D;
            lblCost.Location = new Point(260, 599);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(283, 34);
            lblCost.TabIndex = 3;
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelect.Location = new Point(101, 653);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 4;
            btnSelect.Text = "Chọn";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(260, 653);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEnd
            // 
            btnEnd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnd.Location = new Point(409, 653);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(94, 29);
            btnEnd.TabIndex = 6;
            btnEnd.Text = "Kết thúc";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // grbFullButton
            // 
            grbFullButton.Controls.Add(btnSeat20);
            grbFullButton.Controls.Add(btnSeat19);
            grbFullButton.Controls.Add(btnSeat18);
            grbFullButton.Controls.Add(btnSeat17);
            grbFullButton.Controls.Add(btnSeat16);
            grbFullButton.Controls.Add(btnSeat15);
            grbFullButton.Controls.Add(btnSeat14);
            grbFullButton.Controls.Add(btnSeat13);
            grbFullButton.Controls.Add(btnSeat12);
            grbFullButton.Controls.Add(btnSeat11);
            grbFullButton.Controls.Add(btnSeat10);
            grbFullButton.Controls.Add(btnSeat9);
            grbFullButton.Controls.Add(btnSeat8);
            grbFullButton.Controls.Add(btnSeat7);
            grbFullButton.Controls.Add(btnSeat6);
            grbFullButton.Controls.Add(btnSeat5);
            grbFullButton.Controls.Add(btnSeat4);
            grbFullButton.Controls.Add(btnSeat3);
            grbFullButton.Controls.Add(btnSeat2);
            grbFullButton.Controls.Add(btnSeat1);
            grbFullButton.Location = new Point(45, 115);
            grbFullButton.Name = "grbFullButton";
            grbFullButton.Size = new Size(869, 469);
            grbFullButton.TabIndex = 7;
            grbFullButton.TabStop = false;
            // 
            // btnSeat20
            // 
            btnSeat20.BackColor = Color.White;
            btnSeat20.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat20.Location = new Point(711, 358);
            btnSeat20.Name = "btnSeat20";
            btnSeat20.Size = new Size(112, 91);
            btnSeat20.TabIndex = 11;
            btnSeat20.Text = "20";
            btnSeat20.UseVisualStyleBackColor = false;
            btnSeat20.Click += btnGhe_Click;
            // 
            // btnSeat19
            // 
            btnSeat19.BackColor = Color.White;
            btnSeat19.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat19.Location = new Point(553, 358);
            btnSeat19.Name = "btnSeat19";
            btnSeat19.Size = new Size(112, 91);
            btnSeat19.TabIndex = 12;
            btnSeat19.Text = "19";
            btnSeat19.UseVisualStyleBackColor = false;
            btnSeat19.Click += btnGhe_Click;
            // 
            // btnSeat18
            // 
            btnSeat18.BackColor = Color.White;
            btnSeat18.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat18.Location = new Point(382, 358);
            btnSeat18.Name = "btnSeat18";
            btnSeat18.Size = new Size(112, 91);
            btnSeat18.TabIndex = 13;
            btnSeat18.Text = "18";
            btnSeat18.UseVisualStyleBackColor = false;
            btnSeat18.Click += btnGhe_Click;
            // 
            // btnSeat17
            // 
            btnSeat17.BackColor = Color.White;
            btnSeat17.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat17.Location = new Point(215, 358);
            btnSeat17.Name = "btnSeat17";
            btnSeat17.Size = new Size(112, 91);
            btnSeat17.TabIndex = 14;
            btnSeat17.Text = "17";
            btnSeat17.UseVisualStyleBackColor = false;
            btnSeat17.Click += btnGhe_Click;
            // 
            // btnSeat16
            // 
            btnSeat16.BackColor = Color.White;
            btnSeat16.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat16.Location = new Point(47, 358);
            btnSeat16.Name = "btnSeat16";
            btnSeat16.Size = new Size(112, 91);
            btnSeat16.TabIndex = 15;
            btnSeat16.Text = "16";
            btnSeat16.UseVisualStyleBackColor = false;
            btnSeat16.Click += btnGhe_Click;
            // 
            // btnSeat15
            // 
            btnSeat15.BackColor = Color.White;
            btnSeat15.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat15.Location = new Point(711, 247);
            btnSeat15.Name = "btnSeat15";
            btnSeat15.Size = new Size(112, 91);
            btnSeat15.TabIndex = 6;
            btnSeat15.Text = "15";
            btnSeat15.UseVisualStyleBackColor = false;
            btnSeat15.Click += btnGhe_Click;
            // 
            // btnSeat14
            // 
            btnSeat14.BackColor = Color.White;
            btnSeat14.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat14.Location = new Point(553, 247);
            btnSeat14.Name = "btnSeat14";
            btnSeat14.Size = new Size(112, 91);
            btnSeat14.TabIndex = 7;
            btnSeat14.Text = "14";
            btnSeat14.UseVisualStyleBackColor = false;
            btnSeat14.Click += btnGhe_Click;
            // 
            // btnSeat13
            // 
            btnSeat13.BackColor = Color.White;
            btnSeat13.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat13.Location = new Point(382, 247);
            btnSeat13.Name = "btnSeat13";
            btnSeat13.Size = new Size(112, 91);
            btnSeat13.TabIndex = 8;
            btnSeat13.Text = "13";
            btnSeat13.UseVisualStyleBackColor = false;
            btnSeat13.Click += btnGhe_Click;
            // 
            // btnSeat12
            // 
            btnSeat12.BackColor = Color.White;
            btnSeat12.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat12.Location = new Point(215, 247);
            btnSeat12.Name = "btnSeat12";
            btnSeat12.Size = new Size(112, 91);
            btnSeat12.TabIndex = 9;
            btnSeat12.Text = "12";
            btnSeat12.UseVisualStyleBackColor = false;
            btnSeat12.Click += btnGhe_Click;
            // 
            // btnSeat11
            // 
            btnSeat11.BackColor = Color.White;
            btnSeat11.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat11.Location = new Point(47, 247);
            btnSeat11.Name = "btnSeat11";
            btnSeat11.Size = new Size(112, 91);
            btnSeat11.TabIndex = 10;
            btnSeat11.Text = "11";
            btnSeat11.UseVisualStyleBackColor = false;
            btnSeat11.Click += btnGhe_Click;
            // 
            // btnSeat10
            // 
            btnSeat10.BackColor = Color.White;
            btnSeat10.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat10.Location = new Point(711, 137);
            btnSeat10.Name = "btnSeat10";
            btnSeat10.Size = new Size(112, 91);
            btnSeat10.TabIndex = 1;
            btnSeat10.Text = "10";
            btnSeat10.UseVisualStyleBackColor = false;
            btnSeat10.Click += btnGhe_Click;
            // 
            // btnSeat9
            // 
            btnSeat9.BackColor = Color.White;
            btnSeat9.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat9.Location = new Point(553, 137);
            btnSeat9.Name = "btnSeat9";
            btnSeat9.Size = new Size(112, 91);
            btnSeat9.TabIndex = 2;
            btnSeat9.Text = "9";
            btnSeat9.UseVisualStyleBackColor = false;
            btnSeat9.Click += btnGhe_Click;
            // 
            // btnSeat8
            // 
            btnSeat8.BackColor = Color.White;
            btnSeat8.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat8.Location = new Point(382, 137);
            btnSeat8.Name = "btnSeat8";
            btnSeat8.Size = new Size(112, 91);
            btnSeat8.TabIndex = 3;
            btnSeat8.Text = "8";
            btnSeat8.UseVisualStyleBackColor = false;
            btnSeat8.Click += btnGhe_Click;
            // 
            // btnSeat7
            // 
            btnSeat7.BackColor = Color.White;
            btnSeat7.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat7.Location = new Point(215, 137);
            btnSeat7.Name = "btnSeat7";
            btnSeat7.Size = new Size(112, 91);
            btnSeat7.TabIndex = 4;
            btnSeat7.Text = "7";
            btnSeat7.UseVisualStyleBackColor = false;
            btnSeat7.Click += btnGhe_Click;
            // 
            // btnSeat6
            // 
            btnSeat6.BackColor = Color.White;
            btnSeat6.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat6.Location = new Point(47, 137);
            btnSeat6.Name = "btnSeat6";
            btnSeat6.Size = new Size(112, 91);
            btnSeat6.TabIndex = 5;
            btnSeat6.Text = "6";
            btnSeat6.UseVisualStyleBackColor = false;
            btnSeat6.Click += btnGhe_Click;
            // 
            // btnSeat5
            // 
            btnSeat5.BackColor = Color.White;
            btnSeat5.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat5.Location = new Point(711, 26);
            btnSeat5.Name = "btnSeat5";
            btnSeat5.Size = new Size(112, 91);
            btnSeat5.TabIndex = 0;
            btnSeat5.Text = "5";
            btnSeat5.UseVisualStyleBackColor = false;
            btnSeat5.Click += btnGhe_Click;
            // 
            // btnSeat4
            // 
            btnSeat4.BackColor = Color.White;
            btnSeat4.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat4.Location = new Point(553, 26);
            btnSeat4.Name = "btnSeat4";
            btnSeat4.Size = new Size(112, 91);
            btnSeat4.TabIndex = 0;
            btnSeat4.Text = "4";
            btnSeat4.UseVisualStyleBackColor = false;
            btnSeat4.Click += btnGhe_Click;
            // 
            // btnSeat3
            // 
            btnSeat3.BackColor = Color.White;
            btnSeat3.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat3.Location = new Point(382, 26);
            btnSeat3.Name = "btnSeat3";
            btnSeat3.Size = new Size(112, 91);
            btnSeat3.TabIndex = 0;
            btnSeat3.Text = "3";
            btnSeat3.UseVisualStyleBackColor = false;
            btnSeat3.Click += btnGhe_Click;
            // 
            // btnSeat2
            // 
            btnSeat2.BackColor = Color.White;
            btnSeat2.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat2.Location = new Point(215, 26);
            btnSeat2.Name = "btnSeat2";
            btnSeat2.Size = new Size(112, 91);
            btnSeat2.TabIndex = 0;
            btnSeat2.Text = "2";
            btnSeat2.UseVisualStyleBackColor = false;
            btnSeat2.Click += btnGhe_Click;
            // 
            // btnSeat1
            // 
            btnSeat1.BackColor = Color.White;
            btnSeat1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeat1.Location = new Point(47, 26);
            btnSeat1.Name = "btnSeat1";
            btnSeat1.Size = new Size(112, 91);
            btnSeat1.TabIndex = 0;
            btnSeat1.Text = "1";
            btnSeat1.UseVisualStyleBackColor = false;
            btnSeat1.Click += btnGhe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 708);
            Controls.Add(grbFullButton);
            Controls.Add(btnEnd);
            Controls.Add(btnCancel);
            Controls.Add(btnSelect);
            Controls.Add(lblCost);
            Controls.Add(lblTitleCost);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            grbFullButton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblTitleCost;
        private Label lblCost;
        private Button btnSelect;
        private Button btnCancel;
        private Button btnEnd;
        private GroupBox grbFullButton;
        private Button btnSeat1;
        private Button btnSeat20;
        private Button btnSeat19;
        private Button btnSeat18;
        private Button btnSeat17;
        private Button btnSeat16;
        private Button btnSeat15;
        private Button btnSeat14;
        private Button btnSeat13;
        private Button btnSeat12;
        private Button btnSeat11;
        private Button btnSeat10;
        private Button btnSeat9;
        private Button btnSeat8;
        private Button btnSeat7;
        private Button btnSeat6;
        private Button btnSeat5;
        private Button btnSeat4;
        private Button btnSeat3;
        private Button btnSeat2;
    }
}
