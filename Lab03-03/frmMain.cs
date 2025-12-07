using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab03_03
{
    public partial class frmMain : Form
    {
        List<Student> listOriginal = new List<Student>();
        bool isAscending = true;
        int lastColIndex = -1;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStudent student = new frmStudent();
            student.Subscriber += LoadDB;
            student.ShowDialog();
        }

        private void LoadDB()
        {
            using (var db = new StudentContext())
            {
                listOriginal = db.Students.ToList();
                dgvData.DataSource = listOriginal;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void lblSearchName_Click(object sender, EventArgs e)
        {
            txtSearchName.Focus();
        }

        private void functionAdd_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void functionExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void functionOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files|*.txt;*.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    string[] lines = File.ReadAllLines(open.FileName, System.Text.Encoding.UTF8);

                    using (var db = new StudentContext())
                    {
                        foreach (string line in lines)
                        {
                            if (string.IsNullOrWhiteSpace(line)) continue;
                            string[] data = line.Split(',');
                            if (data.Length >= 4)
                            {
                                string id = data[0].Trim();
                                string fullName = data[1].Trim();
                                string faculty = data[2].Trim();
                                if (!double.TryParse(data[3].Trim(), out double avgScore)) continue;

                                var find = db.Students.Find(id);
                                if (find == null)
                                {
                                    Student stu = new Student()
                                    {
                                        Id = id,
                                        FullName = fullName,
                                        Faculty = faculty,
                                        AverageScore = avgScore,
                                    };
                                    db.Students.Add(stu);
                                }
                                else
                                {

                                    find.FullName = fullName;
                                    find.Faculty = faculty;
                                    find.AverageScore = avgScore;
                                }
                            }
                        }
                        db.SaveChanges();
                    }
                    MessageBox.Show($"Đã nhập xong {lines.Length} sinh viên!", "Uy tín luôn");
                    LoadDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc file rồi: " + ex.Message);
                }
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchName.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                dgvData.DataSource = listOriginal;
                return;
            }

            var listFiltered = listOriginal.Where(x =>
                x.FullName.ToLower().Contains(keyword) ||
                x.Id.ToLower().Contains(keyword) ||
                x.Faculty.ToLower().Contains(keyword) ||
                x.AverageScore.ToString().Contains(keyword)

            ).ToList();
            dgvData.DataSource = listFiltered;
        }

        private void btnKick_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                using (var db = new StudentContext())
                {
                    string selectedId = dgvData.SelectedRows[0].Cells[0].Value.ToString();
                    DialogResult confirm = MessageBox.Show($"Muốn kick sinh viên mã {selectedId} đúng hem?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        var deleStu = db.Students.Find(selectedId);
                        if (deleStu != null)
                        {
                            db.Students.Remove(deleStu);
                            db.SaveChanges();
                            MessageBox.Show("Đã tiễn Mom đó lên đường thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDB();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên này trong DB (chắc mom khác xóa rồi)!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblKick_Click(object sender, EventArgs e)
        {
            btnKick_Click(sender, e);
        }

        private void dgvData_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ( lastColIndex == e.ColumnIndex)
            {
                isAscending = !isAscending;
            }
            else
            {
                isAscending = true;
                lastColIndex = e.ColumnIndex;
            }

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        if (isAscending) listOriginal = listOriginal.OrderBy(x => x.Id).ToList();
                        else listOriginal = listOriginal.OrderByDescending(x => x.Id).ToList();
                        break;
                    }
                case 1:
                    {
                        if (isAscending) listOriginal = listOriginal.OrderBy(x => x.FullName).ToList();
                        else listOriginal = listOriginal.OrderByDescending(x => x.FullName).ToList();
                        break;
                    }
                case 2:
                    {
                        if (isAscending) listOriginal = listOriginal.OrderBy(x => x.Faculty).ToList();
                        else listOriginal = listOriginal.OrderByDescending(x => x.Faculty).ToList();
                        break;
                    }
                case 3:
                    {
                        if (isAscending) listOriginal = listOriginal.OrderBy(x => x.AverageScore).ToList();
                        else listOriginal = listOriginal.OrderByDescending(x => x.AverageScore).ToList();
                        break;
                    }
            }
            dgvData.DataSource = null;
            dgvData.DataSource = listOriginal;
        }
    }
}
