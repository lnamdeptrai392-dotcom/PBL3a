namespace PBL3a.UI.AdminTC
{
    partial class LoiNhuan
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
            LaLN = new Label();
            btThu = new Button();
            btChi = new Button();
            btLN = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.9277611F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.07224F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 217F));
            tableLayoutPanel1.Controls.Add(LaLN, 0, 0);
            tableLayoutPanel1.Controls.Add(btThu, 1, 2);
            tableLayoutPanel1.Controls.Add(btChi, 1, 3);
            tableLayoutPanel1.Controls.Add(btLN, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.9629631F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.0370369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.Size = new Size(987, 549);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LaLN
            // 
            LaLN.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaLN, 6);
            LaLN.Dock = DockStyle.Fill;
            LaLN.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaLN.ForeColor = Color.Black;
            LaLN.Location = new Point(2, 0);
            LaLN.Margin = new Padding(2, 0, 2, 0);
            LaLN.Name = "LaLN";
            LaLN.Size = new Size(983, 166);
            LaLN.TabIndex = 1;
            LaLN.Text = "QUẢN LÝ LỢI NHUẬN";
            LaLN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btThu
            // 
            btThu.BackColor = Color.FromArgb(93, 156, 179);
            btThu.Dock = DockStyle.Bottom;
            btThu.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btThu.ForeColor = Color.White;
            btThu.Location = new Point(232, 270);
            btThu.Margin = new Padding(2, 3, 2, 3);
            btThu.Name = "btThu";
            btThu.Size = new Size(535, 75);
            btThu.TabIndex = 2;
            btThu.Text = "Khoản Thu";
            btThu.UseVisualStyleBackColor = false;
            btThu.Click += btThu_Click;
            // 
            // btChi
            // 
            btChi.BackColor = Color.FromArgb(93, 156, 179);
            btChi.Dock = DockStyle.Bottom;
            btChi.Font = new Font("Segoe UI", 14.1428576F);
            btChi.ForeColor = Color.White;
            btChi.Location = new Point(232, 372);
            btChi.Margin = new Padding(2, 3, 2, 3);
            btChi.Name = "btChi";
            btChi.Size = new Size(535, 77);
            btChi.TabIndex = 3;
            btChi.Text = "Khoản Chi";
            btChi.UseVisualStyleBackColor = false;
            btChi.Click += btChi_Click;
            // 
            // btLN
            // 
            btLN.BackColor = Color.FromArgb(93, 156, 179);
            btLN.Dock = DockStyle.Bottom;
            btLN.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLN.ForeColor = Color.White;
            btLN.Location = new Point(232, 171);
            btLN.Margin = new Padding(2, 3, 2, 3);
            btLN.Name = "btLN";
            btLN.Size = new Size(535, 77);
            btLN.TabIndex = 5;
            btLN.Text = "Lợi Nhuận";
            btLN.UseVisualStyleBackColor = false;
            btLN.Click += btLN_Click;
            // 
            // LoiNhuan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(987, 549);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "LoiNhuan";
            Text = "LoiNhuan";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btThu;
        private Button btChi;
        private Button btLN;
        private Label LaLN;
    }
}