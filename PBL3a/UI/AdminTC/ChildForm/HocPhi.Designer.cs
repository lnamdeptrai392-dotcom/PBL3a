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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbTL = new TextBox();
            laML = new Label();
            laTL = new Label();
            cbbML = new ComboBox();
            btSetHP = new Button();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.9020977F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.0979F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 164F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 411F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 218F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.Controls.Add(tbTL, 6, 1);
            tableLayoutPanel1.Controls.Add(laML, 3, 1);
            tableLayoutPanel1.Controls.Add(laTL, 5, 1);
            tableLayoutPanel1.Controls.Add(cbbML, 4, 1);
            tableLayoutPanel1.Controls.Add(btSetHP, 8, 6);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.Coral;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.375F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 226F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1480, 824);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tbTL
            // 
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(794, 57);
            tbTL.Margin = new Padding(3, 4, 3, 4);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(405, 35);
            tbTL.TabIndex = 4;
            // 
            // laML
            // 
            laML.Dock = DockStyle.Fill;
            laML.Font = new Font("Segoe UI", 9.857143F);
            laML.ForeColor = Color.Black;
            laML.Location = new Point(41, 53);
            laML.Name = "laML";
            laML.Size = new Size(129, 78);
            laML.TabIndex = 1;
            laML.Text = "Mã Lớp: ";
            // 
            // laTL
            // 
            laTL.Dock = DockStyle.Right;
            laTL.Font = new Font("Segoe UI", 9.857143F);
            laTL.ForeColor = Color.Black;
            laTL.Location = new Point(678, 53);
            laTL.Name = "laTL";
            laTL.Size = new Size(110, 78);
            laTL.TabIndex = 2;
            laTL.Text = "Tên Lớp: ";
            // 
            // cbbML
            // 
            cbbML.Dock = DockStyle.Fill;
            cbbML.FormattingEnabled = true;
            cbbML.Location = new Point(176, 57);
            cbbML.Margin = new Padding(3, 4, 3, 4);
            cbbML.Name = "cbbML";
            cbbML.Size = new Size(448, 38);
            cbbML.TabIndex = 9;
            cbbML.TextUpdate += cbbML_TextUpdate;
            // 
            // btSetHP
            // 
            btSetHP.BackColor = Color.FromArgb(93, 156, 179);
            btSetHP.Font = new Font("Segoe UI", 9.857143F);
            btSetHP.ForeColor = Color.White;
            btSetHP.Location = new Point(1225, 707);
            btSetHP.Margin = new Padding(3, 4, 3, 4);
            btSetHP.Name = "btSetHP";
            btSetHP.Size = new Size(207, 90);
            btSetHP.TabIndex = 5;
            btSetHP.Text = "Thiết lập học phí";
            btSetHP.UseVisualStyleBackColor = false;
            btSetHP.Click += btSetHP_Click;
            btSetHP.MouseEnter += btSetHP_MouseEnter;
            btSetHP.MouseLeave += btSetHP_MouseLeave;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 6);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Coral;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(25, 137);
            dataGridView1.Margin = new Padding(4, 6, 4, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 5);
            dataGridView1.Size = new Size(1173, 660);
            dataGridView1.TabIndex = 10;
            // 
            // HocPhi
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 824);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HocPhi";
            Text = "HocPhi";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbTL;
        private Label laML;
        private Label laTL;
        private Button btSetHP;
        private ComboBox cbbML;
        private DataGridView dataGridView1;
    }
}