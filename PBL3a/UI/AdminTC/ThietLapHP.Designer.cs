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
            tbML = new TextBox();
            btT = new Button();
            btLuu = new Button();
            lbHP = new Label();
            textBox1 = new TextBox();
            laTT = new Label();
            textBox2 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8273163F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.17268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 277F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.Controls.Add(tbTL, 4, 1);
            tableLayoutPanel1.Controls.Add(LaHP, 1, 0);
            tableLayoutPanel1.Controls.Add(laML, 1, 1);
            tableLayoutPanel1.Controls.Add(laTL, 3, 1);
            tableLayoutPanel1.Controls.Add(tbML, 2, 1);
            tableLayoutPanel1.Controls.Add(btT, 6, 6);
            tableLayoutPanel1.Controls.Add(btLuu, 6, 5);
            tableLayoutPanel1.Controls.Add(lbHP, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 2, 3);
            tableLayoutPanel1.Controls.Add(laTT, 3, 3);
            tableLayoutPanel1.Controls.Add(textBox2, 4, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.1415939F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.858408F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.Size = new Size(1047, 560);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbTL
            // 
            tableLayoutPanel1.SetColumnSpan(tbTL, 2);
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(559, 156);
            tbTL.Margin = new Padding(2, 2, 2, 2);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(301, 27);
            tbTL.TabIndex = 4;
            // 
            // LaHP
            // 
            LaHP.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaHP, 6);
            LaHP.Dock = DockStyle.Fill;
            LaHP.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaHP.Location = new Point(15, 0);
            LaHP.Margin = new Padding(2, 0, 2, 0);
            LaHP.Name = "LaHP";
            LaHP.Size = new Size(1015, 154);
            LaHP.TabIndex = 0;
            LaHP.Text = "THIẾT LẬP HỌC PHÍ";
            LaHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laML
            // 
            laML.AutoSize = true;
            laML.Dock = DockStyle.Right;
            laML.Font = new Font("Segoe UI", 12F);
            laML.Location = new Point(50, 154);
            laML.Margin = new Padding(2, 0, 2, 0);
            laML.Name = "laML";
            laML.Size = new Size(87, 72);
            laML.TabIndex = 1;
            laML.Text = "Mã Lớp: ";
            // 
            // laTL
            // 
            laTL.AutoSize = true;
            laTL.Dock = DockStyle.Right;
            laTL.Font = new Font("Segoe UI", 12F);
            laTL.Location = new Point(467, 154);
            laTL.Margin = new Padding(2, 0, 2, 0);
            laTL.Name = "laTL";
            laTL.Size = new Size(88, 72);
            laTL.TabIndex = 2;
            laTL.Text = "Tên Lớp: ";
            // 
            // tbML
            // 
            tbML.Dock = DockStyle.Fill;
            tbML.Location = new Point(141, 156);
            tbML.Margin = new Padding(2, 2, 2, 2);
            tbML.Name = "tbML";
            tbML.Size = new Size(293, 27);
            tbML.TabIndex = 3;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 9.857143F);
            btT.Location = new Point(864, 492);
            btT.Margin = new Padding(2, 2, 2, 2);
            btT.Name = "btT";
            btT.Size = new Size(166, 51);
            btT.TabIndex = 7;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // btLuu
            // 
            btLuu.Dock = DockStyle.Bottom;
            btLuu.Font = new Font("Segoe UI", 9.857143F);
            btLuu.Location = new Point(864, 426);
            btLuu.Margin = new Padding(2, 2, 2, 2);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(166, 51);
            btLuu.TabIndex = 6;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            // 
            // lbHP
            // 
            lbHP.AutoSize = true;
            lbHP.Dock = DockStyle.Right;
            lbHP.Font = new Font("Segoe UI", 12F);
            lbHP.Location = new Point(46, 301);
            lbHP.Margin = new Padding(2, 0, 2, 0);
            lbHP.Name = "lbHP";
            lbHP.Size = new Size(91, 86);
            lbHP.TabIndex = 8;
            lbHP.Text = "Số tiền / người";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 303);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 27);
            textBox1.TabIndex = 9;
            // 
            // laTT
            // 
            laTT.AutoSize = true;
            laTT.Dock = DockStyle.Right;
            laTT.Font = new Font("Segoe UI", 12F);
            laTT.Location = new Point(460, 301);
            laTT.Margin = new Padding(2, 0, 2, 0);
            laTT.Name = "laTT";
            laTT.Size = new Size(95, 86);
            laTT.TabIndex = 10;
            laTT.Text = "Tổng tiền";
            laTT.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            tableLayoutPanel1.SetColumnSpan(textBox2, 2);
            textBox2.Enabled = false;
            textBox2.Location = new Point(559, 303);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 27);
            textBox2.TabIndex = 11;
            // 
            // ThietLapHP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 560);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 2, 2, 2);
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
        private TextBox tbML;
        private Button btT;
        private Button btLuu;
        private Label lbHP;
        private TextBox textBox1;
        private Label laTT;
        private TextBox textBox2;
    }
}