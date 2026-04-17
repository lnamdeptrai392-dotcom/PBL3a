namespace PBL3a.UI.Student
{
    partial class StudentSchedule
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            cbbWeekPick = new ComboBox();
            btnChange = new Button();
            dgvSchedule = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.359173F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96.64082F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(dgvSchedule, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.47059F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.52941F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 349F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(804, 500);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 31);
            label1.TabIndex = 0;
            label1.Text = "THỜI KHÓA BIỂU";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbbWeekPick);
            panel1.Controls.Add(btnChange);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(29, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 80);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(31, 29);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 1;
            label2.Text = "Tháng";
            // 
            // cbbWeekPick
            // 
            cbbWeekPick.Anchor = AnchorStyles.Left;
            cbbWeekPick.FormattingEnabled = true;
            cbbWeekPick.Location = new Point(103, 27);
            cbbWeekPick.Name = "cbbWeekPick";
            cbbWeekPick.Size = new Size(119, 28);
            cbbWeekPick.TabIndex = 2;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(240, 10);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(98, 29);
            btnChange.TabIndex = 4;
            btnChange.Text = "Tìm kiếm";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // dgvSchedule
            // 
            dgvSchedule.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.Location = new Point(29, 138);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.Size = new Size(746, 343);
            dgvSchedule.TabIndex = 3;
            // 
            // StudentSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 500);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentSchedule";
            Text = "StudentSchedule";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private ComboBox cbbWeekPick;
        private Button btnChange;
        private Panel panel1;
        private DataGridView dgvSchedule;
    }
}