using Microsoft.Data.SqlClient;
using PBL3a.services;
using System;
using System.Windows.Forms;

namespace PBL3a.UI.Teacher
{
    public partial class TTCN : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private string currentTeacherID;

        public TTCN(string teacherId)
        {
            InitializeComponent();
            currentTeacherID = teacherId;
            this.Load += TTCN_Load;
        }

        private void TTCN_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentTeacherID))
            {
                MessageBox.Show("Không tìm thấy mã giảng viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"
                SELECT 
                    a.Id, a.name, a.sex, a.dateOfBirth, a.phone, t.subject
                FROM accountList a
                INNER JOIN teacherInfo t ON a.Id = t.Id
                WHERE a.Id = @TeacherID AND a.Role = 'Teacher'";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TeacherID", currentTeacherID);

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

                                tbMGV.ReadOnly = true;
                                tbMD.ReadOnly = true;
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin giảng viên trong hệ thống.",
                                    "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = db.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = @"Update accountList
                                SET name = @name, dateOfBirth = @dob, sex = @sex, phone =@phone
                                WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", tbHVT.Text);
                    cmd.Parameters.AddWithValue("@dob", dtNS.Value);
                    cmd.Parameters.AddWithValue("@sex", cbbGT.Text);
                    cmd.Parameters.AddWithValue("@phone", tbSDT.Text);
                    cmd.Parameters.AddWithValue("@id", currentTeacherID);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cap nhat thong tin thanh cong");

                    }
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Loi cap nhat: " + ex.Message);
                }
            }
        }
    }
}