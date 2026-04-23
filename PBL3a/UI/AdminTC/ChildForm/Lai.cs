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

        private void btOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tháng.");
                return;
            }

            if (!int.TryParse(tbNam.Text.Trim(), out int year))
            {
                MessageBox.Show("Năm không hợp lệ.");
                return;
            }

            int month = Convert.ToInt32(comboBox1.SelectedItem);
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        ThuID AS [Mã],
                        LoaiThu AS [Loại thu],
                        NoiDung AS [Nội dung],
                        SoTien AS [Số tiền],
                        NgayThu AS [Ngày thu],
                        GhiChu AS [Ghi chú]
                    FROM KhoanThu 
                    WHERE ThuMonth = @month AND ThuYear = @year
                    UNION ALL
                    SELECT 
                        ChiID AS [Mã chi],
                        LoaiChi AS [Loại chi],
                        NoiDung AS [Nội dung],
                        SoTien AS [Số tiền],
                        NgayChi AS [Ngày chi],
                        GhiChu AS [Ghi chú]
                    FROM KhoanChi
                    WHERE ChiMonth = @month AND ChiYear = @year";
                try
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@month", month);
                        adapter.SelectCommand.Parameters.AddWithValue("@year", year);

                        thuchi = new DataTable();
                        adapter.Fill(thuchi);
                        dataGridView1.DataSource = thuchi;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
