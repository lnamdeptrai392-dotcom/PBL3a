namespace PBL3a.UI.Student
{
    partial class StudentAll
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
            this.MinimumSize = new Size(800, 500);

            panel_content = new Panel();
            btn_exit = new Button();
            btn_fee = new Button();
            btn_score = new Button();
            btn_schedule = new Button();
            btn_info = new Button();
            panel1 = new Panel();
            panelChildBox = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel_content.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_content
            // 
            panel_content.BackColor = Color.FromArgb(112, 146, 190);
            panel_content.Controls.Add(btn_exit);
            panel_content.Controls.Add(btn_fee);
            panel_content.Controls.Add(btn_score);
            panel_content.Controls.Add(btn_schedule);
            panel_content.Controls.Add(btn_info);
            panel_content.Controls.Add(panel1);
            panel_content.Dock = DockStyle.Left;
            panel_content.Width = 220;
            panel_content.Location = new Point(0, 0);
            panel_content.Margin = new Padding(0);
            panel_content.Name = "panel_content";
            panel_content.Size = new Size(206, 560);
            panel_content.TabIndex = 11;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(112, 146, 190);
            btn_exit.Dock = DockStyle.Top;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Segoe UI", 10F);
            btn_exit.ForeColor = SystemColors.ButtonHighlight;
            btn_exit.Location = new Point(0, 287);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(206, 60);
            btn_exit.TabIndex = 11;
            btn_exit.Text = "Đăng xuất";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_fee
            // 
            btn_fee.BackColor = Color.FromArgb(112, 146, 190);
            btn_fee.Dock = DockStyle.Top;
            btn_fee.FlatAppearance.BorderSize = 0;
            btn_fee.FlatStyle = FlatStyle.Flat;
            btn_fee.Font = new Font("Segoe UI", 10F);
            btn_fee.ForeColor = SystemColors.ButtonHighlight;
            btn_fee.Location = new Point(0, 227);
            btn_fee.Margin = new Padding(3, 2, 3, 2);
            btn_fee.Name = "btn_fee";
            btn_fee.Size = new Size(206, 60);
            btn_fee.TabIndex = 4;
            btn_fee.Text = "Học phí";
            btn_fee.UseVisualStyleBackColor = false;
            btn_fee.Click += btn_fee_Click;
            // 
            // btn_score
            // 
            btn_score.BackColor = Color.FromArgb(112, 146, 190);
            btn_score.Dock = DockStyle.Top;
            btn_score.FlatAppearance.BorderSize = 0;
            btn_score.FlatStyle = FlatStyle.Flat;
            btn_score.Font = new Font("Segoe UI", 10F);
            btn_score.ForeColor = SystemColors.ButtonHighlight;
            btn_score.Location = new Point(0, 167);
            btn_score.Margin = new Padding(3, 2, 3, 2);
            btn_score.Name = "btn_score";
            btn_score.Size = new Size(206, 60);
            btn_score.TabIndex = 8;
            btn_score.Text = "Kết quả học tập";
            btn_score.UseVisualStyleBackColor = false;
            btn_score.Click += btn_score_Click;
            // 
            // btn_schedule
            // 
            btn_schedule.AutoSize = true;
            btn_schedule.BackColor = Color.FromArgb(112, 146, 190);
            btn_schedule.Dock = DockStyle.Top;
            btn_schedule.FlatAppearance.BorderSize = 0;
            btn_schedule.FlatStyle = FlatStyle.Flat;
            btn_schedule.Font = new Font("Segoe UI", 10F);
            btn_schedule.ForeColor = SystemColors.ControlLightLight;
            btn_schedule.Location = new Point(0, 107);
            btn_schedule.Margin = new Padding(0);
            btn_schedule.Name = "btn_schedule";
            btn_schedule.Size = new Size(206, 60);
            btn_schedule.TabIndex = 6;
            btn_schedule.Text = "Thời khóa biểu";
            btn_schedule.UseVisualStyleBackColor = false;
            btn_schedule.Click += btn_schedule_Click;
            // 
            // btn_info
            // 
            btn_info.BackColor = Color.FromArgb(112, 146, 190);
            btn_info.Dock = DockStyle.Top;
            btn_info.FlatAppearance.BorderSize = 0;
            btn_info.FlatStyle = FlatStyle.Flat;
            btn_info.Font = new Font("Segoe UI", 10F);
            btn_info.ForeColor = SystemColors.ButtonHighlight;
            btn_info.Location = new Point(0, 47);
            btn_info.Margin = new Padding(0);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(206, 60);
            btn_info.TabIndex = 7;
            btn_info.Text = "Thông tin cá nhân";
            btn_info.UseVisualStyleBackColor = false;
            btn_info.Click += btn_info_Click_1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 47);
            panel1.TabIndex = 0;
            // 
            // panelChildBox
            // 
            panelChildBox.BackColor = Color.AliceBlue;
            panelChildBox.Dock = DockStyle.Fill;
            panelChildBox.Location = new Point(206, 0);
            panelChildBox.Margin = new Padding(0);
            panelChildBox.Name = "panelChildBox";
            panelChildBox.Size = new Size(847, 560);
            panelChildBox.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6428566F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.35714F));
            tableLayoutPanel1.Controls.Add(panel_content, 0, 0);
            tableLayoutPanel1.Controls.Add(panelChildBox, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1053, 560);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // StudentAll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1053, 560);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentAll";
            Text = "Sinh viên Dashboard";
            panel_content.ResumeLayout(false);
            panel_content.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);


        }

        #endregion

        private Panel panel_content;
        private Button btn_exit;
        private Button btn_info;
        private Button btn_fee;
        private Button btn_schedule;
        private Button btn_score;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelChildBox;
    }
}