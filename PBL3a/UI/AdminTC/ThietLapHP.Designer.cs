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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8273163F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.17268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 416F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 255F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.1415939F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.858408F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.Size = new Size(1690, 901);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbTL
            // 
            tableLayoutPanel1.SetColumnSpan(tbTL, 2);
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(957, 276);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(452, 35);
            tbTL.TabIndex = 4;
            // 
            // LaHP
            // 
            LaHP.AutoSize = true;
            LaHP.BackColor = Color.AliceBlue;
            tableLayoutPanel1.SetColumnSpan(LaHP, 6);
            LaHP.Dock = DockStyle.Fill;
            LaHP.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaHP.Location = new Point(23, 0);
            LaHP.Name = "LaHP";
            LaHP.Size = new Size(1641, 273);
            LaHP.TabIndex = 0;
            LaHP.Text = "THIẾT LẬP HỌC PHÍ";
            LaHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laML
            // 
            laML.AutoSize = true;
            laML.Dock = DockStyle.Right;
            laML.Font = new Font("Segoe UI", 12F);
            laML.Location = new Point(117, 273);
            laML.Name = "laML";
            laML.Size = new Size(124, 128);
            laML.TabIndex = 1;
            laML.Text = "Mã Lớp: ";
            // 
            // laTL
            // 
            laTL.AutoSize = true;
            laTL.Dock = DockStyle.Right;
            laTL.Font = new Font("Segoe UI", 12F);
            laTL.Location = new Point(823, 273);
            laTL.Name = "laTL";
            laTL.Size = new Size(128, 128);
            laTL.TabIndex = 2;
            laTL.Text = "Tên Lớp: ";
            // 
            // lbHP
            // 
            lbHP.AutoSize = true;
            lbHP.Dock = DockStyle.Right;
            lbHP.Font = new Font("Segoe UI", 12F);
            lbHP.Location = new Point(39, 513);
            lbHP.Name = "lbHP";
            lbHP.Size = new Size(202, 129);
            lbHP.TabIndex = 8;
            lbHP.Text = "Số tiền / người";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 516);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(438, 35);
            textBox1.TabIndex = 9;
            // 
            // laTT
            // 
            laTT.AutoSize = true;
            laTT.Dock = DockStyle.Right;
            laTT.Font = new Font("Segoe UI", 12F);
            laTT.Location = new Point(816, 513);
            laTT.Name = "laTT";
            laTT.Size = new Size(135, 129);
            laTT.TabIndex = 10;
            laTT.Text = "Tổng tiền";
            laTT.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            tableLayoutPanel1.SetColumnSpan(textBox2, 2);
            textBox2.Enabled = false;
            textBox2.Location = new Point(957, 516);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(450, 35);
            textBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(247, 276);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(522, 38);
            comboBox1.TabIndex = 12;
            // 
            // btLuu
            // 
            btLuu.BackColor = Color.FromArgb(112, 146, 190);
            btLuu.Font = new Font("Segoe UI", 9.857143F);
            btLuu.ForeColor = Color.White;
            btLuu.Location = new Point(1415, 783);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(249, 76);
            btLuu.TabIndex = 6;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = false;
            btLuu.Click += btLuu_Click;
            btLuu.MouseEnter += btLuu_MouseEnter;
            btLuu.MouseLeave += btLuu_MouseLeave;
            // 
            // ThietLapHP
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1690, 901);
            Controls.Add(tableLayoutPanel1);
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