using Microsoft.Data.SqlClient;
using PBL3a.services;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3a.UI.Teacher
{
    public partial class Luong : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private string currentTeacherID;

        public Luong(string teacherId)
        {
            InitializeComponent();
            currentTeacherID = teacherId;
            this.Load += Luong_Load;
        }

        private void Luong_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentTeacherID))
            {
                MessageBox.Show("Không tìm thấy mã giảng viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadSalaryData();
        }

        private void LoadSalaryData()
        {
            string query = @"
                SELECT 
                    SalaryMonth AS [Tháng],
                    SalaryYear AS [Năm],
                    SoLopDay AS [Số lớp dạy],
                    SoBuoiDay AS [Số buổi dạy],
                    LuongCoBan AS [Lương cơ bản],
                    Thuong AS [Thưởng],
                    TongLuong AS [Tổng lương],
                    TrangThai AS [Trạng thái],
                    NgayThanhToan AS [Ngày thanh toán],
                    GhiChu AS [Ghi chú]
                FROM LuongGV
                WHERE TeacherID = @TeacherID
                ORDER BY SalaryYear DESC, SalaryMonth DESC";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TeacherID", currentTeacherID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                dataGridView1.DataSource = null;
                                MessageBox.Show("Giảng viên này chưa có dữ liệu lương.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            dataGridView1.DataSource = dt;
                            FormatDataGridView();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu lương: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;

            if (dataGridView1.Columns["Lương cơ bản"] != null)
                dataGridView1.Columns["Lương cơ bản"].DefaultCellStyle.Format = "N0";

            if (dataGridView1.Columns["Thưởng"] != null)
                dataGridView1.Columns["Thưởng"].DefaultCellStyle.Format = "N0";

            if (dataGridView1.Columns["Tổng lương"] != null)
                dataGridView1.Columns["Tổng lương"].DefaultCellStyle.Format = "N0";

            if (dataGridView1.Columns["Ngày thanh toán"] != null)
                dataGridView1.Columns["Ngày thanh toán"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}