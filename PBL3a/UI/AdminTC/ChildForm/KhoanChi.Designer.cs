
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
        /// <param name="disposing">true if disposing; otherwise, false.</param>
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
            date = new DateTimePicker();
            lbNgay = new Label();
            lbNam = new Label();
            lbTT = new Label();
            dataGridView1 = new DataGridView();
            tbKT = new TextBox();
            btOK = new Button();
            ngay = new DateTimePicker();
            cbbC = new ComboBox();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 385F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 409F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 207F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(date, 0, 0);
            tableLayoutPanel1.Controls.Add(lbNgay, 1, 1);
            tableLayoutPanel1.Controls.Add(lbNam, 3, 1);
            tableLayoutPanel1.Controls.Add(lbTT, 1, 7);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 3);
            tableLayoutPanel1.Controls.Add(tbKT, 2, 7);
            tableLayoutPanel1.Controls.Add(btOK, 6, 5);
            tableLayoutPanel1.Controls.Add(ngay, 2, 1);
            tableLayoutPanel1.Controls.Add(cbbC, 4, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 337F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(1457, 760);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // date
            // 
            date.Location = new Point(3, 3);
            date.Name = "date";
            date.Size = new Size(51, 35);
            date.TabIndex = 13;
            // 
            // lbNgay
            // 
            lbNgay.AutoSize = true;
            lbNgay.Dock = DockStyle.Right;
            lbNgay.Font = new Font("Segoe UI", 9.857143F);
            lbNgay.ForeColor = Color.Black;
            lbNgay.Location = new Point(161, 34);
            lbNgay.Name = "lbNgay";
            lbNgay.Size = new Size(75, 92);
            lbNgay.TabIndex = 3;
            lbNgay.Text = "Ngày:";
            // 
            // lbNam
            // 
            lbNam.AutoSize = true;
            lbNam.Dock = DockStyle.Right;
            lbNam.Font = new Font("Segoe UI", 9.857143F);
            lbNam.ForeColor = Color.Black;
            lbNam.Location = new Point(690, 34);
            lbNam.Name = "lbNam";
            lbNam.Size = new Size(119, 92);
            lbNam.TabIndex = 4;
            lbNam.Text = "Chi trong:";
            // 
            // lbTT
            // 
            lbTT.AutoSize = true;
            lbTT.Dock = DockStyle.Right;
            lbTT.Font = new Font("Segoe UI", 9.857143F);
            lbTT.ForeColor = Color.Black;
            lbTT.Location = new Point(139, 659);
            lbTT.Name = "lbTT";
            lbTT.Size = new Size(74, 92);
            lbTT.TabIndex = 5;
            lbTT.Text = "Tổng:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 4);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(54, 74);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 3);
            dataGridView1.Size = new Size(1141, 561);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // tbKT
            // 
            tableLayoutPanel1.SetColumnSpan(tbKT, 3);
            tbKT.Dock = DockStyle.Top;
            tbKT.Enabled = false;
            tbKT.Location = new Point(219, 663);
            tbKT.Margin = new Padding(3, 4, 3, 4);
            tbKT.Name = "tbKT";
            tbKT.Size = new Size(976, 35);
            tbKT.TabIndex = 11;
            // 
            // btOK
            // 
            btOK.BackColor = Color.FromArgb(93, 156, 179);
            btOK.Dock = DockStyle.Bottom;
            btOK.Font = new Font("Segoe UI", 12F);
            btOK.ForeColor = Color.White;
            btOK.Location = new Point(1232, 561);
            btOK.Margin = new Padding(3, 4, 3, 4);
            btOK.Name = "btOK";
            btOK.Size = new Size(201, 74);
            btOK.TabIndex = 6;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = false;
            btOK.Click += btOK_Click;
            btOK.MouseEnter += btOK_MouseEnter;
            btOK.MouseLeave += btOK_MouseLeave;
            // 
            // ngay
            // 
            ngay.Location = new Point(242, 37);
            ngay.Name = "ngay";
            ngay.Size = new Size(379, 35);
            ngay.TabIndex = 14;
            // 
            // cbbC
            // 
            cbbC.FormattingEnabled = true;
            cbbC.Items.AddRange(new object[] { "ngày", "tháng", "năm" });
            cbbC.Location = new Point(815, 37);
            cbbC.Name = "cbbC";
            cbbC.Size = new Size(403, 38);
            cbbC.TabIndex = 15;
            // 
            // KhoanChi
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1457, 760);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "KhoanChi";
            Text = "KhoanChi";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbNgay;
        private Label lbNam;
        private Label lbTT;
        private Button btOK;
        private DataGridView dataGridView1;
        private TextBox tbKT;
        private DateTimePicker date;
        private DateTimePicker ngay;
        private ComboBox cbbC;
    }
}


