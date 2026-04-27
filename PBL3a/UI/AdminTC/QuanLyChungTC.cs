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

        private void btnFee_Click(object sender, EventArgs e)
        {
            HocPhi hocphi = new HocPhi();
            but_chform.OpenChildForm(hocphi, sender, paDesktop);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            LuongGV luong = new LuongGV();
            but_chform.OpenChildForm(luong, sender, paDesktop);
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            but_chform.ActivateButton(sender);
            Lai lai = new Lai();
            but_chform.OpenChildForm(lai, sender, paDesktop);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void btKT_Click(object sender, EventArgs e)
        {
            but_chform.ActivateButton(sender);
            KhoanThu khoanThu = new KhoanThu();
            but_chform.OpenChildForm(khoanThu, sender, paDesktop);
        }

        private void btKC_Click(object sender, EventArgs e)
        {
            but_chform.ActivateButton(sender);
            KhoanChi khoanChi = new KhoanChi();
            but_chform.OpenChildForm(khoanChi, sender, paDesktop);
        }
    }
}
