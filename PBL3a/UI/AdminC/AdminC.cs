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

        private void butViewDuyetDon_Click(object sender, EventArgs e)
        {
            quanLyDuyetDon newForm = new quanLyDuyetDon();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void butViewKhoaLop_Click(object sender, EventArgs e)
        {
            quanLyKhoaHoc newForm = new quanLyKhoaHoc();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
