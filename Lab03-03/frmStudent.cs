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

namespace Lab03_03
{
    public delegate void AnyHandler();
    public partial class frmStudent : Form
    {
        public event AnyHandler Subscriber;
        public frmStudent()
        {
            InitializeComponent();
        }

        private bool validation()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAvg.Text))
            {
                MessageBox.Show("Nhập thiếu rồi kìa má!", "Ê nha ê nha ê nha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            double score;
            if (!double.TryParse(txtAvg.Text, out score) || score < 0 || score > 10)
            {
                MessageBox.Show("Điểm phải là số từ 0 đến 10!", "Giỡn mặt hả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAvg.Focus();
                txtAvg.SelectAll();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                using (var db = new StudentContext())
                {
                    var find = db.Students.Find(txtId.Text);
                    if (find == null)
                    {
                        db.Students.Add(new Student
                        {
                            Id = txtId.Text,
                            FullName = txtName.Text,
                            Faculty = cbbFaculty.Text,
                            AverageScore = double.Parse(txtAvg.Text)
                        });
                        db.SaveChanges();
                        MessageBox.Show("Thêm sanh diên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Subscriber.Invoke();
                        this.Close();
                    }
                    else
                    {
                        DialogResult check = MessageBox.Show("Mã SV này có rồi đại ca ơi!\nBấm OK thì SỬA còn CANCEL thì nhập lại!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (check == DialogResult.OK) {

                            find.FullName = txtName.Text;
                            find.Faculty = cbbFaculty.Text;
                            find.AverageScore = double.Parse(txtAvg.Text);
                            db.SaveChanges();
                            MessageBox.Show("Sửa sanh diên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Subscriber.Invoke();
                            this.Close();
                        }
                        else if (check  == DialogResult.Cancel) 
                        {
                            txtId.Focus();
                            txtId.SelectAll();
                        }
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
