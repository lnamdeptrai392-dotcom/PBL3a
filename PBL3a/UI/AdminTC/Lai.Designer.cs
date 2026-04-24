namespace PBL3a.UI.AdminTC
{
    partial class Lai
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lbThang = new Label();
            lbNam = new Label();
            lbTT = new Label();
            dataGridView1 = new DataGridView();
            tbNam = new TextBox();
            tbT = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btOK = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbThang
            // 
            lbThang.AutoSize = true;
            lbThang.Dock = DockStyle.Right;
            lbThang.Font = new Font("Segoe UI", 9.857143F);
            lbThang.ForeColor = Color.Black;
            lbThang.Location = new Point(126, 14);
            lbThang.Name = "lbThang";
            lbThang.Size = new Size(86, 53);
            lbThang.TabIndex = 3;
            lbThang.Text = "Tháng:";
            // 
            // lbNam
            // 
            lbNam.AutoSize = true;
            lbNam.Dock = DockStyle.Right;
            lbNam.Font = new Font("Segoe UI", 9.857143F);
            lbNam.ForeColor = Color.Black;
            lbNam.Location = new Point(624, 14);
            lbNam.Name = "lbNam";
            lbNam.Size = new Size(70, 53);
            lbNam.TabIndex = 4;
            lbNam.Text = "Năm:";
            // 
            // lbTT
            // 
            lbTT.AutoSize = true;
            lbTT.Dock = DockStyle.Right;
            lbTT.Font = new Font("Segoe UI", 9.857143F);
            lbTT.ForeColor = Color.Black;
            lbTT.Location = new Point(138, 679);
            lbTT.Name = "lbTT";
            lbTT.Size = new Size(74, 60);
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
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(56, 79);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 3);
            dataGridView1.Size = new Size(1142, 582);
            dataGridView1.TabIndex = 8;
            // 
            // tbNam
            // 
            tbNam.Dock = DockStyle.Top;
            tbNam.Location = new Point(700, 18);
            tbNam.Margin = new Padding(3, 4, 3, 4);
            tbNam.Name = "tbNam";
            tbNam.Size = new Size(498, 35);
            tbNam.TabIndex = 10;
            // 
            // tbT
            // 
            tableLayoutPanel1.SetColumnSpan(tbT, 3);
            tbT.Dock = DockStyle.Top;
            tbT.Enabled = false;
            tbT.Location = new Point(218, 683);
            tbT.Margin = new Padding(3, 4, 3, 4);
            tbT.Name = "tbT";
            tbT.Size = new Size(980, 35);
            tbT.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.38461F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 395F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 504F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 201F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Controls.Add(btOK, 6, 5);
            tableLayoutPanel1.Controls.Add(lbThang, 1, 1);
            tableLayoutPanel1.Controls.Add(lbNam, 3, 1);
            tableLayoutPanel1.Controls.Add(lbTT, 1, 7);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 3);
            tableLayoutPanel1.Controls.Add(tbNam, 4, 1);
            tableLayoutPanel1.Controls.Add(tbT, 2, 7);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1457, 760);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btOK
            // 
            btOK.BackColor = Color.FromArgb(112, 146, 190);
            btOK.Dock = DockStyle.Bottom;
            btOK.Font = new Font("Segoe UI", 12F);
            btOK.ForeColor = Color.White;
            btOK.Location = new Point(1233, 587);
            btOK.Margin = new Padding(3, 4, 3, 4);
            btOK.Name = "btOK";
            btOK.Size = new Size(195, 74);
            btOK.TabIndex = 7;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = false;
            btOK.Click += btOK_Click;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new Point(218, 18);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(389, 38);
            comboBox1.TabIndex = 12;
            // 
            // Lai
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1457, 760);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lai";
            Text = "Lai";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbThang;
        private Label lbNam;
        private Label lbTT;
        private DataGridView dataGridView1;
        private TextBox tbNam;
        private TextBox tbT;
        private ComboBox comboBox1;
        private Button btOK;
    }
}