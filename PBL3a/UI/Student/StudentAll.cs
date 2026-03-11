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
            
            schedule.ShowDialog();
            this.Hide();

        }

  

        private void btn_info_Click(object sender, EventArgs e)
        {
            StudentINFO info = new StudentINFO();
            
            info.ShowDialog();
            this.Hide();
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            StudentScore score = new StudentScore();
            this.Hide();
            score.ShowDialog();
            
        }

        private void btn_fee_Click(object sender, EventArgs e)
        {
            StudentFee fee = new StudentFee();
            fee.ShowDialog();
            this.Hide();
        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            StudentMaterial material = new StudentMaterial();
            
            material.ShowDialog();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.ShowDialog();
            
        }
    }
}
