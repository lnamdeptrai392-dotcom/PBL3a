namespace PBL3a.UI.Login
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelCard;
        private TextBox txtUsername;
        private Button btnLogin;
        private CheckBox chkShowPassword;
        private Label lblTitle;
        private Label lblForgot;
        private PictureBox picAvatar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelCard = new Panel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            lblTitle = new Label();
            lblForgot = new Label();
            chkShowPassword = new CheckBox();
            picAvatar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
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
            panelCard.Controls.Add(picAvatar);
            panelCard.Location = new Point(100, 75);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(700, 350);
            panelCard.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Gainsboro;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(350, 149);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 29);
            txtPassword.TabIndex = 0;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Gainsboro;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 13F);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(350, 91);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 29);
            txtUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(112, 146, 190);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(350, 226);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(346, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(224, 37);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Member Login";
            // 
            // lblForgot
            // 
            lblForgot.ForeColor = Color.Gray;
            lblForgot.Location = new Point(350, 285);
            lblForgot.Name = "lblForgot";
            lblForgot.Size = new Size(220, 23);
            lblForgot.TabIndex = 4;
            lblForgot.Text = "Forgot Username / Password?";
            lblForgot.Click += lblForgot_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Location = new Point(350, 196);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(104, 24);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show";
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.Transparent;
            picAvatar.Image = Properties.Resources.user_interface;
            picAvatar.Location = new Point(70, 82);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(184, 184);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 7;
            picAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(346, 59);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 8;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(346, 123);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 9;
            label2.Text = "Mật khẩu:";
            // 
            // LoginForm
            // 
            ClientSize = new Size(900, 500);
            Controls.Add(panelCard);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        private TextBox txtPassword;
        private Label label2;
        private Label label1;
    }
}