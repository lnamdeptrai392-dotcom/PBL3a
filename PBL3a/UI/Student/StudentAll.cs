using PBL3a.UI.AdminTC;
using PBL3a.UI.Login;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3a.UI.Student
{
    public partial class StudentAll : Form
    {
        
        private Form? activeForm = null;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string StudentID { get; set; } = "";


        public StudentAll(string id)
        {
            InitializeComponent();
            this.StudentID = id;
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildBox.Controls.Add(childForm);
            this.panelChildBox.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_info_Click_1(object sender, EventArgs e)
        {

            openChildForm(new StudentINFO(StudentID), sender);
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentScore(StudentID), sender);
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentSchedule(StudentID), sender);
        }

        private void btn_fee_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentFee(StudentID), sender);
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Hide();
                LoginForm f = new LoginForm();
                f.ShowDialog();
                this.Close();
            }
        }

        
    }
}