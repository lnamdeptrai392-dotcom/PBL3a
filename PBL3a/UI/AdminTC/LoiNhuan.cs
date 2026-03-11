using Microsoft.IdentityModel.Tokens;
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
        private void Loinhuan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Lai lai = new Lai();
            this.Hide();
            lai.ShowDialog();
            this.Show();
        }
    }
}
