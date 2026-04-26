using Microsoft.Data.SqlClient;
using PBL3a.services;
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
        private DatabaseHelper db = new DatabaseHelper();
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
                    if (loai == "Thu") { tong += Convert.ToDecimal(row["Số tiền"]); }
                    else if (loai == "Chi") { tong -= Convert.ToDecimal(row["Số tiền"]); }
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

            string query = "";

            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    if (cbbLN.SelectedItem.ToString() == "ngày")
                    {
                        query = @"
                        SELECT ThuID AS [Mã], 
                               LoaiThu AS [Loại thu], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayThu AS [Ngày thu], 
                               GhiChu AS [Ghi chú], 
                               'Thu' AS [Loại Giao Dịch]
                        FROM KhoanThu WHERE NgayThu = @date
                        UNION ALL
                        SELECT ChiID AS [Mã chi], 
                                LoaiChi AS [Loại chi], 
                                NoiDung AS [Nội dung], 
                                SoTien AS [Số tiền], 
                                NgayChi AS [Ngày chi], 
                                GhiChu AS [Ghi chú], 
                                'Chi' AS [Loại Giao Dịch]
                        FROM KhoanChi WHERE NgayChi = @date";

                        cmd.Parameters.Add("@date", SqlDbType.Date).Value = today;
                    }
                    else if (cbbLN.SelectedItem.ToString() == "tháng")
                    {
                        query = @"
                        SELECT ThuID AS [Mã], 
                               LoaiThu AS [Loại thu], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayThu AS [Ngày thu], 
                               GhiChu AS [Ghi chú], 
                               'Thu' AS [Loại Giao Dịch]
                        FROM KhoanThu WHERE ThuMonth = @month AND ThuYear = @year
                        UNION ALL
                        SELECT ChiID AS [Mã chi], 
                                LoaiChi AS [Loại chi], 
                                NoiDung AS [Nội dung], 
                                SoTien AS [Số tiền], 
                                NgayChi AS [Ngày chi], 
                                GhiChu AS [Ghi chú], 
                                'Chi' AS [Loại Giao Dịch]
                        FROM KhoanChi WHERE ChiMonth = @month AND ChiYear = @year";

                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);
                    }
                    else if (cbbLN.SelectedItem.ToString() == "năm")
                    {
                        query = @"
                        SELECT ThuID AS [Mã], 
                               LoaiThu AS [Loại thu], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayThu AS [Ngày thu], 
                               GhiChu AS [Ghi chú], 
                               'Thu' AS [Loại Giao Dịch]
                        FROM KhoanThu WHERE ThuYear = @year
                        UNION ALL
                        SELECT ChiID AS [Mã chi], 
                                LoaiChi AS [Loại chi], 
                                NoiDung AS [Nội dung], 
                                SoTien AS [Số tiền], 
                                NgayChi AS [Ngày chi], 
                                GhiChu AS [Ghi chú], 
                                'Chi' AS [Loại Giao Dịch]
                        FROM KhoanChi WHERE ChiYear = @year";

                        cmd.Parameters.AddWithValue("@year", year);
                    }

                    if (string.IsNullOrEmpty(query)) return;

                    cmd.CommandText = query;

                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            thuchi = new DataTable();
                            adapter.Fill(thuchi);
                            dataGridView1.DataSource = thuchi;
                            dataGridView1.Columns["Ngày thu"].DefaultCellStyle.Format = "yyyy-MM-dd";
                        }
                        TinhTongKhoan();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    }
                }
            }
        }
    }
}
