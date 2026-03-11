namespace PBL3a.UI.AdminTC
{
    partial class QuanLyChungTC
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
            LaTC = new Label();
            btHP = new Button();
            btT = new Button();
            btLGV = new Button();
            btLN = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 501F));
            tableLayoutPanel1.Controls.Add(LaTC, 0, 0);
            tableLayoutPanel1.Controls.Add(btHP, 1, 1);
            tableLayoutPanel1.Controls.Add(btT, 1, 4);
            tableLayoutPanel1.Controls.Add(btLGV, 1, 2);
            tableLayoutPanel1.Controls.Add(btLN, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.9629631F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.0370369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Size = new Size(1419, 770);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // LaTC
            // 
            LaTC.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaTC, 6);
            LaTC.Dock = DockStyle.Fill;
            LaTC.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaTC.Location = new Point(3, 0);
            LaTC.Name = "LaTC";
            LaTC.Size = new Size(1413, 234);
            LaTC.TabIndex = 1;
            LaTC.Text = "QUẢN LÝ CỦA PHÒNG TÀI CHÍNH";
            LaTC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btHP
            // 
            btHP.Dock = DockStyle.Bottom;
            btHP.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btHP.Location = new Point(462, 251);
            btHP.Margin = new Padding(3, 4, 3, 4);
            btHP.Name = "btHP";
            btHP.Size = new Size(453, 116);
            btHP.TabIndex = 2;
            btHP.Text = "Học Phí Học Viên";
            btHP.UseVisualStyleBackColor = true;
            btHP.Click += btHP_Click;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 14.1428576F);
            btT.Location = new Point(462, 623);
            btT.Margin = new Padding(3, 4, 3, 4);
            btT.Name = "btT";
            btT.Size = new Size(453, 116);
            btT.TabIndex = 4;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // btLGV
            // 
            btLGV.Dock = DockStyle.Bottom;
            btLGV.Font = new Font("Segoe UI", 14.1428576F);
            btLGV.Location = new Point(462, 377);
            btLGV.Margin = new Padding(3, 4, 3, 4);
            btLGV.Name = "btLGV";
            btLGV.Size = new Size(453, 116);
            btLGV.TabIndex = 3;
            btLGV.Text = "Lương Giảng Viên";
            btLGV.UseVisualStyleBackColor = true;
            btLGV.Click += btLGV_Click;
            // 
            // btLN
            // 
            btLN.Dock = DockStyle.Bottom;
            btLN.Font = new Font("Segoe UI", 14.1428576F);
            btLN.Location = new Point(462, 501);
            btLN.Margin = new Padding(3, 4, 3, 4);
            btLN.Name = "btLN";
            btLN.Size = new Size(453, 112);
            btLN.TabIndex = 5;
            btLN.Text = "Lợi Nhuận";
            btLN.UseVisualStyleBackColor = true;
            btLN.Click += btLN_Click;
            // 
            // QuanLyChungTC
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1419, 770);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuanLyChungTC";
            Text = "QuanLyChung";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label LaTC;
        private Button btHP;
        private Button btLGV;
        private Button btT;
        private Button btLN;
    }
}