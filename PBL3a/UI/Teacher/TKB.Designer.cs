namespace PBL3a.UI.Teacher
{
    partial class TKB
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            listView1 = new ListView();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 163F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 413F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 357F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(button1, 5, 5);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 5, 2);
            tableLayoutPanel1.Controls.Add(listView1, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 4, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 249F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 198F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(1318, 750);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 7);
            label1.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(458, 24);
            label1.Name = "label1";
            label1.Size = new Size(402, 65);
            label1.TabIndex = 0;
            label1.Text = "THỜI KHÓA BIỂU ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.1428576F);
            label2.Location = new Point(65, 143);
            label2.Name = "label2";
            label2.Size = new Size(157, 37);
            label2.TabIndex = 1;
            label2.Text = "Mã lớp học: ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1037, 615);
            button1.Name = "button1";
            button1.Size = new Size(220, 99);
            button1.TabIndex = 3;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(228, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(407, 38);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Enabled = false;
            textBox1.Location = new Point(906, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(351, 35);
            textBox1.TabIndex = 5;
            // 
            // listView1
            // 
            tableLayoutPanel1.SetColumnSpan(listView1, 4);
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(65, 225);
            listView1.Name = "listView1";
            tableLayoutPanel1.SetRowSpan(listView1, 3);
            listView1.Size = new Size(835, 489);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.1428576F);
            label3.Location = new Point(706, 143);
            label3.Name = "label3";
            label3.Size = new Size(159, 37);
            label3.TabIndex = 2;
            label3.Text = "Tên lớp học:";
            // 
            // TKB
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 750);
            Controls.Add(tableLayoutPanel1);
            Name = "TKB";
            Text = "TKB";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private ListView listView1;
        private Label label3;
    }
}