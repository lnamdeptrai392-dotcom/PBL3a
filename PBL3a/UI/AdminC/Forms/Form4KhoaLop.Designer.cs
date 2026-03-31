namespace PBL3a.UI.AdminC.Forms
{
    partial class Form4KhoaLop
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
            cbbKhoa = new ComboBox();
            cbbLop = new ComboBox();
            lbChonKhoa = new Label();
            lbChonLop = new Label();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(24, 107);
            dgvData.Margin = new Padding(3, 4, 3, 4);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(894, 489);
            dgvData.TabIndex = 0;
            // 
            // lbChinh
            // 
            lbChinh.AutoSize = true;
            lbChinh.Location = new Point(346, 12);
            lbChinh.Name = "lbChinh";
            lbChinh.Size = new Size(144, 20);
            lbChinh.TabIndex = 1;
            lbChinh.Text = "Thông Tin Khóa/Lớp";
            // 
            // cbbKhoa
            // 
            cbbKhoa.FormattingEnabled = true;
            cbbKhoa.Location = new Point(179, 56);
            cbbKhoa.Margin = new Padding(3, 4, 3, 4);
            cbbKhoa.Name = "cbbKhoa";
            cbbKhoa.Size = new Size(138, 28);
            cbbKhoa.TabIndex = 2;
            cbbKhoa.SelectedIndexChanged += cbbKhoa_SelectedIndexChanged;
            // 
            // cbbLop
            // 
            cbbLop.FormattingEnabled = true;
            cbbLop.Location = new Point(502, 56);
            cbbLop.Margin = new Padding(3, 4, 3, 4);
            cbbLop.Name = "cbbLop";
            cbbLop.Size = new Size(138, 28);
            cbbLop.TabIndex = 3;
            // 
            // lbChonKhoa
            // 
            lbChonKhoa.AutoSize = true;
            lbChonKhoa.Location = new Point(91, 60);
            lbChonKhoa.Name = "lbChonKhoa";
            lbChonKhoa.Size = new Size(81, 20);
            lbChonKhoa.TabIndex = 4;
            lbChonKhoa.Text = "Chọn Khóa";
            // 
            // lbChonLop
            // 
            lbChonLop.AutoSize = true;
            lbChonLop.Location = new Point(413, 60);
            lbChonLop.Name = "lbChonLop";
            lbChonLop.Size = new Size(72, 20);
            lbChonLop.TabIndex = 5;
            lbChonLop.Text = "Chọn Lớp";
            // 
            // btnView
            // 
            btnView.Location = new Point(719, 56);
            btnView.Margin = new Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(86, 31);
            btnView.TabIndex = 6;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // Form4KhoaLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 600);
            Controls.Add(btnView);
            Controls.Add(lbChonLop);
            Controls.Add(lbChonKhoa);
            Controls.Add(cbbLop);
            Controls.Add(cbbKhoa);
            Controls.Add(lbChinh);
            Controls.Add(dgvData);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4KhoaLop";
            Text = "Form4TTKhoaLop";
            Load += Form4KhoaLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Label lbChinh;
        private ComboBox cbbKhoa;
        private ComboBox cbbLop;
        private Label lbChonKhoa;
        private Label lbChonLop;
        private Button btnView;
    }
}