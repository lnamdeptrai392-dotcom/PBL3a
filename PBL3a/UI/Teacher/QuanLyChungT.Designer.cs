namespace PBL3a.UI.Teacher
{
    partial class QuanLyChungT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnExit = new Button();
            btnSalary = new Button();
            btnScore = new Button();
            btnSchedule = new Button();
            btnInfo = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(44, 78, 98);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnSalary);
            panelMenu.Controls.Add(btnScore);
            panelMenu.Controls.Add(btnSchedule);
            panelMenu.Controls.Add(btnInfo);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 500);
            panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 340);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 55);
            btnExit.TabIndex = 6;
            btnExit.Text = "Đăng xuất";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = Color.FromArgb(44, 78, 98);
            btnSalary.Dock = DockStyle.Top;
            btnSalary.FlatAppearance.BorderSize = 0;
            btnSalary.FlatStyle = FlatStyle.Flat;
            btnSalary.Font = new Font("Segoe UI", 10F);
            btnSalary.ForeColor = Color.White;
            btnSalary.Location = new Point(0, 285);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(200, 55);
            btnSalary.TabIndex = 5;
            btnSalary.Text = "Lương";
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click;
            // 
            // btnScore
            // 
            btnScore.BackColor = Color.FromArgb(44, 78, 98);
            btnScore.Dock = DockStyle.Top;
            btnScore.FlatAppearance.BorderSize = 0;
            btnScore.FlatStyle = FlatStyle.Flat;
            btnScore.Font = new Font("Segoe UI", 10F);
            btnScore.ForeColor = Color.White;
            btnScore.Location = new Point(0, 230);
            btnScore.Name = "btnScore";
            btnScore.Size = new Size(200, 55);
            btnScore.TabIndex = 3;
            btnScore.Text = "Nhập điểm";
            btnScore.UseVisualStyleBackColor = false;
            btnScore.Click += btnScore_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.FromArgb(44, 78, 98);
            btnSchedule.Dock = DockStyle.Top;
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 10F);
            btnSchedule.ForeColor = Color.White;
            btnSchedule.Location = new Point(0, 175);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(200, 55);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "Thời khóa biểu";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.FromArgb(44, 78, 98);
            btnInfo.Dock = DockStyle.Top;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Segoe UI", 10F);
            btnInfo.ForeColor = Color.White;
            btnInfo.Location = new Point(0, 120);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(200, 55);
            btnInfo.TabIndex = 1;
            btnInfo.Text = "Thông tin cá nhân";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(44, 78, 98);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 120);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2026;
            pictureBox1.Location = new Point(43, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 500);
            panelMain.TabIndex = 1;
            // 
            // QuanLyChungT
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(44, 78, 98);
            ClientSize = new Size(1000, 500);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "QuanLyChungT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLyChungT";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panelMain;
        private Button btnInfo;
        private Button btnExit;
        private Button btnSalary;
        private Button btnScore;
        private Button btnSchedule;
        private PictureBox pictureBox1;
    }
}