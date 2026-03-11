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
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
<<<<<<< Updated upstream
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.2972527F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.7027473F));
=======
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.046627F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.953373F));
>>>>>>> Stashed changes
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.Controls.Add(LaLN, 0, 0);
            tableLayoutPanel1.Controls.Add(btThu, 1, 2);
            tableLayoutPanel1.Controls.Add(btChi, 1, 3);
            tableLayoutPanel1.Controls.Add(btT, 1, 4);
            tableLayoutPanel1.Controls.Add(button1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.9629631F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
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
            LaLN.Size = new Size(1696, 209);
            LaLN.TabIndex = 1;
            LaLN.Text = "QUẢN LÝ LỢI NHUẬN";
            LaLN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btThu
            // 
            btThu.Dock = DockStyle.Bottom;
            btThu.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
            btThu.Location = new Point(523, 363);
            btThu.Name = "btThu";
            btThu.Size = new Size(675, 116);
=======
            btThu.Location = new Point(532, 363);
            btThu.Name = "btThu";
            btThu.Size = new Size(666, 116);
>>>>>>> Stashed changes
            btThu.TabIndex = 2;
            btThu.Text = "Khoản Thu";
            btThu.UseVisualStyleBackColor = true;
            btThu.Click += btThu_Click;
            // 
            // btChi
            // 
            btChi.Dock = DockStyle.Bottom;
            btChi.Font = new Font("Segoe UI", 14.1428576F);
<<<<<<< Updated upstream
            btChi.Location = new Point(523, 522);
            btChi.Name = "btChi";
            btChi.Size = new Size(675, 116);
=======
            btChi.Location = new Point(532, 522);
            btChi.Name = "btChi";
            btChi.Size = new Size(666, 116);
>>>>>>> Stashed changes
            btChi.TabIndex = 3;
            btChi.Text = "Khoản Chi";
            btChi.UseVisualStyleBackColor = true;
            btChi.Click += btChi_Click;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 14.1428576F);
<<<<<<< Updated upstream
            btT.Location = new Point(523, 675);
            btT.Name = "btT";
            btT.Size = new Size(675, 116);
=======
            btT.Location = new Point(532, 675);
            btT.Name = "btT";
            btT.Size = new Size(666, 116);
>>>>>>> Stashed changes
            btT.TabIndex = 4;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(523, 212);
            button1.Name = "button1";
            button1.Size = new Size(675, 116);
            button1.TabIndex = 5;
            button1.Text = "Tính lợi nhuận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoiNhuan
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
        private Button button1;
    }
}