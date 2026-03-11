namespace PBL3a.UI.AdminTC
{
    partial class KhoanThu
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

        private void InitializeComponent()
        {
            tbKT = new TextBox();
            tbNam = new TextBox();
            dataGridView1 = new DataGridView();
            btT = new Button();
            btOK = new Button();
            lbTT = new Label();
            lbNam = new Label();
            lbThang = new Label();
            LaKT = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbKT
            // 
            tableLayoutPanel1.SetColumnSpan(tbKT, 3);
            tbKT.Dock = DockStyle.Top;
            tbKT.Enabled = false;
            tbKT.Location = new Point(155, 494);
            tbKT.Margin = new Padding(2, 2, 2, 2);
            tbKT.Name = "tbKT";
            tbKT.Size = new Size(676, 27);
            tbKT.TabIndex = 11;
            // 
            // tbNam
            // 
            tbNam.Dock = DockStyle.Top;
            tbNam.Location = new Point(539, 105);
            tbNam.Margin = new Padding(2, 2, 2, 2);
            tbNam.Name = "tbNam";
            tbNam.Size = new Size(292, 27);
            tbNam.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 4);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(35, 143);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 3);
            dataGridView1.Size = new Size(796, 326);
            dataGridView1.TabIndex = 8;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 12F);
            btT.Location = new Point(878, 420);
            btT.Margin = new Padding(2, 2, 2, 2);
            btT.Name = "btT";
            btT.Size = new Size(126, 49);
            btT.TabIndex = 7;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // btOK
            // 
            btOK.Dock = DockStyle.Bottom;
            btOK.Font = new Font("Segoe UI", 12F);
            btOK.Location = new Point(878, 349);
            btOK.Margin = new Padding(2, 2, 2, 2);
            btOK.Name = "btOK";
            btOK.Size = new Size(126, 49);
            btOK.TabIndex = 6;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // lbTT
            // 
            lbTT.AutoSize = true;
            lbTT.Dock = DockStyle.Right;
            lbTT.Font = new Font("Segoe UI", 12F);
            lbTT.Location = new Point(35, 492);
            lbTT.Margin = new Padding(2, 0, 2, 0);
            lbTT.Name = "lbTT";
            lbTT.Size = new Size(116, 39);
            lbTT.TabIndex = 5;
            lbTT.Text = "Tổng khoản thu:";
            // 
            // lbNam
            // 
            lbNam.AutoSize = true;
            lbNam.Dock = DockStyle.Right;
            lbNam.Font = new Font("Segoe UI", 12F);
            lbNam.Location = new Point(477, 103);
            lbNam.Margin = new Padding(2, 0, 2, 0);
            lbNam.Name = "lbNam";
            lbNam.Size = new Size(58, 25);
            lbNam.TabIndex = 4;
            lbNam.Text = "Năm:";
            // 
            // lbThang
            // 
            lbThang.AutoSize = true;
            lbThang.Dock = DockStyle.Right;
            lbThang.Font = new Font("Segoe UI", 12F);
            lbThang.Location = new Point(81, 103);
            lbThang.Margin = new Padding(2, 0, 2, 0);
            lbThang.Name = "lbThang";
            lbThang.Size = new Size(70, 25);
            lbThang.TabIndex = 3;
            lbThang.Text = "Tháng:";
            // 
            // LaKT
            // 
            LaKT.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaKT, 8);
            LaKT.Dock = DockStyle.Fill;
            LaKT.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaKT.Location = new Point(2, 0);
            LaKT.Margin = new Padding(2, 0, 2, 0);
            LaKT.Name = "LaKT";
            LaKT.Size = new Size(1034, 103);
            LaKT.TabIndex = 2;
            LaKT.Text = "QUẢN LÝ KHOẢN THU";
            LaKT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4899712F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.510025F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 263F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 296F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.Controls.Add(LaKT, 0, 0);
            tableLayoutPanel1.Controls.Add(lbThang, 1, 1);
            tableLayoutPanel1.Controls.Add(lbNam, 3, 1);
            tableLayoutPanel1.Controls.Add(lbTT, 1, 7);
            tableLayoutPanel1.Controls.Add(btOK, 6, 4);
            tableLayoutPanel1.Controls.Add(btT, 6, 5);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 3);
            tableLayoutPanel1.Controls.Add(tbNam, 4, 1);
            tableLayoutPanel1.Controls.Add(tbKT, 2, 7);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.Size = new Size(1038, 551);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new Point(155, 105);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(259, 28);
            comboBox1.TabIndex = 12;
            // 
            // KhoanThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 551);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "KhoanThu";
            Text = "KhoanThu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbKT;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LaKT;
        private Label lbThang;
        private Label lbNam;
        private Label lbTT;
        private Button btOK;
        private Button btT;
        private DataGridView dataGridView1;
        private TextBox tbNam;
        private ComboBox comboBox1;
    }
}