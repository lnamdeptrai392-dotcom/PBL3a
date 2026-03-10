namespace PBL3a.UI.Teacher
{
    partial class QuanLyChungT
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.6012039F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.3987961F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 491F));
            tableLayoutPanel1.Controls.Add(button6, 2, 1);
            tableLayoutPanel1.Controls.Add(button5, 1, 1);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Font = new Font("Segoe UI", 11.1428576F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1490, 786);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Left;
            button6.Font = new Font("Segoe UI", 11.1428576F);
            button6.Location = new Point(1001, 485);
            button6.Name = "button6";
            button6.Size = new Size(315, 208);
            button6.TabIndex = 5;
            button6.Text = "Thoát";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Font = new Font("Segoe UI", 11.1428576F);
            button5.Location = new Point(585, 485);
            button5.Name = "button5";
            button5.Size = new Size(332, 208);
            button5.TabIndex = 4;
            button5.Text = "Thu nhập";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Right;
            button4.Font = new Font("Segoe UI", 11.1428576F);
            button4.Location = new Point(170, 485);
            button4.Name = "button4";
            button4.Size = new Size(332, 208);
            button4.TabIndex = 3;
            button4.Text = "Tài liệu";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.Font = new Font("Segoe UI", 11.1428576F);
            button3.Location = new Point(1001, 92);
            button3.Name = "button3";
            button3.Size = new Size(315, 208);
            button3.TabIndex = 2;
            button3.Text = "Nhập điểm và nhận xét";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 11.1428576F);
            button2.Location = new Point(585, 92);
            button2.Name = "button2";
            button2.Size = new Size(332, 208);
            button2.TabIndex = 1;
            button2.Text = "Thời khóa biểu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 11.1428576F);
            button1.Location = new Point(170, 92);
            button1.Name = "button1";
            button1.Size = new Size(332, 208);
            button1.TabIndex = 0;
            button1.Text = "Thông tin cá nhân";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // QuanLyChungT
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 786);
            Controls.Add(tableLayoutPanel1);
            Name = "QuanLyChungT";
            Text = "QuanLyChungT";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}