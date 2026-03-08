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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 292F));
            tableLayoutPanel1.Controls.Add(LaTC, 0, 0);
            tableLayoutPanel1.Controls.Add(btHP, 1, 1);
            tableLayoutPanel1.Controls.Add(btLGV, 1, 2);
            tableLayoutPanel1.Controls.Add(btT, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.9629631F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.0370369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(828, 385);
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
            LaTC.Size = new Size(824, 123);
            LaTC.TabIndex = 1;
            LaTC.Text = "QUẢN LÝ CỦA PHÒNG TÀI CHÍNH";
            LaTC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btHP
            // 
            btHP.Dock = DockStyle.Bottom;
            btHP.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btHP.Location = new Point(270, 135);
            btHP.Margin = new Padding(2, 2, 2, 2);
            btHP.Name = "btHP";
            btHP.Size = new Size(264, 58);
            btHP.TabIndex = 2;
            btHP.Text = "Học Phí Học Viên";
            btHP.UseVisualStyleBackColor = true;
            // 
            // btLGV
            // 
            btLGV.Dock = DockStyle.Bottom;
            btLGV.Font = new Font("Segoe UI", 14.1428576F);
            btLGV.Location = new Point(270, 215);
            btLGV.Margin = new Padding(2, 2, 2, 2);
            btLGV.Name = "btLGV";
            btLGV.Size = new Size(264, 58);
            btLGV.TabIndex = 3;
            btLGV.Text = "Lương Giảng Viên";
            btLGV.UseVisualStyleBackColor = true;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 14.1428576F);
            btT.Location = new Point(270, 291);
            btT.Margin = new Padding(2, 2, 2, 2);
            btT.Name = "btT";
            btT.Size = new Size(264, 58);
            btT.TabIndex = 4;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            // 
            // QuanLyChung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 385);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 2, 2, 2);
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