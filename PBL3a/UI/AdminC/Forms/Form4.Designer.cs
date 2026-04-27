namespace PBL3a.UI.AdminC.Forms
{
    partial class Form4
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
            dgvData = new DataGridView();
            lbChinh = new Label();
            cbbMH = new ComboBox();
            cbbKhoi = new ComboBox();
            lbChonMH = new Label();
            lbChonKhoi = new Label();
            btnView = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnView2 = new Button();
            lbNhapDuLieu = new Label();
            txtNhapDuLieu = new TextBox();
            cbbSearch = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbbTTL = new ComboBox();
            dgvGV = new DataGridView();
            dgvHS = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHS).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = SystemColors.Window;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(25, 266);
            dgvData.Margin = new Padding(3, 4, 3, 4);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(743, 577);
            dgvData.TabIndex = 0;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // lbChinh
            // 
            lbChinh.AutoSize = true;
            lbChinh.BorderStyle = BorderStyle.FixedSingle;
            lbChinh.Location = new Point(447, 35);
            lbChinh.Name = "lbChinh";
            lbChinh.Size = new Size(146, 22);
            lbChinh.TabIndex = 1;
            lbChinh.Text = "Thông Tin Khóa/Lớp";
            // 
            // cbbMH
            // 
            cbbMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMH.FormattingEnabled = true;
            cbbMH.Location = new Point(139, 37);
            cbbMH.Margin = new Padding(3, 4, 3, 4);
            cbbMH.Name = "cbbMH";
            cbbMH.Size = new Size(110, 28);
            cbbMH.TabIndex = 2;
            cbbMH.SelectedIndexChanged += cbbMH_SelectedIndexChanged;
            // 
            // cbbKhoi
            // 
            cbbKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKhoi.FormattingEnabled = true;
            cbbKhoi.Location = new Point(350, 37);
            cbbKhoi.Margin = new Padding(3, 4, 3, 4);
            cbbKhoi.Name = "cbbKhoi";
            cbbKhoi.Size = new Size(103, 28);
            cbbKhoi.TabIndex = 3;
            // 
            // lbChonMH
            // 
            lbChonMH.AutoSize = true;
            lbChonMH.Location = new Point(25, 41);
            lbChonMH.Name = "lbChonMH";
            lbChonMH.Size = new Size(108, 20);
            lbChonMH.TabIndex = 4;
            lbChonMH.Text = "Chọn Môn Học";
            // 
            // lbChonKhoi
            // 
            lbChonKhoi.AutoSize = true;
            lbChonKhoi.Location = new Point(267, 41);
            lbChonKhoi.Name = "lbChonKhoi";
            lbChonKhoi.Size = new Size(77, 20);
            lbChonKhoi.TabIndex = 5;
            lbChonKhoi.Text = "Chọn Khối";
            // 
            // btnView
            // 
            btnView.Location = new Point(139, 73);
            btnView.Margin = new Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(550, 43);
            btnView.TabIndex = 6;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbChinh);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1414, 59);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnView2);
            panel2.Controls.Add(lbNhapDuLieu);
            panel2.Controls.Add(txtNhapDuLieu);
            panel2.Controls.Add(cbbSearch);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cbbTTL);
            panel2.Controls.Add(dgvGV);
            panel2.Controls.Add(dgvHS);
            panel2.Controls.Add(dgvData);
            panel2.Controls.Add(cbbMH);
            panel2.Controls.Add(cbbKhoi);
            panel2.Controls.Add(lbChonMH);
            panel2.Controls.Add(lbChonKhoi);
            panel2.Controls.Add(btnView);
            panel2.Location = new Point(0, 59);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1414, 1500);
            panel2.TabIndex = 8;
            // 
            // btnView2
            // 
            btnView2.Location = new Point(937, 73);
            btnView2.Name = "btnView2";
            btnView2.Size = new Size(447, 43);
            btnView2.TabIndex = 16;
            btnView2.Text = "View";
            btnView2.UseVisualStyleBackColor = true;
            btnView2.Click += btnView2_Click;
            // 
            // lbNhapDuLieu
            // 
            lbNhapDuLieu.AutoSize = true;
            lbNhapDuLieu.Location = new Point(1087, 40);
            lbNhapDuLieu.Name = "lbNhapDuLieu";
            lbNhapDuLieu.Size = new Size(98, 20);
            lbNhapDuLieu.TabIndex = 15;
            lbNhapDuLieu.Text = "Nhập dữ liệu:";
            // 
            // txtNhapDuLieu
            // 
            txtNhapDuLieu.BorderStyle = BorderStyle.None;
            txtNhapDuLieu.Location = new Point(1191, 39);
            txtNhapDuLieu.Name = "txtNhapDuLieu";
            txtNhapDuLieu.Size = new Size(193, 20);
            txtNhapDuLieu.TabIndex = 14;
            txtNhapDuLieu.Enter += txtNhapDuLieu_Enter;
            // 
            // cbbSearch
            // 
            cbbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSearch.FormattingEnabled = true;
            cbbSearch.Location = new Point(937, 38);
            cbbSearch.Name = "cbbSearch";
            cbbSearch.Size = new Size(131, 28);
            cbbSearch.TabIndex = 13;
            cbbSearch.SelectedIndexChanged += cbbSearch_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(740, 40);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 12;
            label3.Text = "Hoặc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(824, 41);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 11;
            label2.Text = "Tìm kiếm theo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 40);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 10;
            label1.Text = "Tình Trạng Lớp";
            // 
            // cbbTTL
            // 
            cbbTTL.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTTL.FormattingEnabled = true;
            cbbTTL.Location = new Point(588, 37);
            cbbTTL.Margin = new Padding(3, 4, 3, 4);
            cbbTTL.Name = "cbbTTL";
            cbbTTL.Size = new Size(101, 28);
            cbbTTL.TabIndex = 9;
            cbbTTL.SelectedIndexChanged += cbbTTL_SelectedIndexChanged;
            // 
            // dgvGV
            // 
            dgvGV.BackgroundColor = SystemColors.Window;
            dgvGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGV.Location = new Point(774, 266);
            dgvGV.Margin = new Padding(3, 4, 3, 4);
            dgvGV.Name = "dgvGV";
            dgvGV.RowHeadersWidth = 51;
            dgvGV.Size = new Size(724, 80);
            dgvGV.TabIndex = 8;
            // 
            // dgvHS
            // 
            dgvHS.BackgroundColor = SystemColors.Window;
            dgvHS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHS.Location = new Point(774, 354);
            dgvHS.Margin = new Padding(3, 4, 3, 4);
            dgvHS.Name = "dgvHS";
            dgvHS.RowHeadersWidth = 51;
            dgvHS.Size = new Size(724, 489);
            dgvHS.TabIndex = 7;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1414, 1001);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvData;
        private Label lbChinh;
        private ComboBox cbbMH;
        private ComboBox cbbKhoi;
        private Label lbChonMH;
        private Label lbChonKhoi;
        private Button btnView;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvHS;
        private DataGridView dgvGV;
        private Label label1;
        private ComboBox cbbTTL;
        private Label label2;
        private ComboBox cbbSearch;
        private Label label3;
        private Label lbNhapDuLieu;
        private TextBox txtNhapDuLieu;
        private Button btnView2;
    }
}