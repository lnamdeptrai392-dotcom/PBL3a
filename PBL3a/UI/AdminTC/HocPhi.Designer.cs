namespace PBL3a.UI.AdminTC
{
    partial class HocPhi
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbTL = new TextBox();
            laML = new Label();
            laTL = new Label();
            cbbML = new ComboBox();
            btSetHP = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 382F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 218F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Controls.Add(tbTL, 6, 1);
            tableLayoutPanel1.Controls.Add(laML, 3, 1);
            tableLayoutPanel1.Controls.Add(laTL, 5, 1);
            tableLayoutPanel1.Controls.Add(cbbML, 4, 1);
            tableLayoutPanel1.Controls.Add(btSetHP, 8, 6);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.Coral;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.375F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 226F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1481, 824);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tbTL
            // 
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(831, 86);
            tbTL.Margin = new Padding(3, 4, 3, 4);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(376, 35);
            tbTL.TabIndex = 4;
            // 
            // laML
            // 
            laML.Dock = DockStyle.Right;
            laML.Font = new Font("Segoe UI", 9.857143F);
            laML.ForeColor = Color.Black;
            laML.Location = new Point(381, 82);
            laML.Name = "laML";
            laML.Size = new Size(103, 119);
            laML.TabIndex = 1;
            laML.Text = "Mã Lớp: ";
            // 
            // laTL
            // 
            laTL.Dock = DockStyle.Right;
            laTL.Font = new Font("Segoe UI", 9.857143F);
            laTL.ForeColor = Color.Black;
            laTL.Location = new Point(715, 82);
            laTL.Name = "laTL";
            laTL.Size = new Size(110, 119);
            laTL.TabIndex = 2;
            laTL.Text = "Tên Lớp: ";
            // 
            // cbbML
            // 
            cbbML.Dock = DockStyle.Fill;
            cbbML.FormattingEnabled = true;
            cbbML.Location = new Point(490, 86);
            cbbML.Margin = new Padding(3, 4, 3, 4);
            cbbML.Name = "cbbML";
            cbbML.Size = new Size(218, 38);
            cbbML.TabIndex = 9;
            // 
            // btSetHP
            // 
            btSetHP.BackColor = Color.FromArgb(112, 146, 190);
            btSetHP.Font = new Font("Segoe UI", 9.857143F);
            btSetHP.ForeColor = Color.White;
            btSetHP.Location = new Point(1232, 707);
            btSetHP.Margin = new Padding(3, 4, 3, 4);
            btSetHP.Name = "btSetHP";
            btSetHP.Size = new Size(207, 90);
            btSetHP.TabIndex = 5;
            btSetHP.Text = "Thiết lập học phí";
            btSetHP.UseVisualStyleBackColor = false;
            btSetHP.Click += btSetHP_Click;
            btSetHP.MouseEnter += btSetHP_MouseEnter;
            btSetHP.MouseLeave += btSetHP_MouseLeave;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 6);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Coral;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(26, 207);
            dataGridView1.Margin = new Padding(5, 6, 5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 5);
            dataGridView1.Size = new Size(1179, 590);
            dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.857143F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 82);
            label1.Name = "label1";
            label1.Size = new Size(103, 118);
            label1.TabIndex = 11;
            label1.Text = "Khóa: ";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Enabled = false;
            textBox1.Location = new Point(142, 86);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 35);
            textBox1.TabIndex = 12;
            // 
            // HocPhi
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1481, 824);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HocPhi";
            Text = "HocPhi";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbTL;
        private Label laML;
        private Label laTL;
        private Button btSetHP;
        private ComboBox cbbML;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
    }
}