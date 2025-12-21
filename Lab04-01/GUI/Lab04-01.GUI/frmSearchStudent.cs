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
using Microsoft.EntityFrameworkCore;

namespace Lab04_01.GUI
{
    public partial class frmSearchStudent : Form
    {
        public frmSearchStudent()
        {
            InitializeComponent();
            GUIHelper.DecorateDataGridView(dgvSearch);
        }

        private void frmSearchStudent_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFaculty();
                LoadAllStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFaculty()
        {
            using (var db = new DBContext())
            {
                var faculties = db.Faculties.ToList();

                faculties.Insert(0, new Faculty { FacultyID = "", FacultyName = "-- Tất cả các khoa --" });

                cbFaculty.DataSource = faculties;
                cbFaculty.DisplayMember = "FacultyName";
                cbFaculty.ValueMember = "FacultyID";
                cbFaculty.SelectedIndex = 0;
            }
        }

        private void LoadAllStudents()
        {
            using (var db = new DBContext())
            {
                var students = db.Students
                    .Include(s => s.Faculty)
                    .Select(s => new
                    {
                        MSSV = s.StudentID,
                        HoTen = s.StudentName,
                        Khoa = s.Faculty.FacultyName,
                        DiemTB = s.AverageScore
                    })
                    .ToList();

                dgvSearch.DataSource = students;

                if (dgvSearch.Columns.Count > 0)
                {
                    dgvSearch.Columns["MSSV"].HeaderText = "Mã Số SV";
                    dgvSearch.Columns["HoTen"].HeaderText = "Họ Tên";
                    dgvSearch.Columns["Khoa"].HeaderText = "Khoa";
                    dgvSearch.Columns["DiemTB"].HeaderText = "Điểm TB";
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBContext())
                {
                    string studentID = txtStudentID.Text.Trim();
                    string studentName = txtFullName.Text.Trim();
                    string facultyID = cbFaculty.SelectedValue?.ToString();

                    var query = db.Students.Include(s => s.Faculty).AsQueryable();

                    if (!string.IsNullOrEmpty(studentID))
                    {
                        query = query.Where(s => s.StudentID.Contains(studentID));
                    }

                    if (!string.IsNullOrEmpty(studentName))
                    {
                        query = query.Where(s => s.StudentName.Contains(studentName));
                    }

                    if (!string.IsNullOrEmpty(facultyID))
                    {
                        query = query.Where(s => s.FacultyID == facultyID);
                    }

                    var results = query.Select(s => new
                    {
                        MSSV = s.StudentID,
                        HoTen = s.StudentName,
                        Khoa = s.Faculty.FacultyName,
                        DiemTB = s.AverageScore
                    }).ToList();

                    dgvSearch.DataSource = results;

                    if (dgvSearch.Columns.Count > 0)
                    {
                        dgvSearch.Columns["MSSV"].HeaderText = "Mã Số SV";
                        dgvSearch.Columns["HoTen"].HeaderText = "Họ Tên";
                        dgvSearch.Columns["Khoa"].HeaderText = "Khoa";
                        dgvSearch.Columns["DiemTB"].HeaderText = "Điểm TB";
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
                        cbFaculty.SelectedIndex = 0;

                        LoadAllStudents();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }



            LoadAllStudents();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);

        }

        private void cbFaculty_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSearch.Rows[e.RowIndex];

                txtStudentID.Text = row.Cells["MSSV"].Value?.ToString();
                txtFullName.Text = row.Cells["HoTen"].Value?.ToString();
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
    }
}
