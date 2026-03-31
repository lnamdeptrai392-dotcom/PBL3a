using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.Student
{
    public partial class StudentMaterial : Form
    {
        public StudentMaterial()
        {
            InitializeComponent();
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAll student = new StudentAll();

            student.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
