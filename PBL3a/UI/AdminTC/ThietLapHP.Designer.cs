namespace PBL3a.UI.AdminTC
{
    partial class ThietLapHP
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
            lbHP = new Label();
            textBox1 = new TextBox();
            laTT = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            btLuu = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8273163F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.17268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.Controls.Add(tbTL, 4, 1);
            tableLayoutPanel1.Controls.Add(LaHP, 1, 0);
            tableLayoutPanel1.Controls.Add(laML, 1, 1);
            tableLayoutPanel1.Controls.Add(laTL, 3, 1);
            tableLayoutPanel1.Controls.Add(lbHP, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 2, 3);
            tableLayoutPanel1.Controls.Add(laTT, 3, 3);
            tableLayoutPanel1.Controls.Add(textBox2, 4, 3);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(btLuu, 6, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.1415939F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.858408F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(986, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbTL
            // 
            tableLayoutPanel1.SetColumnSpan(tbTL, 2);
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(558, 138);
            tbTL.Margin = new Padding(2);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(263, 23);
            tbTL.TabIndex = 4;
            // 
            // LaHP
            // 
            LaHP.AutoSize = true;
            LaHP.BackColor = Color.AliceBlue;
            tableLayoutPanel1.SetColumnSpan(LaHP, 6);
            LaHP.Dock = DockStyle.Fill;
            LaHP.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaHP.Location = new Point(14, 0);
            LaHP.Margin = new Padding(2, 0, 2, 0);
            LaHP.Name = "LaHP";
            LaHP.Size = new Size(956, 136);
            LaHP.TabIndex = 0;
            LaHP.Text = "THIẾT LẬP HỌC PHÍ";
            LaHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laML
            // 
            laML.AutoSize = true;
            laML.Dock = DockStyle.Right;
            laML.Font = new Font("Segoe UI", 12F);
            laML.Location = new Point(70, 136);
            laML.Margin = new Padding(2, 0, 2, 0);
            laML.Name = "laML";
            laML.Size = new Size(70, 64);
            laML.TabIndex = 1;
            laML.Text = "Mã Lớp: ";
            // 
            // laTL
            // 
            laTL.AutoSize = true;
            laTL.Dock = DockStyle.Right;
            laTL.Font = new Font("Segoe UI", 12F);
            laTL.Location = new Point(483, 136);
            laTL.Margin = new Padding(2, 0, 2, 0);
            laTL.Name = "laTL";
            laTL.Size = new Size(71, 64);
            laTL.TabIndex = 2;
            laTL.Text = "Tên Lớp: ";
            // 
            // lbHP
            // 
            lbHP.AutoSize = true;
            lbHP.Dock = DockStyle.Right;
            lbHP.Font = new Font("Segoe UI", 12F);
            lbHP.Location = new Point(27, 256);
            lbHP.Margin = new Padding(2, 0, 2, 0);
            lbHP.Name = "lbHP";
            lbHP.Size = new Size(113, 64);
            lbHP.TabIndex = 8;
            lbHP.Text = "Số tiền / người";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 258);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 23);
            textBox1.TabIndex = 9;
            // 
            // laTT
            // 
            laTT.AutoSize = true;
            laTT.Dock = DockStyle.Right;
            laTT.Font = new Font("Segoe UI", 12F);
            laTT.Location = new Point(479, 256);
            laTT.Margin = new Padding(2, 0, 2, 0);
            laTT.Name = "laTT";
            laTT.Size = new Size(75, 64);
            laTT.TabIndex = 10;
            laTT.Text = "Tổng tiền";
            laTT.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            tableLayoutPanel1.SetColumnSpan(textBox2, 2);
            textBox2.Enabled = false;
            textBox2.Location = new Point(558, 258);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 23);
            textBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 138);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(304, 23);
            comboBox1.TabIndex = 12;
            // 
            // btLuu
            // 
            btLuu.BackColor = Color.FromArgb(112, 146, 190);
            btLuu.Font = new Font("Segoe UI", 9.857143F);
            btLuu.ForeColor = Color.White;
            btLuu.Location = new Point(825, 391);
            btLuu.Margin = new Padding(2);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(145, 38);
            btLuu.TabIndex = 6;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = false;
            btLuu.Click += btLuu_Click;
            btLuu.MouseEnter += btLuu_MouseEnter;
            btLuu.MouseLeave += btLuu_MouseLeave;
            // 
            // ThietLapHP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(986, 450);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "ThietLapHP";
            Text = "ThietLapHP";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbTL;
        private Label LaHP;
        private Label laML;
        private Label laTL;
        private Button btLuu;
        private Label lbHP;
        private Label laTT;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}