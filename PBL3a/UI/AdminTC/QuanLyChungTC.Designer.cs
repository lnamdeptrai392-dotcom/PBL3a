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
            btHP = new Button();
            btLGV = new Button();
            panel4 = new Panel();
            panelDesktop = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            btT = new Button();
            btLN = new Button();
            paDesktop = new Panel();
            panel4.SuspendLayout();
            panelDesktop.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btHP
            // 
            btHP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btHP.BackColor = Color.FromArgb(112, 146, 190);
            btHP.FlatAppearance.BorderSize = 0;
            btHP.FlatStyle = FlatStyle.Flat;
            btHP.Font = new Font("Microsoft Sans Serif", 11.1428576F);
            btHP.ForeColor = Color.White;
            btHP.Location = new Point(3, 99);
            btHP.Margin = new Padding(3, 4, 3, 4);
            btHP.Name = "btHP";
            btHP.Size = new Size(361, 91);
            btHP.TabIndex = 2;
            btHP.Text = "Học Phí Học Viên";
            btHP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btHP.UseVisualStyleBackColor = false;
            btHP.Click += btHP_Click;
            // 
            // btLGV
            // 
            btLGV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btLGV.BackColor = Color.FromArgb(112, 146, 190);
            btLGV.FlatAppearance.BorderSize = 0;
            btLGV.FlatStyle = FlatStyle.Flat;
            btLGV.Font = new Font("Microsoft Sans Serif", 11.1428576F);
            btLGV.ForeColor = Color.White;
            btLGV.Location = new Point(3, 198);
            btLGV.Margin = new Padding(3, 4, 3, 4);
            btLGV.Name = "btLGV";
            btLGV.Padding = new Padding(10, 0, 0, 0);
            btLGV.Size = new Size(361, 89);
            btLGV.TabIndex = 3;
            btLGV.Text = "Lương Giảng Viên";
            btLGV.UseVisualStyleBackColor = false;
            btLGV.Click += btLGV_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panelDesktop);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1690, 901);
            panel4.TabIndex = 4;
            // 
            // panelDesktop
            // 
            panelDesktop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktop.Controls.Add(tableLayoutPanel1);
            panelDesktop.Location = new Point(0, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1690, 901);
            panelDesktop.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.FromArgb(112, 146, 190);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.7159767F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.28403F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(btT, 0, 4);
            tableLayoutPanel1.Controls.Add(btLGV, 0, 2);
            tableLayoutPanel1.Controls.Add(btLN, 0, 3);
            tableLayoutPanel1.Controls.Add(paDesktop, 1, 1);
            tableLayoutPanel1.Controls.Add(btHP, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 415F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1690, 901);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(112, 146, 190);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(370, 0);
            label1.Name = "label1";
            label1.Size = new Size(1317, 95);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ TÀI CHÍNH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btT
            // 
            btT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btT.BackColor = Color.FromArgb(112, 146, 190);
            btT.FlatAppearance.BorderSize = 0;
            btT.FlatStyle = FlatStyle.Flat;
            btT.Font = new Font("Microsoft Sans Serif", 11.1428576F);
            btT.ForeColor = Color.White;
            btT.Location = new Point(3, 394);
            btT.Margin = new Padding(3, 4, 3, 4);
            btT.Name = "btT";
            btT.Padding = new Padding(10, 0, 0, 0);
            btT.Size = new Size(361, 94);
            btT.TabIndex = 4;
            btT.Text = "Đăng xuất";
            btT.UseVisualStyleBackColor = false;
            btT.Click += btT_Click;
            // 
            // btLN
            // 
            btLN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btLN.BackColor = Color.FromArgb(112, 146, 190);
            btLN.FlatAppearance.BorderSize = 0;
            btLN.FlatStyle = FlatStyle.Flat;
            btLN.Font = new Font("Microsoft Sans Serif", 11.1428576F);
            btLN.ForeColor = Color.White;
            btLN.Location = new Point(3, 295);
            btLN.Margin = new Padding(3, 4, 3, 4);
            btLN.Name = "btLN";
            btLN.Padding = new Padding(10, 0, 0, 0);
            btLN.Size = new Size(361, 91);
            btLN.TabIndex = 5;
            btLN.Text = "Lợi Nhuận";
            btLN.UseVisualStyleBackColor = false;
            btLN.Click += btLN_Click;
            // 
            // paDesktop
            // 
            paDesktop.BackColor = Color.AliceBlue;
            paDesktop.Dock = DockStyle.Fill;
            paDesktop.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paDesktop.ForeColor = Color.White;
            paDesktop.Location = new Point(370, 98);
            paDesktop.Name = "paDesktop";
            tableLayoutPanel1.SetRowSpan(paDesktop, 5);
            paDesktop.Size = new Size(1317, 800);
            paDesktop.TabIndex = 8;
            // 
            // QuanLyChungTC
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1690, 901);
            Controls.Add(panel4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuanLyChungTC";
            Text = "QuanLyChung";
            panel4.ResumeLayout(false);
            panelDesktop.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btHP;
        private Button btLGV;
        private Panel panel4;
        private Button btLN;
        private Button btT;
        private Panel panelDesktop;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel paDesktop;
        private Label label1;
    }
}