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
            btCheckL = new Button();
            btSetL = new Button();
            comboBox1 = new ComboBox();
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
            LaL.Location = new Point(16, 0);
            LaL.Margin = new Padding(2, 0, 2, 0);
            LaL.Name = "LaL";
            LaL.Size = new Size(997, 88);
            LaL.TabIndex = 0;
            LaL.Text = "QUẢN LÝ LƯƠNG GIẢNG VIÊN";
            LaL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.02892F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.97108F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 183F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 263F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.Controls.Add(tbTL, 4, 1);
            tableLayoutPanel1.Controls.Add(LaL, 1, 0);
            tableLayoutPanel1.Controls.Add(laMGV, 1, 1);
            tableLayoutPanel1.Controls.Add(laTGV, 3, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 3);
            tableLayoutPanel1.Controls.Add(btT, 6, 6);
            tableLayoutPanel1.Controls.Add(btCheckL, 6, 5);
            tableLayoutPanel1.Controls.Add(btSetL, 6, 4);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.Size = new Size(1032, 547);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbTL
            // 
            tableLayoutPanel1.SetColumnSpan(tbTL, 2);
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(558, 91);
            tbTL.Margin = new Padding(2, 3, 2, 3);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(285, 27);
            tbTL.TabIndex = 4;
            // 
            // laMGV
            // 
            laMGV.AutoSize = true;
            laMGV.Dock = DockStyle.Right;
            laMGV.Font = new Font("Segoe UI", 12F);
            laMGV.Location = new Point(28, 88);
            laMGV.Margin = new Padding(2, 0, 2, 0);
            laMGV.Name = "laMGV";
            laMGV.Size = new Size(102, 38);
            laMGV.TabIndex = 1;
            laMGV.Text = "Mã Giảng Viên: ";
            // 
            // laTGV
            // 
            laTGV.AutoSize = true;
            laTGV.Dock = DockStyle.Right;
            laTGV.Font = new Font("Segoe UI", 12F);
            laTGV.Location = new Point(404, 88);
            laTGV.Margin = new Padding(2, 0, 2, 0);
            laTGV.Name = "laTGV";
            laTGV.Size = new Size(150, 38);
            laTGV.TabIndex = 2;
            laTGV.Text = "Tên Giảng Viên: ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 4);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(16, 154);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 4);
            dataGridView1.Size = new Size(801, 376);
            dataGridView1.TabIndex = 8;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 9.857143F);
            btT.Location = new Point(847, 479);
            btT.Margin = new Padding(2, 3, 2, 3);
            btT.Name = "btT";
            btT.Size = new Size(166, 51);
            btT.TabIndex = 7;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // btCheckL
            // 
            btCheckL.Dock = DockStyle.Bottom;
            btCheckL.Font = new Font("Segoe UI", 9.857143F);
            btCheckL.Location = new Point(847, 414);
            btCheckL.Margin = new Padding(2, 3, 2, 3);
            btCheckL.Name = "btCheckL";
            btCheckL.Size = new Size(166, 51);
            btCheckL.TabIndex = 6;
            btCheckL.Text = "Kiểm tra tình trạng";
            btCheckL.UseVisualStyleBackColor = true;
            btCheckL.Click += btCheckL_Click;
            // 
            // btSetL
            // 
            btSetL.Dock = DockStyle.Bottom;
            btSetL.Font = new Font("Segoe UI", 9.857143F);
            btSetL.Location = new Point(847, 343);
            btSetL.Margin = new Padding(2, 3, 2, 3);
            btSetL.Name = "btSetL";
            btSetL.Size = new Size(166, 51);
            btSetL.TabIndex = 5;
            btSetL.Text = "Tính toán lương";
            btSetL.UseVisualStyleBackColor = true;
            btSetL.Click += btSetL_Click;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(134, 91);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 28);
            comboBox1.TabIndex = 9;
            // 
            // LuongGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 547);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 3, 2, 3);
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
        private Button btCheckL;
        private Button btSetL;
        private ComboBox comboBox1;
    }
}