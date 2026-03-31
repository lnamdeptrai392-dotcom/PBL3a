using Microsoft.Data.SqlClient;
using PBL3a.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.Teacher
{
    public partial class Luong : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        public Luong()
        {
            InitializeComponent();
            Load += Luong_Load;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Luong_Load(object sender, EventArgs e)
        {
            //  Lấy Username từ Form Login
            Form loginForm = Application.OpenForms["LoginForm"];
            if (loginForm == null)
            {
                MessageBox.Show("Không tìm thấy phiên đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Control[] txtUsers = loginForm.Controls.Find("txtUsername", true);
            string currentUsername = txtUsers.Length > 0 ? txtUsers[0].Text : "";

            if (string.IsNullOrEmpty(currentUsername)) return;

            string query = @"
                 SELECT l.SalaryMonth, l.SalaryYear, l.SoLopDay, l.SoBuoiDay, l.LuongCoBan, l.Thuong, l.TongLuong, l.TrangThai, l.NgayThanhToan, l.GhiChu
                 FROM LuongGV l INNER JOIN accountList a ON l.TeacherID = a.Id
                 WHERE a.username = @Username";
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Truyền tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@Username", currentUsername);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
