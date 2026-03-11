namespace PBL3a.UI.AdminTC
{
    partial class LuongGV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LaL = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbTL = new TextBox();
            laMGV = new Label();
            laTGV = new Label();
            dataGridView1 = new DataGridView();
            btT = new Button();
            comboBox1 = new ComboBox();
            btSetL = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LaL
            // 
            LaL.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaL, 6);
            LaL.Dock = DockStyle.Fill;
            LaL.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            LaL.Location = new Point(24, 0);
            LaL.Name = "LaL";
            LaL.Size = new Size(1496, 131);
=======
            LaL.Location = new Point(14, 0);
            LaL.Margin = new Padding(2, 0, 2, 0);
            LaL.Name = "LaL";
            LaL.Size = new Size(873, 65);
>>>>>>> parent of 0d2331e (1)
            LaL.TabIndex = 0;
            LaL.Text = "QUẢN LÝ LƯƠNG GIẢNG VIÊN";
            LaL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
>>>>>>> parent of e404351 (1)
=======
>>>>>>> parent of e404351 (1)
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.02892F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.97108F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 274F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 394F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 255F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
=======
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.02892F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.97108F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
>>>>>>> parent of 0d2331e (1)
            tableLayoutPanel1.Controls.Add(tbTL, 4, 1);
            tableLayoutPanel1.Controls.Add(LaL, 1, 0);
            tableLayoutPanel1.Controls.Add(laMGV, 1, 1);
            tableLayoutPanel1.Controls.Add(laTGV, 3, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 3);
            tableLayoutPanel1.Controls.Add(btT, 6, 6);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(btSetL, 6, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
<<<<<<< HEAD
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
=======
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
>>>>>>> parent of 0d2331e (1)
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.666666F));
<<<<<<< HEAD
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 226F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1548, 820);
=======
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(903, 410);
>>>>>>> parent of 0d2331e (1)
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbTL
            // 
            tableLayoutPanel1.SetColumnSpan(tbTL, 2);
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
<<<<<<< HEAD
            tbTL.Location = new Point(838, 135);
            tbTL.Margin = new Padding(3, 4, 3, 4);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(427, 35);
=======
            tbTL.Location = new Point(489, 67);
            tbTL.Margin = new Padding(2, 2, 2, 2);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(249, 23);
>>>>>>> parent of 0d2331e (1)
            tbTL.TabIndex = 4;
            // 
            // laMGV
            // 
            laMGV.AutoSize = true;
            laMGV.Dock = DockStyle.Right;
            laMGV.Font = new Font("Segoe UI", 12F);
<<<<<<< HEAD
            laMGV.Location = new Point(39, 131);
            laMGV.Name = "laMGV";
            laMGV.Size = new Size(217, 58);
=======
            laMGV.Location = new Point(33, 65);
            laMGV.Margin = new Padding(2, 0, 2, 0);
            laMGV.Name = "laMGV";
            laMGV.Size = new Size(81, 29);
>>>>>>> parent of 0d2331e (1)
            laMGV.TabIndex = 1;
            laMGV.Text = "Tên Giảng Viên: ";
            // 
            // laTGV
            // 
            laTGV.AutoSize = true;
            laTGV.Dock = DockStyle.Right;
            laTGV.Font = new Font("Segoe UI", 12F);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
>>>>>>> parent of e404351 (1)
=======
>>>>>>> parent of e404351 (1)
            laTGV.Location = new Point(615, 131);
            laTGV.Name = "laTGV";
            laTGV.Size = new Size(205, 58);
=======
            laTGV.Location = new Point(365, 65);
            laTGV.Margin = new Padding(2, 0, 2, 0);
            laTGV.Name = "laTGV";
            laTGV.Size = new Size(120, 29);
>>>>>>> parent of 0d2331e (1)
            laTGV.TabIndex = 2;
            laTGV.Text = "Mã Giảng Viên:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 4);
            dataGridView1.Dock = DockStyle.Fill;
<<<<<<< HEAD
            dataGridView1.Location = new Point(24, 231);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 4);
            dataGridView1.Size = new Size(1202, 564);
=======
            dataGridView1.Location = new Point(14, 115);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            tableLayoutPanel1.SetRowSpan(dataGridView1, 4);
            dataGridView1.Size = new Size(701, 282);
>>>>>>> parent of 0d2331e (1)
            dataGridView1.TabIndex = 8;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 9.857143F);
<<<<<<< HEAD
            btT.Location = new Point(1271, 719);
            btT.Margin = new Padding(3, 4, 3, 4);
            btT.Name = "btT";
            btT.Size = new Size(249, 76);
=======
            btT.Location = new Point(742, 359);
            btT.Margin = new Padding(2, 2, 2, 2);
            btT.Name = "btT";
            btT.Size = new Size(145, 38);
>>>>>>> parent of 0d2331e (1)
            btT.TabIndex = 7;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // comboBox1
            // 
<<<<<<< HEAD
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(202, 135);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(356, 38);
            comboBox1.TabIndex = 9;
=======
            btCheckL.Dock = DockStyle.Bottom;
            btCheckL.Font = new Font("Segoe UI", 9.857143F);
            btCheckL.Location = new Point(742, 310);
            btCheckL.Margin = new Padding(2, 2, 2, 2);
            btCheckL.Name = "btCheckL";
            btCheckL.Size = new Size(145, 38);
            btCheckL.TabIndex = 6;
            btCheckL.Text = "Kiểm tra tình trạng";
            btCheckL.UseVisualStyleBackColor = true;
            btCheckL.Click += btCheckL_Click;
>>>>>>> parent of 0d2331e (1)
            // 
            // btSetL
            // 
            btSetL.Dock = DockStyle.Bottom;
            btSetL.Font = new Font("Segoe UI", 9.857143F);
<<<<<<< HEAD
            btSetL.Location = new Point(1271, 621);
            btSetL.Margin = new Padding(3, 4, 3, 4);
            btSetL.Name = "btSetL";
            btSetL.Size = new Size(249, 76);
=======
            btSetL.Location = new Point(742, 257);
            btSetL.Margin = new Padding(2, 2, 2, 2);
            btSetL.Name = "btSetL";
            btSetL.Size = new Size(145, 38);
>>>>>>> parent of 0d2331e (1)
            btSetL.TabIndex = 5;
            btSetL.Text = "Tính toán lương";
            btSetL.UseVisualStyleBackColor = true;
            btSetL.Click += btSetL_Click;
<<<<<<< HEAD
<<<<<<< HEAD
=======
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
<<<<<<< HEAD
            comboBox1.Location = new Point(262, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(342, 38);
=======
            comboBox1.Location = new Point(118, 67);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 23);
>>>>>>> parent of 0d2331e (1)
            comboBox1.TabIndex = 9;
>>>>>>> Stashed changes
=======
>>>>>>> parent of e404351 (1)
=======
>>>>>>> parent of e404351 (1)
            // 
            // LuongGV
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1548, 820);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
=======
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 410);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 2, 2, 2);
>>>>>>> parent of 0d2331e (1)
            Name = "LuongGV";
            Text = "LuongGV";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Label LaL;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbTL;
        private Label laMGV;
        private Label laTGV;
        private DataGridView dataGridView1;
        private Button btT;
        private Button btSetL;
        private ComboBox comboBox1;
    }
}