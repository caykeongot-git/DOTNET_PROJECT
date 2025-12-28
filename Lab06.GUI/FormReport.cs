using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab06.DAL;
using Lab06.DAL.Models;
using Lab06.BLL;
using Lab04_01.GUI;

namespace Lab06.GUI
{
    public partial class FormReport : Form
    {
        private readonly SachService sachService = new SachService();
        public FormReport()
        {
            InitializeComponent();
            GUIHelper.DecorateDataGridView(dgvReport);
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // Yêu cầu đề bài: Xuất danh sách sách sắp xếp GIẢM DẦN theo năm
            var listSach = sachService.GetAll();

            // Dùng LINQ để sắp xếp giảm dần theo NamXB
            var listReport = listSach.OrderByDescending(s => s.NamXB).ToList();

            // Đổ vào Grid (Tương tự Form1, dùng Select để hiện tên loại đẹp)
            dgvReport.DataSource = listReport.Select(s => new
            {
                MaSach = s.MaSach,
                TenSach = s.TenSach,
                NamXB = s.NamXB,
                LoaiSach = s.LoaiSach?.TenLoai
            }).ToList();

            // Chỉnh lại Header cột cho đẹp
            dgvReport.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvReport.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvReport.Columns["NamXB"].HeaderText = "Năm XB";
            dgvReport.Columns["LoaiSach"].HeaderText = "Thể Loại";
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
