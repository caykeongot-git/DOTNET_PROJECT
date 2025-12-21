namespace Lab04_04.GUI
{
    partial class frmOrderReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderReport));
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            dtk2 = new DateTimePicker();
            dtk1 = new DateTimePicker();
            ckb1 = new CheckBox();
            label3 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvData = new DataGridView();
            lblTotal = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTotal, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(1404, 661);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtk2);
            groupBox1.Controls.Add(dtk1);
            groupBox1.Controls.Add(ckb1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(262, 38);
            groupBox1.Margin = new Padding(262, 38, 262, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(880, 152);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thôn Tin Đơn Hàng";
            // 
            // dtk2
            // 
            dtk2.Location = new Point(514, 113);
            dtk2.Margin = new Padding(3, 2, 3, 2);
            dtk2.Name = "dtk2";
            dtk2.Size = new Size(219, 29);
            dtk2.TabIndex = 11;
            dtk2.ValueChanged += dtk2_ValueChanged;
            // 
            // dtk1
            // 
            dtk1.Location = new Point(233, 113);
            dtk1.Margin = new Padding(3, 2, 3, 2);
            dtk1.Name = "dtk1";
            dtk1.Size = new Size(219, 29);
            dtk1.TabIndex = 10;
            dtk1.ValueChanged += dtk1_ValueChanged;
            // 
            // ckb1
            // 
            ckb1.AutoSize = true;
            ckb1.Location = new Point(51, 56);
            ckb1.Margin = new Padding(3, 2, 3, 2);
            ckb1.Name = "ckb1";
            ckb1.Size = new Size(187, 25);
            ckb1.TabIndex = 9;
            ckb1.Text = "Xem tất cả trong tháng";
            ckb1.UseVisualStyleBackColor = true;
            ckb1.CheckedChanged += ckb1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 118);
            label3.Name = "label3";
            label3.Size = new Size(21, 21);
            label3.TabIndex = 6;
            label3.Text = "~";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 113);
            label1.Name = "label1";
            label1.Size = new Size(148, 21);
            label1.TabIndex = 6;
            label1.Text = "Thời gian giao hàng";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvData, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 200);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 473F));
            tableLayoutPanel2.Size = new Size(1398, 425);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvData
            // 
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Dock = DockStyle.Fill;
            dgvData.Location = new Point(3, 2);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(1392, 421);
            dgvData.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Red;
            lblTotal.Location = new Point(1253, 633);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(148, 21);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Thời gian giao hàng";
            // 
            // frmOrderReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 661);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmOrderReport";
            Text = "Amazon";
            Load += frmOrderReport_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Button btnDelete;
        private Button btnBack;
        private Button btnSearch;
        private ComboBox cbFaculty;
        private Label label4;
        private TextBox txtFullName;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvData;
        private DateTimePicker dtk1;
        private CheckBox ckb1;
        private Label label3;
        private Label label1;
        private DateTimePicker dtk2;
        private Label lblTotal;
    }
}