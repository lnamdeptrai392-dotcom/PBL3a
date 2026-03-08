namespace PBL3a.UI.AdminC
{
    partial class quanLyDuyetDon
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
            listBoxduyetdon1 = new ListBox();
            buttonduyetdon1 = new Button();
            buttonduyetdon2 = new Button();
            SuspendLayout();
            // 
            // labelqlduyetdon1
            // 
            labelqlduyetdon1.Anchor = AnchorStyles.None;
            labelqlduyetdon1.AutoSize = true;
            labelqlduyetdon1.BackColor = SystemColors.Info;
            labelqlduyetdon1.BorderStyle = BorderStyle.Fixed3D;
            labelqlduyetdon1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelqlduyetdon1.Location = new Point(364, 24);
            labelqlduyetdon1.Name = "labelqlduyetdon1";
            labelqlduyetdon1.Size = new Size(356, 23);
            labelqlduyetdon1.TabIndex = 0;
            labelqlduyetdon1.Text = "Quản Lý Duyệt Đơn - Trung Tâm Gia Sư";
            // 
            // listBoxduyetdon1
            // 
            listBoxduyetdon1.Anchor = AnchorStyles.None;
            listBoxduyetdon1.FormattingEnabled = true;
            listBoxduyetdon1.Location = new Point(244, 90);
            listBoxduyetdon1.Name = "listBoxduyetdon1";
            listBoxduyetdon1.Size = new Size(589, 324);
            listBoxduyetdon1.TabIndex = 1;
            // 
            // buttonduyetdon1
            // 
            buttonduyetdon1.Anchor = AnchorStyles.None;
            buttonduyetdon1.Location = new Point(626, 422);
            buttonduyetdon1.Name = "buttonduyetdon1";
            buttonduyetdon1.Size = new Size(94, 29);
            buttonduyetdon1.TabIndex = 2;
            buttonduyetdon1.Text = "Đồng ý";
            buttonduyetdon1.UseVisualStyleBackColor = true;
            // 
            // buttonduyetdon2
            // 
            buttonduyetdon2.Anchor = AnchorStyles.None;
            buttonduyetdon2.Location = new Point(739, 422);
            buttonduyetdon2.Name = "buttonduyetdon2";
            buttonduyetdon2.Size = new Size(94, 29);
            buttonduyetdon2.TabIndex = 3;
            buttonduyetdon2.Text = "Từ chối";
            buttonduyetdon2.UseVisualStyleBackColor = true;
            // 
            // quanLyDuyetDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 574);
            Controls.Add(buttonduyetdon2);
            Controls.Add(buttonduyetdon1);
            Controls.Add(listBoxduyetdon1);
            Controls.Add(labelqlduyetdon1);
            Name = "quanLyDuyetDon";
            Text = "Duyệt Đơn Đăng Ký";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelqlduyetdon1;
        private ListBox listBoxduyetdon1;
        private Button buttonduyetdon1;
        private Button buttonduyetdon2;
    }
}