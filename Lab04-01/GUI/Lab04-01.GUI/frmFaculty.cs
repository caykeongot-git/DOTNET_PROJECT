using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab04_01.DAL;
using Lab04_01.DAL.Entities;

namespace Lab04_01.GUI
{
    public partial class frmFaculty : Form
    {
        public frmFaculty()
        {
            InitializeComponent();
            GUIHelper.DecorateDataGridView(dgvFaculty);
        }

        private void ClearInputs()
        {
            txtFacultyID.Clear();
            txtFacultyName.Clear();
            txtGS.Clear();
            txtFacultyID.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFacultyID.Text) ||
                    string.IsNullOrWhiteSpace(txtFacultyName.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int totalProf = 0;
                if (!string.IsNullOrWhiteSpace(txtGS.Text))
                {
                    if (!int.TryParse(txtGS.Text, out totalProf) || totalProf < 0)
                    {
                        MessageBox.Show("Tổng số GS phải là số nguyên dương!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using (var db = new DBContext())
                {
                    var find = db.Faculties.Find(txtFacultyID.Text);

                    if (find == null)
                    {
                        Faculty faculty = new Faculty()
                        {
                            FacultyID = txtFacultyID.Text,
                            FacultyName = txtFacultyName.Text,
                            TotalProfessor = string.IsNullOrWhiteSpace(txtGS.Text) ?
                                (int?)null : totalProf
                        };

                        db.Faculties.Add(faculty);
                        db.SaveChanges();

                        MessageBox.Show("Thêm khoa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearInputs();
                        LoadFaculties();
                    }
                    else
                    {
                        MessageBox.Show("Mã khoa đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFacultyID.Text) ||
                    string.IsNullOrWhiteSpace(txtFacultyName.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int totalProf = 0;
                if (!string.IsNullOrWhiteSpace(txtGS.Text))
                {
                    if (!int.TryParse(txtGS.Text, out totalProf) || totalProf < 0)
                    {
                        MessageBox.Show("Tổng số GS phải là số nguyên dương!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using (var db = new DBContext())
                {
                    var find = db.Faculties.Find(txtFacultyID.Text);

                    if (find != null)
                    {
                        find.FacultyName = txtFacultyName.Text;
                        find.TotalProfessor = string.IsNullOrWhiteSpace(txtGS.Text) ?
                            (int?)null : totalProf;

                        db.SaveChanges();

                        MessageBox.Show("Cập nhật khoa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearInputs();
                        LoadFaculties();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khoa cần sửa!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFacultyID.Text))
                {
                    MessageBox.Show("Vui lòng chọn khoa cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa khoa này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    using (var db = new DBContext())
                    {
                        var find = db.Faculties.Find(txtFacultyID.Text);

                        if (find != null)
                        {
                            var hasStudents = db.Students.Any(s => s.FacultyID == txtFacultyID.Text);

                            if (hasStudents)
                            {
                                MessageBox.Show("Không thể xóa khoa này vì còn sinh viên!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            db.Faculties.Remove(find);
                            db.SaveChanges();

                            MessageBox.Show("Xóa khoa thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearInputs();
                            LoadFaculties();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khoa cần xóa!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFaculties();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFaculties()
        {
            using (var db = new DBContext())
            {
                var faculties = db.Faculties.Select(f => new
                {
                    MaKhoa = f.FacultyID,
                    TenKhoa = f.FacultyName,
                    TongSoGS = f.TotalProfessor
                }).ToList();

                dgvFaculty.DataSource = faculties;

                dgvFaculty.Columns["MaKhoa"].HeaderText = "Mã Khoa";
                dgvFaculty.Columns["TenKhoa"].HeaderText = "Tên Khoa";
                dgvFaculty.Columns["TongSoGS"].HeaderText = "Tổng số GS";
            }
        }

        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFaculty.Rows[e.RowIndex];

                txtFacultyID.Text = row.Cells["MaKhoa"].Value?.ToString();
                txtFacultyName.Text = row.Cells["TenKhoa"].Value?.ToString();
                txtGS.Text = row.Cells["TongSoGS"].Value?.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
