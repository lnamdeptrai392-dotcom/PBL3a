using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.AdminC
{
    public partial class AdminC : Form
    {
        public AdminC()
        {
            InitializeComponent();
        }

        private void btnOkDuyetDon_Click(object sender, EventArgs e)
        {
            if (rdoViewDuyetDon.Checked == true)
            {
                quanLyDuyetDon newForm = new quanLyDuyetDon();
                this.Hide();
                newForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng click chọn 'View' trước khi nhấn OK!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOkKhoaHoc_Click(object sender, EventArgs e)
        {
            if (rdoViewKhoaHoc.Checked == true)
            {
                quanLyKhoaHoc newForm = new quanLyKhoaHoc();
                this.Hide();
                newForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng click chọn 'View' trước khi nhấn OK!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
