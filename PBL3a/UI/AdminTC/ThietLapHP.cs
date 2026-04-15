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
        private string MaLop;
        public ThietLapHP(string m)
        {
            InitializeComponent();
            MaLop = m;
            setGUI();
        }

        public void setGUI()
        {
            cbbMaLop.Text = MaLop;
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"select class_name from Class where classID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", MaLop);
                    object result = cmd.ExecuteScalar();
                    string tenlop = result.ToString();
                    tbTL.Text = tenlop;
                }
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"update HocPhi set SoTien = @tienTrenNg where ClassID = @id and TrangThai = N'Chưa đóng'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tienTrenNg", Convert.ToDecimal(txtTienTrenNg.Text));
                    cmd.Parameters.AddWithValue("@id", MaLop);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật học phí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu nào được cập nhật. Vui lòng kiểm tra lại trạng thái lớp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
                string selectedClassID = cbbMaLop.SelectedItem.ToString();
                MaLop = selectedClassID;
                LoadTenLop(MaLop);
            }
        }

        public int capapcity_cl(string idlop)
        {
            int cap = 0;
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT COUNT(AccountID) FROM HocPhi WHERE ClassID = @id AND TrangThai = N'Chưa đóng'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idlop);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        cap = Convert.ToInt32(result);
                    }
                }
            }
            return cap;
        }

        public decimal SetHP(decimal hphi)
        {
            int cap = capapcity_cl(MaLop);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}