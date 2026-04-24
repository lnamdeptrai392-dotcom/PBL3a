using Microsoft.Data.SqlClient;
using PBL3a.services;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class KhoanChi : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtChi = new DataTable();

        public KhoanChi()
        {
            InitializeComponent();
            Load += KhoanChi_Load;
        }

        private void KhoanChi_Load(object? sender, EventArgs e)
        {
            SetupDataGridView();
            comboBox1.SelectedIndex = -1;
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

        private void btOK_Click(object? sender, EventArgs e)
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
            LoadKhoanChi(month, year);
            TinhTongKhoanChi();
        }

        public void LoadKhoanChi(int month, int year)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        ChiID AS [Mã chi],
                        LoaiChi AS [Loại chi],
                        NoiDung AS [Nội dung],
                        SoTien AS [Số tiền],
                        NgayChi AS [Ngày chi],
                        GhiChu AS [Ghi chú]
                    FROM KhoanChi
                    WHERE ChiMonth = @month AND ChiYear = @year
                    ORDER BY NgayChi";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@month", month);
                    adapter.SelectCommand.Parameters.AddWithValue("@year", year);

                    dtChi = new DataTable();
                    adapter.Fill(dtChi);
                    dataGridView1.DataSource = dtChi;
                }
            }
        }

        private void TinhTongKhoanChi()
        {
            decimal tong = 0;

            foreach (DataRow row in dtChi.Rows)
            {
                if (row["Số tiền"] != DBNull.Value)
                {
                    tong += Convert.ToDecimal(row["Số tiền"]);
                }
            }

            tbKT.Text = tong.ToString("N0") + " VNĐ";
        }

        private void butT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btOK_MouseEnter(object sender, EventArgs e)
        {
            but_chform.bt_MouseEnter(sender, e);
        }

        private void btOK_MouseLeave(object sender, EventArgs e)
        {
            but_chform.bt_MouseLeave(sender, e);
        }
    }
}

