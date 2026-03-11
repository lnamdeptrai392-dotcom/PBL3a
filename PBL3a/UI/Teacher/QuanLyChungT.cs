using PBL3a.UI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.Teacher
{
    public partial class QuanLyChungT : Form
    {
        public QuanLyChungT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TTCN nextForm = new TTCN();
            this.Close();
            nextForm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TKB tKB = new TKB();
            this.Close();
            tKB.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NhapDiem nhapDiem = new NhapDiem();
            this.Close();
            nhapDiem.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TaiLieu tl = new TaiLieu();
            this.Close();
            tl.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong();
            this.Close();
            luong.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
