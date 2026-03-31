using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3a.services;

namespace PBL3a.UI.AdminC.Forms
{
    public partial class Form4KhoaLop : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public Form4KhoaLop()
        {
            InitializeComponent();
        }

        private void Form4KhoaLop_Load(object sender, EventArgs e)
        {
            LoadComboBoxKhoa();
        }
        private void LoadComboBoxKhoa()
        {
            string query = "SELECT DISTINCT courseID FROM Class";
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // QUAN TRỌNG: Gán Member trước DataSource
                    cbbKhoa.DisplayMember = "courseID";
                    cbbKhoa.ValueMember = "courseID";
                    cbbKhoa.DataSource = dt;

                    cbbKhoa.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách Khóa: " + ex.Message);
                }
            }
        }
        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bỏ qua nếu chưa chọn item nào hoặc giá trị null
            if (cbbKhoa.SelectedIndex == -1 || cbbKhoa.SelectedValue == null)
                return;

            string selectedCourse = "";

            // Xử lý an toàn: Lấy chuỗi mã Khóa (Dù WinForms trả về kiểu gì)
            if (cbbKhoa.SelectedValue is DataRowView drv)
            {
                selectedCourse = drv["courseID"].ToString();
            }
            else
            {
                selectedCourse = cbbKhoa.SelectedValue.ToString();
            }

            // Gọi hàm load Lớp bằng mã Khóa vừa lấy được
            LoadComboBoxLop(selectedCourse);
        }
        private void LoadComboBoxLop(string courseID)
        {
            string query = "SELECT classID, class_name FROM Class WHERE courseID = @courseID";
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@courseID", courseID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbbLop.DataSource = dt;
                    cbbLop.DisplayMember = "class_name"; // Hiển thị tên lớp (Lớp Toán 10A1...)
                    cbbLop.ValueMember = "classID";      // Lấy mã lớp (T01.0426...)
                    cbbLop.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách Lớp: " + ex.Message);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cbbLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một lớp để xem thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedClassID = cbbLop.SelectedValue.ToString();

            // Câu truy vấn kết hợp (JOIN) để lấy thông tin học sinh trong lớp được chọn
            string query = @"
                SELECT 
                    a.Id AS [Mã HV], 
                    a.name AS [Họ và Tên], 
                    a.dateOfBirth AS [Ngày Sinh], 
                    a.sex AS [Giới Tính], 
                    a.phone AS [Số Điện Thoại]
                FROM accountList a
                INNER JOIN JoinClass j ON a.Id = j.AccountID
                WHERE j.classID = @classID AND a.Role = 'Student'";

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@classID", selectedClassID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Đổ dữ liệu vào DataGridView
                    dgvData.DataSource = dt;

                    // Chỉnh UI DataGridView cho đẹp (Tùy chọn)
                    dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvData.AllowUserToAddRows = false; // Ẩn dòng trống dưới cùng
                    dgvData.ReadOnly = true;            // Chỉ xem, không cho sửa trực tiếp trên lưới
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu lớp: " + ex.Message);
                }
            }
        }
    }
}
