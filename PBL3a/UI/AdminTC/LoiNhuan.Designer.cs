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
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.9277611F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.07224F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 323F));
            tableLayoutPanel1.Controls.Add(LaLN, 0, 0);
            tableLayoutPanel1.Controls.Add(btThu, 1, 2);
            tableLayoutPanel1.Controls.Add(btChi, 1, 3);
            tableLayoutPanel1.Controls.Add(btLN, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.9629631F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.0370369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 134F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.Size = new Size(1293, 752);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LaLN
            // 
            LaLN.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaLN, 6);
            LaLN.Dock = DockStyle.Fill;
            LaLN.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaLN.ForeColor = Color.Black;
            LaLN.Location = new Point(3, 0);
            LaLN.Name = "LaLN";
            LaLN.Size = new Size(1287, 204);
            LaLN.TabIndex = 1;
            LaLN.Text = "QUẢN LÝ LỢI NHUẬN";
            LaLN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btThu
            // 
            btThu.BackColor = Color.FromArgb(112, 146, 190);
            btThu.Dock = DockStyle.Bottom;
            btThu.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btThu.ForeColor = Color.White;
            btThu.Location = new Point(293, 335);
            btThu.Name = "btThu";
            btThu.Size = new Size(673, 114);
            btThu.TabIndex = 2;
            btThu.Text = "Khoản Thu";
            btThu.UseVisualStyleBackColor = false;
            btThu.Click += btThu_Click;
            // 
            // btChi
            // 
            btChi.BackColor = Color.FromArgb(112, 146, 190);
            btChi.Dock = DockStyle.Bottom;
            btChi.Font = new Font("Segoe UI", 14.1428576F);
            btChi.ForeColor = Color.White;
            btChi.Location = new Point(293, 467);
            btChi.Name = "btChi";
            btChi.Size = new Size(673, 116);
            btChi.TabIndex = 3;
            btChi.Text = "Khoản Chi";
            btChi.UseVisualStyleBackColor = false;
            btChi.Click += btChi_Click;
            // 
            // btLN
            // 
            btLN.BackColor = Color.FromArgb(112, 146, 190);
            btLN.Dock = DockStyle.Bottom;
            btLN.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLN.ForeColor = Color.White;
            btLN.Location = new Point(293, 213);
            btLN.Name = "btLN";
            btLN.Size = new Size(673, 116);
            btLN.TabIndex = 5;
            btLN.Text = "Lợi Nhuận";
            btLN.UseVisualStyleBackColor = false;
            btLN.Click += btLN_Click;
            // 
            // LoiNhuan
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1293, 752);
            Controls.Add(tableLayoutPanel1);
            Name = "LoiNhuan";
            Text = "LoiNhuan";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label LaLN;
        private Button btThu;
        private Button btChi;
        private Button btLN;
    }
}