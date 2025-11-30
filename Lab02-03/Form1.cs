using System.Drawing;

namespace Lab02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private long TinhTienGhe(int soGhe)
        {
            if (soGhe <= 5) return 30000;
            else if (soGhe <= 10) return 40000;
            else if (soGhe <= 15) return 50000;
            else return 80000;
        }


        private void btnGhe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã bán rồi!", "Thông báo");
            }
            else if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            long tongTien = 0;

            foreach (Control c in grbFullButton.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;

                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.Yellow;

                        int soGhe = int.Parse(btn.Text);
                        tongTien += TinhTienGhe(soGhe);
                    }
                }
            }
            lblCost.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control c in grbFullButton.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.White;
                    }
                }
            }
            lblCost.Text = "0 VNĐ";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GOOD BYE and SEEYA ^(^.^)^ ", "Thông Báo");
            Application.Exit();
        }
    }
}
