namespace PBL3a.UI.Login
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel LoginTable1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LoginTable1 = new TableLayoutPanel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            LoginTable1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginTable1
            // 
            LoginTable1.ColumnCount = 2;
            LoginTable1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.0065145F));
            LoginTable1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.9934845F));
            LoginTable1.Controls.Add(lblUsername, 0, 0);
            LoginTable1.Controls.Add(txtUsername, 1, 0);
            LoginTable1.Controls.Add(lblPassword, 0, 1);
            LoginTable1.Controls.Add(txtPassword, 1, 1);
            LoginTable1.Controls.Add(chkShowPassword, 1, 2);
            LoginTable1.Controls.Add(btnLogin, 1, 3);
            LoginTable1.Dock = DockStyle.Fill;
            LoginTable1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            LoginTable1.Location = new Point(0, 0);
            LoginTable1.Name = "LoginTable1";
            LoginTable1.Padding = new Padding(20);
            LoginTable1.RowCount = 4;
            LoginTable1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            LoginTable1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            LoginTable1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            LoginTable1.RowStyles.Add(new RowStyle(SizeType.Absolute, 136F));
            LoginTable1.Size = new Size(961, 525);
            LoginTable1.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(68, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(152, 23);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(786, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(73, 65);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(152, 68);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(786, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Anchor = AnchorStyles.Left;
            chkShowPassword.Location = new Point(152, 114);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(104, 24);
            chkShowPassword.TabIndex = 4;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.Location = new Point(507, 154);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            ClientSize = new Size(961, 525);
            Controls.Add(LoginTable1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            LoginTable1.ResumeLayout(false);
            LoginTable1.PerformLayout();
            ResumeLayout(false);
        }
    }
}