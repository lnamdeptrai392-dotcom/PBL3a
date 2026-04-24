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
            txtTienTrenNg = new TextBox();
            laTT = new Label();
            txtTongT = new TextBox();
            cbbMaLop = new ComboBox();
            butTT = new Button();
            btLuu = new Button();
            button1 = new Button();
            label1 = new Label();
            txtSS = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8273163F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.17268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 278F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 17F));
            tableLayoutPanel1.Controls.Add(tbTL, 4, 1);
            tableLayoutPanel1.Controls.Add(LaHP, 1, 0);
            tableLayoutPanel1.Controls.Add(laML, 1, 1);
            tableLayoutPanel1.Controls.Add(laTL, 3, 1);
            tableLayoutPanel1.Controls.Add(lbHP, 1, 3);
            tableLayoutPanel1.Controls.Add(txtTienTrenNg, 2, 3);
            tableLayoutPanel1.Controls.Add(laTT, 3, 3);
            tableLayoutPanel1.Controls.Add(txtTongT, 4, 3);
            tableLayoutPanel1.Controls.Add(cbbMaLop, 2, 1);
            tableLayoutPanel1.Controls.Add(butTT, 6, 4);
            tableLayoutPanel1.Controls.Add(btLuu, 6, 5);
            tableLayoutPanel1.Controls.Add(button1, 6, 6);
            tableLayoutPanel1.Controls.Add(label1, 1, 4);
            tableLayoutPanel1.Controls.Add(txtSS, 2, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.1415939F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.858408F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.Size = new Size(1127, 600);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbTL
            // 
            tableLayoutPanel1.SetColumnSpan(tbTL, 2);
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(636, 185);
            tbTL.Margin = new Padding(2, 3, 2, 3);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(301, 27);
            tbTL.TabIndex = 4;
            // 
            // LaHP
            // 
            LaHP.AutoSize = true;
            LaHP.BackColor = Color.White;
            tableLayoutPanel1.SetColumnSpan(LaHP, 6);
            LaHP.Dock = DockStyle.Fill;
            LaHP.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaHP.Location = new Point(16, 0);
            LaHP.Margin = new Padding(2, 0, 2, 0);
            LaHP.Name = "LaHP";
            LaHP.Size = new Size(1091, 182);
            LaHP.TabIndex = 0;
            LaHP.Text = "THIẾT LẬP HỌC PHÍ";
            LaHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laML
            // 
            laML.AutoSize = true;
            laML.Dock = DockStyle.Right;
            laML.Font = new Font("Segoe UI", 12F);
            laML.Location = new Point(74, 182);
            laML.Margin = new Padding(2, 0, 2, 0);
            laML.Name = "laML";
            laML.Size = new Size(87, 85);
            laML.TabIndex = 1;
            laML.Text = "Mã Lớp: ";
            // 
            // laTL
            // 
            laTL.AutoSize = true;
            laTL.Dock = DockStyle.Right;
            laTL.Font = new Font("Segoe UI", 12F);
            laTL.Location = new Point(544, 182);
            laTL.Margin = new Padding(2, 0, 2, 0);
            laTL.Name = "laTL";
            laTL.Size = new Size(88, 85);
            laTL.TabIndex = 2;
            laTL.Text = "Tên Lớp: ";
            // 
            // lbHP
            // 
            lbHP.AutoSize = true;
            lbHP.Dock = DockStyle.Right;
            lbHP.Font = new Font("Segoe UI", 12F);
            lbHP.Location = new Point(18, 281);
            lbHP.Margin = new Padding(2, 0, 2, 0);
            lbHP.Name = "lbHP";
            lbHP.Size = new Size(143, 108);
            lbHP.TabIndex = 8;
            lbHP.Text = "Số tiền / người";
            // 
            // txtTienTrenNg
            // 
            txtTienTrenNg.Location = new Point(165, 284);
            txtTienTrenNg.Margin = new Padding(2, 3, 2, 3);
            txtTienTrenNg.Name = "txtTienTrenNg";
            txtTienTrenNg.Size = new Size(346, 27);
            txtTienTrenNg.TabIndex = 9;
            // 
            // laTT
            // 
            laTT.AutoSize = true;
            laTT.Dock = DockStyle.Right;
            laTT.Font = new Font("Segoe UI", 12F);
            laTT.Location = new Point(537, 281);
            laTT.Margin = new Padding(2, 0, 2, 0);
            laTT.Name = "laTT";
            laTT.Size = new Size(95, 108);
            laTT.TabIndex = 10;
            laTT.Text = "Tổng tiền";
            laTT.TextAlign = ContentAlignment.TopRight;
            // 
            // txtTongT
            // 
            tableLayoutPanel1.SetColumnSpan(txtTongT, 2);
            txtTongT.Dock = DockStyle.Fill;
            txtTongT.Enabled = false;
            txtTongT.Location = new Point(636, 284);
            txtTongT.Margin = new Padding(2, 3, 2, 3);
            txtTongT.Name = "txtTongT";
            txtTongT.Size = new Size(301, 27);
            txtTongT.TabIndex = 11;
            // 
            // cbbMaLop
            // 
            cbbMaLop.Dock = DockStyle.Fill;
            cbbMaLop.FormattingEnabled = true;
            cbbMaLop.Location = new Point(165, 185);
            cbbMaLop.Margin = new Padding(2, 3, 2, 3);
            cbbMaLop.Name = "cbbMaLop";
            cbbMaLop.Size = new Size(346, 28);
            cbbMaLop.TabIndex = 12;
            cbbMaLop.SelectedIndexChanged += cbbMaLop_SelectedIndexChanged;
            // 
            // butTT
            // 
            butTT.BackColor = Color.FromArgb(93, 156, 179);
            butTT.Font = new Font("Segoe UI", 9.857143F);
            butTT.ForeColor = Color.White;
            butTT.Location = new Point(941, 392);
            butTT.Margin = new Padding(2, 3, 2, 3);
            butTT.Name = "butTT";
            butTT.Size = new Size(166, 51);
            butTT.TabIndex = 13;
            butTT.Text = "Tổng tiền";
            butTT.UseVisualStyleBackColor = false;
            butTT.Click += butTT_Click;
            // 
            // btLuu
            // 
            btLuu.BackColor = Color.FromArgb(93, 156, 179);
            btLuu.Font = new Font("Segoe UI", 9.857143F);
            btLuu.ForeColor = Color.White;
            btLuu.Location = new Point(941, 457);
            btLuu.Margin = new Padding(2, 3, 2, 3);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(166, 51);
            btLuu.TabIndex = 6;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = false;
            btLuu.Click += btLuu_Click;
            btLuu.MouseEnter += btLuu_MouseEnter;
            btLuu.MouseLeave += btLuu_MouseLeave;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(93, 156, 179);
            button1.Font = new Font("Segoe UI", 9.857143F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(941, 522);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(166, 51);
            button1.TabIndex = 16;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(108, 389);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 65);
            label1.TabIndex = 14;
            label1.Text = "Sĩ số";
            // 
            // txtSS
            // 
            txtSS.Dock = DockStyle.Fill;
            txtSS.Location = new Point(166, 393);
            txtSS.Margin = new Padding(3, 4, 3, 4);
            txtSS.Name = "txtSS";
            txtSS.Size = new Size(344, 27);
            txtSS.TabIndex = 15;
            // 
            // ThietLapHP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1127, 600);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 3, 2, 3);
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
        private TextBox txtTongT;
        private TextBox txtTienTrenNg;
        private ComboBox cbbMaLop;
        private Button butTT;
        private Label label1;
        private TextBox txtSS;
        private Button button1;
    }
}