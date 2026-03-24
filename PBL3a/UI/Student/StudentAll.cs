<<<<<<< Updated upstream
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
=======
﻿using PBL3a.UI.Login;
using System;
using System.Windows.Forms;
using System.ComponentModel;
>>>>>>> Stashed changes

namespace PBL3a.UI.Student
{
    public partial class StudentAll : Form
    {
        
        private Form? activeForm = null;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string StudentID { get; set; } = "";
        public StudentAll()
        {
            InitializeComponent();

        }
<<<<<<< Updated upstream

        private void StudentAll_Load(object sender, EventArgs e)
=======
        public StudentAll(string id)
>>>>>>> Stashed changes
        {
            InitializeComponent();
            this.StudentID = id;
        }
<<<<<<< Updated upstream

        private void button3_Click(object sender, EventArgs e)
        {
=======
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
>>>>>>> Stashed changes

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // 1. Ẩn menu đi
            tableLayoutPanel1.Visible = false;

            // 2. Thêm form con vào chính cái panel đang chứa cái table
            panel_content.Controls.Add(childForm);

            // 3. Đưa lên trên cùng để đảm bảo không bị cái gì che
            childForm.BringToFront();
            childForm.Show();
        }

<<<<<<< Updated upstream
        private void button6_Click(object sender, EventArgs e)
        {

=======
        // --- SỰ KIỆN CÁC NÚT ---
        
        private void btn_info_Click(object sender, EventArgs e)
        {
            
            openChildForm(new StudentINFO(this.StudentID));
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentScore());
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentSchedule());
        }

        private void btn_fee_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentFee());
        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentMaterial());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                LoginForm f = new LoginForm();
                f.Show();
                this.Close();
            }
>>>>>>> Stashed changes
        }

        
    }
}