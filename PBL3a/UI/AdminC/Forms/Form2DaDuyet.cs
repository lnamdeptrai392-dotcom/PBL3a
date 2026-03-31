using Microsoft.Data.SqlClient;
using PBL3a.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.AdminC.Forms
{
    public partial class Form2DaDuyet : Form
    {
        DatabaseHelper dbHelper = new DatabaseHelper();
        public Form2DaDuyet()
        {
            InitializeComponent();
        }

        private void Form2DaDuyet_Load(object sender, EventArgs e)
        {
            LoadComboBoxKhoa();
        }

        private void LoadComboBoxKhoa()
        {
            DataTable dtKhoa = new DataTable();
            dtKhoa.Columns.Add("courseID");
            dtKhoa.Columns.Add("courseName");

            // Thêm tùy chọn "Tất cả" và danh sách các khóa học
            dtKhoa.Rows.Add("ALL", "Tất cả các khóa");
            dtKhoa.Rows.Add("T01", "Toán (T01)");
            dtKhoa.Rows.Add("V01", "Văn (V01)");
            dtKhoa.Rows.Add("H01", "Hóa (H01)");
            dtKhoa.Rows.Add("L01", "Lý (L01)");
            dtKhoa.Rows.Add("S01", "Sinh (S01)");
            dtKhoa.Rows.Add("NN01", "Tiếng Anh (NN01)");
            dtKhoa.Rows.Add("NN02", "Tiếng Nhật (NN02)");
            dtKhoa.Rows.Add("NN03", "Tiếng Trung (NN03)");

            cbbKhoa.DataSource = dtKhoa;
            cbbKhoa.DisplayMember = "courseName"; // Hiển thị tên cho người dùng xem
            cbbKhoa.ValueMember = "courseID";     // Ẩn cái mã (T01) ở dưới để code lấy
            cbbKhoa.SelectedIndex = 0;
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedValue != null)
            {
                // Lấy mã Khóa vừa chọn (VD: T01)
                string selectedCourse = cbbKhoa.SelectedValue.ToString();
                LoadComboBoxLop(selectedCourse);
            }
        }

        private void LoadComboBoxLop(string courseId)
        {
            string query = "SELECT classID, class_name FROM Class";

            // Nếu người dùng chọn 1 khóa cụ thể (không phải ALL) thì mới lọc lớp
            if (courseId != "ALL")
            {
                query += " WHERE courseID = @courseId";
            }

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (courseId != "ALL")
                        {
                            cmd.Parameters.AddWithValue("@courseId", courseId);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dtLop = new DataTable();
                        adapter.Fill(dtLop);

                        // Thêm 1 dòng "Tất cả các lớp" lên đầu danh sách
                        DataRow row = dtLop.NewRow();
                        row["classID"] = "ALL";
                        row["class_name"] = "Tất cả các lớp";
                        dtLop.Rows.InsertAt(row, 0);

                        cbbLop.DataSource = dtLop;
                        cbbLop.DisplayMember = "class_name";
                        cbbLop.ValueMember = "classID";
                        cbbLop.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedValue == null || cbbLop.SelectedValue == null) return;

            string khoaDuocChon = cbbKhoa.SelectedValue.ToString(); // VD: "T01" hoặc "ALL"
            string lopDuocChon = cbbLop.SelectedValue.ToString();   // VD: "T01.0426" hoặc "ALL"

            string query = @"
                SELECT 
                    jc.AccountID AS [Mã Học Sinh],
                    a.name AS [Tên Học Viên],
                    a.sex AS [Giới Tính],
                    a.dateOfBirth AS [Ngày Sinh],
                    c.classID AS [Mã Lớp],
                    c.class_name AS [Tên Lớp]
                FROM JoinClass jc
                INNER JOIN accountList a ON jc.AccountID = a.Id
                INNER JOIN Class c ON jc.classID = c.classID
                WHERE 1=1 ";

            // Thêm điều kiện lọc Khóa (Dùng courseID của bảng Class hoặc bảng JoinClass đều được)
            if (khoaDuocChon != "ALL")
            {
                query += " AND c.courseID = @courseId ";
            }

            // Thêm điều kiện lọc Lớp
            if (lopDuocChon != "ALL")
            {
                query += " AND c.classID = @classId ";
            }

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (khoaDuocChon != "ALL")
                            cmd.Parameters.AddWithValue("@courseId", khoaDuocChon);

                        if (lopDuocChon != "ALL")
                            cmd.Parameters.AddWithValue("@classId", lopDuocChon);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvData.DataSource = dt;
                        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Xóa lựa chọn mặc định của dòng đầu tiên cho đẹp
                        dgvData.ClearSelection();

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không có học sinh nào khớp với lựa chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy xuất dữ liệu: " + ex.Message);
                }
            }
        }
    }
}
