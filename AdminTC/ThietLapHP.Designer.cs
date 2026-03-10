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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8273163F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.17268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 181F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 415F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 255F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.1415939F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.858408F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.Size = new Size(1571, 840);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbTL
            // 
            tableLayoutPanel1.SetColumnSpan(tbTL, 2);
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(841, 234);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(451, 35);
            tbTL.TabIndex = 4;
            // 
            // LaHP
            // 
            LaHP.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaHP, 6);
            LaHP.Dock = DockStyle.Fill;
            LaHP.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaHP.Location = new Point(23, 0);
            LaHP.Name = "LaHP";
            LaHP.Size = new Size(1524, 231);
            LaHP.TabIndex = 0;
            LaHP.Text = "THIẾT LẬP HỌC PHÍ";
            LaHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laML
            // 
            laML.AutoSize = true;
            laML.Dock = DockStyle.Right;
            laML.Font = new Font("Segoe UI", 12F);
            laML.Location = new Point(83, 231);
            laML.Name = "laML";
            laML.Size = new Size(124, 108);
            laML.TabIndex = 1;
            laML.Text = "Mã Lớp: ";
            // 
            // laTL
            // 
            laTL.AutoSize = true;
            laTL.Dock = DockStyle.Right;
            laTL.Font = new Font("Segoe UI", 12F);
            laTL.Location = new Point(707, 231);
            laTL.Name = "laTL";
            laTL.Size = new Size(128, 108);
            laTL.TabIndex = 2;
            laTL.Text = "Tên Lớp: ";
            // 
            // tbML
            // 
            tbML.Dock = DockStyle.Fill;
            tbML.Location = new Point(213, 234);
            tbML.Name = "tbML";
            tbML.Size = new Size(441, 35);
            tbML.TabIndex = 3;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 9.857143F);
            btT.Location = new Point(1298, 739);
            btT.Name = "btT";
            btT.Size = new Size(249, 76);
            btT.TabIndex = 7;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // btLuu
            // 
            btLuu.Dock = DockStyle.Bottom;
            btLuu.Font = new Font("Segoe UI", 9.857143F);
            btLuu.Location = new Point(1298, 640);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(249, 76);
            btLuu.TabIndex = 6;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            // 
            // lbHP
            // 
            lbHP.AutoSize = true;
            lbHP.Dock = DockStyle.Right;
            lbHP.Font = new Font("Segoe UI", 12F);
            lbHP.Location = new Point(77, 451);
            lbHP.Name = "lbHP";
            lbHP.Size = new Size(130, 129);
            lbHP.TabIndex = 8;
            lbHP.Text = "Số tiền / người";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 454);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(441, 35);
            textBox1.TabIndex = 9;
            // 
            // laTT
            // 
            laTT.AutoSize = true;
            laTT.Dock = DockStyle.Right;
            laTT.Font = new Font("Segoe UI", 12F);
            laTT.Location = new Point(700, 451);
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
            textBox2.Location = new Point(841, 454);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(451, 35);
            textBox2.TabIndex = 11;
            // 
            // ThietLapHP
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 840);
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
        private TextBox tbML;
        private Button btT;
        private Button btLuu;
        private Label lbHP;
        private TextBox textBox1;
        private Label laTT;
        private TextBox textBox2;
    }
}