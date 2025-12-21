using Lab04_01.GUI;
using Lab05.DAL;
using Lab05.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05.GUI
{
    public partial class frmRegister : Form
    {
        DBContext db = new DBContext();
        public frmRegister()
        {
            InitializeComponent();
            GUIHelper.DecorateDataGridView(dgvStudent);
        }
         
        private void frmRegister_Load(object sender, EventArgs e)
        {
            try
            {
                var listFaculties = db.Faculties.ToList();

                FillFacultyCombobox(listFaculties);

                CreateColumnsForGrid();

                if (listFaculties.Count > 0)
                {
                    int firstFacultyID = listFaculties[0].FacultyID;

                    var listMajors = db.Majors.Where(m => m.FacultyID == firstFacultyID).ToList();

                    FillMajorCombobox(listMajors);
                }

                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Load Form: " + ex.Message);
            }
        }

        private void CreateColumnsForGrid()
        {
            dgvStudent.Columns.Clear();
            dgvStudent.AutoGenerateColumns = false;

            DataGridViewCheckBoxColumn colSelect = new DataGridViewCheckBoxColumn();
            colSelect.Name = "colSelect";
            colSelect.HeaderText = "Chọn";
            colSelect.Width = 50;
            dgvStudent.Columns.Add(colSelect);

            dgvStudent.Columns.Add("colMSSV", "MSSV");

            dgvStudent.Columns.Add("colName", "Họ Tên");
            dgvStudent.Columns["colName"].Width = 150;  

            dgvStudent.Columns.Add("colFaculty", "Khoa");

            dgvStudent.Columns.Add("colAvg", "ĐTB");

            dgvStudent.Columns.Add("colMajor", "Chuyên Ngành");
            dgvStudent.Columns["colMajor"].Width = 150;
        }

        private void FillFacultyCombobox(List<Faculty> listFaculties)
        {
            cmbFaculty.DataSource = listFaculties;
            cmbFaculty.DisplayMember = "FacultyName";
            cmbFaculty.ValueMember = "FacultyID";
        }

        private void FillMajorCombobox(List<Major> listMajors)
        {
            cmbMajor.DataSource = listMajors;
            cmbMajor.DisplayMember = "Name";
            cmbMajor.ValueMember = "MajorID";
        }

        private void LoadDataGrid()
        {
            if (cmbFaculty.SelectedValue == null) return;

            if (int.TryParse(cmbFaculty.SelectedValue.ToString(), out int facultyID))
            {
                var listStudents = db.Students
                                     .Where(s => s.FacultyID == facultyID)
                                     .Include(s => s.Faculty)
                                     .Include(s => s.Major)
                                     .ToList();

                BindGrid(listStudents);
            }
        }

        private void BindGrid(List<Student> listStudents)
        {
            dgvStudent.Rows.Clear();

            foreach (var item in listStudents)
            {
                int index = dgvStudent.Rows.Add();

                dgvStudent.Rows[index].Cells["colSelect"].Value = false;
                dgvStudent.Rows[index].Cells["colMSSV"].Value = item.StudentID;
                dgvStudent.Rows[index].Cells["colName"].Value = item.FullName;
                dgvStudent.Rows[index].Cells["colFaculty"].Value = item.Faculty?.FacultyName;
                dgvStudent.Rows[index].Cells["colAvg"].Value = item.AverageScore;

                dgvStudent.Rows[index].Cells["colMajor"].Value = item.Major?.Name ?? "";
            }
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFaculty.SelectedValue != null && int.TryParse(cmbFaculty.SelectedValue.ToString(), out int facultyID))
            {
                var listMajors = db.Majors.Where(m => m.FacultyID == facultyID).ToList();
                FillMajorCombobox(listMajors);
                LoadDataGrid();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMajor.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn Chuyên ngành muốn đăng ký!");
                    return;
                }

                int selectedMajorID = (int)cmbMajor.SelectedValue;
                int countUpdated = 0;

                foreach (DataGridViewRow row in dgvStudent.Rows)
                {
                    if (row.Cells["colMSSV"].Value == null) continue;

                    bool isSelected = false;
                    if (row.Cells["colSelect"].Value != null)
                        isSelected = (bool)row.Cells["colSelect"].Value;

                    if (isSelected)
                    {
                        string studentID = row.Cells["colMSSV"].Value.ToString();

                        var student = db.Students.FirstOrDefault(s => s.StudentID == studentID);
                        if (student != null)
                        {
                            student.MajorID = selectedMajorID;
                            countUpdated++;
                        }
                    }
                }

                if (countUpdated > 0)
                {
                    db.SaveChanges(); 
                    MessageBox.Show($"Đăng ký thành công cho {countUpdated} sinh viên!");
                    LoadDataGrid(); 
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn sinh viên nào (Tích vào ô vuông đầu dòng)!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
