using PBL3a.UI.Login;
using System;
using System.Collections.Concurrent;
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
            but_chform.ActivateButton(sender);
            HocPhi hocPhi = new HocPhi();
            but_chform.OpenChildForm(hocPhi, sender, paDesktop);
        }

        // Đăng xuất
        private void btT_Click(object sender, EventArgs e)
        {
            but_chform.ActivateButton(sender);
            this.Close();
        }

        // Lương giáo viên
        private void btLGV_Click(object sender, EventArgs e)
        {
            but_chform.ActivateButton(sender);
            LuongGV luong = new LuongGV();
            but_chform.OpenChildForm(luong, sender, paDesktop);
        }

        // Lợi nhuận
        private void btLN_Click(object sender, EventArgs e)
        {
            but_chform.ActivateButton(sender);
            LoiNhuan loinhuan = new LoiNhuan();
            but_chform.OpenChildForm(loinhuan, sender, paDesktop);
        }
    }
}