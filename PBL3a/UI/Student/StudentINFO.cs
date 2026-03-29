using Microsoft.Data.SqlClient;
using PBL3a.services;
using System;
using System.Windows.Forms;

namespace PBL3a.UI.Student
{
    public partial class StudentINFO : Form
    {

        DatabaseHelper db = new DatabaseHelper();
        private string currentID = "";

        public StudentINFO()
        {
            InitializeComponent();
        }


        public StudentINFO(string id)
        {
            InitializeComponent();
            this.currentID = id;

            LoadThongTinHocSinh();
        }

        private void StudentINFO_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(currentID))
            {
                LoadThongTinHocSinh();
            }
        }

        private void LoadThongTinHocSinh()
        {
            using (SqlConnection con = db.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT name, dateOfBirth, sex, phone FROM accountList WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", currentID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtHoTen.Text = reader["name"].ToString();
                        dtpNgaySinh.Value = reader["dateOfBirth"] != DBNull.Value ? Convert.ToDateTime(reader["dateOfBirth"]) : DateTime.Now;
                        cboGioiTinh.Text = reader["sex"].ToString();
                        txtSDT.Text = reader["phone"].ToString();

                        txtEmail.Text = "Chua cap nhat";
                        txtDiaChi.Text = "Chua cap nhat";
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when loading information: " + ex.Message);
                }
            }
        }


        //private void btn_back_Click(object sender, EventArgs e)
        //{

        //    StudentAll? parent = this.ParentForm as StudentAll;
        //    if (parent != null && parent.tableLayoutPanel1 != null)
        //    {
        //        parent.tableLayoutPanel1.Visible = true; 
        //        this.Close(); 
        //    }
        //}
        private void btn_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE accountList 
                                     SET name = @name, dateOfBirth = @dob, sex = @sex, phone = @phone 
                                     WHERE Id = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@dob", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@sex", cboGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@phone", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@id", currentID);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message);
                }
            }
        }
    }
}