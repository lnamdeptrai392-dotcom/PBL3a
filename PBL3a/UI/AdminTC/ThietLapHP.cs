using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class ThietLapHP : Form
    {
        public ThietLapHP()
        {
            InitializeComponent();
        }

        private void btT_Click(object sender, EventArgs e)
        {
            HocPhi hocPhi = new HocPhi();
            this.Close();
            hocPhi.ShowDialog();
            this.Show();
        }
    }
}
