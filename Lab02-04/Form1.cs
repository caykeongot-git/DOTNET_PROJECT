using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02_04
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private bool CheckValue()
        {
            if (string.IsNullOrWhiteSpace(txtAccNumber.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtMoney.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo");
                return false;
            }

            if (!long.TryParse(txtMoney.Text, out long SoTien))
            {
                MessageBox.Show("Số tiền phải là số! (Ví dụ: 100000000)", "Cảnh báo");
                return false;
            }

            if (SoTien < 0)
            {
                MessageBox.Show("Số tiền phải là số dương không âm! (Ví dụ: 100000000)", "Cảnh báo");
                return false;
            }
            return true;
        }

        private ListViewItem Search(string stk)
        {
            foreach (ListViewItem item in lvAccount.Items)
            {
                if (item.SubItems[1].Text == stk) return item;
            }
            return null;
        }

        private void UpdateTotal()
        {
            decimal sum = 0;
            foreach (ListViewItem item in lvAccount.Items)
            {
                sum += decimal.Parse(item.SubItems[4].Text);
            }
            txtTotal.Text = sum.ToString("N0") + " VNĐ";
        }

        private void UpdateSTT()
        {
            for (int i = 0; i < lvAccount.Items.Count; i++)
            {
                lvAccount.Items[i].Text = (i + 1).ToString();
            }
        }

        private void ResetForm()
        {
            txtAccNumber.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtMoney.Text = "";
            txtAccNumber.Focus();

        }

        private void btnAddorUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckValue()) return;
            try
            {
                ListViewItem item = Search(txtAccNumber.Text);
                if (item == null)
                {
                    item = new ListViewItem("");
                    item.SubItems.Add(txtAccNumber.Text);
                    item.SubItems.Add(txtName.Text);
                    item.SubItems.Add(txtAddress.Text);
                    item.SubItems.Add(txtMoney.Text);
                    lvAccount.Items.Add(item);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo");

                }
                else
                {
                    item.SubItems[2].Text = txtName.Text;
                    item.SubItems[3].Text = txtAddress.Text;
                    item.SubItems[4].Text = txtMoney.Text;
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
                }
                UpdateTotal();
                UpdateSTT();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Muốn xóa thật à?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                ListViewItem item = Search(txtAccNumber.Text);
                if (item != null)
                {
                    lvAccount.Items.Remove(item);
                    UpdateTotal();
                    UpdateSTT();
                    ResetForm();
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leave!", "Thông báo");
            Application.Exit();
        }

        private void lvAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAccount.SelectedItems.Count > 0)
            {

                ListViewItem item = lvAccount.SelectedItems[0];
                txtAccNumber.Text = item.SubItems[1].Text;
                txtName.Text = item.SubItems[2].Text;
                txtAddress.Text = item.SubItems[3].Text;
                txtMoney.Text = item.SubItems[4].Text;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Text Files|*.txt";
                open.Title = "Chọn file txt để nhập dữ liệu vào app";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(open.FileName);
                    foreach (string line in lines)
                    {
                        string[] data = line.Split('|');
                        if (data.Length == 4)
                        {
                            ListViewItem item = new ListViewItem("");
                            item.SubItems.Add(data[0]);
                            item.SubItems.Add(data[1]);
                            item.SubItems.Add(data[2]);
                            item.SubItems.Add(data[3]);
                            lvAccount.Items.Add(item);
                        }
                        UpdateTotal();
                        UpdateSTT();
                        ResetForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccNumber.Text) || string.IsNullOrWhiteSpace(txtMoney.Text))
            {
                MessageBox.Show("Vui lòng nhập Số tài khoản và Số tiền cần nạp!", "Cảnh báo");
                return;
            }

            if (!long.TryParse(txtMoney.Text, out long soTienNap) || soTienNap <= 0)
            {
                MessageBox.Show("Số tiền nạp phải là số dương!", "Lỗi");
                return;
            }

            ListViewItem item = Search(txtAccNumber.Text);

            if (item != null)
            {
                long soDuHienTai = long.Parse(item.SubItems[4].Text);

                long soDuMoi = soDuHienTai + soTienNap;

                item.SubItems[4].Text = soDuMoi.ToString();

                UpdateTotal();

                MessageBox.Show($"Nạp thành công {soTienNap:N0} VND.\nSố dư mới: {soDuMoi:N0} VND", "Success");
            }
            else
            {
                MessageBox.Show("Không tìm thấy số tài khoản này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccNumber.Text) || string.IsNullOrWhiteSpace(txtMoney.Text))
            {
                MessageBox.Show("Vui lòng nhập Số tài khoản và Số tiền cần rút!", "Cảnh báo");
                return;
            }

            if (!long.TryParse(txtMoney.Text, out long soTienRut) || soTienRut <= 0)
            {
                MessageBox.Show("Số tiền rút phải là số dương!", "Lỗi");
                return;
            }

            ListViewItem item = Search(txtAccNumber.Text);

            if (item != null)
            {
                long soDuHienTai = long.Parse(item.SubItems[4].Text);

                if (soDuHienTai < soTienRut)
                {
                    MessageBox.Show($"Số dư không đủ! (Còn có {soDuHienTai:N0} mà đòi rút {soTienRut:N0}?)", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                long soDuMoi = soDuHienTai - soTienRut;
                item.SubItems[4].Text = soDuMoi.ToString();
                UpdateTotal();
                MessageBox.Show($"Rút thành công {soTienRut:N0} VND.\nSố dư còn lại: {soDuMoi:N0} VND", "Success");
            }
            else
            {
                MessageBox.Show("Không tìm thấy số tài khoản này!", "Lỗi");
            }
        }
    }
}
