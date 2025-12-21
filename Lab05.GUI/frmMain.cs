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
    public partial class frmMain : Form
    {
        DBContext db = new DBContext();
        string sourceFilePath = "";
        string imageFolderPath = Path.Combine(Application.StartupPath, "Images");
        public frmMain()
        {
            InitializeComponent();
            GUIHelper.DecorateDataGridView(dgvStudent);
        }
         
        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvStudent.Columns.Clear();
            dgvStudent.Columns.Add("colID", "MSSV");
            dgvStudent.Columns.Add("colName", "Họ Tên");
            dgvStudent.Columns.Add("colFaculty", "Khoa");
            dgvStudent.Columns.Add("colAvg", "ĐTB");
            dgvStudent.Columns.Add("colAvatar", "Avatar");

            dgvStudent.Columns[4].Visible = false;
            if (!Directory.Exists(imageFolderPath)) Directory.CreateDirectory(imageFolderPath);

            LoadCombobox();
            LoadDataGrid();
        }
        private void LoadCombobox()
        {
            cmbFaculty.DataSource = db.Faculties.ToList();
            cmbFaculty.DisplayMember = "FacultyName";
            cmbFaculty.ValueMember = "FacultyID";
        }

        private void LoadDataGrid()
        {
            var query = db.Students.Include(s => s.Faculty).AsQueryable();

            if (chkUnregister.Checked)
            {
                query = query.Where(s => s.MajorID == null);
            }

            var list = query.ToList();
            dgvStudent.Rows.Clear();
            foreach (var item in list)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;
                dgvStudent.Rows[index].Cells[4].Value = item.Avatar;
            }
        }

        private void chkUnregister_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void btnUploadAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                sourceFilePath = openDlg.FileName;
                picAvatar.Image = Image.FromFile(sourceFilePath);
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvStudent.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                cmbFaculty.SelectedIndex = cmbFaculty.FindStringExact(row.Cells[2].Value.ToString());
                txtAverageScore.Text = row.Cells[3].Value.ToString();

                string avatarFilename = row.Cells[4].Value?.ToString();
                if (!string.IsNullOrEmpty(avatarFilename))
                {
                    string path = Path.Combine(imageFolderPath, avatarFilename);
                    if (File.Exists(path))
                    {
                        picAvatar.Image = Image.FromFile(path);
                        sourceFilePath = "";
                    }
                    else picAvatar.Image = null;
                }
                else picAvatar.Image = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentID.Text == "" || txtName.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!"); return;
                }

                var student = db.Students.FirstOrDefault(s => s.StudentID == txtStudentID.Text);
                string avatarFileName = null;

                if (!string.IsNullOrEmpty(sourceFilePath))
                {
                    string extension = Path.GetExtension(sourceFilePath);

                    avatarFileName = txtStudentID.Text + extension;

                    string destPath = Path.Combine(imageFolderPath, avatarFileName);
                    File.Copy(sourceFilePath, destPath, true);
                }
                else
                {
                    if (student != null) avatarFileName = student.Avatar;
                }

                if (student == null)
                {
                    student = new Student();
                    student.StudentID = txtStudentID.Text;
                    student.FullName = txtName.Text;
                    student.AverageScore = double.Parse(txtAverageScore.Text);
                    student.FacultyID = (int)cmbFaculty.SelectedValue;
                    student.Avatar = avatarFileName;

                    db.Students.Add(student);
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    student.FullName = txtName.Text;
                    student.AverageScore = double.Parse(txtAverageScore.Text);
                    student.FacultyID = (int)cmbFaculty.SelectedValue;

                    if (!string.IsNullOrEmpty(avatarFileName))
                        student.Avatar = avatarFileName;

                    MessageBox.Show("Cập nhật thành công!");
                }

                db.SaveChanges();

                txtStudentID.Text = ""; txtName.Text = ""; txtAverageScore.Text = "";
                picAvatar.Image = null; sourceFilePath = "";
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var student = db.Students.FirstOrDefault(s => s.StudentID == txtStudentID.Text);
            if (student != null)
            {
                if (!string.IsNullOrEmpty(student.Avatar))
                {
                    string path = Path.Combine(imageFolderPath, student.Avatar);
                    if (File.Exists(path)) File.Delete(path);
                }

                db.Students.Remove(student);
                db.SaveChanges();
                LoadDataGrid();
                MessageBox.Show("Xóa thành công!");
            }
            else MessageBox.Show("Không tìm thấy SV!");
        }

        private void đăngKýChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister f = new frmRegister();
            f.ShowDialog();
        }
    }
}
