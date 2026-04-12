using Microsoft.Data.SqlClient;
using PBL3;
using PBL3a.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBL3a.UI.AdminTC
{
    public partial class ThietLapHP : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        public ThietLapHP()
        {
            InitializeComponent();
        }

        public void setGUI()
        {
            cbbMaLop.Items.Clear();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT classID FROM Class ORDER BY classID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbbMaLop.Items.Add(reader["classID"].ToString());
                    }
                }
            }
            if (cbbMaLop.Items.Count > 0)
                cbbMaLop.SelectedIndex = -1;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"update HocPhi set SoTien = @tienTrenNg where ClassID = @id and TrangThai = 'Chưa đóng'";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tienTrenNg", Convert.ToDecimal(txtTienTrenNg.Text));
                    cmd.Parameters.AddWithValue("@id",cbbMaLop.Text);
                }
            } 
                
            this.Close();
        }

        private void btLuu_MouseEnter(object sender, EventArgs e)
        {
            but_chform.bt_MouseEnter(sender, e);
        }

        private void btLuu_MouseLeave(object sender, EventArgs e)
        {
            but_chform.bt_MouseLeave(sender, e);
        }

        private void LoadTenLop(string classID)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT class_name FROM Class WHERE classID = @classID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@classID", classID);
                    object result = cmd.ExecuteScalar();
                    tbTL.Text = result != null ? result.ToString() : "";
                }
            }
        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaLop.SelectedItem == null) return;
            else
            {
                string classID = cbbMaLop.SelectedItem.ToString();
                LoadTenLop(classID);
            }
        }

        public int capapcity_cl(string idlop)
        {
            int cap;
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"select capacity from Class where classID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idlop);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        cap = Convert.ToInt32(result);
                    }
                    else { cap = 0; }
                }
            }
            return cap;
        }

        public decimal SetHP(decimal hphi)
        {
            string idlop = cbbMaLop.SelectedItem.ToString();
            int cap = capapcity_cl(idlop);
            txtSS.Text = cap.ToString();
            return cap * hphi;
        }

        private void butTT_Click(object sender, EventArgs e)
        {
            decimal hphi1 = Convert.ToDecimal(txtTienTrenNg.Text.ToString());
            if (hphi1 < 0) { MessageBox.Show("So tien khong hop le!!"); }
            else
            {
                decimal tongTien = SetHP(hphi1);
                txtTongT.Text = tongTien.ToString();
            }
        }
    }
}