using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab04_01.DAL.Entities;
using Lab04_01.DAL;
using Microsoft.EntityFrameworkCore;

namespace Lab04_01.GUI
{
    public partial class frmMain : Form
    {
        double _average;

        public frmMain()
        {
            InitializeComponent();
            GUIHelper.DecorateDataGridView(dgvData);
            LoadFaculty();
            LoadDB();
        }

        private void LoadDB()
        {
            using (var db = new DBContext())
            {
                var students = db.Students.Include(x => x.Faculty).Select(x => new
                {
                    StudentID = x.StudentID,
                    StudentName = x.StudentName,
                    FacultyName = x.Faculty.FacultyName,
                    AverageScore = x.AverageScore,
                }).ToList();


                dgvData.DataSource = students;

                dgvData.Columns["StudentID"].HeaderText = "Mã Số SV";
                dgvData.Columns["StudentName"].HeaderText = "Họ Tên";
                dgvData.Columns["FacultyName"].HeaderText = "Khoa";
                dgvData.Columns["AverageScore"].HeaderText = "Điểm TB";
            }
        }

        private void LoadFaculty()
        {
            using (var db = new DBContext())
            {
                cbFaculty.DataSource = db.Faculties.ToList();
                cbFaculty.DisplayMember = "FacultyName";
                cbFaculty.ValueMember = "FacultyID";
            }
        }

        public bool validation()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtAverage.Text))
            {
                MessageBox.Show("Nhập thiếu kìa má!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbFaculty.SelectedValue == null)
            {
                MessageBox.Show("Chọn khoa đi má!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (double.TryParse(txtAverage.Text, out _average) == false || _average < 0 || _average > 10)
            {
                MessageBox.Show("Điểm là số từ 0 -> 10 không phải chữ nha má", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (validation())
            {
                using (var db = new DBContext())
                {
                    var find = db.Students.Find(txtStudentID.Text);

                    if (find == null)
                    {
                        Student stu = new Student()
                        {
                            StudentID = txtStudentID.Text,
                            StudentName = txtFullName.Text,
                            AverageScore = _average,
                            FacultyID = cbFaculty.SelectedValue.ToString(),
                        };
                        db.Students.Add(stu);
                        db.SaveChanges();
                        MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtStudentID.Clear();
                        txtFullName.Clear();
                        txtAverage.Clear();
                        cbFaculty.SelectedIndex = 0;
                        txtStudentID.Focus();

                        LoadDB();
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên có trong danh sách ời!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validation())
            {

                using (var db = new DBContext())
                {

                    var find = db.Students.Find(txtStudentID.Text);

                    if (find != null)
                    {
                        find.StudentName = txtFullName.Text;
                        find.FacultyID = cbFaculty.SelectedValue.ToString();
                        find.AverageScore = double.Parse(txtAverage.Text);
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Làm gì có sinh viên này trong danh sách?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    txtStudentID.Clear();
                    txtFullName.Clear();
                    txtAverage.Clear();
                    cbFaculty.SelectedIndex = 0;
                    txtStudentID.Focus();

                    LoadDB();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Nhập mã sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                using (var db = new DBContext())
                {
                    var find = db.Students.Find(txtStudentID.Text);

                    if (find != null)
                    {
                        db.Students.Remove(find);
                        db.SaveChanges();

                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtStudentID.Clear();
                        txtFullName.Clear();
                        txtAverage.Clear();
                        cbFaculty.SelectedIndex = 0;
                        txtStudentID.Focus();

                        LoadDB();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];

                txtStudentID.Text = row.Cells["StudentID"].Value?.ToString();
                txtFullName.Text = row.Cells["StudentName"].Value?.ToString();
                txtAverage.Text = row.Cells["AverageScore"].Value?.ToString();

                using (var db = new DBContext())
                {
                    var student = db.Students.Find(txtStudentID.Text);
                    if (student != null)
                    {
                        cbFaculty.SelectedValue = student.FacultyID;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file dữ liệu sinh viên";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(openFileDialog.FileName);
                    int successCount = 0;
                    int errorCount = 0;
                    using (var db = new DBContext())
                    {
                        foreach (string line in lines)
                        {
                            if (string.IsNullOrWhiteSpace(line))
                                continue;

                            string[] data = line.Split(',');

                            if (data.Length < 4)
                            {
                                errorCount++;
                                continue;
                            }

                            try
                            {
                                string studentID = data[0].Trim();
                                string studentName = data[1].Trim();
                                string facultyID = data[2].Trim();
                                double averageScore = double.Parse(data[3].Trim());

                                var find = db.Students.Find(studentID);

                                if (find == null)
                                {
                                    Student stu = new Student()
                                    {
                                        StudentID = studentID,
                                        StudentName = studentName,
                                        FacultyID = facultyID,
                                        AverageScore = averageScore
                                    };

                                    db.Students.Add(stu);
                                    successCount++;
                                }
                                else
                                {
                                    errorCount++;
                                }
                            }
                            catch
                            {
                                errorCount++;
                            }
                        }

                        db.SaveChanges();
                    }

                    MessageBox.Show($"Import hoàn tất!\nThành công: {successCount}\nLỗi/Trùng: {errorCount}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnManageFaculty_Click(object sender, EventArgs e)
        {
            frmFaculty frm = new frmFaculty();
            frm.ShowDialog();
            LoadFaculty();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaculty frm = new frmFaculty();
            frm.ShowDialog();
            LoadFaculty();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchStudent frm = new frmSearchStudent();
            frm.ShowDialog();
            LoadDB();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tìmKiếmToolStripMenuItem_Click(sender, e);
            LoadDB();
        }
    }
}
