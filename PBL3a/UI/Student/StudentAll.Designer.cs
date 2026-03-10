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
            btn_fee = new Button();
            btn_schedule = new Button();
            btn_info = new Button();
            btn_score = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_exit = new Button();
            btn_material = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_fee
            // 
            btn_fee.Anchor = AnchorStyles.Right;
            btn_fee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_fee.Location = new Point(42, 277);
            btn_fee.Name = "btn_fee";
            btn_fee.Size = new Size(206, 120);
            btn_fee.TabIndex = 4;
            btn_fee.Text = "Học phí";
            btn_fee.UseVisualStyleBackColor = true;
            btn_fee.Click += btn_fee_Click;
            // 
            // btn_schedule
            // 
            btn_schedule.Anchor = AnchorStyles.Left;
            btn_schedule.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_schedule.Location = new Point(544, 52);
            btn_schedule.Name = "btn_schedule";
            btn_schedule.Size = new Size(206, 120);
            btn_schedule.TabIndex = 6;
            btn_schedule.Text = "Thời khóa biểu";
            btn_schedule.UseVisualStyleBackColor = true;
            btn_schedule.Click += btn_schedule_Click;
            // 
            // btn_info
            // 
            btn_info.Anchor = AnchorStyles.Right;
            btn_info.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_info.Location = new Point(42, 52);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(206, 120);
            btn_info.TabIndex = 7;
            btn_info.Text = "Thông tin cá nhân";
            btn_info.UseVisualStyleBackColor = true;
            btn_info.Click += btn_info_Click;
            // 
            // btn_score
            // 
            btn_score.Anchor = AnchorStyles.None;
            btn_score.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_score.Location = new Point(293, 52);
            btn_score.Name = "btn_score";
            btn_score.Size = new Size(206, 120);
            btn_score.TabIndex = 8;
            btn_score.Text = "Kết quả học tập";
            btn_score.UseVisualStyleBackColor = true;
            btn_score.Click += btn_score_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.4455F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.5545F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 258F));
            tableLayoutPanel1.Controls.Add(btn_exit, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_material, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_score, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_schedule, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_info, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_fee, 0, 1);
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
            // btn_exit
            // 
            btn_exit.Anchor = AnchorStyles.Left;
            btn_exit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_exit.Location = new Point(544, 277);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(206, 120);
            btn_exit.TabIndex = 11;
            btn_exit.Text = "Đăng xuất";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_material
            // 
            btn_material.Anchor = AnchorStyles.None;
            btn_material.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_material.Location = new Point(293, 277);
            btn_material.Name = "btn_material";
            btn_material.Size = new Size(206, 120);
            btn_material.TabIndex = 10;
            btn_material.Text = "Tài liệu";
            btn_material.UseVisualStyleBackColor = true;
            btn_material.Click += btn_material_Click;
            // 
            // StudentAll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "StudentAll";
            Text = "Form1";
            Load += StudentAll_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_fee;
        private Button btn_schedule;
        private Button btn_info;
        private Button btn_score;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_exit;
        private Button btn_material;
    }
}