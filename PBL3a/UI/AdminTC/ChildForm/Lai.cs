using Microsoft.Data.SqlClient;
using PBL3a.services;
using PBL3a.services.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class Lai : Form
    {
        private AdminTC_Service admin_sv = new AdminTC_Service();
        private DataTable thuchi = new DataTable();
        public Lai()
        {
            InitializeComponent();
            Load += Lai_Load;
        }

        private void Lai_Load(object? sender, EventArgs e)
        {
            SetupDataGridView();
            cbbLN.SelectedIndex = 0;
            date.Value = DateTime.Now;
        }
        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
        }

        private void btT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btT_MouseEnter(object sender, EventArgs e)
        {
            but_chform.bt_MouseEnter(sender, e);
        }

        private void btT_MouseLeave(object sender, EventArgs e)
        {
            but_chform.bt_MouseLeave(sender, e);
        }

        private void TinhTongKhoan()
        {
            decimal tong = 0;
            foreach (DataRow row in thuchi.Rows)
            {
                if (row["Số tiền"] != DBNull.Value)
                {
                    string loai = row["Loại Giao Dịch"].ToString();
                    if (loai == "Thu") { tong += Convert.ToDecimal(row["Số tiền"]);  }
                    else if(loai == "Chi") { tong -= Convert.ToDecimal(row["Số tiền"]); }
                    else { MessageBox.Show("Loai giao dich tren khong hop le!!!"); }
                }
            }

            tbT.Text = tong.ToString("N0") + " VNĐ";
        }


        private void btOK_Click(object sender, EventArgs e)
        {
            if (cbbLN.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tùy chọn thời gian để xem");
                return;
            }

            DateTime today = date.Value.Date;
            int month = date.Value.Month;
            int year = date.Value.Year;
            if (cbbLN.SelectedItem.ToString() == "ngày")
            {
                thuchi = admin_sv.getNetIncomeByDate(today);
            }
            else if (cbbLN.SelectedItem.ToString() == "tháng")
            {
                thuchi = admin_sv.getNetIncomeByMonth(month, year);
            }
            else if (cbbLN.SelectedItem.ToString() == "năm")
            {
                thuchi = admin_sv.getNetIncomeByYear(year);
            }
            else { return; }
            try
            {
                dataGridView1.DataSource = thuchi;

                if (dataGridView1.Columns.Contains("Mã"))
                {
                    dataGridView1.Columns["Mã"].DefaultCellStyle.BackColor = Color.LightGray;
                }
                if (dataGridView1.Columns.Contains("Ngày thu"))
                {
                    dataGridView1.Columns["Ngày thu"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
                TinhTongKhoan();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi kết nối: " + ex.Message); }
        }
    }
}
