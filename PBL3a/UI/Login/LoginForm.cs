using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using PBL3a.services;

namespace PBL3a.UI.Login
{
    public partial class LoginForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Role FROM accountList WHERE username = @u AND Password = @p";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["Role"].ToString();
                        MessageBox.Show("Đăng nhập thành công. Role: " + role);

                        reader.Close();
                        OpenFormByRole(role);
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối SQL: " + ex.Message);
                }
            }
        }

        private void OpenFormByRole(string role)
        {
            Form nextForm = null;

            if (role == "AdminC")
            {
                nextForm = new PBL3a.UI.AdminC.AdminC();
            }
            else if (role == "AdminDD")
            {
                nextForm = new PBL3a.UI.AdminDD.Form1();
            }
            else if (role == "AdminTC")
            {
                nextForm = new PBL3a.UI.AdminTC.QuanLyChung();
            }
            else
            {
                MessageBox.Show("Role không hợp lệ hoặc chưa có màn hình tương ứng");
                return;
            }

            nextForm.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}