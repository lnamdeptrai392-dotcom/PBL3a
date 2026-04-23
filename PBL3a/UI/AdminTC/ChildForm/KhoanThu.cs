using Microsoft.Data.SqlClient;
using PBL3a.services;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class KhoanThu : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtThu = new DataTable();

        public KhoanThu()
        {
            InitializeComponent();
            Load += KhoanThu_Load;
        }

        private void KhoanThu_Load(object? sender, EventArgs e)
        {
            SetupDataGridView();
            comboBox1.SelectedIndex = 0;
            tbNam.Text = DateTime.Now.Year.ToString();
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
        }

        public void LoadKhoanThu(int month, int year)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        ThuID AS [Mã thu],
                        LoaiThu AS [Loại thu],
                        NoiDung AS [Nội dung],
                        SoTien AS [Số tiền],
                        NgayThu AS [Ngày thu],
                        GhiChu AS [Ghi chú]
                    FROM KhoanThu
                    WHERE ThuMonth = @month AND ThuYear = @year
                    ORDER BY NgayThu";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@month", month);
                    adapter.SelectCommand.Parameters.AddWithValue("@year", year);

                    dtThu = new DataTable();
                    adapter.Fill(dtThu);
                    dataGridView1.DataSource = dtThu;
                }
            }
        }

        private void TinhTongKhoanThu()
        {
            decimal tong = 0;

            foreach (DataRow row in dtThu.Rows)
            {
                if (row["Số tiền"] != DBNull.Value)
                {
                    tong += Convert.ToDecimal(row["Số tiền"]);
                }
            }

            tbKT.Text = tong.ToString("N0") + " VNĐ";
        }

        private void btOK_MouseEnter(object sender, EventArgs e)
        {
            but_chform.bt_MouseEnter(sender, e);
        }

        private void btOK_MouseLeave(object sender, EventArgs e)
        {
            but_chform.bt_MouseLeave(sender, e);
        }

        private void butT_Click(object sender, EventArgs e)
        {
            this.Close();
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
            LoadKhoanThu(month, year);
            TinhTongKhoanThu();
        }
    }
}