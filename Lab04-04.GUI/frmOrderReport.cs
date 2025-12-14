using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab04_04.DAL;
using Microsoft.EntityFrameworkCore;
namespace Lab04_04.GUI
{
    public partial class frmOrderReport : Form
    {
        public frmOrderReport()
        {
            InitializeComponent();
            GUIHelper.DecorateDataGridView(dgvData);
            LoadData();

        }

        private void frmOrderReport_Load(object sender, EventArgs e)
        {
            dtk1.Value = DateTime.Now;
            dtk2.Value = DateTime.Now;
            LoadData();
        }

        private void LoadData()
        {
            DateTime fromDate = dtk1.Value.Date;
            DateTime toDate = dtk2.Value.Date;

            using (var db = new DBContext())
            {
                var query = db.Invoices.Include(i => i.Orders)
                                       .Where(i => i.DeliveryDate.Date >= fromDate && i.DeliveryDate.Date <= toDate);

                var result = query.Select(p => new
                {
                    SoHD = p.InvoiceNo,
                    NgayDat = p.OrderDate,
                    NgayGiao = p.DeliveryDate,
                    ThanhTien = p.Orders.Sum(o => o.Price * o.Quantity)
                }).ToList();

                dgvData.DataSource = result;

                dgvData.Columns["SoHD"].HeaderText = "Số HĐ";
                dgvData.Columns["NgayDat"].HeaderText = "Ngày Đặt";
                dgvData.Columns["NgayGiao"].HeaderText = "Ngày Giao";
                dgvData.Columns["ThanhTien"].HeaderText = "Thành Tiền";
                dgvData.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

                lblTotal.Text = "Tổng Cộng: " + result.Sum(x => x.ThanhTien).ToString("N0");
            }
        }

        private void dtk1_ValueChanged(object sender, EventArgs e)
        {
            if (!ckb1.Checked) LoadData();
        }

        private void dtk2_ValueChanged(object sender, EventArgs e)
        {
            if (!ckb1.Checked) LoadData();
        }

        private void ckb1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb1.Checked)
            {
                DateTime today = DateTime.Now;

                DateTime firstDay = new DateTime(today.Year, today.Month, 1);

                DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

                dtk1.Value = firstDay;
                dtk2.Value = lastDay;

                LoadData();
            }
            else
            {
                LoadData();
            }
        }
    }
}
