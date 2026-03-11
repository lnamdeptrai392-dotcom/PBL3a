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
            this.Close();
        }

        private void btThu_Click(object sender, EventArgs e)
        {
            KhoanThu thu = new KhoanThu();
            this.Hide();
            thu.ShowDialog();
            this.Show();
        }

        private void btChi_Click(object sender, EventArgs e)
        {
            KhoanChi chi = new KhoanChi();
            this.Hide();
            chi.ShowDialog();
            this.Show();
        }

        private void btLN_Click(object sender, EventArgs e)
        {
            Lai lai = new Lai();
            this.Hide();
            lai.ShowDialog();
            this.Show();
        }
    }
}