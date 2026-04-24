namespace PBL3a.UI.AdminTC
{
    partial class QuanLyChungTC
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
            panel2 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            paDesktop = new Panel();
            panel3 = new Panel();
            btHP = new Button();
            panel1 = new Panel();
            btDX = new Button();
            btKC = new Button();
            btKT = new Button();
            btLN = new Button();
            btLGV = new Button();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(112, 146, 190);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1483, 63);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel4);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1483, 63);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(236, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1247, 63);
            panel6.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(549, 9);
            label1.Name = "label1";
<<<<<<< Updated upstream
            label1.Size = new Size(295, 47);
=======
            label1.Size = new Size(406, 62);
>>>>>>> Stashed changes
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Tài Chính";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 63);
            panel4.TabIndex = 1;
            // 
            // paDesktop
            // 
            paDesktop.Location = new Point(239, 69);
            paDesktop.Name = "paDesktop";
            paDesktop.Size = new Size(864, 412);
            paDesktop.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(paDesktop);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1483, 641);
            panel3.TabIndex = 2;
            // 
            // btHP
            // 
            btHP.Dock = DockStyle.Top;
            btHP.FlatAppearance.BorderSize = 0;
            btHP.FlatStyle = FlatStyle.Flat;
            btHP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btHP.ForeColor = Color.White;
            btHP.Location = new Point(0, 0);
            btHP.Margin = new Padding(0);
            btHP.Name = "btHP";
            btHP.Size = new Size(236, 72);
            btHP.TabIndex = 1;
            btHP.Text = "Học Phí";
            btHP.UseVisualStyleBackColor = true;
            btHP.Click += btHP_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(112, 146, 190);
            panel1.Controls.Add(btDX);
            panel1.Controls.Add(btKC);
            panel1.Controls.Add(btKT);
            panel1.Controls.Add(btLN);
            panel1.Controls.Add(btLGV);
            panel1.Controls.Add(btHP);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 63);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 578);
            panel1.TabIndex = 0;
            // 
            // btDX
            // 
            btDX.Dock = DockStyle.Top;
            btDX.FlatAppearance.BorderSize = 0;
            btDX.FlatStyle = FlatStyle.Flat;
            btDX.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDX.ForeColor = Color.White;
<<<<<<< Updated upstream
            btDX.Location = new Point(0, 216);
=======
            btDX.Location = new Point(0, 300);
>>>>>>> Stashed changes
            btDX.Margin = new Padding(0);
            btDX.Name = "btDX";
            btDX.Size = new Size(236, 72);
            btDX.TabIndex = 4;
            btDX.Text = "Đăng Xuất";
            btDX.UseVisualStyleBackColor = true;
            btDX.Click += btDX_Click;
            // 
            // btKC
            // 
            btKC.BackColor = Color.FromArgb(44, 78, 98);
            btKC.Dock = DockStyle.Top;
            btKC.FlatAppearance.BorderSize = 0;
            btKC.FlatStyle = FlatStyle.Flat;
            btKC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btKC.ForeColor = Color.White;
            btKC.Location = new Point(0, 240);
            btKC.Margin = new Padding(0);
            btKC.Name = "btKC";
            btKC.Size = new Size(200, 60);
            btKC.TabIndex = 6;
            btKC.Text = "Khoản Chi";
            btKC.UseVisualStyleBackColor = false;
            btKC.Click += btKC_Click;
            // 
            // btKT
            // 
            btKT.BackColor = Color.FromArgb(44, 78, 98);
            btKT.Dock = DockStyle.Top;
            btKT.FlatAppearance.BorderSize = 0;
            btKT.FlatStyle = FlatStyle.Flat;
            btKT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btKT.ForeColor = Color.White;
            btKT.Location = new Point(0, 180);
            btKT.Margin = new Padding(0);
            btKT.Name = "btKT";
            btKT.Size = new Size(200, 60);
            btKT.TabIndex = 5;
            btKT.Text = "Khoản Thu";
            btKT.UseVisualStyleBackColor = false;
            btKT.Click += btKT_Click;
            // 
            // btLN
            // 
            btLN.Dock = DockStyle.Top;
            btLN.FlatAppearance.BorderSize = 0;
            btLN.FlatStyle = FlatStyle.Flat;
            btLN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLN.ForeColor = Color.White;
            btLN.Location = new Point(0, 144);
            btLN.Margin = new Padding(0);
            btLN.Name = "btLN";
            btLN.Size = new Size(236, 72);
            btLN.TabIndex = 3;
            btLN.Text = "Lợi Nhuận";
            btLN.UseVisualStyleBackColor = true;
            btLN.Click += btLN_Click;
            // 
            // btLGV
            // 
            btLGV.Dock = DockStyle.Top;
            btLGV.FlatAppearance.BorderSize = 0;
            btLGV.FlatStyle = FlatStyle.Flat;
            btLGV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLGV.ForeColor = Color.White;
            btLGV.Location = new Point(0, 72);
            btLGV.Margin = new Padding(0);
            btLGV.Name = "btLGV";
            btLGV.Size = new Size(236, 72);
            btLGV.TabIndex = 2;
            btLGV.Text = "Lương Giáo Viên";
            btLGV.UseVisualStyleBackColor = true;
            btLGV.Click += btLGV_Click;
            // 
            // QuanLyChungTC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1483, 641);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "QuanLyChungTC";
            Text = "QuanLyChungTC";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2; 
        private Panel panel3;
        private Label label1;
        private Button btHP;
        private Panel panel1;
        private Button btDX;
        private Button btLN;
        private Button btLGV;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
<<<<<<< Updated upstream
        private Panel paDesktop;
=======
        private Button btKC;
        private Button btKT;
>>>>>>> Stashed changes
    }
}