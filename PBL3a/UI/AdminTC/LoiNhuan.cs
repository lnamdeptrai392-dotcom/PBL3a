using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class LoiNhuan : Form
    {
        public LoiNhuan()
        {
            InitializeComponent();
        }

        private void btT_Click(object sender, EventArgs e)
        {
            QuanLyChungTC mainTC = new QuanLyChungTC();
            this.Close();
            mainTC.ShowDialog();
            this.Show();
        }

        private void btThu_Click(object sender, EventArgs e)
        {
            KhoanThu thu = new KhoanThu();
            this.Close();
            thu.ShowDialog();
            this.Show();
        }

        private void btChi_Click(object sender, EventArgs e)
        {
            KhoanChi chi = new KhoanChi();
            this.Close();
            chi.ShowDialog();
            this.Show();
        }
    }
}
