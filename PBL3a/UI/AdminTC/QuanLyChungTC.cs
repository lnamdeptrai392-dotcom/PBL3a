using PBL3a.UI.Login;
using System;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class QuanLyChungTC : Form
    {
        public QuanLyChungTC()
        {
            InitializeComponent();
        }

        private void QuanLyChungTC_Load(object sender, EventArgs e)
        {

        }

        // Khi đóng form -> thoát toàn bộ chương trình
        private void QuanLyChungTC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Học phí
        private void btHP_Click(object sender, EventArgs e)
        {
            HocPhi hocPhi = new HocPhi();
            this.Hide();
            hocPhi.ShowDialog();
            this.Show();
        }

        // Đăng xuất
        private void btT_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        // Lương giáo viên
        private void btLGV_Click(object sender, EventArgs e)
        {
            LuongGV luong = new LuongGV();
            this.Hide();
            luong.ShowDialog();
            this.Show();
        }

        // Lợi nhuận
        private void btLN_Click(object sender, EventArgs e)
        {
            LoiNhuan loinhuan = new LoiNhuan();
            this.Hide();
            loinhuan.ShowDialog();
            this.Show();
        }
    }
}