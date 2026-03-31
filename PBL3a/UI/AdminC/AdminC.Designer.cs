namespace PBL3a.UI.AdminC
{
    partial class AdminC
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            butOut = new Button();
            btnTaoTK = new Button();
            btnKhoaLop = new Button();
            btnDaDuyet = new Button();
            btnDuyetDon = new Button();
            btnHome = new Button();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(112, 146, 190);
            panelMenu.Controls.Add(butOut);
            panelMenu.Controls.Add(btnTaoTK);
            panelMenu.Controls.Add(btnKhoaLop);
            panelMenu.Controls.Add(btnDaDuyet);
            panelMenu.Controls.Add(btnDuyetDon);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(238, 509);
            panelMenu.TabIndex = 0;
            // 
            // butOut
            // 
            butOut.Dock = DockStyle.Top;
            butOut.FlatAppearance.BorderSize = 0;
            butOut.FlatStyle = FlatStyle.Flat;
            butOut.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            butOut.Image = Properties.Resources.logout;
            butOut.ImageAlign = ContentAlignment.MiddleLeft;
            butOut.Location = new Point(0, 400);
            butOut.Name = "butOut";
            butOut.Padding = new Padding(20, 0, 0, 0);
            butOut.Size = new Size(238, 80);
            butOut.TabIndex = 6;
            butOut.Text = "     Đăng Xuất";
            butOut.TextAlign = ContentAlignment.MiddleLeft;
            butOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            butOut.UseVisualStyleBackColor = true;
            butOut.Click += butOut_Click;
            // 
            // btnTaoTK
            // 
            btnTaoTK.Dock = DockStyle.Top;
            btnTaoTK.FlatAppearance.BorderSize = 0;
            btnTaoTK.FlatStyle = FlatStyle.Flat;
            btnTaoTK.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnTaoTK.Image = Properties.Resources.pen_clip;
            btnTaoTK.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaoTK.Location = new Point(0, 320);
            btnTaoTK.Name = "btnTaoTK";
            btnTaoTK.Padding = new Padding(20, 0, 0, 0);
            btnTaoTK.Size = new Size(238, 80);
            btnTaoTK.TabIndex = 5;
            btnTaoTK.Text = "     Tạo Tài Khoản";
            btnTaoTK.TextAlign = ContentAlignment.MiddleLeft;
            btnTaoTK.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaoTK.UseVisualStyleBackColor = true;
            btnTaoTK.Click += btnTaoTK_Click;
            // 
            // btnKhoaLop
            // 
            btnKhoaLop.Dock = DockStyle.Top;
            btnKhoaLop.FlatAppearance.BorderSize = 0;
            btnKhoaLop.FlatStyle = FlatStyle.Flat;
            btnKhoaLop.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnKhoaLop.Image = Properties.Resources.workshop;
            btnKhoaLop.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoaLop.Location = new Point(0, 240);
            btnKhoaLop.Name = "btnKhoaLop";
            btnKhoaLop.Padding = new Padding(20, 0, 0, 0);
            btnKhoaLop.Size = new Size(238, 80);
            btnKhoaLop.TabIndex = 4;
            btnKhoaLop.Text = "     Thông Tin Khóa/Lớp";
            btnKhoaLop.TextAlign = ContentAlignment.MiddleLeft;
            btnKhoaLop.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhoaLop.UseVisualStyleBackColor = true;
            btnKhoaLop.Click += btnKhoaLop_Click;
            // 
            // btnDaDuyet
            // 
            btnDaDuyet.Dock = DockStyle.Top;
            btnDaDuyet.FlatAppearance.BorderSize = 0;
            btnDaDuyet.FlatStyle = FlatStyle.Flat;
            btnDaDuyet.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaDuyet.Image = Properties.Resources.task_checklist;
            btnDaDuyet.ImageAlign = ContentAlignment.MiddleLeft;
            btnDaDuyet.Location = new Point(0, 160);
            btnDaDuyet.Name = "btnDaDuyet";
            btnDaDuyet.Padding = new Padding(20, 0, 0, 0);
            btnDaDuyet.Size = new Size(238, 80);
            btnDaDuyet.TabIndex = 2;
            btnDaDuyet.Text = "     Đơn Đã Duyệt";
            btnDaDuyet.TextAlign = ContentAlignment.MiddleLeft;
            btnDaDuyet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDaDuyet.UseVisualStyleBackColor = true;
            btnDaDuyet.Click += btnDaDuyet_Click;
            // 
            // btnDuyetDon
            // 
            btnDuyetDon.BackColor = Color.FromArgb(112, 146, 190);
            btnDuyetDon.Dock = DockStyle.Top;
            btnDuyetDon.FlatAppearance.BorderSize = 0;
            btnDuyetDon.FlatStyle = FlatStyle.Flat;
            btnDuyetDon.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDuyetDon.Image = Properties.Resources.form1;
            btnDuyetDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnDuyetDon.Location = new Point(0, 80);
            btnDuyetDon.Name = "btnDuyetDon";
            btnDuyetDon.Padding = new Padding(20, 0, 0, 0);
            btnDuyetDon.Size = new Size(238, 80);
            btnDuyetDon.TabIndex = 1;
            btnDuyetDon.Text = "     Duyệt Đơn";
            btnDuyetDon.TextAlign = ContentAlignment.MiddleLeft;
            btnDuyetDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDuyetDon.UseVisualStyleBackColor = false;
            btnDuyetDon.Click += btnDuyetDon_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Image = Properties.Resources.house_chimney;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(0, 12, 0, 10);
            btnHome.Size = new Size(238, 80);
            btnHome.TabIndex = 0;
            btnHome.TextAlign = ContentAlignment.BottomCenter;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(238, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(799, 509);
            panelDesktop.TabIndex = 2;
            // 
            // AdminC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 509);
            Controls.Add(panelDesktop);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminC";
            Text = "Admin Quản Lý Chung";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnHome;
        private Button btnDuyetDon;
        private Button btnTaoTK;
        private Button btnKhoaLop;
        private Button btnDaDuyet;
        private Panel panelDesktop;
        private Button butOut;
    }
}