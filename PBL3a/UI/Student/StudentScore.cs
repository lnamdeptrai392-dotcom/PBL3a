using Microsoft.Data.SqlClient;
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
    public partial class StudentScore : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private string currentID = "";
        public StudentScore(string id)
        {
            InitializeComponent();
            this.currentID = id;
            LoadScoreData();
        }
        private void StudentScore_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentID))
            {
                LoadScoreData();
            }
        }
        private void LoadScoreData()
        {
            
            using (SqlConnection con = db.GetConnection())
            {
                try
                {
                    con.Open();
                    //
                    string query = @"select 
                                d.ClassID AS [Mã môn], 
                                cl.class_name AS [Tên lớp học], 
                                d.Diem AS [Điểm học tập], 
                                d.NhanXet AS [Nhận xét]
                            from JoinClass jc
                            inner join Diem d on d.ClassID = jc.classID AND d.AccountID = jc.AccountID
                            inner join Class cl on cl.classID = jc.classID
                            where jc.AccountID = @id";
                    using (SqlDataAdapter a = new SqlDataAdapter(query, con))
                    {
                        a.SelectCommand.Parameters.AddWithValue("id", currentID);
                        DataTable dt = new DataTable();
                        a.Fill(dt);
                        dgvScore.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            //xuat file excel
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            //show du lieu theo ki hoc, nam hoc
        }

        private void cboSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
