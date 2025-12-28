using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab06.DAL.Models;
using Lab06.DAL;
using Lab06.BLL;
using Lab04_01.GUI;

namespace Lab06.GUI
{
    public partial class frmMain : Form
    {
        private readonly SachService sachService = new SachService();
        public frmMain()
        {
            InitializeComponent();
            GUIHelper.DecorateDataGridView(dgvSach);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Load ComboBox
                var listLoai = sachService.GetAllLoaiSach();
                FillCboLoai(listLoai);

                // 2. Load DataGridView ban đầu
                var listSach = sachService.GetAll();
                BindGrid(listSach);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void FillCboLoai(List<LoaiSach> listLoai)
        {
            cmbLoaiSach.DataSource = listLoai;
            cmbLoaiSach.DisplayMember = "TenLoai";
            cmbLoaiSach.ValueMember = "MaLoai";
        }

        // Hàm BindGrid sửa lại: Dùng DataSource để tự sinh cột
        private void BindGrid(List<Sach> listSach)
        {
            // Dùng Select để tạo ra một danh sách mới chỉ chứa các cột cần hiển thị
            // Việc này giúp Grid tự sinh cột đúng tên và lấy được Tên Loại thay vì Mã Loại
            var displayList = listSach.Select(s => new
            {
                MaSach = s.MaSach,
                TenSach = s.TenSach,
                NamXB = s.NamXB,
                // Lấy tên loại từ bảng quan hệ. Nếu null thì để trống
                TheLoai = s.LoaiSach != null ? s.LoaiSach.TenLoai : ""
            }).ToList();

            dgvSach.DataSource = displayList;

            // Tùy chỉnh tiêu đề cột cho đẹp (nếu muốn, không bắt buộc vì Grid đã tự hiện)
            if (dgvSach.Columns.Count > 0)
            {
                dgvSach.Columns["MaSach"].HeaderText = "Mã Sách";
                dgvSach.Columns["TenSach"].HeaderText = "Tên Sách";
                dgvSach.Columns["NamXB"].HeaderText = "Năm XB";
                dgvSach.Columns["TheLoai"].HeaderText = "Thể Loại";

                // Ẩn cột thừa nếu có hoặc chỉnh kích thước
                dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Lấy từ khóa, tìm kiếm và đổ lại vào Grid ngay lập tức
            string keyword = txtTimKiem.Text.Trim();
            var ketQua = sachService.Search(keyword);
            BindGrid(ketQua);
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Vì dùng DataSource nên lấy value theo tên cột (Property name)
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];

                txtMaSach.Text = row.Cells["MaSach"].Value?.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value?.ToString();
                txtNamXB.Text = row.Cells["NamXB"].Value?.ToString();

                // Gán ngược lại ComboBox dựa trên tên loại hiển thị
                string tenLoai = row.Cells["TheLoai"].Value?.ToString();
                cmbLoaiSach.Text = tenLoai;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (sachService.FindById(txtMaSach.Text) != null)
                {
                    MessageBox.Show("Mã sách đã tồn tại!");
                    return;
                }
                SaveData();
                MessageBox.Show("Thêm thành công!");
            }
        }




        private void SaveData()
        {
            Sach s = new Sach()
            {
                MaSach = txtMaSach.Text,
                TenSach = txtTenSach.Text,
                NamXB = int.Parse(txtNamXB.Text),
                MaLoai = (int)cmbLoaiSach.SelectedValue
            };
            sachService.InsertUpdate(s);
            BindGrid(sachService.GetAll()); // Grid sẽ tự refresh
            ResetInput();
        }
        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text) || string.IsNullOrWhiteSpace(txtTenSach.Text) || string.IsNullOrWhiteSpace(txtNamXB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            if (txtMaSach.Text.Length > 6)
            {
                MessageBox.Show("Mã sách tối đa 6 ký tự!");
                return false;
            }
            return true;
        }

        private void ResetInput()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtNamXB.Clear();
            if (cmbLoaiSach.Items.Count > 0) cmbLoaiSach.SelectedIndex = 0;
            txtMaSach.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (sachService.FindById(txtMaSach.Text) == null)
                {
                    MessageBox.Show("Không tìm thấy mã sách để sửa!");
                    return;
                }
                SaveData();
                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var s = sachService.FindById(txtMaSach.Text);
            if (s == null)
            {
                MessageBox.Show("Sách cần xóa không tồn tại!");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sachService.Delete(txtMaSach.Text);
                MessageBox.Show("Xóa thành công!");
                BindGrid(sachService.GetAll());
                ResetInput();
            }
        }

        private void thốngKêSáchTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport frm = new FormReport();
            frm.ShowDialog(); // Hiển thị form báo cáo dạng hộp thoại
        }
    }
}
