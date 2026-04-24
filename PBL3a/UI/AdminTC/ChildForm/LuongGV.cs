using Microsoft.Data.SqlClient;
using PBL3;
using PBL3a.services;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class LuongGV : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtLuong = new DataTable();

        public LuongGV()
        {
            InitializeComponent();
            Load += LuongGV_Load;
            cbbMGV.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void LuongGV_Load(object? sender, EventArgs e)
        {
            SetupDataGridView();
            LoadDanhSachGiangVien(cbbMGV.Text);
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadDanhSachGiangVien(string text)
        {
            cbbMGV.Items.Clear();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id FROM accountList WHERE Role = 'Teacher' AND Id LIKE @text ORDER BY Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@text", "%" + text + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbbMGV.Items.Add(reader["Id"].ToString());
                        }
                    }
                }
            }

            if (cbbMGV.Items.Count > 0)
                cbbMGV.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbbMGV.SelectedItem == null) return;

            string teacherID = cbbMGV.SelectedItem.ToString();
            LoadTenGiangVien(teacherID);
            LoadLuongTheoGV(teacherID);
        }

        private void LoadTenGiangVien(string teacherID)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT name FROM accountList WHERE Id = @teacherID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherID", teacherID);
                    object result = cmd.ExecuteScalar();
                    tbTL.Text = result != null ? result.ToString() : "";
                }
            }
        }

        private void LoadLuongTheoGV(string teacherID)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        LuongID,
                        TeacherID AS [Mã GV],
                        SalaryMonth AS [Tháng],
                        SalaryYear AS [Năm],
                        SoLopDay AS [Số lớp dạy],
                        SoBuoiDay AS [Số buổi dạy],
                        LuongCoBan AS [Lương cơ bản],
                        Thuong AS [Thưởng],
                        Phat AS [Phạt],
                        TongLuong AS [Tổng lương],
                        TrangThai AS [Trạng thái],
                        NgayThanhToan AS [Ngày thanh toán],
                        GhiChu AS [Ghi chú]
                    FROM LuongGV
                    WHERE TeacherID = @teacherID
                    ORDER BY SalaryYear DESC, SalaryMonth DESC";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@teacherID", teacherID);
                    dtLuong = new DataTable();
                    adapter.Fill(dtLuong);
                    dataGridView1.DataSource = dtLuong;
                }
            }

            if (dataGridView1.Columns["LuongID"] != null)
                dataGridView1.Columns["LuongID"].ReadOnly = true;

            if (dataGridView1.Columns["Mã GV"] != null)
                dataGridView1.Columns["Mã GV"].ReadOnly = true;

            if (dataGridView1.Columns["Tháng"] != null)
                dataGridView1.Columns["Tháng"].ReadOnly = true;

            if (dataGridView1.Columns["Năm"] != null)
                dataGridView1.Columns["Năm"].ReadOnly = true;

            if (dataGridView1.Columns["Số lớp dạy"] != null)
                dataGridView1.Columns["Số lớp dạy"].ReadOnly = true;

            if (dataGridView1.Columns["Số buổi dạy"] != null)
                dataGridView1.Columns["Số buổi dạy"].ReadOnly = true;

            if (dataGridView1.Columns["Tổng lương"] != null)
                dataGridView1.Columns["Tổng lương"].ReadOnly = true;
        }

        private void btCheckL_Click(object sender, EventArgs e)
        {
            if (cbbMGV.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giảng viên.");
                return;
            }

            string teacherID = cbbMGV.SelectedItem.ToString();
            LoadLuongTheoGV(teacherID);
        }

        private void LoadLuongTheoThang(int month, int year, string teacherID)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        LuongID,
                        TeacherID AS [Mã GV],
                        SalaryMonth AS [Tháng],
                        SalaryYear AS [Năm],
                        SoLopDay AS [Số lớp dạy],
                        SoBuoiDay AS [Số buổi dạy],
                        LuongCoBan AS [Lương cơ bản],
                        Thuong AS [Thưởng],
                        Phat AS [Phạt],
                        TongLuong AS [Tổng lương],
                        TrangThai AS [Trạng thái],
                        NgayThanhToan AS [Ngày thanh toán],
                        GhiChu AS [Ghi chú]
                    FROM LuongGV
                    WHERE TeacherID = @teacherID
                    AND SalaryMonth = @month 
                    AND SalaryYear = @year";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@teacherID", teacherID);
                    adapter.SelectCommand.Parameters.AddWithValue("@month", month);
                    adapter.SelectCommand.Parameters.AddWithValue("@year", year);
                    dtLuong = new DataTable();
                    adapter.Fill(dtLuong);
                    dataGridView1.DataSource = dtLuong;
                }
            }
        }

        private void btSetL_Click(object sender, EventArgs e)
        {
            if (cbbMGV.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giảng viên.");
                return;
            }

            string teacherID = cbbMGV.SelectedItem.ToString();
            LoadLuongTheoGV(teacherID);

            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            if (cbbThang.SelectedItem != null && txtNam.Text != "")
            {
                month = Convert.ToInt32(cbbThang.SelectedItem.ToString());
                year = Convert.ToInt32(txtNam.Text);
            }
            else if ((cbbThang.SelectedItem != null || txtNam.Text == "") && (cbbThang.SelectedItem == null || txtNam.Text != ""))
            {
                MessageBox.Show("Hay chon thang va nam");
                return;
            }

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string checkQuery = @"
                SELECT COUNT(*)
                FROM LuongGV
                WHERE TeacherID = @teacherID AND SalaryMonth = @month AND SalaryYear = @year";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@teacherID", teacherID);
                    checkCmd.Parameters.AddWithValue("@month", month);
                    checkCmd.Parameters.AddWithValue("@year", year);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Tháng này đã có bảng lương cho giảng viên.");
                        LoadLuongTheoThang(month, year, teacherID);
                        return;
                    }
                }

                string classCountQuery = @"SELECT COUNT(*) FROM Class WHERE teacherID = @teacherID
                                        AND start_date <= EOMONTH(DATEFROMPARTS(@year, @month, 1))
                                        AND end_date >= DATEFROMPARTS(@year, @month, 1)";
                int soLopDay = 0;

                using (SqlCommand cmd = new SqlCommand(classCountQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherID", teacherID);
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    soLopDay = (int)cmd.ExecuteScalar();
                }

                int soBuoiDay = soLopDay * 8;
                decimal luongCoBan = soBuoiDay * 400000;
                decimal thuong = 0;
                decimal phat = 0;
                decimal tongLuong = luongCoBan + thuong - phat;

                string insertQuery = @"
                INSERT INTO LuongGV
                (TeacherID, SalaryMonth, SalaryYear, SoLopDay, SoBuoiDay, LuongCoBan, Thuong, Phat, TongLuong, TrangThai, NgayThanhToan, GhiChu)
                VALUES
                (@teacherID, @month, @year, @soLopDay, @soBuoiDay, @luongCoBan, @thuong, @phat, @tongLuong, N'Chưa thanh toán', NULL, NULL)";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@teacherID", teacherID);
                    insertCmd.Parameters.AddWithValue("@month", month);
                    insertCmd.Parameters.AddWithValue("@year", year);
                    insertCmd.Parameters.AddWithValue("@soLopDay", soLopDay);
                    insertCmd.Parameters.AddWithValue("@soBuoiDay", soBuoiDay);
                    insertCmd.Parameters.AddWithValue("@luongCoBan", luongCoBan);
                    insertCmd.Parameters.AddWithValue("@thuong", thuong);
                    insertCmd.Parameters.AddWithValue("@phat", phat);
                    insertCmd.Parameters.AddWithValue("@tongLuong", tongLuong);

                    insertCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Đã tính toán lương thành công.");
            LoadLuongTheoGV(teacherID);
        }

        private void btSetL_MouseEnter(object sender, EventArgs e)
        {
            but_chform.bt_MouseEnter(sender, e);
        }

        private void btSetL_MouseLeave(object sender, EventArgs e)
        {
            but_chform.bt_MouseLeave(sender, e);
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            string keyword = cbbMGV.Text;
            int cursorPosition = cbbMGV.SelectionStart;

            cbbMGV.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            LoadDanhSachGiangVien(keyword);

            cbbMGV.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            cbbMGV.Text = keyword;
            cbbMGV.SelectionStart = cursorPosition;

            if (cbbMGV.Items.Count > 0)
            {
                cbbMGV.DroppedDown = true;
                Cursor.Current = Cursors.Default;
            }
            else
            {
                cbbMGV.DroppedDown = false;
            }
        }

        private void CapNhatThuongPhatXuongDB(int luongID, decimal thuong, decimal phat, decimal tongLuong)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                                UPDATE LuongGV 
                                SET Thuong = @thuong, 
                                    Phat = @phat, 
                                    TongLuong = @tongLuong 
                                WHERE LuongID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@thuong", thuong);
                    cmd.Parameters.AddWithValue("@phat", phat);
                    cmd.Parameters.AddWithValue("@tongLuong", tongLuong);
                    cmd.Parameters.AddWithValue("@id", luongID);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi đồng bộ CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Thưởng" || colName == "Phạt")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                decimal luongCB = Convert.ToDecimal(row.Cells["Lương cơ bản"].Value != DBNull.Value ? row.Cells["Lương cơ bản"].Value : 0);
                decimal thuong = Convert.ToDecimal(row.Cells["Thưởng"].Value != DBNull.Value ? row.Cells["Thưởng"].Value : 0);
                decimal phat = Convert.ToDecimal(row.Cells["Phạt"].Value != DBNull.Value ? row.Cells["Phạt"].Value : 0);

                decimal tongLuong = luongCB + thuong - phat;

                row.Cells["Tổng lương"].Value = tongLuong;

                int luongID = Convert.ToInt32(row.Cells["LuongID"].Value);
                CapNhatThuongPhatXuongDB(luongID, thuong, phat, tongLuong);
            }
        }
    }
}