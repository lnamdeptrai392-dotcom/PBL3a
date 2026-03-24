using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.Student
{
    public partial class StudentFee : Form
    {
        public StudentFee()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======

        private void btn_back_Click(object sender, EventArgs e)
        {
            StudentAll? parent = this.ParentForm as StudentAll;

            // CS8602: Kiểm tra null trước khi truy cập vào tableLayoutPanel1
            if (parent != null && parent.tableLayoutPanel1 != null)
            {
                parent.tableLayoutPanel1.Visible = true;
                this.Close();
            }

        }
>>>>>>> Stashed changes
    }
}
