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
            panel1 = new Panel();
            label3 = new Label();
            butExit = new Button();
            butViewKhoaLop = new Button();
            butViewDuyetDon = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(butExit);
            panel1.Controls.Add(butViewKhoaLop);
            panel1.Controls.Add(butViewDuyetDon);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-38, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 430);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(376, 19);
            label3.Name = "label3";
            label3.Size = new Size(180, 30);
            label3.TabIndex = 5;
            label3.Text = "Trung Tâm Gia Sư";
            // 
            // butExit
            // 
            butExit.Anchor = AnchorStyles.None;
            butExit.Location = new Point(407, 344);
            butExit.Name = "butExit";
            butExit.Size = new Size(110, 43);
            butExit.TabIndex = 4;
            butExit.Text = "Thoát";
            butExit.UseVisualStyleBackColor = true;
            butExit.Click += butExit_Click;
            // 
            // butViewKhoaLop
            // 
            butViewKhoaLop.Anchor = AnchorStyles.None;
            butViewKhoaLop.Location = new Point(565, 202);
            butViewKhoaLop.Name = "butViewKhoaLop";
            butViewKhoaLop.Size = new Size(110, 43);
            butViewKhoaLop.TabIndex = 3;
            butViewKhoaLop.Text = "View";
            butViewKhoaLop.UseVisualStyleBackColor = true;
            butViewKhoaLop.Click += butViewKhoaLop_Click;
            // 
            // butViewDuyetDon
            // 
            butViewDuyetDon.Anchor = AnchorStyles.None;
            butViewDuyetDon.Location = new Point(254, 202);
            butViewDuyetDon.Name = "butViewDuyetDon";
            butViewDuyetDon.Size = new Size(110, 43);
            butViewDuyetDon.TabIndex = 2;
            butViewDuyetDon.Text = "View";
            butViewDuyetDon.UseVisualStyleBackColor = true;
            butViewDuyetDon.Click += butViewDuyetDon_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(527, 143);
            label2.Name = "label2";
            label2.Size = new Size(199, 30);
            label2.TabIndex = 1;
            label2.Text = "Quản Lý Duyệt Đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 143);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Duyệt Đơn";
            // 
            // AdminC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 469);
            Controls.Add(panel1);
            Name = "AdminC";
            Text = "Admin Quản Lý Chung";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button butExit;
        private Button butViewKhoaLop;
        private Button butViewDuyetDon;
        private Label label3;
    }
}