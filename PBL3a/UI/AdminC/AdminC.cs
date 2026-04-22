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
        

        public AdminC()
        {
            InitializeComponent();
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
            
            openChildForm(new Forms.Form1DuyetDon(), sender);

        }

        private void btnDaDuyet_Click(object sender, EventArgs e)
        {
            
            openChildForm(new Forms.Form2DaDuyet(), sender);

        }

        

        private void btnKhoaLop_Click(object sender, EventArgs e)
        {
           
            openChildForm(new Forms.Form4KhoaLop(), sender);

        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            
            openChildForm(new Forms.Form5TaoTK(), sender);

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
