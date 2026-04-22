using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PBL3a.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.Student
{
    public partial class StudentFee : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private readonly string currentID = "";

        public StudentFee(string id)
        {
            InitializeComponent();
            this.currentID = id;
            //dang ky su kien cho studentFeeLoad
            LoadHocPhiHocSinh();
        }

        private void LoadHocPhiHocSinh()
        {
            using (SqlConnection con = db.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = @"SELECT ClassID AS [Mã lớp học],
                                    TuitionMonth AS [Tháng học], 
                                    TuitionYear AS [Năm học], 
                                    SoTien AS [Số tiền], 
                                    TrangThai AS [Trạng thái], 
                                    NgayDong AS [Ngày đóng], 
                                    GhiChu  AS [Ghi chú]
                                    FROM HocPhi WHERE AccountID = @id";
                    using (SqlDataAdapter a = new SqlDataAdapter(query, con))
                    {
                        // Add the parameter with value
                        a.SelectCommand.Parameters.AddWithValue("id", currentID);
                        DataTable dt = new DataTable();
                        a.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void StudentFee_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentID))
            {
                LoadHocPhiHocSinh();
            }
        }
    }
}
