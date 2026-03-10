namespace PBL3a.UI.AdminTC
{
    partial class KhoanChi
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
            LaKC = new Label();
            lbThang = new Label();
            lbNam = new Label();
            lbTT = new Label();
            btOK = new Button();
            btT = new Button();
            listView1 = new ListView();
            tbNam = new TextBox();
            tbKT = new TextBox();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.783783F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.21622F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 357F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 444F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Controls.Add(LaKC, 0, 0);
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
            tableLayoutPanel1.Size = new Size(1522, 819);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // LaKC
            // 
            LaKC.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaKC, 8);
            LaKC.Dock = DockStyle.Fill;
            LaKC.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaKC.Location = new Point(3, 0);
            LaKC.Name = "LaKC";
            LaKC.Size = new Size(1516, 149);
            LaKC.TabIndex = 2;
            LaKC.Text = "QUẢN LÝ KHOẢN CHI";
            LaKC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbThang
            // 
            lbThang.AutoSize = true;
            lbThang.Dock = DockStyle.Right;
            lbThang.Font = new Font("Segoe UI", 12F);
            lbThang.Location = new Point(128, 149);
            lbThang.Name = "lbThang";
            lbThang.Size = new Size(100, 37);
            lbThang.TabIndex = 3;
            lbThang.Text = "Tháng:";
            // 
            // lbNam
            // 
            lbNam.AutoSize = true;
            lbNam.Dock = DockStyle.Right;
            lbNam.Font = new Font("Segoe UI", 12F);
            lbNam.Location = new Point(685, 149);
            lbNam.Name = "lbNam";
            lbNam.Size = new Size(82, 37);
            lbNam.TabIndex = 4;
            lbNam.Text = "Năm:";
            // 
            // lbTT
            // 
            lbTT.AutoSize = true;
            lbTT.Dock = DockStyle.Right;
            lbTT.Font = new Font("Segoe UI", 12F);
            lbTT.Location = new Point(64, 732);
            lbTT.Name = "lbTT";
            lbTT.Size = new Size(164, 58);
            lbTT.TabIndex = 5;
            lbTT.Text = "Tổng khoản thu:";
            // 
            // btOK
            // 
            btOK.Dock = DockStyle.Bottom;
            btOK.Font = new Font("Segoe UI", 12F);
            btOK.Location = new Point(1279, 517);
            btOK.Name = "btOK";
            btOK.Size = new Size(194, 74);
            btOK.TabIndex = 6;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 12F);
            btT.Location = new Point(1279, 623);
            btT.Name = "btT";
            btT.Size = new Size(194, 74);
            btT.TabIndex = 7;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // listView1
            // 
            tableLayoutPanel1.SetColumnSpan(listView1, 4);
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(58, 209);
            listView1.Name = "listView1";
            tableLayoutPanel1.SetRowSpan(listView1, 3);
            listView1.Size = new Size(1153, 488);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tbNam
            // 
            tbNam.Dock = DockStyle.Top;
            tbNam.Location = new Point(773, 152);
            tbNam.Name = "tbNam";
            tbNam.Size = new Size(438, 35);
            tbNam.TabIndex = 10;
            // 
            // tbKT
            // 
            tableLayoutPanel1.SetColumnSpan(tbKT, 3);
            tbKT.Dock = DockStyle.Top;
            tbKT.Enabled = false;
            tbKT.Location = new Point(234, 735);
            tbKT.Name = "tbKT";
            tbKT.Size = new Size(977, 35);
            tbKT.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new Point(234, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(351, 38);
            comboBox1.TabIndex = 12;
            // 
            // KhoanChi
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 819);
            Controls.Add(tableLayoutPanel1);
            Name = "KhoanChi";
            Text = "KhoanChi";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label LaKC;
        private Label lbThang;
        private Label lbNam;
        private Label lbTT;
        private Button btOK;
        private Button btT;
        private ListView listView1;
        private TextBox tbNam;
        private TextBox tbKT;
        private ComboBox comboBox1;
    }
}