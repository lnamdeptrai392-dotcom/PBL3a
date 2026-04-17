namespace PBL3a.UI.Login
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            chkShowPassword = new CheckBox();
            lblForgot = new Label();
            lblTitle = new Label();
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            picAvatar = new PictureBox();
            panelCard = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            panelCard.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chkShowPassword
            // 
            chkShowPassword.ForeColor = Color.FromArgb(26, 47, 58);
            chkShowPassword.Location = new Point(475, 322);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(104, 24);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Hiển thị";
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblForgot
            // 
            lblForgot.ForeColor = Color.Gray;
            lblForgot.Location = new Point(731, 323);
            lblForgot.Name = "lblForgot";
            lblForgot.Size = new Size(124, 23);
            lblForgot.TabIndex = 4;
            lblForgot.Text = "Quên mật khẩu?";
            lblForgot.Click += lblForgot_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.ForeColor = Color.FromArgb(26, 47, 58);
            lblTitle.Location = new Point(463, 84);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(296, 78);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Đăng nhập";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(93, 156, 179);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(556, 370);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(212, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(471, 199);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " abc@123";
            txtUsername.Size = new Size(370, 31);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(471, 272);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " ********";
            txtPassword.Size = new Size(370, 36);
            txtPassword.TabIndex = 0;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.FromArgb(26, 47, 58);
            label1.Location = new Point(471, 162);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 8;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.FromArgb(26, 47, 58);
            label2.Location = new Point(470, 241);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 9;
            label2.Text = "Mật khẩu:";
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.Transparent;
            picAvatar.Image = Properties.Resources._2026;
            picAvatar.Location = new Point(77, 62);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(187, 169);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 7;
            picAvatar.TabStop = false;
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(label2);
            panelCard.Controls.Add(label1);
            panelCard.Controls.Add(txtPassword);
            panelCard.Controls.Add(txtUsername);
            panelCard.Controls.Add(btnLogin);
            panelCard.Controls.Add(lblTitle);
            panelCard.Controls.Add(lblForgot);
            panelCard.Controls.Add(chkShowPassword);
            panelCard.Dock = DockStyle.Fill;
            panelCard.Location = new Point(0, 0);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(1000, 500);
            panelCard.TabIndex = 0;
            panelCard.Paint += panelCard_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 78, 98);
            panel1.Controls.Add(picAvatar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 500);
            panel1.TabIndex = 1;
            // 
            // LoginForm
            // 
            BackColor = Color.FromArgb(244, 247, 246);
            ClientSize = new Size(1000, 500);
            Controls.Add(panel1);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1000, 500);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private CheckBox chkShowPassword;
        private Label lblForgot;
        private Label lblTitle;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private PictureBox picAvatar;
        private Panel panelCard;
        private Panel panel1;
    }
}