using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class KhoanChi : Form
    {
        public KhoanChi()
        {
            InitializeComponent();
        }

        private void btT_Click(object sender, EventArgs e)
        {
            LoiNhuan loinhuan = new LoiNhuan();
            this.Hide();
            loinhuan.ShowDialog();
            this.Show();
        }
    }
}
