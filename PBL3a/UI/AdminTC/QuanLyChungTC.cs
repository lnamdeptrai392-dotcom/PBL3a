using PBL3a.UI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class QuanLyChungTC : Form
    {
        public QuanLyChungTC()
        {
            InitializeComponent();
        }

        private void QuanLyChung_Load(object sender, EventArgs e)
        {

        }

        private void btHP_Click(object sender, EventArgs e)
        {
            HocPhi hocPhi = new HocPhi();
            this.Hide();
            hocPhi.ShowDialog();
            this.Show();
        }

        private void btT_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void btLGV_Click(object sender, EventArgs e)
        {
            LuongGV luong = new LuongGV();
            this.Hide();
            luong.ShowDialog();
            this.Show();
        }

        private void btLN_Click(object sender, EventArgs e)
        {
            LoiNhuan loinhuan = new LoiNhuan();
            this.Hide();
            loinhuan.ShowDialog();
            this.Show();
        }
    }
}
