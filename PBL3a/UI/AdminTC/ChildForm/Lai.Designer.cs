namespace PBL3a.UI.AdminTC
{
    partial class Lai
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
            LaLS = new Label();
            lbThang = new Label();
            lbNam = new Label();
            lbTT = new Label();
            btT = new Button();
            dataGridView1 = new DataGridView();
            tbNam = new TextBox();
            tbKT = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btOK = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LaLS
            // 
            LaLS.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaLS, 8);
            LaLS.Dock = DockStyle.Fill;
            LaLS.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaLS.ForeColor = Color.Black;
            LaLS.Location = new Point(2, 0);
            LaLS.Margin = new Padding(2, 0, 2, 0);
            LaLS.Name = "LaLS";
            LaLS.Size = new Size(982, 106);
            LaLS.TabIndex = 2;
            LaLS.Text = "LÃI SUẤT";
            LaLS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbThang
            // 
            lbThang.AutoSize = true;
            lbThang.Dock = DockStyle.Right;
            lbThang.Font = new Font("Segoe UI", 12F);
            lbThang.ForeColor = Color.Black;
            lbThang.Location = new Point(44, 106);
            lbThang.Margin = new Padding(2, 0, 2, 0);
            lbThang.Name = "lbThang";
            lbThang.Size = new Size(56, 26);
            lbThang.TabIndex = 3;
            lbThang.Text = "Tháng:";
            // 
            // lbNam
            // 
            lbNam.AutoSize = true;
            lbNam.Dock = DockStyle.Right;
            lbNam.Font = new Font("Segoe UI", 12F);
            lbNam.ForeColor = Color.Black;
            lbNam.Location = new Point(458, 106);
            lbNam.Margin = new Padding(2, 0, 2, 0);
            lbNam.Name = "lbNam";
            lbNam.Size = new Size(47, 26);
            lbNam.TabIndex = 4;
            lbNam.Text = "Năm:";
            // 
            // lbTT
            // 
            lbTT.AutoSize = true;
            lbTT.Dock = DockStyle.Right;
            lbTT.Font = new Font("Segoe UI", 12F);
            lbTT.ForeColor = Color.Black;
            lbTT.Location = new Point(52, 397);
            lbTT.Margin = new Padding(2, 0, 2, 0);
            lbTT.Name = "lbTT";
            lbTT.Size = new Size(48, 42);
            lbTT.TabIndex = 5;
            lbTT.Text = "Tổng:";
            // 
            // btT
            // 
            btT.BackColor = Color.FromArgb(112, 146, 190);
            btT.Font = new Font("Segoe UI", 12F);
            btT.ForeColor = Color.White;
            btT.Location = new Point(846, 399);
            btT.Margin = new Padding(2);
            btT.Name = "btT";
            btT.Size = new Size(110, 37);
            btT.TabIndex = 7;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = false;
            btT.Click += btT_Click;
            btT.MouseEnter += btT_MouseEnter;
            btT.MouseLeave += btT_MouseLeave;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 4);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(26, 144);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 3);
            dataGridView1.Size = new Size(792, 243);
            dataGridView1.TabIndex = 8;
            // 
            // tbNam
            // 
            tbNam.Dock = DockStyle.Top;
            tbNam.Location = new Point(509, 108);
            tbNam.Margin = new Padding(2);
            tbNam.Name = "tbNam";
            tbNam.Size = new Size(309, 23);
            tbNam.TabIndex = 10;
            // 
            // tbKT
            // 
            tableLayoutPanel1.SetColumnSpan(tbKT, 3);
            tbKT.Dock = DockStyle.Top;
            tbKT.Enabled = false;
            tbKT.Location = new Point(104, 399);
            tbKT.Margin = new Padding(2);
            tbKT.Name = "tbKT";
            tbKT.Size = new Size(714, 23);
            tbKT.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.3226833F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.6773148F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 246F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 159F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 313F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Controls.Add(btOK, 6, 5);
            tableLayoutPanel1.Controls.Add(LaLS, 0, 0);
            tableLayoutPanel1.Controls.Add(lbThang, 1, 1);
            tableLayoutPanel1.Controls.Add(lbNam, 3, 1);
            tableLayoutPanel1.Controls.Add(lbTT, 1, 7);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 3);
            tableLayoutPanel1.Controls.Add(tbNam, 4, 1);
            tableLayoutPanel1.Controls.Add(tbKT, 2, 7);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(btT, 6, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(986, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btOK
            // 
            btOK.BackColor = Color.FromArgb(112, 146, 190);
            btOK.Font = new Font("Segoe UI", 12F);
            btOK.ForeColor = Color.White;
            btOK.Location = new Point(846, 338);
            btOK.Margin = new Padding(2);
            btOK.Name = "btOK";
            btOK.Size = new Size(110, 37);
            btOK.TabIndex = 7;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = false;
            btOK.Click += btOK_Click;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new Point(104, 108);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 23);
            comboBox1.TabIndex = 12;
            // 
            // Lai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(986, 450);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "Lai";
            Text = "Lai";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LaLS;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbThang;
        private Label lbNam;
        private Label lbTT;
        private Button btT;
        private DataGridView dataGridView1;
        private TextBox tbNam;
        private TextBox tbKT;
        private ComboBox comboBox1;
        private Button btOK;
    }
}