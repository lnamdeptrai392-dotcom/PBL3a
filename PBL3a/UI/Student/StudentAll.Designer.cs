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
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
<<<<<<< Updated upstream
            button6 = new Button();
            button2 = new Button();
=======
            btn_exit = new Button();
            btn_material = new Button();
            panel_content = new Panel();
>>>>>>> Stashed changes
            tableLayoutPanel1.SuspendLayout();
            panel_content.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
<<<<<<< Updated upstream
            button1.Anchor = AnchorStyles.Right;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.Location = new Point(42, 277);
            button1.Name = "button1";
            button1.Size = new Size(206, 120);
            button1.TabIndex = 4;
            button1.Text = "Học phí";
            button1.UseVisualStyleBackColor = true;
=======
            btn_fee.Anchor = AnchorStyles.Right;
            btn_fee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_fee.Location = new Point(43, 277);
            btn_fee.Name = "btn_fee";
            btn_fee.Size = new Size(206, 120);
            btn_fee.TabIndex = 4;
            btn_fee.Text = "Học phí";
            btn_fee.UseVisualStyleBackColor = true;
            btn_fee.Click += btn_fee_Click;
>>>>>>> Stashed changes
            // 
            // button3
            // 
<<<<<<< Updated upstream
            button3.Anchor = AnchorStyles.Left;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button3.Location = new Point(544, 52);
            button3.Name = "button3";
            button3.Size = new Size(206, 120);
            button3.TabIndex = 6;
            button3.Text = "Thời khóa biểu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
=======
            btn_schedule.Anchor = AnchorStyles.Left;
            btn_schedule.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_schedule.Location = new Point(545, 52);
            btn_schedule.Name = "btn_schedule";
            btn_schedule.Size = new Size(206, 120);
            btn_schedule.TabIndex = 6;
            btn_schedule.Text = "Thời khóa biểu";
            btn_schedule.UseVisualStyleBackColor = true;
            btn_schedule.Click += btn_schedule_Click;
>>>>>>> Stashed changes
            // 
            // button4
            // 
<<<<<<< Updated upstream
            button4.Anchor = AnchorStyles.Right;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button4.Location = new Point(42, 52);
            button4.Name = "button4";
            button4.Size = new Size(206, 120);
            button4.TabIndex = 7;
            button4.Text = "Thông tin cá nhân";
            button4.UseVisualStyleBackColor = true;
=======
            btn_info.Anchor = AnchorStyles.Right;
            btn_info.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_info.Location = new Point(43, 52);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(206, 120);
            btn_info.TabIndex = 7;
            btn_info.Text = "Thông tin cá nhân";
            btn_info.UseVisualStyleBackColor = true;
            btn_info.Click += btn_info_Click;
>>>>>>> Stashed changes
            // 
            // button5
            // 
<<<<<<< Updated upstream
            button5.Anchor = AnchorStyles.None;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button5.Location = new Point(293, 52);
            button5.Name = "button5";
            button5.Size = new Size(206, 120);
            button5.TabIndex = 8;
            button5.Text = "Kết quả học tập";
            button5.UseVisualStyleBackColor = true;
=======
            btn_score.Anchor = AnchorStyles.None;
            btn_score.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_score.Location = new Point(294, 52);
            btn_score.Name = "btn_score";
            btn_score.Size = new Size(206, 120);
            btn_score.TabIndex = 8;
            btn_score.Text = "Kết quả học tập";
            btn_score.UseVisualStyleBackColor = true;
            btn_score.Click += btn_score_Click;
>>>>>>> Stashed changes
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.4455F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.5545F));
<<<<<<< Updated upstream
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 258F));
            tableLayoutPanel1.Controls.Add(button6, 2, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 1);
            tableLayoutPanel1.Controls.Add(button5, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button4, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
=======
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 257F));
            tableLayoutPanel1.Controls.Add(btn_exit, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_material, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_score, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_schedule, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_info, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_fee, 0, 1);
>>>>>>> Stashed changes
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // button6
            // 
<<<<<<< Updated upstream
            button6.Anchor = AnchorStyles.Left;
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button6.Location = new Point(544, 277);
            button6.Name = "button6";
            button6.Size = new Size(206, 120);
            button6.TabIndex = 11;
            button6.Text = "Đăng xuất";
            button6.UseVisualStyleBackColor = true;
=======
            btn_exit.Anchor = AnchorStyles.Left;
            btn_exit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_exit.Location = new Point(545, 277);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(206, 120);
            btn_exit.TabIndex = 11;
            btn_exit.Text = "Đăng xuất";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
>>>>>>> Stashed changes
            // 
            // button2
            // 
<<<<<<< Updated upstream
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button2.Location = new Point(293, 277);
            button2.Name = "button2";
            button2.Size = new Size(206, 120);
            button2.TabIndex = 10;
            button2.Text = "Tài liệu";
            button2.UseVisualStyleBackColor = true;
=======
            btn_material.Anchor = AnchorStyles.None;
            btn_material.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_material.Location = new Point(294, 277);
            btn_material.Name = "btn_material";
            btn_material.Size = new Size(206, 120);
            btn_material.TabIndex = 10;
            btn_material.Text = "Tài liệu";
            btn_material.UseVisualStyleBackColor = true;
            btn_material.Click += btn_material_Click;
>>>>>>> Stashed changes
            // 
            // panel_content
            // 
            panel_content.Controls.Add(tableLayoutPanel1);
            panel_content.Dock = DockStyle.Fill;
            panel_content.Location = new Point(0, 0);
            panel_content.Name = "panel_content";
            panel_content.Size = new Size(800, 450);
            panel_content.TabIndex = 11;
            // 
            // StudentAll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_content);
            Name = "StudentAll";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            panel_content.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
<<<<<<< Updated upstream
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button6;
        private Button button2;
=======
        private Button btn_fee;
        private Button btn_schedule;
        private Button btn_info;
        private Button btn_score;
        private Button btn_exit;
        private Button btn_material;
        private Panel panel_content;
        public TableLayoutPanel tableLayoutPanel1;
>>>>>>> Stashed changes
    }
}