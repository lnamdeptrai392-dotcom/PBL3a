using Microsoft.Data.SqlClient;
using PBL3;
using PBL3a.services;
using PBL3a.services.BLL;
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
        private AdminTC_Service admin_sv = new AdminTC_Service();
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
            LoadTenLop(MaLop);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtTienTrenNg.Text, out decimal tienTrenNg))
            {
                MessageBox.Show("Số tiền không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTienTrenNg.Focus(); 
                return;
            }

            if (tienTrenNg < 0)
            {
                MessageBox.Show("Số tiền không được là số âm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int rowsAffected = admin_sv.UpdateTuition(MaLop, tienTrenNg);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật học phí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu nào được cập nhật. Vui lòng kiểm tra lại trạng thái lớp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            tbTL.Text =  admin_sv.GetClassNameByID(classID);
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
            return admin_sv.getUnpaidCapacity(idlop);
        }

        public decimal SetHP(decimal hphi)
        {
            int cap = capapcity_cl(MaLop);
            txtSS.Text = cap.ToString();
            return cap * hphi;
        }

        private void butTT_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTienTrenNg.Text, out decimal hphi1))
            {
                if (hphi1 < 0)
                {
                    MessageBox.Show("Số tiền không hợp lệ!!");
                }
                else
                {
                    decimal tongTien = SetHP(hphi1);
                    txtTongT.Text = tongTien.ToString("N0") + "VND"; 
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một con số hợp lệ cho học phí!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}