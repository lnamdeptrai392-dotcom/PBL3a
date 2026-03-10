using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class HocPhi : Form
    {
        public HocPhi()
        {
            InitializeComponent();
        }

        private void btSetHP_Click(object sender, EventArgs e)
        {
            ThietLapHP thlap = new ThietLapHP();
            this.Hide();
            thlap.ShowDialog();
            this.Show();
        }

        private void btT_Click(object sender, EventArgs e)
        {
            QuanLyChungTC mainTC = new QuanLyChungTC();
            this.Hide();
            mainTC.ShowDialog();
            this.Show();
        }
    }
}
