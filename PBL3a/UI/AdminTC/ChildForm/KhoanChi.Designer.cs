
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbThang = new Label();
            lbNam = new Label();
            lbTT = new Label();
            dataGridView1 = new DataGridView();
            tbNam = new TextBox();
            tbKT = new TextBox();
            comboBox1 = new ComboBox();
            btOK = new Button();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 502F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 207F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lbThang, 1, 1);
            tableLayoutPanel1.Controls.Add(lbNam, 3, 1);
            tableLayoutPanel1.Controls.Add(lbTT, 1, 7);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 3);
            tableLayoutPanel1.Controls.Add(tbNam, 4, 1);
            tableLayoutPanel1.Controls.Add(tbKT, 2, 7);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(btOK, 6, 5);
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
            tableLayoutPanel1.Size = new Size(1480, 824);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lbThang
            // 
            lbThang.AutoSize = true;
            lbThang.Dock = DockStyle.Right;
            lbThang.Font = new Font("Segoe UI", 9.857143F);
            lbThang.ForeColor = Color.Black;
            lbThang.Location = new Point(150, 34);
            lbThang.Name = "lbThang";
            lbThang.Size = new Size(86, 92);
            lbThang.TabIndex = 3;
            lbThang.Text = "Tháng:";
            // 
            // lbNam
            // 
            lbNam.AutoSize = true;
            lbNam.Dock = DockStyle.Right;
            lbNam.Font = new Font("Segoe UI", 9.857143F);
            lbNam.ForeColor = Color.Black;
            lbNam.Location = new Point(646, 34);
            lbNam.Name = "lbNam";
            lbNam.Size = new Size(70, 92);
            lbNam.TabIndex = 4;
            lbNam.Text = "Năm:";
            // 
            // lbTT
            // 
            lbTT.AutoSize = true;
            lbTT.Dock = DockStyle.Right;
            lbTT.Font = new Font("Segoe UI", 9.857143F);
            lbTT.ForeColor = Color.Black;
            lbTT.Location = new Point(162, 723);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(60, 138);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 3);
            dataGridView1.Size = new Size(1158, 561);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tbNam
            // 
            tbNam.Dock = DockStyle.Top;
            tbNam.Location = new Point(722, 38);
            tbNam.Margin = new Padding(3, 4, 3, 4);
            tbNam.Name = "tbNam";
            tbNam.Size = new Size(496, 35);
            tbNam.TabIndex = 10;
            // 
            // tbKT
            // 
            tableLayoutPanel1.SetColumnSpan(tbKT, 3);
            tbKT.Dock = DockStyle.Top;
            tbKT.Enabled = false;
            tbKT.Location = new Point(242, 727);
            tbKT.Margin = new Padding(3, 4, 3, 4);
            tbKT.Name = "tbKT";
            tbKT.Size = new Size(976, 35);
            tbKT.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new Point(242, 38);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(379, 38);
            comboBox1.TabIndex = 12;
            // 
            // btOK
            // 
            btOK.BackColor = Color.FromArgb(93, 156, 179);
            btOK.Dock = DockStyle.Bottom;
            btOK.Font = new Font("Segoe UI", 12F);
            btOK.ForeColor = Color.White;
            btOK.Location = new Point(1255, 625);
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
            // KhoanChi
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 824);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "KhoanChi";
            Text = "KhoanChi";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbThang;
        private Label lbNam;
        private Label lbTT;
        private Button btOK;
        private DataGridView dataGridView1;
        private TextBox tbNam;
        private TextBox tbKT;
        private ComboBox comboBox1;
    }
}

