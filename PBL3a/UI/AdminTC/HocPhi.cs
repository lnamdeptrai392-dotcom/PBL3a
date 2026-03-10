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

        public HocPhi()
        {
            InitializeComponent();
            Load += HocPhi_Load;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            comboBox1.Items.Clear();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT classID FROM Class ORDER BY classID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["classID"].ToString());
                    }
                }
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            int classID = Convert.ToInt32(comboBox1.SelectedItem);
            LoadTenLop(classID);
            LoadHocPhiTheoLop(classID);
        }

        private void LoadTenLop(int classID)
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

        private void LoadHocPhiTheoLop(int classID)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        hp.HocPhiID,
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

        private void btCheckHP_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp.");
                return;
            }

            int classID = Convert.ToInt32(comboBox1.SelectedItem);
            LoadHocPhiTheoLop(classID);
        }

        private void btSetHP_Click(object sender, EventArgs e)
        {
            if (dtHocPhi == null || dtHocPhi.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lưu.");
                return;
            }

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                foreach (DataRow row in dtHocPhi.Rows)
                {
                    string query = @"
                        UPDATE HocPhi
                        SET 
                            SoTien = @SoTien,
                            TrangThai = @TrangThai,
                            NgayDong = @NgayDong,
                            GhiChu = @GhiChu
                        WHERE HocPhiID = @HocPhiID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HocPhiID", Convert.ToInt32(row["HocPhiID"]));
                        cmd.Parameters.AddWithValue("@SoTien", Convert.ToDecimal(row["Số tiền"]));
                        cmd.Parameters.AddWithValue("@TrangThai", row["Trạng thái"]?.ToString() ?? "");

                        if (row["Ngày đóng"] == DBNull.Value || string.IsNullOrWhiteSpace(row["Ngày đóng"].ToString()))
                            cmd.Parameters.AddWithValue("@NgayDong", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@NgayDong", Convert.ToDateTime(row["Ngày đóng"]));

                        if (row["Ghi chú"] == DBNull.Value || string.IsNullOrWhiteSpace(row["Ghi chú"].ToString()))
                            cmd.Parameters.AddWithValue("@GhiChu", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@GhiChu", row["Ghi chú"].ToString());

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Lưu thay đổi học phí thành công.");

            if (comboBox1.SelectedItem != null)
            {
                int classID = Convert.ToInt32(comboBox1.SelectedItem);
                LoadHocPhiTheoLop(classID);
            }
        }

        private void btT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}