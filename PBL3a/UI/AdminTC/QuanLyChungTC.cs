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

        private void btHP_Click(object sender, EventArgs e)
        {
            but_chform.ActivateButton(sender);
            HocPhi hocphi = new HocPhi();
            but_chform.OpenChildForm(hocphi, sender, paDesktop);
        }

        // Lương giáo viên
        private void btLGV_Click(object sender, EventArgs e)
        {
            but_chform.ActivateButton(sender);
            LuongGV luong = new LuongGV();
            but_chform.OpenChildForm(luong, sender, paDesktop);
        }

        // Lợi nhuận
        private void btLN_Click(object sender, EventArgs e)
        {
            but_chform.ActivateButton(sender);
            LoiNhuan loinhuan = new LoiNhuan();
            but_chform.OpenChildForm(loinhuan, sender, paDesktop);
        }


        // Đăng xuất
        private void btDX_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
