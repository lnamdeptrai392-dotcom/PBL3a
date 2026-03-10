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
            tableLayoutPanel1 = new TableLayoutPanel();
            tbTL = new TextBox();
            LaHP = new Label();
            laML = new Label();
            laTL = new Label();
            tbML = new TextBox();
            btT = new Button();
            btCheckHP = new Button();
            btSetHP = new Button();
            listView1 = new ListView();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.8125954F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.1874F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 277F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.Controls.Add(tbTL, 4, 1);
            tableLayoutPanel1.Controls.Add(LaHP, 1, 0);
            tableLayoutPanel1.Controls.Add(laML, 1, 1);
            tableLayoutPanel1.Controls.Add(laTL, 3, 1);
            tableLayoutPanel1.Controls.Add(tbML, 2, 1);
            tableLayoutPanel1.Controls.Add(btT, 6, 6);
            tableLayoutPanel1.Controls.Add(btCheckHP, 6, 5);
            tableLayoutPanel1.Controls.Add(btSetHP, 6, 4);
            tableLayoutPanel1.Controls.Add(listView1, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.Size = new Size(1022, 533);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tbTL
            // 
            tableLayoutPanel1.SetColumnSpan(tbTL, 2);
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(534, 83);
            tbTL.Margin = new Padding(2);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(301, 27);
            tbTL.TabIndex = 4;
            // 
            // LaHP
            // 
            LaHP.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaHP, 6);
            LaHP.Dock = DockStyle.Fill;
            LaHP.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaHP.Location = new Point(15, 0);
            LaHP.Margin = new Padding(2, 0, 2, 0);
            LaHP.Name = "LaHP";
            LaHP.Size = new Size(990, 81);
            LaHP.TabIndex = 0;
            LaHP.Text = "QUẢN LÝ HỌC PHÍ";
            LaHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laML
            // 
            laML.AutoSize = true;
            laML.Dock = DockStyle.Right;
            laML.Font = new Font("Segoe UI", 12F);
            laML.Location = new Point(16, 81);
            laML.Margin = new Padding(2, 0, 2, 0);
            laML.Name = "laML";
            laML.Size = new Size(82, 36);
            laML.TabIndex = 1;
            laML.Text = "Mã Lớp: ";
            // 
            // laTL
            // 
            laTL.AutoSize = true;
            laTL.Dock = DockStyle.Right;
            laTL.Font = new Font("Segoe UI", 12F);
            laTL.Location = new Point(442, 81);
            laTL.Margin = new Padding(2, 0, 2, 0);
            laTL.Name = "laTL";
            laTL.Size = new Size(88, 36);
            laTL.TabIndex = 2;
            laTL.Text = "Tên Lớp: ";
            // 
            // tbML
            // 
            tbML.Dock = DockStyle.Fill;
            tbML.Location = new Point(102, 83);
            tbML.Margin = new Padding(2);
            tbML.Name = "tbML";
            tbML.Size = new Size(307, 27);
            tbML.TabIndex = 3;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 9.857143F);
            btT.Location = new Point(839, 465);
            btT.Margin = new Padding(2);
            btT.Name = "btT";
            btT.Size = new Size(166, 51);
            btT.TabIndex = 7;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // btCheckHP
            // 
            btCheckHP.Dock = DockStyle.Bottom;
            btCheckHP.Font = new Font("Segoe UI", 9.857143F);
            btCheckHP.Location = new Point(839, 399);
            btCheckHP.Margin = new Padding(2);
            btCheckHP.Name = "btCheckHP";
            btCheckHP.Size = new Size(166, 51);
            btCheckHP.TabIndex = 6;
            btCheckHP.Text = "Kiểm tra tình trạng";
            btCheckHP.UseVisualStyleBackColor = true;
            // 
            // btSetHP
            // 
            btSetHP.Dock = DockStyle.Bottom;
            btSetHP.Font = new Font("Segoe UI", 9.857143F);
            btSetHP.Location = new Point(839, 330);
            btSetHP.Margin = new Padding(2);
            btSetHP.Name = "btSetHP";
            btSetHP.Size = new Size(166, 51);
            btSetHP.TabIndex = 5;
            btSetHP.Text = "Thiết lập học phí";
            btSetHP.UseVisualStyleBackColor = true;
            btSetHP.Click += btSetHP_Click;
            // 
            // listView1
            // 
            tableLayoutPanel1.SetColumnSpan(listView1, 4);
            listView1.Location = new Point(15, 139);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            tableLayoutPanel1.SetRowSpan(listView1, 4);
            listView1.Size = new Size(792, 377);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // HocPhi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 533);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "HocPhi";
            Text = "HocPhi";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label LaHP;
        private TextBox tbTL;
        private Label laML;
        private Label laTL;
        private TextBox tbML;
        private ListView listView1;
        private Button btT;
        private Button btCheckHP;
        private Button btSetHP;
    }
}