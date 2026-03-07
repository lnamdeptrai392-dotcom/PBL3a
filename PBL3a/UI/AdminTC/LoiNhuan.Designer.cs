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
            btT = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.Controls.Add(LaLN, 0, 0);
            tableLayoutPanel1.Controls.Add(btThu, 1, 1);
            tableLayoutPanel1.Controls.Add(btChi, 1, 2);
            tableLayoutPanel1.Controls.Add(btT, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.9629631F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.0370369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 159F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.Size = new Size(1702, 861);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LaLN
            // 
            LaLN.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaLN, 6);
            LaLN.Dock = DockStyle.Fill;
            LaLN.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaLN.Location = new Point(3, 0);
            LaLN.Name = "LaLN";
            LaLN.Size = new Size(1696, 304);
            LaLN.TabIndex = 1;
            LaLN.Text = "QUẢN LÝ LƯƠNG GIẢNG VIÊN";
            LaLN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btThu
            // 
            btThu.Dock = DockStyle.Bottom;
            btThu.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btThu.Location = new Point(604, 363);
            btThu.Name = "btThu";
            btThu.Size = new Size(595, 116);
            btThu.TabIndex = 2;
            btThu.Text = "Khoản Thu";
            btThu.UseVisualStyleBackColor = true;
            // 
            // btChi
            // 
            btChi.Dock = DockStyle.Bottom;
            btChi.Font = new Font("Segoe UI", 14.1428576F);
            btChi.Location = new Point(604, 522);
            btChi.Name = "btChi";
            btChi.Size = new Size(595, 116);
            btChi.TabIndex = 3;
            btChi.Text = "Khoản Chi";
            btChi.UseVisualStyleBackColor = true;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 14.1428576F);
            btT.Location = new Point(604, 675);
            btT.Name = "btT";
            btT.Size = new Size(595, 116);
            btT.TabIndex = 4;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            // 
            // LoiNhuan
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1702, 861);
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
        private Button btT;
    }
}