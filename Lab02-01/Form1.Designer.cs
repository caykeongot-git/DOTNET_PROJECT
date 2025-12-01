namespace Lab02_01
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
            txtNum1 = new TextBox();
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum2 = new TextBox();
            btnAdd = new Button();
            btnSub = new Button();
            btnTimes = new Button();
            btnDivided = new Button();
            btnModulus = new Button();
            lblAnswer = new Label();
            txtAnswer = new TextBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(312, 115);
            txtNum1.Margin = new Padding(3, 2, 3, 2);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(196, 23);
            txtNum1.TabIndex = 3;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(194, 118);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 2;
            lblNum1.Text = "Number 1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(194, 160);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(60, 15);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Number 2";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(312, 157);
            txtNum2.Margin = new Padding(3, 2, 3, 2);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(196, 23);
            txtNum2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(12, 221);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 76);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(162, 221);
            btnSub.Margin = new Padding(3, 2, 3, 2);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(100, 76);
            btnSub.TabIndex = 4;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnTimes
            // 
            btnTimes.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimes.Location = new Point(312, 221);
            btnTimes.Margin = new Padding(3, 2, 3, 2);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(100, 76);
            btnTimes.TabIndex = 4;
            btnTimes.Text = "x";
            btnTimes.UseVisualStyleBackColor = true;
            btnTimes.Click += btnTimes_Click;
            // 
            // btnDivided
            // 
            btnDivided.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivided.Location = new Point(463, 221);
            btnDivided.Margin = new Padding(3, 2, 3, 2);
            btnDivided.Name = "btnDivided";
            btnDivided.Size = new Size(100, 76);
            btnDivided.TabIndex = 4;
            btnDivided.Text = "/";
            btnDivided.UseVisualStyleBackColor = true;
            btnDivided.Click += btnDivided_Click;
            // 
            // btnModulus
            // 
            btnModulus.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModulus.Location = new Point(605, 221);
            btnModulus.Margin = new Padding(3, 2, 3, 2);
            btnModulus.Name = "btnModulus";
            btnModulus.Size = new Size(100, 76);
            btnModulus.TabIndex = 4;
            btnModulus.Text = "%";
            btnModulus.UseVisualStyleBackColor = true;
            btnModulus.Click += btnModulus_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(194, 363);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(46, 15);
            lblAnswer.TabIndex = 2;
            lblAnswer.Text = "Answer";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(312, 360);
            txtAnswer.Margin = new Padding(3, 2, 3, 2);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(196, 23);
            txtAnswer.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(703, 66);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "CALCULATOR PRO MAX +++";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(717, 403);
            Controls.Add(lblTitle);
            Controls.Add(btnModulus);
            Controls.Add(btnDivided);
            Controls.Add(btnTimes);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(txtAnswer);
            Controls.Add(lblAnswer);
            Controls.Add(txtNum2);
            Controls.Add(lblNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "CALCULATOR";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum2;
        private Button btnAdd;
        private Button btnSub;
        private Button btnTimes;
        private Button btnDivided;
        private Button btnModulus;
        private Label lblAnswer;
        private TextBox txtAnswer;
        private Label lblTitle;
    }
}
