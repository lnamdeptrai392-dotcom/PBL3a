using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            this.AcceptButton = btnLogin;
            this.DoubleBuffered = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

            
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
                    string query = "SELECT Id, Role FROM accountList WHERE Username = @u AND Password = @p";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["Role"]?.ToString() ?? "";
                                string userId = reader["Id"]?.ToString() ?? "";

                                

                                reader.Close();
                                OpenFormByRole(role, userId);
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
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }

        private void OpenFormByRole(string role, string userId)
{
    Form nextForm = null;

    if (role == "AdminC")
        nextForm = new PBL3a.UI.AdminC.AdminC();
    else if (role == "AdminDD")
        nextForm = new PBL3a.UI.AdminDD.Form1();
    else if (role == "AdminTC")
        nextForm = new PBL3a.UI.AdminTC.QuanLyChungTC();
    else if (role == "Student")
        nextForm = new PBL3a.UI.Student.StudentAll(userId);
    else if (role == "Teacher")
        nextForm = new PBL3a.UI.Teacher.QuanLyChungT(userId); // sửa chỗ này
    else
    {
        MessageBox.Show("Role không hợp lệ");
        return;
    }

    this.Hide();
    nextForm.ShowDialog();
    this.Close();
}

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

      

        private void SetRounded(Control c, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(c.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(c.Width - radius, c.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, c.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            c.Region = new Region(path);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblForgot_Click(object sender, EventArgs e)
        {

        }
    }
}