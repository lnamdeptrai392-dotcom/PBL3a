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
            labelAdminC1 = new Label();
            labelAdminC2 = new Label();
            buttonAdminC1 = new Button();
            buttonAdminC2 = new Button();
            SuspendLayout();
            // 
            // labelAdminC1
            // 
            labelAdminC1.Anchor = AnchorStyles.None;
            labelAdminC1.AutoSize = true;
            labelAdminC1.BackColor = SystemColors.Info;
            labelAdminC1.BorderStyle = BorderStyle.Fixed3D;
            labelAdminC1.FlatStyle = FlatStyle.Popup;
            labelAdminC1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdminC1.Location = new Point(237, 189);
            labelAdminC1.Name = "labelAdminC1";
            labelAdminC1.Size = new Size(223, 30);
            labelAdminC1.TabIndex = 0;
            labelAdminC1.Text = "QUẢN LÝ DUYỆT ĐƠN";
            // 
            // labelAdminC2
            // 
            labelAdminC2.Anchor = AnchorStyles.None;
            labelAdminC2.AutoSize = true;
            labelAdminC2.BackColor = SystemColors.Info;
            labelAdminC2.BorderStyle = BorderStyle.Fixed3D;
            labelAdminC2.FlatStyle = FlatStyle.Popup;
            labelAdminC2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdminC2.Location = new Point(608, 189);
            labelAdminC2.Name = "labelAdminC2";
            labelAdminC2.Size = new Size(261, 30);
            labelAdminC2.TabIndex = 1;
            labelAdminC2.Text = "QUẢN LÝ KHÓA, LỚP HỌC";
            // 
            // buttonAdminC1
            // 
            buttonAdminC1.Anchor = AnchorStyles.None;
            buttonAdminC1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdminC1.BackColor = SystemColors.Info;
            buttonAdminC1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdminC1.ForeColor = Color.Firebrick;
            buttonAdminC1.Location = new Point(258, 261);
            buttonAdminC1.Name = "buttonAdminC1";
            buttonAdminC1.Size = new Size(191, 84);
            buttonAdminC1.TabIndex = 0;
            buttonAdminC1.Text = "VIEW";
            buttonAdminC1.UseVisualStyleBackColor = false;
            buttonAdminC1.Click += buttonAdminC1_Click;
            // 
            // buttonAdminC2
            // 
            buttonAdminC2.Anchor = AnchorStyles.None;
            buttonAdminC2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdminC2.BackColor = SystemColors.Info;
            buttonAdminC2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdminC2.ForeColor = Color.Firebrick;
            buttonAdminC2.Location = new Point(645, 261);
            buttonAdminC2.Name = "buttonAdminC2";
            buttonAdminC2.Size = new Size(191, 84);
            buttonAdminC2.TabIndex = 2;
            buttonAdminC2.Text = "VIEW";
            buttonAdminC2.UseVisualStyleBackColor = false;
            buttonAdminC2.Click += buttonAdminC2_Click;
            // 
            // AdminC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 592);
            Controls.Add(buttonAdminC2);
            Controls.Add(buttonAdminC1);
            Controls.Add(labelAdminC2);
            Controls.Add(labelAdminC1);
            Name = "AdminC";
            Text = "Admin Quản Lý Chung";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAdminC1;
        private Label labelAdminC2;
        private Button buttonAdminC1;
        private Button buttonAdminC2;
    }
}