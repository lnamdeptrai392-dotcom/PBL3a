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

            ActivateButton(button1);
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

                if (currentButton != null)
                {
                    currentButton.BackColor = Color.FromArgb(44, 78, 98);
                    currentButton.ForeColor = Color.White;
                }

                currentButton = btn;
                currentButton.BackColor = Color.FromArgb(144, 188, 245);
                currentButton.ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new TTCN(currentTeacherID));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new TKB(currentTeacherID));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new NhapDiem());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new TaiLieu());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Luong(currentTeacherID));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}