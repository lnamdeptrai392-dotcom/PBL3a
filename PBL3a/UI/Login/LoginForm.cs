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

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu");
                return;
            }

            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Role FROM accountList WHERE Username = @u AND Password = @p";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
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
                nextForm = new PBL3a.UI.AdminTC.QuanLyChungTC();
            }
            else if (role == "Student")
            {
                nextForm = new PBL3a.UI.Student.StudentAll();
            }
            else if (role == "Teacher")
            {
                nextForm = new PBL3a.UI.Teacher.QuanLyChungT();
            }
            else
            {
                MessageBox.Show("Role không hợp lệ hoặc chưa có màn hình tương ứng");
                return;
            }

            this.Hide();              // Ẩn form login
            nextForm.ShowDialog();    // Mở form mới theo kiểu modal
            this.Close();             // Khi form kia đóng thì login cũng đóng luôn
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}