using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PBL3a.services;

namespace PBL3a.UI.Teacher
{
    public partial class NhapDiem : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private List<string> dsLop = new List<string>();
        private bool isFiltering = false;

        public NhapDiem()
        {
            InitializeComponent();

            this.Load += NhapDiem_Load;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            comboBox1.KeyUp += comboBox1_KeyUp;
            button2.Click += button2_Click;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            button2.Text = "Lưu điểm";
        }

        private void NhapDiem_Load(object? sender, EventArgs e)
        {
            LoadDanhSachLop();
        }

        private void LoadDanhSachLop()
        {
            comboBox1.Items.Clear();
            dsLop.Clear();

            string query = "SELECT classID FROM Class ORDER BY classID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string classId = reader["classID"].ToString() ?? "";
                        dsLop.Add(classId);
                    }
                }
            }

            comboBox1.Items.AddRange(dsLop.Cast<object>().ToArray());
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (isFiltering) return;

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                return;

            string keyword = comboBox1.Text.Trim();
            string[] filtered;

            if (string.IsNullOrWhiteSpace(keyword))
                filtered = dsLop.ToArray();
            else
                filtered = dsLop
                    .Where(x => x.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToArray();

            isFiltering = true;

            comboBox1.BeginUpdate();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(filtered.Cast<object>().ToArray());
            comboBox1.EndUpdate();

            comboBox1.DroppedDown = filtered.Length > 0;
            comboBox1.Text = keyword;
            comboBox1.SelectionStart = comboBox1.Text.Length;
            comboBox1.SelectionLength = 0;

            isFiltering = false;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string classId = comboBox1.SelectedItem.ToString() ?? "";
            if (string.IsNullOrWhiteSpace(classId)) return;

            comboBox1.DroppedDown = false;

            LoadTenLop(classId);
            LoadHocSinhTheoLop(classId);
        }

        private void LoadTenLop(string classId)
        {
            string query = "SELECT class_name FROM Class WHERE classID = @ClassID";

            using (SqlConnection conn = db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ClassID", classId);
                conn.Open();

                object? result = cmd.ExecuteScalar();
                textBox1.Text = result?.ToString() ?? "";
            }
        }

        private void LoadHocSinhTheoLop(string classId)
        {
            string query = @"
                SELECT 
                    a.Id AS AccountID,
                    a.name AS HoTen,
                    d.Diem,
                    d.NhanXet
                FROM accountList a
                INNER JOIN JoinClass jc ON a.Id = jc.AccountID
                LEFT JOIN Diem d ON a.Id = d.AccountID AND jc.classID = d.ClassID
                WHERE jc.classID = @ClassID
                  AND a.Role = 'Student'
                ORDER BY a.Id";

            using (SqlConnection conn = db.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@ClassID", classId);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            CaiDatDataGridView();
        }

        private void CaiDatDataGridView()
        {
            if (dataGridView1.Columns["AccountID"] != null)
            {
                dataGridView1.Columns["AccountID"].HeaderText = "Mã học sinh";
                dataGridView1.Columns["AccountID"].ReadOnly = true;
            }

            if (dataGridView1.Columns["HoTen"] != null)
            {
                dataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
                dataGridView1.Columns["HoTen"].ReadOnly = true;
            }

            if (dataGridView1.Columns["Diem"] != null)
            {
                dataGridView1.Columns["Diem"].HeaderText = "Điểm";
                dataGridView1.Columns["Diem"].ReadOnly = false;
            }

            if (dataGridView1.Columns["NhanXet"] != null)
            {
                dataGridView1.Columns["NhanXet"].HeaderText = "Nhận xét";
                dataGridView1.Columns["NhanXet"].ReadOnly = false;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp trước!");
                return;
            }

            string classId = comboBox1.SelectedItem.ToString() ?? "";

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string accountId = row.Cells["AccountID"].Value?.ToString() ?? "";
                    string diemText = row.Cells["Diem"].Value?.ToString() ?? "";
                    string nhanXet = row.Cells["NhanXet"].Value?.ToString() ?? "";

                    if (string.IsNullOrWhiteSpace(accountId))
                        continue;

                    object diemValue = DBNull.Value;

                    if (!string.IsNullOrWhiteSpace(diemText))
                    {
                        if (!double.TryParse(diemText, out double diem))
                        {
                            MessageBox.Show($"Điểm của {accountId} không hợp lệ!");
                            return;
                        }

                        if (diem < 0 || diem > 10)
                        {
                            MessageBox.Show($"Điểm của {accountId} phải từ 0-10!");
                            return;
                        }

                        diemValue = diem;
                    }

                    string query = @"
                        IF EXISTS (
                            SELECT 1
                            FROM Diem
                            WHERE AccountID = @AccountID AND ClassID = @ClassID
                        )
                        BEGIN
                            UPDATE Diem
                            SET Diem = @Diem,
                                NhanXet = @NhanXet
                            WHERE AccountID = @AccountID AND ClassID = @ClassID
                        END
                        ELSE
                        BEGIN
                            INSERT INTO Diem (AccountID, ClassID, Diem, NhanXet)
                            VALUES (@AccountID, @ClassID, @Diem, @NhanXet)
                        END";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", accountId);
                        cmd.Parameters.AddWithValue("@ClassID", classId);
                        cmd.Parameters.AddWithValue("@Diem", diemValue);
                        cmd.Parameters.AddWithValue("@NhanXet",
                            string.IsNullOrWhiteSpace(nhanXet) ? DBNull.Value : (object)nhanXet);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Lưu thành công!");
            LoadHocSinhTheoLop(classId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}