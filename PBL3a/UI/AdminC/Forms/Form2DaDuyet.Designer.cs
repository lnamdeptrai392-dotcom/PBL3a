namespace PBL3a.UI.AdminC.Forms
{
    partial class Form2DaDuyet
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
            lbTitle = new Label();
            cbbKhoa = new ComboBox();
            lbKhoa = new Label();
            btnView = new Button();
            lbLop = new Label();
            cbbLop = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(35, 70);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(725, 339);
            dgvData.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(231, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(283, 20);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Các Đơn Xin Tham Gia Lớp Học Đã Duyệt";
            // 
            // cbbKhoa
            // 
            cbbKhoa.FormattingEnabled = true;
            cbbKhoa.Location = new Point(158, 36);
            cbbKhoa.Name = "cbbKhoa";
            cbbKhoa.Size = new Size(137, 28);
            cbbKhoa.TabIndex = 2;
            cbbKhoa.SelectedIndexChanged += cbbKhoa_SelectedIndexChanged;
            // 
            // lbKhoa
            // 
            lbKhoa.AutoSize = true;
            lbKhoa.Location = new Point(71, 36);
            lbKhoa.Name = "lbKhoa";
            lbKhoa.Size = new Size(81, 20);
            lbKhoa.TabIndex = 3;
            lbKhoa.Text = "Chọn Khóa";
            // 
            // btnView
            // 
            btnView.Location = new Point(640, 32);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 4;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // lbLop
            // 
            lbLop.AutoSize = true;
            lbLop.Location = new Point(324, 36);
            lbLop.Name = "lbLop";
            lbLop.Size = new Size(72, 20);
            lbLop.TabIndex = 5;
            lbLop.Text = "Chọn Lớp";
            // 
            // cbbLop
            // 
            cbbLop.FormattingEnabled = true;
            cbbLop.Location = new Point(402, 33);
            cbbLop.Name = "cbbLop";
            cbbLop.Size = new Size(137, 28);
            cbbLop.TabIndex = 6;
            // 
            // Form2DaDuyet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbbLop);
            Controls.Add(lbLop);
            Controls.Add(btnView);
            Controls.Add(lbKhoa);
            Controls.Add(cbbKhoa);
            Controls.Add(lbTitle);
            Controls.Add(dgvData);
            Name = "Form2DaDuyet";
            Text = "Form2DaDuyet";
            Load += Form2DaDuyet_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Label lbTitle;
        private ComboBox cbbKhoa;
        private Label lbKhoa;
        private Button btnView;
        private Label lbLop;
        private ComboBox cbbLop;
    }
}