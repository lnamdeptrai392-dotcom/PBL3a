namespace PBL3a.UI.AdminTC
{
    partial class QuanLyChung
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
            btLGV = new Button();
            btT = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 334F));
            tableLayoutPanel1.Controls.Add(LaTC, 0, 0);
            tableLayoutPanel1.Controls.Add(btHP, 1, 1);
            tableLayoutPanel1.Controls.Add(btLGV, 1, 2);
            tableLayoutPanel1.Controls.Add(btT, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.46154F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.53846F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.Size = new Size(946, 513);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // LaTC
            // 
            LaTC.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaTC, 6);
            LaTC.Dock = DockStyle.Fill;
            LaTC.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaTC.Location = new Point(2, 0);
            LaTC.Margin = new Padding(2, 0, 2, 0);
            LaTC.Name = "LaTC";
            LaTC.Size = new Size(942, 152);
            LaTC.TabIndex = 1;
            LaTC.Text = "QUẢN LÝ CỦA PHÒNG TÀI CHÍNH";
            LaTC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btHP
            // 
            btHP.Dock = DockStyle.Bottom;
            btHP.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btHP.Location = new Point(308, 180);
            btHP.Margin = new Padding(2, 3, 2, 3);
            btHP.Name = "btHP";
            btHP.Size = new Size(302, 77);
            btHP.TabIndex = 2;
            btHP.Text = "Học Phí Học Viên";
            btHP.UseVisualStyleBackColor = true;
            // 
            // btLGV
            // 
            btLGV.Dock = DockStyle.Bottom;
            btLGV.Font = new Font("Segoe UI", 14.1428576F);
            btLGV.Location = new Point(308, 287);
            btLGV.Margin = new Padding(2, 3, 2, 3);
            btLGV.Name = "btLGV";
            btLGV.Size = new Size(302, 77);
            btLGV.TabIndex = 3;
            btLGV.Text = "Lương Giảng Viên";
            btLGV.UseVisualStyleBackColor = true;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 14.1428576F);
            btT.Location = new Point(308, 388);
            btT.Margin = new Padding(2, 3, 2, 3);
            btT.Name = "btT";
            btT.Size = new Size(302, 77);
            btT.TabIndex = 4;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            // 
            // QuanLyChung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 513);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "QuanLyChung";
            Text = "QuanLyChung";
            Load += QuanLyChung_Load;
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
    }
}