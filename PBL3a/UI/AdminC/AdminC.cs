using PBL3a.UI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.AdminC
{
    public partial class AdminC : Form
    {
        private Form activeForm;
        private Color defaultColor = Color.FromArgb(112, 146, 190);
        private Color activeColor = Color.FromArgb(70, 130, 180);

        public AdminC()
        {
            InitializeComponent();
        }

        private void SetActiveMenu(Button clickedButton)
        {
            // 1. Trả toàn bộ các nút menu về màu mặc định
            btnDuyetDon.BackColor = defaultColor;
            btnKhoaLop.BackColor = defaultColor;
            btnTaoTK.BackColor = defaultColor;
            btnTaoLH.BackColor = defaultColor;

            // 2. Đổi màu đậm cho riêng nút đang được click
            clickedButton.BackColor = activeColor;
        }

        private void openChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDuyetDon_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnDuyetDon);
            openChildForm(new Forms.Form1(), sender);

        }

        private void btnKhoaLop_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnKhoaLop);
            openChildForm(new Forms.Form4(), sender);

        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnTaoTK);
            openChildForm(new Forms.Form5(), sender);

        }

        private void btnTaoLH_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnTaoLH);
            openChildForm(new Forms.Form2(), sender);
        }

        private void butOut_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();
            this.Hide();
            newForm.ShowDialog();
            this.Close();

        }
    }
}
