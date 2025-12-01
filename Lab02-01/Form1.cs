namespace Lab02_01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void CheckValid()
        {
            if (string.IsNullOrEmpty(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text) )
            {
                throw new InvalidDataException("Vui lòng nhập đầy đủ dữ liệu!");
            }
            return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CheckValid();
                long ans = long.Parse(txtNum1.Text) + long.Parse(txtNum2.Text);
                txtAnswer.Text = ans.ToString();
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"[ERROR]: {ex.Message}", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                CheckValid();
                long ans = long.Parse(txtNum1.Text) - long.Parse(txtNum2.Text);
                txtAnswer.Text = ans.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[ERROR]: {ex.Message}", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            try
            {
                CheckValid();
                long ans = long.Parse(txtNum1.Text) * long.Parse(txtNum2.Text);
                txtAnswer.Text = ans.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[ERROR]: {ex.Message}", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            try
            {
                CheckValid();
                if (txtNum2.Text == 0.ToString())
                {
                    throw new ArgumentException("Lỗi chia cho 0");
                }
                else
                {
                    double ans = double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text);
                    txtAnswer.Text = ans.ToString();
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"[ERROR]: {ex.Message}", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum2.ResetText();
            }
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNum2.Text == 0.ToString())
                {
                    throw new ArgumentException("Lỗi chia cho 0");
                }
                else
                {
                    long ans = long.Parse(txtNum1.Text) % long.Parse(txtNum2.Text);
                    txtAnswer.Text = ans.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[ERROR]: {ex.Message}", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum2.ResetText();
            }
        }
    }
}
