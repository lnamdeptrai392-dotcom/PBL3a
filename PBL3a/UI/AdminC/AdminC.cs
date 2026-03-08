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

        private void buttonAdminC1_Click(object sender, EventArgs e)
        {
            quanLyDuyetDon formMoi = new quanLyDuyetDon();
            this.Hide();
            formMoi.ShowDialog();
            this.Show();

        }

        private void buttonAdminC2_Click(object sender, EventArgs e)
        {
            quanLyKhoaHoc formMoi = new quanLyKhoaHoc();
            this.Hide();
            formMoi.ShowDialog();
            this.Show();
        }
    }
}
