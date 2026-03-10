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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbKT = new TextBox();
            tbNam = new TextBox();
            listView1 = new ListView();
            btT = new Button();
            btOK = new Button();
            lbTT = new Label();
            lbNam = new Label();
            lbThang = new Label();
            LaKT = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbKT
            // 
            tableLayoutPanel1.SetColumnSpan(tbKT, 3);
            tbKT.Dock = DockStyle.Top;
            tbKT.Enabled = false;
            tbKT.Location = new Point(235, 742);
            tbKT.Name = "tbKT";
            tbKT.Size = new Size(1014, 35);
            tbKT.TabIndex = 11;
            // 
            // tbNam
            // 
            tbNam.Dock = DockStyle.Top;
            tbNam.Location = new Point(811, 158);
            tbNam.Name = "tbNam";
            tbNam.Size = new Size(438, 35);
            tbNam.TabIndex = 10;
            // 
            // listView1
            // 
            tableLayoutPanel1.SetColumnSpan(listView1, 4);
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(53, 216);
            listView1.Name = "listView1";
            tableLayoutPanel1.SetRowSpan(listView1, 3);
            listView1.Size = new Size(1196, 488);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 12F);
            btT.Location = new Point(1319, 630);
            btT.Name = "btT";
            btT.Size = new Size(189, 74);
            btT.TabIndex = 7;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // btOK
            // 
            btOK.Dock = DockStyle.Bottom;
            btOK.Font = new Font("Segoe UI", 12F);
            btOK.Location = new Point(1319, 524);
            btOK.Name = "btOK";
            btOK.Size = new Size(189, 74);
            btOK.TabIndex = 6;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            // 
            // lbTT
            // 
            lbTT.AutoSize = true;
            lbTT.Dock = DockStyle.Right;
            lbTT.Font = new Font("Segoe UI", 12F);
            lbTT.Location = new Point(57, 739);
            lbTT.Name = "lbTT";
            lbTT.Size = new Size(172, 58);
            lbTT.TabIndex = 5;
            lbTT.Text = "Tổng khoản thu:";
            // 
            // lbNam
            // 
            lbNam.AutoSize = true;
            lbNam.Dock = DockStyle.Right;
            lbNam.Font = new Font("Segoe UI", 12F);
            lbNam.Location = new Point(723, 155);
            lbNam.Name = "lbNam";
            lbNam.Size = new Size(82, 38);
            lbNam.TabIndex = 4;
            lbNam.Text = "Năm:";
            // 
            // lbThang
            // 
            lbThang.AutoSize = true;
            lbThang.Dock = DockStyle.Right;
            lbThang.Font = new Font("Segoe UI", 12F);
            lbThang.Location = new Point(129, 155);
            lbThang.Name = "lbThang";
            lbThang.Size = new Size(100, 38);
            lbThang.TabIndex = 3;
            lbThang.Text = "Tháng:";
            // 
            // LaKT
            // 
            LaKT.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaKT, 8);
            LaKT.Dock = DockStyle.Fill;
            LaKT.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaKT.Location = new Point(3, 0);
            LaKT.Name = "LaKT";
            LaKT.Size = new Size(1551, 155);
            LaKT.TabIndex = 2;
            LaKT.Text = "QUẢN LÝ KHOẢN THU";
            LaKT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4899712F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.510025F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 394F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 444F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 195F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Controls.Add(LaKT, 0, 0);
            tableLayoutPanel1.Controls.Add(lbThang, 1, 1);
            tableLayoutPanel1.Controls.Add(lbNam, 3, 1);
            tableLayoutPanel1.Controls.Add(lbTT, 1, 7);
            tableLayoutPanel1.Controls.Add(btOK, 6, 4);
            tableLayoutPanel1.Controls.Add(btT, 6, 5);
            tableLayoutPanel1.Controls.Add(listView1, 1, 3);
            tableLayoutPanel1.Controls.Add(tbNam, 4, 1);
            tableLayoutPanel1.Controls.Add(tbKT, 2, 7);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 262F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(1557, 826);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new Point(235, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(388, 38);
            comboBox1.TabIndex = 12;
            // 
            // KhoanThu
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 826);
            Controls.Add(tableLayoutPanel1);
            Name = "KhoanThu";
            Text = "KhoanThu";
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
        private ListView listView1;
        private TextBox tbNam;
        private ComboBox comboBox1;
    }
}