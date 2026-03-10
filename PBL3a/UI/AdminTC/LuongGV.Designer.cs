namespace PBL3a.UI.AdminTC
{
    partial class LuongGV
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
            LaL = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbTL = new TextBox();
            laMGV = new Label();
            laTGV = new Label();
            listView1 = new ListView();
            btT = new Button();
            btCheckL = new Button();
            btSetL = new Button();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LaL
            // 
            LaL.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaL, 6);
            LaL.Dock = DockStyle.Fill;
            LaL.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaL.Location = new Point(23, 0);
            LaL.Name = "LaL";
            LaL.Size = new Size(1499, 131);
            LaL.TabIndex = 0;
            LaL.Text = "QUẢN LÝ LƯƠNG GIẢNG VIÊN";
            LaL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.02892F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.97108F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 274F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 394F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 255F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Controls.Add(tbTL, 4, 1);
            tableLayoutPanel1.Controls.Add(LaL, 1, 0);
            tableLayoutPanel1.Controls.Add(laMGV, 1, 1);
            tableLayoutPanel1.Controls.Add(laTGV, 3, 1);
            tableLayoutPanel1.Controls.Add(listView1, 1, 3);
            tableLayoutPanel1.Controls.Add(btT, 6, 6);
            tableLayoutPanel1.Controls.Add(btCheckL, 6, 5);
            tableLayoutPanel1.Controls.Add(btSetL, 6, 4);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 226F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1548, 820);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbTL
            // 
            tableLayoutPanel1.SetColumnSpan(tbTL, 2);
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(839, 134);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(428, 35);
            tbTL.TabIndex = 4;
            // 
            // laMGV
            // 
            laMGV.AutoSize = true;
            laMGV.Dock = DockStyle.Right;
            laMGV.Font = new Font("Segoe UI", 12F);
            laMGV.Location = new Point(52, 131);
            laMGV.Name = "laMGV";
            laMGV.Size = new Size(144, 58);
            laMGV.TabIndex = 1;
            laMGV.Text = "Mã Giảng Viên: ";
            // 
            // laTGV
            // 
            laTGV.AutoSize = true;
            laTGV.Dock = DockStyle.Right;
            laTGV.Font = new Font("Segoe UI", 12F);
            laTGV.Location = new Point(616, 131);
            laTGV.Name = "laTGV";
            laTGV.Size = new Size(217, 58);
            laTGV.TabIndex = 2;
            laTGV.Text = "Tên Giảng Viên: ";
            // 
            // listView1
            // 
            tableLayoutPanel1.SetColumnSpan(listView1, 4);
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(23, 230);
            listView1.Name = "listView1";
            tableLayoutPanel1.SetRowSpan(listView1, 4);
            listView1.Size = new Size(1204, 566);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 9.857143F);
            btT.Location = new Point(1273, 720);
            btT.Name = "btT";
            btT.Size = new Size(249, 76);
            btT.TabIndex = 7;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // btCheckL
            // 
            btCheckL.Dock = DockStyle.Bottom;
            btCheckL.Font = new Font("Segoe UI", 9.857143F);
            btCheckL.Location = new Point(1273, 622);
            btCheckL.Name = "btCheckL";
            btCheckL.Size = new Size(249, 76);
            btCheckL.TabIndex = 6;
            btCheckL.Text = "Kiểm tra tình trạng";
            btCheckL.UseVisualStyleBackColor = true;
            // 
            // btSetL
            // 
            btSetL.Dock = DockStyle.Bottom;
            btSetL.Font = new Font("Segoe UI", 9.857143F);
            btSetL.Location = new Point(1273, 516);
            btSetL.Name = "btSetL";
            btSetL.Size = new Size(249, 76);
            btSetL.TabIndex = 5;
            btSetL.Text = "Tính toán lương";
            btSetL.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(202, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(357, 38);
            comboBox1.TabIndex = 9;
            // 
            // LuongGV
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1548, 820);
            Controls.Add(tableLayoutPanel1);
            Name = "LuongGV";
            Text = "LuongGV";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LaL;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbTL;
        private Label laMGV;
        private Label laTGV;
        private ListView listView1;
        private Button btT;
        private Button btCheckL;
        private Button btSetL;
        private ComboBox comboBox1;
    }
}