using Microsoft.Data.SqlClient;
using PBL3a.services;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class HocPhi : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtHocPhi = new DataTable();
        private Button currentButton;

        public HocPhi()
        {
            InitializeComponent();
            Load += HocPhi_Load;
            cbbML.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void HocPhi_Load(object? sender, EventArgs e)
        {
            LoadDanhSachLop();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadDanhSachLop()
        {
            cbbML.Items.Clear();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT classID FROM Class ORDER BY classID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbbML.Items.Add(reader["classID"].ToString());
                    }
                }
                conn.Close();
            }

            if (cbbML.Items.Count > 0)
                cbbML.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbbML.SelectedItem == null) return;
            else
            {
                string classID = cbbML.SelectedItem.ToString();
                LoadTenLop(classID);
                LoadHocPhiTheoLop(classID);
            }
        }

        private void LoadTenLop(string classID)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT class_name FROM Class WHERE classID = @classID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@classID", classID);
                    object result = cmd.ExecuteScalar();
                    tbTL.Text = result != null ? result.ToString() : "";
                }
            }
        }

        private void LoadHocPhiTheoLop(string classID)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        hp.HocPhiID AS [ID],
                        hp.AccountID AS [Mã HS],
                        a.name AS [Tên học sinh],
                        hp.TuitionMonth AS [Tháng],
                        hp.TuitionYear AS [Năm],
                        hp.SoTien AS [Số tiền],
                        hp.TrangThai AS [Trạng thái],
                        hp.NgayDong AS [Ngày đóng],
                        hp.GhiChu AS [Ghi chú]
                    FROM HocPhi hp
                    INNER JOIN accountList a ON hp.AccountID = a.Id
                    WHERE hp.ClassID = @classID
                    ORDER BY hp.TuitionYear DESC, hp.TuitionMonth DESC, a.Id";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@classID", classID);
                    dtHocPhi = new DataTable();
                    adapter.Fill(dtHocPhi);
                    dataGridView1.DataSource = dtHocPhi;
                }
            }

            if (dataGridView1.Columns["HocPhiID"] != null)
                dataGridView1.Columns["HocPhiID"].ReadOnly = true;

            if (dataGridView1.Columns["Mã HS"] != null)
                dataGridView1.Columns["Mã HS"].ReadOnly = true;

            if (dataGridView1.Columns["Tên học sinh"] != null)
                dataGridView1.Columns["Tên học sinh"].ReadOnly = true;

            if (dataGridView1.Columns["Tháng"] != null)
                dataGridView1.Columns["Tháng"].ReadOnly = true;

            if (dataGridView1.Columns["Năm"] != null)
                dataGridView1.Columns["Năm"].ReadOnly = true;
        }

        private void btSetHP_Click(object sender, EventArgs e)
        {
            string malop = cbbML.Text;
            ThietLapHP thietLap = new ThietLapHP(malop);
            this.Hide();
            thietLap.ShowDialog();
            this.Show();
            LoadHocPhiTheoLop(malop);
        }

        private void btSetHP_MouseEnter(object sender, EventArgs e)
        {
            but_chform.bt_MouseEnter(sender, e);
        }

        private void btSetHP_MouseLeave(object sender, EventArgs e)
        {
            but_chform.bt_MouseLeave(sender, e);
        }
    }
}