namespace PBL3a.UI.AdminC
{
    partial class quanLyKhoaHoc
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
            labelqlduyetdon1 = new Label();
            SuspendLayout();
            // 
            // labelqlduyetdon1
            // 
            labelqlduyetdon1.Anchor = AnchorStyles.None;
            labelqlduyetdon1.AutoSize = true;
            labelqlduyetdon1.BackColor = SystemColors.Info;
            labelqlduyetdon1.BorderStyle = BorderStyle.Fixed3D;
            labelqlduyetdon1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelqlduyetdon1.Location = new Point(307, 80);
            labelqlduyetdon1.Name = "labelqlduyetdon1";
            labelqlduyetdon1.Size = new Size(2, 23);
            labelqlduyetdon1.TabIndex = 1;
            labelqlduyetdon1.Click += labelqlduyetdon1_Click;
            // 
            // quanLyKhoaHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 539);
            Controls.Add(labelqlduyetdon1);
            Name = "quanLyKhoaHoc";
            Text = "Khóa Học/ Lớp Học";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelqlduyetdon1;
    }
}