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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbTL = new TextBox();
            laMGV = new Label();
            laTGV = new Label();
            dataGridView1 = new DataGridView();
            cbbMGV = new ComboBox();
            btSetL = new Button();
            laThang = new Label();
            laNam = new Label();
            cbbThang = new ComboBox();
            txtNam = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.104023F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.89598F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 17F));
            tableLayoutPanel1.Controls.Add(tbTL, 4, 1);
            tableLayoutPanel1.Controls.Add(laMGV, 1, 1);
            tableLayoutPanel1.Controls.Add(laTGV, 3, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 4);
            tableLayoutPanel1.Controls.Add(cbbMGV, 2, 1);
            tableLayoutPanel1.Controls.Add(btSetL, 6, 8);
            tableLayoutPanel1.Controls.Add(laThang, 1, 2);
            tableLayoutPanel1.Controls.Add(laNam, 3, 2);
            tableLayoutPanel1.Controls.Add(cbbThang, 2, 2);
            tableLayoutPanel1.Controls.Add(txtNam, 4, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Microsoft Sans Serif", 9F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.83582F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 67.16418F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.Size = new Size(987, 549);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbTL
            // 
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(562, 31);
            tbTL.Margin = new Padding(2, 3, 2, 3);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(256, 24);
            tbTL.TabIndex = 4;
            // 
            // laMGV
            // 
            laMGV.AutoSize = true;
            laMGV.Dock = DockStyle.Right;
            laMGV.Font = new Font("Microsoft Sans Serif", 9F);
            laMGV.ForeColor = Color.Black;
            laMGV.Location = new Point(37, 28);
            laMGV.Margin = new Padding(2, 0, 2, 0);
            laMGV.Name = "laMGV";
            laMGV.Size = new Size(76, 57);
            laMGV.TabIndex = 1;
            laMGV.Text = "Mã Giảng Viên: ";
            // 
            // laTGV
            // 
            laTGV.AutoSize = true;
            laTGV.Dock = DockStyle.Right;
            laTGV.Font = new Font("Microsoft Sans Serif", 9F);
            laTGV.ForeColor = Color.Black;
            laTGV.Location = new Point(442, 28);
            laTGV.Margin = new Padding(2, 0, 2, 0);
            laTGV.Name = "laTGV";
            laTGV.Size = new Size(116, 57);
            laTGV.TabIndex = 2;
            laTGV.Text = "Tên Giảng Viên: ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 4);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(16, 126);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 5);
            dataGridView1.Size = new Size(802, 406);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // cbbMGV
            // 
            cbbMGV.Dock = DockStyle.Fill;
            cbbMGV.FormattingEnabled = true;
            cbbMGV.Location = new Point(117, 31);
            cbbMGV.Margin = new Padding(2, 3, 2, 3);
            cbbMGV.Name = "cbbMGV";
            cbbMGV.Size = new Size(300, 26);
            cbbMGV.TabIndex = 9;
            cbbMGV.TextUpdate += comboBox1_TextUpdate;
            // 
            // btSetL
            // 
            btSetL.BackColor = Color.FromArgb(93, 156, 179);
            btSetL.Font = new Font("Segoe UI", 9.857143F);
            btSetL.ForeColor = Color.White;
            btSetL.Location = new Point(833, 489);
            btSetL.Margin = new Padding(2, 3, 2, 3);
            btSetL.Name = "btSetL";
            btSetL.Size = new Size(134, 41);
            btSetL.TabIndex = 5;
            btSetL.Text = "Tính toán lương";
            btSetL.UseVisualStyleBackColor = false;
            btSetL.Click += btSetL_Click;
            btSetL.MouseEnter += btSetL_MouseEnter;
            btSetL.MouseLeave += btSetL_MouseLeave;
            // 
            // laThang
            // 
            laThang.AutoSize = true;
            laThang.Dock = DockStyle.Right;
            laThang.Font = new Font("Microsoft Sans Serif", 9F);
            laThang.ForeColor = Color.Black;
            laThang.Location = new Point(60, 85);
            laThang.Margin = new Padding(2, 0, 2, 0);
            laThang.Name = "laThang";
            laThang.Size = new Size(53, 28);
            laThang.TabIndex = 10;
            laThang.Text = "Tháng:";
            // 
            // laNam
            // 
            laNam.AutoSize = true;
            laNam.Dock = DockStyle.Right;
            laNam.Font = new Font("Microsoft Sans Serif", 9F);
            laNam.ForeColor = Color.Black;
            laNam.Location = new Point(514, 85);
            laNam.Margin = new Padding(2, 0, 2, 0);
            laNam.Name = "laNam";
            laNam.Size = new Size(44, 28);
            laNam.TabIndex = 11;
            laNam.Text = "Năm:";
            // 
            // cbbThang
            // 
            cbbThang.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbbThang.Dock = DockStyle.Fill;
            cbbThang.FormattingEnabled = true;
            cbbThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbbThang.Location = new Point(118, 89);
            cbbThang.Margin = new Padding(3, 4, 3, 4);
            cbbThang.Name = "cbbThang";
            cbbThang.Size = new Size(298, 26);
            cbbThang.TabIndex = 12;
            // 
            // txtNam
            // 
            txtNam.Dock = DockStyle.Fill;
            txtNam.Location = new Point(563, 89);
            txtNam.Margin = new Padding(3, 4, 3, 4);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(254, 24);
            txtNam.TabIndex = 13;
            // 
            // LuongGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(987, 549);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "LuongGV";
            Text = "LuongGV";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbTL;
        private Label laMGV;
        private Label laTGV;
        private DataGridView dataGridView1;
        private Button btSetL;
        private ComboBox cbbMGV;
        private Label laThang;
        private Label laNam;
        private ComboBox cbbThang;
        private TextBox txtNam;
    }
}