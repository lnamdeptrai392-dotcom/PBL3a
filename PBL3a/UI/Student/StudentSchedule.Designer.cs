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
            label2 = new Label();
            cbbWeekPick = new ComboBox();
            dgvSchedule = new DataGridView();
            btnChange = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4345551F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.5654449F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(cbbWeekPick, 1, 1);
            tableLayoutPanel1.Controls.Add(dgvSchedule, 1, 3);
            tableLayoutPanel1.Controls.Add(btnChange, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.363636F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.636364F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 281F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(333, 10);
            label1.Name = "label1";
            label1.Size = new Size(193, 31);
            label1.TabIndex = 0;
            label1.Text = "THỜI KHÓA BIỂU";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(34, 59);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 1;
            label2.Text = "Tháng";
            // 
            // cbbWeekPick
            // 
            cbbWeekPick.Anchor = AnchorStyles.Left;
            cbbWeekPick.FormattingEnabled = true;
            cbbWeekPick.Location = new Point(98, 56);
            cbbWeekPick.Name = "cbbWeekPick";
            cbbWeekPick.Size = new Size(151, 28);
            cbbWeekPick.TabIndex = 2;
            // 
            // dgvSchedule
            // 
            dgvSchedule.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.Location = new Point(98, 131);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.Size = new Size(663, 275);
            dgvSchedule.TabIndex = 3;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(98, 93);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(98, 29);
            btnChange.TabIndex = 4;
            btnChange.Text = "Tìm kiếm";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // StudentSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "StudentSchedule";
            Text = "StudentSchedule";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private ComboBox cbbWeekPick;
        private DataGridView dgvSchedule;
        private Button btnChange;
    }
}