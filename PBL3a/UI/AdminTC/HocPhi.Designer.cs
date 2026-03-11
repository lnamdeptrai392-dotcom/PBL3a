namespace PBL3a.UI.AdminTC
{
    partial class HocPhi
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
            tbTL = new TextBox();
            LaHP = new Label();
            laML = new Label();
            laTL = new Label();
            btT = new Button();
            btCheckHP = new Button();
            btSetHP = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.8125954F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.1874F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.Controls.Add(tbTL, 4, 1);
            tableLayoutPanel1.Controls.Add(LaHP, 1, 0);
            tableLayoutPanel1.Controls.Add(laML, 1, 1);
            tableLayoutPanel1.Controls.Add(laTL, 3, 1);
            tableLayoutPanel1.Controls.Add(btT, 6, 6);
            tableLayoutPanel1.Controls.Add(btCheckHP, 6, 5);
            tableLayoutPanel1.Controls.Add(btSetHP, 6, 4);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(894, 400);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tbTL
            // 
            tableLayoutPanel1.SetColumnSpan(tbTL, 2);
            tbTL.Dock = DockStyle.Fill;
            tbTL.Enabled = false;
            tbTL.Location = new Point(466, 63);
            tbTL.Margin = new Padding(2);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(263, 23);
            tbTL.TabIndex = 4;
            // 
            // LaHP
            // 
            LaHP.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LaHP, 6);
            LaHP.Dock = DockStyle.Fill;
            LaHP.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaHP.Location = new Point(14, 0);
            LaHP.Margin = new Padding(2, 0, 2, 0);
            LaHP.Name = "LaHP";
            LaHP.Size = new Size(864, 61);
            LaHP.TabIndex = 0;
            LaHP.Text = "QUẢN LÝ HỌC PHÍ";
            LaHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laML
            // 
            laML.AutoSize = true;
            laML.Dock = DockStyle.Right;
            laML.Font = new Font("Segoe UI", 12F);
            laML.Location = new Point(15, 61);
            laML.Margin = new Padding(2, 0, 2, 0);
            laML.Name = "laML";
            laML.Size = new Size(70, 27);
            laML.TabIndex = 1;
            laML.Text = "Mã Lớp: ";
            // 
            // laTL
            // 
            laTL.AutoSize = true;
            laTL.Dock = DockStyle.Right;
            laTL.Font = new Font("Segoe UI", 12F);
            laTL.Location = new Point(391, 61);
            laTL.Margin = new Padding(2, 0, 2, 0);
            laTL.Name = "laTL";
            laTL.Size = new Size(71, 27);
            laTL.TabIndex = 2;
            laTL.Text = "Tên Lớp: ";
            // 
            // btT
            // 
            btT.Dock = DockStyle.Bottom;
            btT.Font = new Font("Segoe UI", 9.857143F);
            btT.Location = new Point(733, 349);
            btT.Margin = new Padding(2);
            btT.Name = "btT";
            btT.Size = new Size(145, 38);
            btT.TabIndex = 7;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // btCheckHP
            // 
            btCheckHP.Dock = DockStyle.Bottom;
            btCheckHP.Font = new Font("Segoe UI", 9.857143F);
            btCheckHP.Location = new Point(733, 299);
            btCheckHP.Margin = new Padding(2);
            btCheckHP.Name = "btCheckHP";
            btCheckHP.Size = new Size(145, 38);
            btCheckHP.TabIndex = 6;
            btCheckHP.Text = "Kiểm tra tình trạng";
            btCheckHP.UseVisualStyleBackColor = true;
            // 
            // btSetHP
            // 
            btSetHP.Dock = DockStyle.Bottom;
            btSetHP.Font = new Font("Segoe UI", 9.857143F);
            btSetHP.Location = new Point(733, 247);
            btSetHP.Margin = new Padding(2);
            btSetHP.Name = "btSetHP";
            btSetHP.Size = new Size(145, 38);
            btSetHP.TabIndex = 5;
            btSetHP.Text = "Thiết lập học phí";
            btSetHP.UseVisualStyleBackColor = true;
            btSetHP.Click += btSetHP_Click;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 63);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 23);
            comboBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 3);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(90, 106);
            dataGridView1.Name = "dataGridView1";
            tableLayoutPanel1.SetRowSpan(dataGridView1, 4);
            dataGridView1.Size = new Size(614, 280);
            dataGridView1.TabIndex = 10;
            // 
            // HocPhi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 400);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "HocPhi";
            Text = "HocPhi";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label LaHP;
        private TextBox tbTL;
        private Label laML;
        private Label laTL;
        private Button btT;
        private Button btCheckHP;
        private Button btSetHP;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
    }
}