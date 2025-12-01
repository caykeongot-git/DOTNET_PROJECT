using System.Net.WebSockets;
using System.Linq;
using System.Diagnostics.Eventing.Reader;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;

namespace Lab02_02
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void LoadDB(string searchKeyword = "")
        {
            using (var db = new StudentsContext())
            {

                IQueryable<Student> query = db.Students;

                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    query = query.Where(s => s.Id.Contains(searchKeyword)
                                          || s.FullName.Contains(searchKeyword));
                }

                var listStudents = query.ToList();

                grvInformation.DataSource = listStudents;

                int soNam = listStudents.Count(s => s.Sex == "Nam");
                int soNu = listStudents.Count(s => s.Sex == "Nữ");

                lblValueMale.Text = soNam.ToString();
                lblValueFemale.Text = soNu.ToString();
            }
        }

        private void ToTal()
        {
            using (var db = new StudentsContext())
            {
                int soNam = db.Students.Where(x => x.Sex == "Nam").Count();
                int soNu = db.Students.Where(x => x.Sex == "Nữ").Count();

                lblValueMale.Text = soNam.ToString();
                lblValueFemale.Text = soNu.ToString();

            }
        }

        private void btnAddorEdit_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập Mã và Tên sinh viên!", "Cảnh báo");
            //    return;  
            //}

            //if (!double.TryParse(txtAvrg.Text, out double diemTB))
            //{
            //    MessageBox.Show("Điểm trung bình phải là số! (Ví dụ: 8.5)", "Cảnh báo");
            //    return;
            //}

            //if (diemTB < 0 || diemTB > 10)
            //{
            //    MessageBox.Show("Điểm phải từ 0 đến 10!", "Cảnh báo");
            //    return;
            //}

            try
            {
                using (var db = new StudentsContext())
                {
                    var id = db.Students.Find(txtCode.Text);
                    if (id == null)
                    {
                        Student st = new Student()
                        {
                            Id = txtCode.Text.Length != 0 ? txtCode.Text : throw new ArgumentException("Vui lòng nhập đầy đủ thông tin!"),
                            FullName = txtName.Text.Length != 0 ? txtName.Text : throw new ArgumentException("Vui lòng nhập đầy đủ thông tin!"),
                            Sex = (radMale.Checked ? "Nam" : "Nữ"),
                            GPA = txtAvrg.Text.Length != 0 ? double.Parse(txtAvrg.Text) : throw new ArgumentException("Vui lòng nhập đầy đủ thông tin!"),
                            Faculty = cbFaculty.Text
                        };
                        db.Students.Add(st);
                        db.SaveChanges();
                        MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDB();
                    }
                    else
                    {
                        id.Id = txtCode.Text.Length != 0 ? txtCode.Text : throw new ArgumentException("Vui lòng nhập đầy đủ thông tin!");
                        id.FullName = txtName.Text.Length != 0 ? txtName.Text : throw new ArgumentException("Vui lòng nhập đầy đủ thông tin!");
                        id.Sex = (radMale.Checked ? "Nam" : "Nữ");
                        id.GPA = txtAvrg.Text.Length != 0 ? double.Parse(txtAvrg.Text) : throw new ArgumentException("Vui lòng nhập đầy đủ thông tin!");
                        id.Faculty = cbFaculty.Text;

                        db.SaveChanges();
                        MessageBox.Show("Thay đổi dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDB();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new StudentsContext())
                {
                    var id = db.Students.Find(txtCode.Text);
                    if (id != null)
                    {
                        DialogResult check = MessageBox.Show("Muốn xóa thật à?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                        if (check == DialogResult.Yes)
                        {
                            db.Students.Remove(id);
                            db.SaveChanges();
                            MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDB();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Làm gì có Mã Số Sinh Viên đó?", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;

                    }
                }
            }
            catch
            {

            }
        }

        private void grvInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grvInformation.Rows[e.RowIndex];
                txtCode.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam") radMale.Checked = true;
                else radFemale.Checked = true;
                txtAvrg.Text = row.Cells[3].Value.ToString();
                cbFaculty.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new StudentsContext())
                {
                    OpenFileDialog open = new OpenFileDialog();
                    open.Filter = "Text Files|*.txt";

                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        string[] lines = File.ReadAllLines(open.FileName);
                        foreach (string line in lines)
                        {
                            string[] data = line.Split('|');
                            if (data.Length == 5)
                            {
                                if (double.TryParse(data[3], out double gpa))
                                {
                                    Student sv = new Student();
                                    sv.Id = data[0];
                                    sv.FullName = data[1];
                                    sv.Sex = data[2];
                                    sv.GPA = gpa;
                                    sv.Faculty = data[4];

                                    var checkSV = db.Students.FirstOrDefault(x => x.Id == sv.Id);
                                    if (checkSV == null)
                                    {
                                        db.Students.Add(sv);
                                    }
                                    else
                                    {
                                        checkSV.FullName = sv.FullName;
                                        checkSV.Sex = sv.Sex;
                                        checkSV.GPA = sv.GPA;
                                        checkSV.Faculty = sv.Faculty;

                                    }
                                }
                            }
                        }
                        db.SaveChanges();
                        MessageBox.Show("Thêm dữ liệu từ file thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDB();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDB(txtSearch.Text.Trim());
        }
    }
}
