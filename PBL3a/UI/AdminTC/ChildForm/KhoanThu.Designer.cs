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
            lbNgay = new Label();
            laLC = new Label();
            lbTT = new Label();
            dataGridView1 = new DataGridView();
            tbKT = new TextBox();
            btOK = new Button();
            ngay = new DateTimePicker();
            cbbT = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.783783F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.21622F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 443F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.Controls.Add(lbNgay, 1, 1);
            tableLayoutPanel1.Controls.Add(laLC, 3, 1);
            tableLayoutPanel1.Controls.Add(lbTT, 1, 7);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 3);
            tableLayoutPanel1.Controls.Add(tbKT, 2, 7);
            tableLayoutPanel1.Controls.Add(btOK, 6, 5);
            tableLayoutPanel1.Controls.Add(ngay, 2, 1);
            tableLayoutPanel1.Controls.Add(cbbT, 4, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.83582F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 67.16418F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(1480, 824);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lbNgay
            // 
            lbNgay.AutoSize = true;
            lbNgay.Dock = DockStyle.Right;
            lbNgay.Font = new Font("Segoe UI", 9.857143F);
            lbNgay.ForeColor = Color.Black;
            lbNgay.Location = new Point(154, 43);
            lbNgay.Name = "lbNgay";
            lbNgay.Size = new Size(75, 88);
            lbNgay.TabIndex = 3;
            lbNgay.Text = "Ngày:";
            // 
            // laLC
            // 
            laLC.AutoSize = true;
            laLC.Dock = DockStyle.Right;
            laLC.Font = new Font("Segoe UI", 9.857143F);
            laLC.ForeColor = Color.Black;
            laLC.Location = new Point(641, 43);
            laLC.Name = "laLC";
            laLC.Size = new Size(125, 88);
            laLC.TabIndex = 4;
            laLC.Text = "Thu trong:";
            // 
            // lbTT
            // 
            lbTT.AutoSize = true;
            lbTT.Dock = DockStyle.Right;
            lbTT.Font = new Font("Segoe UI", 9.857143F);
            lbTT.ForeColor = Color.Black;
            lbTT.Location = new Point(155, 731);
            lbTT.Name = "lbTT";
            lbTT.Size = new Size(74, 84);
            lbTT.TabIndex = 5;
            lbTT.Text = "Tổng:";
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
            dataGridView1.Location = new Point(58, 143);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 3);
            dataGridView1.Size = new Size(1151, 556);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // tbKT
            // 
            tableLayoutPanel1.SetColumnSpan(tbKT, 3);
            tbKT.Dock = DockStyle.Top;
            tbKT.Enabled = false;
            tbKT.Location = new Point(235, 735);
            tbKT.Margin = new Padding(3, 4, 3, 4);
            tbKT.Name = "tbKT";
            tbKT.Size = new Size(974, 35);
            tbKT.TabIndex = 11;
            // 
            // btOK
            // 
            btOK.BackColor = Color.FromArgb(112, 146, 190);
            btOK.Dock = DockStyle.Bottom;
            btOK.Font = new Font("Segoe UI", 12F);
            btOK.ForeColor = Color.White;
            btOK.Location = new Point(1245, 625);
            btOK.Margin = new Padding(3, 4, 3, 4);
            btOK.Name = "btOK";
            btOK.Size = new Size(215, 74);
            btOK.TabIndex = 6;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = false;
            btOK.Click += btOK_Click;
            btOK.MouseEnter += btOK_MouseEnter;
            btOK.MouseLeave += btOK_MouseLeave;
            // 
            // ngay
            // 
            ngay.Location = new Point(235, 46);
            ngay.Name = "ngay";
            ngay.Size = new Size(369, 35);
            ngay.TabIndex = 15;
            // 
            // cbbT
            // 
            cbbT.FormattingEnabled = true;
            cbbT.Items.AddRange(new object[] { "ngày", "tháng", "năm" });
            cbbT.Location = new Point(772, 46);
            cbbT.Name = "cbbT";
            cbbT.Size = new Size(403, 38);
            cbbT.TabIndex = 16;
            // 
            // KhoanThu
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 824);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "KhoanThu";
            Text = "KhoanThu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbNgay;
        private Label laLC;
        private Label lbTT;
        private DataGridView dataGridView1;
        private TextBox tbKT;
        private Button btOK;
        private DateTimePicker ngay;
        private ComboBox cbbT;
    }
}



