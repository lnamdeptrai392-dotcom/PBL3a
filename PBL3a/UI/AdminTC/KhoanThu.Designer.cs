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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            LaKC = new Label();
            lbThang = new Label();
            lbNam = new Label();
            lbTT = new Label();
            dataGridView1 = new DataGridView();
            tbNam = new TextBox();
            tbKT = new TextBox();
            comboBox1 = new ComboBox();
            btOK = new Button();
            butT = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.783783F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.21622F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 424F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 444F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 201F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Controls.Add(LaKC, 0, 0);
            tableLayoutPanel1.Controls.Add(lbThang, 1, 1);
            tableLayoutPanel1.Controls.Add(lbNam, 3, 1);
            tableLayoutPanel1.Controls.Add(lbTT, 1, 7);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 3);
            tableLayoutPanel1.Controls.Add(tbNam, 4, 1);
            tableLayoutPanel1.Controls.Add(tbKT, 2, 7);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(btOK, 6, 5);
            tableLayoutPanel1.Controls.Add(butT, 6, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 262F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(1690, 901);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // LaKC
            // 
            LaKC.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaKC, 8);
            LaKC.Dock = DockStyle.Fill;
            LaKC.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaKC.ForeColor = Color.Black;
            LaKC.Location = new Point(3, 0);
            LaKC.Name = "LaKC";
            LaKC.Size = new Size(1684, 215);
            LaKC.TabIndex = 2;
            LaKC.Text = "QUẢN LÝ KHOẢN THU";
            LaKC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbThang
            // 
            lbThang.AutoSize = true;
            lbThang.Dock = DockStyle.Right;
            lbThang.Font = new Font("Segoe UI", 12F);
            lbThang.ForeColor = Color.Black;
            lbThang.Location = new Point(223, 215);
            lbThang.Name = "lbThang";
            lbThang.Size = new Size(100, 53);
            lbThang.TabIndex = 3;
            lbThang.Text = "Tháng:";
            // 
            // lbNam
            // 
            lbNam.AutoSize = true;
            lbNam.Dock = DockStyle.Right;
            lbNam.Font = new Font("Segoe UI", 12F);
            lbNam.ForeColor = Color.Black;
            lbNam.Location = new Point(847, 215);
            lbNam.Name = "lbNam";
            lbNam.Size = new Size(82, 53);
            lbNam.TabIndex = 4;
            lbNam.Text = "Năm:";
            // 
            // lbTT
            // 
            lbTT.AutoSize = true;
            lbTT.Dock = DockStyle.Right;
            lbTT.Font = new Font("Segoe UI", 12F);
            lbTT.ForeColor = Color.Black;
            lbTT.Location = new Point(104, 809);
            lbTT.Name = "lbTT";
            lbTT.Size = new Size(219, 83);
            lbTT.TabIndex = 5;
            lbTT.Text = "Tổng khoản thu:";
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
            dataGridView1.Location = new Point(80, 292);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 3);
            dataGridView1.Size = new Size(1293, 486);
            dataGridView1.TabIndex = 8;
            // 
            // tbNam
            // 
            tbNam.Dock = DockStyle.Top;
            tbNam.Location = new Point(935, 219);
            tbNam.Margin = new Padding(3, 4, 3, 4);
            tbNam.Name = "tbNam";
            tbNam.Size = new Size(438, 35);
            tbNam.TabIndex = 10;
            // 
            // tbKT
            // 
            tableLayoutPanel1.SetColumnSpan(tbKT, 3);
            tbKT.Dock = DockStyle.Top;
            tbKT.Enabled = false;
            tbKT.Location = new Point(329, 813);
            tbKT.Margin = new Padding(3, 4, 3, 4);
            tbKT.Name = "tbKT";
            tbKT.Size = new Size(1044, 35);
            tbKT.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new Point(329, 219);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(418, 38);
            comboBox1.TabIndex = 12;
            // 
            // btOK
            // 
            btOK.BackColor = Color.FromArgb(112, 146, 190);
            btOK.Dock = DockStyle.Bottom;
            btOK.Font = new Font("Segoe UI", 12F);
            btOK.ForeColor = Color.White;
            btOK.Location = new Point(1441, 704);
            btOK.Margin = new Padding(3, 4, 3, 4);
            btOK.Name = "btOK";
            btOK.Size = new Size(195, 74);
            btOK.TabIndex = 6;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = false;
            btOK.Click += btOK_Click;
            btOK.MouseEnter += btOK_MouseEnter;
            btOK.MouseLeave += btOK_MouseLeave;
            // 
            // butT
            // 
            butT.BackColor = Color.FromArgb(112, 146, 190);
            butT.Dock = DockStyle.Bottom;
            butT.Font = new Font("Segoe UI", 12F);
            butT.ForeColor = Color.White;
            butT.Location = new Point(1441, 814);
            butT.Margin = new Padding(3, 4, 3, 4);
            butT.Name = "butT";
            butT.Size = new Size(195, 74);
            butT.TabIndex = 13;
            butT.Text = "Thoát";
            butT.UseVisualStyleBackColor = false;
            butT.Click += butT_Click;
            butT.MouseEnter += btOK_MouseEnter;
            butT.MouseLeave += btOK_MouseLeave;
            // 
            // KhoanThu
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1690, 901);
            Controls.Add(tableLayoutPanel1);
            Name = "KhoanThu";
            Text = "KhoanThu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label LaKC;
        private Label lbThang;
        private Label lbNam;
        private Label lbTT;
        private DataGridView dataGridView1;
        private TextBox tbNam;
        private TextBox tbKT;
        private ComboBox comboBox1;
        private Button btOK;
        private Button butT;
    }
}