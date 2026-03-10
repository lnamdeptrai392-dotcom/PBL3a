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
            this.Close();
            hocPhi.ShowDialog();
            this.Show();
        }

        private void btT_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Close();
            login.ShowDialog();
            this.Show();
        }

        private void btLGV_Click(object sender, EventArgs e)
        {
            LuongGV luong = new LuongGV();
            this.Close();
            luong.ShowDialog();
            this.Show();
        }

        private void btLN_Click(object sender, EventArgs e)
        {
            LoiNhuan loinhuan = new LoiNhuan();
            this.Close();
            loinhuan.ShowDialog();
            this.Show();
        }
    }
}
