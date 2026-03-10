using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.Teacher
{
    public partial class Luong : Form
    {
        public Luong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyChungT quanly = new QuanLyChungT();
            this.Close();
            quanly.ShowDialog();
            this.Show();
        }
    }
}
