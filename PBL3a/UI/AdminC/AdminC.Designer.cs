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
            gbDuyetDon = new GroupBox();
            radioButton1 = new RadioButton();
            btnOkDuyetDon = new Button();
            rdoViewDuyetDon = new RadioButton();
            gbKhoaLopHoc = new GroupBox();
            radioButton2 = new RadioButton();
            btnOkKhoaHoc = new Button();
            rdoViewKhoaHoc = new RadioButton();
            gbDuyetDon.SuspendLayout();
            gbKhoaLopHoc.SuspendLayout();
            SuspendLayout();
            // 
            // gbDuyetDon
            // 
            gbDuyetDon.Anchor = AnchorStyles.None;
            gbDuyetDon.BackColor = SystemColors.Info;
            gbDuyetDon.Controls.Add(radioButton1);
            gbDuyetDon.Controls.Add(btnOkDuyetDon);
            gbDuyetDon.Controls.Add(rdoViewDuyetDon);
            gbDuyetDon.Location = new Point(46, 113);
            gbDuyetDon.Name = "gbDuyetDon";
            gbDuyetDon.Size = new Size(285, 196);
            gbDuyetDon.TabIndex = 3;
            gbDuyetDon.TabStop = false;
            gbDuyetDon.Text = "Quản Lý Duyệt Đơn";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(110, 89);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "None";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnOkDuyetDon
            // 
            btnOkDuyetDon.BackColor = Color.FromArgb(255, 192, 192);
            btnOkDuyetDon.Location = new Point(97, 133);
            btnOkDuyetDon.Name = "btnOkDuyetDon";
            btnOkDuyetDon.Size = new Size(94, 29);
            btnOkDuyetDon.TabIndex = 5;
            btnOkDuyetDon.Text = "OK";
            btnOkDuyetDon.UseVisualStyleBackColor = false;
            btnOkDuyetDon.Click += btnOkDuyetDon_Click;
            // 
            // rdoViewDuyetDon
            // 
            rdoViewDuyetDon.AutoSize = true;
            rdoViewDuyetDon.Location = new Point(110, 50);
            rdoViewDuyetDon.Name = "rdoViewDuyetDon";
            rdoViewDuyetDon.Size = new Size(62, 24);
            rdoViewDuyetDon.TabIndex = 0;
            rdoViewDuyetDon.TabStop = true;
            rdoViewDuyetDon.Text = "View";
            rdoViewDuyetDon.UseVisualStyleBackColor = true;
            // 
            // gbKhoaLopHoc
            // 
            gbKhoaLopHoc.Anchor = AnchorStyles.None;
            gbKhoaLopHoc.BackColor = SystemColors.Info;
            gbKhoaLopHoc.Controls.Add(radioButton2);
            gbKhoaLopHoc.Controls.Add(btnOkKhoaHoc);
            gbKhoaLopHoc.Controls.Add(rdoViewKhoaHoc);
            gbKhoaLopHoc.Location = new Point(361, 113);
            gbKhoaLopHoc.Name = "gbKhoaLopHoc";
            gbKhoaLopHoc.Size = new Size(295, 196);
            gbKhoaLopHoc.TabIndex = 4;
            gbKhoaLopHoc.TabStop = false;
            gbKhoaLopHoc.Text = "Quản Lý Khóa/ Lớp Học";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(118, 89);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "None";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnOkKhoaHoc
            // 
            btnOkKhoaHoc.BackColor = Color.FromArgb(255, 192, 192);
            btnOkKhoaHoc.Location = new Point(109, 133);
            btnOkKhoaHoc.Name = "btnOkKhoaHoc";
            btnOkKhoaHoc.Size = new Size(94, 29);
            btnOkKhoaHoc.TabIndex = 2;
            btnOkKhoaHoc.Text = "OK";
            btnOkKhoaHoc.UseVisualStyleBackColor = false;
            btnOkKhoaHoc.Click += btnOkKhoaHoc_Click;
            // 
            // rdoViewKhoaHoc
            // 
            rdoViewKhoaHoc.AutoSize = true;
            rdoViewKhoaHoc.Location = new Point(118, 50);
            rdoViewKhoaHoc.Name = "rdoViewKhoaHoc";
            rdoViewKhoaHoc.Size = new Size(62, 24);
            rdoViewKhoaHoc.TabIndex = 0;
            rdoViewKhoaHoc.TabStop = true;
            rdoViewKhoaHoc.Text = "View";
            rdoViewKhoaHoc.UseVisualStyleBackColor = true;
            // 
            // AdminC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 398);
            Controls.Add(gbKhoaLopHoc);
            Controls.Add(gbDuyetDon);
            Name = "AdminC";
            Text = "Admin Quản Lý Chung";
            gbDuyetDon.ResumeLayout(false);
            gbDuyetDon.PerformLayout();
            gbKhoaLopHoc.ResumeLayout(false);
            gbKhoaLopHoc.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private GroupBox gbDuyetDon;
        private GroupBox gbKhoaLopHoc;
        private RadioButton rdoViewDuyetDon;
        private RadioButton rdoViewKhoaHoc;
        private Button btnOkDuyetDon;
        private Button btnOkKhoaHoc;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}