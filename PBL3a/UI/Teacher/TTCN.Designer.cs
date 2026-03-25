namespace PBL3a.UI.Teacher
{
    partial class TTCN
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbHVT = new TextBox();
            tbSDT = new TextBox();
            tbE = new TextBox();
            tbMD = new TextBox();
            tbMGV = new TextBox();
            cbbGT = new ComboBox();
            dtNS = new DateTimePicker();
            btT = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 434F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 215F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 388F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 4, 1);
            tableLayoutPanel1.Controls.Add(label8, 4, 2);
            tableLayoutPanel1.Controls.Add(tbHVT, 2, 1);
            tableLayoutPanel1.Controls.Add(tbSDT, 2, 4);
            tableLayoutPanel1.Controls.Add(tbE, 2, 5);
            tableLayoutPanel1.Controls.Add(tbMD, 5, 1);
            tableLayoutPanel1.Controls.Add(tbMGV, 5, 2);
            tableLayoutPanel1.Controls.Add(cbbGT, 2, 2);
            tableLayoutPanel1.Controls.Add(dtNS, 2, 3);
            tableLayoutPanel1.Controls.Add(btT, 5, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 11.1428576F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 137F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 89F));
            tableLayoutPanel1.Size = new Size(1474, 785);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 7);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1468, 137);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN CÁ NHÂN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.1428576F);
            label2.Location = new Point(165, 137);
            label2.Name = "label2";
            label2.Size = new Size(137, 37);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.1428576F);
            label3.Location = new Point(165, 241);
            label3.Name = "label3";
            label3.Size = new Size(125, 37);
            label3.TabIndex = 2;
            label3.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.1428576F);
            label4.Location = new Point(165, 348);
            label4.Name = "label4";
            label4.Size = new Size(148, 37);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.1428576F);
            label5.Location = new Point(165, 461);
            label5.Name = "label5";
            label5.Size = new Size(70, 37);
            label5.TabIndex = 4;
            label5.Text = "SĐT:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.1428576F);
            label6.Location = new Point(165, 569);
            label6.Name = "label6";
            label6.Size = new Size(88, 37);
            label6.TabIndex = 5;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.1428576F);
            label7.Location = new Point(838, 137);
            label7.Name = "label7";
            label7.Size = new Size(173, 37);
            label7.TabIndex = 6;
            label7.Text = "Chuyên môn:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.1428576F);
            label8.Location = new Point(838, 241);
            label8.Name = "label8";
            label8.Size = new Size(192, 37);
            label8.TabIndex = 7;
            label8.Text = "Mã giảng viên:";
            // 
            // tbHVT
            // 
            tbHVT.Dock = DockStyle.Fill;
            tbHVT.Location = new Point(340, 140);
            tbHVT.Name = "tbHVT";
            tbHVT.Size = new Size(428, 42);
            tbHVT.TabIndex = 9;
            // 
            // tbSDT
            // 
            tbSDT.Dock = DockStyle.Fill;
            tbSDT.Location = new Point(340, 464);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(428, 42);
            tbSDT.TabIndex = 10;
            // 
            // tbE
            // 
            tbE.Dock = DockStyle.Fill;
            tbE.Location = new Point(340, 572);
            tbE.Name = "tbE";
            tbE.Size = new Size(428, 42);
            tbE.TabIndex = 11;
            // 
            // tbMD
            // 
            tbMD.Dock = DockStyle.Fill;
            tbMD.Location = new Point(1053, 140);
            tbMD.Name = "tbMD";
            tbMD.Size = new Size(382, 42);
            tbMD.TabIndex = 12;
            // 
            // tbMGV
            // 
            tbMGV.Dock = DockStyle.Fill;
            tbMGV.Location = new Point(1053, 244);
            tbMGV.Name = "tbMGV";
            tbMGV.Size = new Size(382, 42);
            tbMGV.TabIndex = 13;
            // 
            // cbbGT
            // 
            cbbGT.Dock = DockStyle.Fill;
            cbbGT.FormattingEnabled = true;
            cbbGT.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGT.Location = new Point(340, 244);
            cbbGT.Name = "cbbGT";
            cbbGT.Size = new Size(428, 44);
            cbbGT.TabIndex = 14;
            // 
            // dtNS
            // 
            dtNS.Dock = DockStyle.Fill;
            dtNS.Location = new Point(340, 351);
            dtNS.Name = "dtNS";
            dtNS.Size = new Size(428, 42);
            dtNS.TabIndex = 15;
            // 
            // btT
            // 
            btT.Location = new Point(1053, 572);
            btT.Name = "btT";
            btT.Size = new Size(172, 88);
            btT.TabIndex = 8;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // TTCN
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1474, 785);
            Controls.Add(tableLayoutPanel1);
            Name = "TTCN";
            Text = "QuanLyChungT";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btT;
        private TextBox tbHVT;
        private TextBox tbSDT;
        private TextBox tbE;
        private TextBox tbMD;
        private TextBox tbMGV;
        private ComboBox cbbGT;
        private DateTimePicker dtNS;
    }
}