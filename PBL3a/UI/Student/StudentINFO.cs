using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.Student
{
    public partial class StudentINFO : Form
    {
        public StudentINFO()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StudentAll student = new StudentAll();
            student.Show();
            this.Close();
        }
    }
}
