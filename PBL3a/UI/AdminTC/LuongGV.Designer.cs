namespace PBL3a.UI.AdminTC
{
    partial class LuongGV
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
            LaL = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbTL = new TextBox();
            laMGV = new Label();
            laTGV = new Label();
            tbML = new TextBox();
            listView1 = new ListView();
            btT = new Button();
            btCheckL = new Button();
            btSetL = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LaL
            // 
            LaL.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaL, 6);
            LaL.Dock = DockStyle.Fill;
            LaL.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaL.Location = new Point(15, 0);
            LaL.Margin = new Padding(2, 0, 2, 0);
            LaL.Name = "LaL";
            LaL.Size = new Size(1000, 88);
            LaL.TabIndex = 0;
            LaL.Text = "QUẢN LÝ LƯƠNG GIẢNG VIÊN";
            LaL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.02892F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.97108F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 183F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 263F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.Controls.Add(tbTL, 4, 1);
            tableLayoutPanel1.Controls.Add(LaL, 1, 0);
            tableLayoutPanel1.Controls.Add(laMGV, 1, 1);
            tableLayoutPanel1.Controls.Add(laTGV, 3, 1);
            tableLayoutPanel1.Controls.Add(tbML, 2, 1);
            tableLayoutPanel1.Controls.Add(listView1, 1, 3);
            tableLayoutPanel1.Controls.Add(btT, 6, 6);
            tableLayoutPanel1.Controls.Add(btCheckL, 6, 5);
            tableLayoutPanel1.Controls.Add(btSetL, 6, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.Size = new Size(1032, 547);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbTL
            // 
            tableLayoutPanel1.SetColumnSpan(tbTL, 2);
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(559, 90);
            tbTL.Margin = new Padding(2);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(286, 27);
            tbTL.TabIndex = 4;
            // 
            // laMGV
            // 
            laMGV.AutoSize = true;
            laMGV.Dock = DockStyle.Right;
            laMGV.Font = new Font("Segoe UI", 12F);
            laMGV.Location = new Point(28, 88);
            laMGV.Margin = new Padding(2, 0, 2, 0);
            laMGV.Name = "laMGV";
            laMGV.Size = new Size(102, 38);
            laMGV.TabIndex = 1;
            laMGV.Text = "Mã Giảng Viên: ";
            // 
            // laTGV
            // 
            laTGV.AutoSize = true;
            laTGV.Dock = DockStyle.Right;
            laTGV.Font = new Font("Segoe UI", 12F);
            laTGV.Location = new Point(405, 88);
            laTGV.Margin = new Padding(2, 0, 2, 0);
            laTGV.Name = "laTGV";
            laTGV.Size = new Size(150, 38);
            laTGV.TabIndex = 2;
            laTGV.Text = "Tên Giảng Viên: ";
            // 
            // tbML
            // 
            tbML.Dock = DockStyle.Fill;
            tbML.Location = new Point(134, 90);
            tbML.Margin = new Padding(2);
            tbML.Name = "tbML";
            tbML.Size = new Size(238, 27);
            tbML.TabIndex = 3;
            // 
            // listView1
            // 
            tableLayoutPanel1.SetColumnSpan(listView1, 4);
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(15, 153);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            tableLayoutPanel1.SetRowSpan(listView1, 4);
            listView1.Size = new Size(803, 378);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 9.857143F);
            btT.Location = new Point(849, 480);
            btT.Margin = new Padding(2);
            btT.Name = "btT";
            btT.Size = new Size(166, 51);
            btT.TabIndex = 7;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // btCheckL
            // 
            btCheckL.Dock = DockStyle.Bottom;
            btCheckL.Font = new Font("Segoe UI", 9.857143F);
            btCheckL.Location = new Point(849, 415);
            btCheckL.Margin = new Padding(2);
            btCheckL.Name = "btCheckL";
            btCheckL.Size = new Size(166, 51);
            btCheckL.TabIndex = 6;
            btCheckL.Text = "Kiểm tra tình trạng";
            btCheckL.UseVisualStyleBackColor = true;
            // 
            // btSetL
            // 
            btSetL.Dock = DockStyle.Bottom;
            btSetL.Font = new Font("Segoe UI", 9.857143F);
            btSetL.Location = new Point(849, 344);
            btSetL.Margin = new Padding(2);
            btSetL.Name = "btSetL";
            btSetL.Size = new Size(166, 51);
            btSetL.TabIndex = 5;
            btSetL.Text = "Tính toán lương";
            btSetL.UseVisualStyleBackColor = true;
            // 
            // LuongGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 547);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "LuongGV";
            Text = "LuongGV";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LaL;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbTL;
        private Label laMGV;
        private Label laTGV;
        private TextBox tbML;
        private ListView listView1;
        private Button btT;
        private Button btCheckL;
        private Button btSetL;
    }
}