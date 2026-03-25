using PBL3a.UI.Login;
using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace PBL3a.UI.Student
{
    public partial class StudentAll : Form
    {
        // Biến lưu Form đang hiển thị
        private Form? activeForm = null;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string StudentID { get; set; } = "";

        // Constructor cho Designer
        public StudentAll()
        {
            InitializeComponent();
        }

        // Constructor nhận ID từ Login
        public StudentAll(string id)
        {
            InitializeComponent();
            this.StudentID = id;
            tableLayoutPanel1.BringToFront();
        }

        // Hàm dùng chung để mở Form con vào panel_content
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Ẩn menu 6 ô vuông (tableLayoutPanel1)
            if (tableLayoutPanel1 != null) tableLayoutPanel1.Visible = false;

            // Thêm form con vào panel_content
            panel_content.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        // --- SỰ KIỆN CÁC NÚT ---

        private void btn_info_Click(object sender, EventArgs e)
        {
            // Truyền this.StudentID vào để Form con biết load dữ liệu của ai
            openChildForm(new StudentINFO(this.StudentID));
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            // Nếu StudentScore cũng cần ID, hãy truyền vào tương tự StudentINFO
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
                // Đóng form hiện tại và hiện lại Login
                this.Hide();
                LoginForm f = new LoginForm();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}