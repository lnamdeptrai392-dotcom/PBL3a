using PBL3a.UI.Login;

namespace PBL3a.UI.Student
{
    public partial class StudentAll : Form
    {
        public StudentAll()
        {
            InitializeComponent();
        }
        // //
        private void StudentAll_Load(object sender, EventArgs e)
        {

        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            StudentSchedule schedule = new StudentSchedule();
            this.Hide();
            schedule.ShowDialog();
            this.Show();
        }

  

        private void btn_info_Click(object sender, EventArgs e)
        {
            StudentINFO info = new StudentINFO();
            this.Hide();
            info.ShowDialog();
            this.Show();
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            StudentScore score = new StudentScore();
            this.Hide();
            score.ShowDialog();
            this.Show();
        }

        private void btn_fee_Click(object sender, EventArgs e)
        {
            StudentFee fee = new StudentFee();
            this.Hide();
            fee.ShowDialog();
            this.Show();
        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            StudentMaterial material = new StudentMaterial();
            this.Hide();
            material.ShowDialog();
            this.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }
    }
}
