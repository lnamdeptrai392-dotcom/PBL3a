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
    public partial class TTCN : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        public TTCN()
        {
            InitializeComponent();
            this.Load += TTCN_Load;
        }

        private void TTCN_Load(object sender, EventArgs e)
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
                SELECT 
                    a.Id, a.name, a.sex, a.dateOfBirth, a.phone, t.subject
                FROM accountList a
                INNER JOIN Teacher t ON a.Id = t.Id
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
                            if (reader.Read())
                            {
                                tbHVT.Text = reader["name"] != DBNull.Value ? reader["name"].ToString() : "";
                                tbMGV.Text = reader["Id"].ToString();
                                tbMD.Text = reader["subject"] != DBNull.Value ? reader["subject"].ToString() : "";
                                tbSDT.Text = reader["phone"] != DBNull.Value ? reader["phone"].ToString() : "";

                                cbbGT.Text = reader["sex"] != DBNull.Value ? reader["sex"].ToString() : "";
                                if (reader["dateOfBirth"] != DBNull.Value)
                                {
                                    dtNS.Value = Convert.ToDateTime(reader["dateOfBirth"]);
                                }
                                tbE.Text = "Chưa có dữ liệu";

                                // Đặt các TextBox thành ReadOnly
                                tbMGV.ReadOnly = true;
                                tbMD.ReadOnly = true;
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin giảng viên trong hệ thống.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin cá nhân: " + ex.Message);
            }
        }

        private void btT_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
