using PBL3a.UI.Login;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3a.UI.Teacher
{
    public partial class QuanLyChungT : Form
    {
        private string currentTeacherID;
        private Form currentChildForm;
        private Button currentButton;

        public QuanLyChungT(string teacherId)
        {
            InitializeComponent();
            currentTeacherID = teacherId;

            ActivateButton(btnInfo);
            OpenChildForm(new TTCN(currentTeacherID));
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                Button btn = (Button)senderBtn;
                if (currentButton == btn) return;

                currentButton = btn;
            }
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TTCN(currentTeacherID));
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TKB(currentTeacherID));
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhapDiem());
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Luong(currentTeacherID));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}