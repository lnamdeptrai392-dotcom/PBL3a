namespace PBL3a.UI.AdminC.Forms
{
    partial class Form1DuyetDon
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
            btnDongY = new Button();
            btnTuChoi = new Button();
            btnLuuY = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(10, 21);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(1254, 433);
            dgvData.TabIndex = 0;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(520, 460);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(75, 23);
            btnDongY.TabIndex = 1;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnTuChoi
            // 
            btnTuChoi.Location = new Point(619, 460);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(75, 23);
            btnTuChoi.TabIndex = 2;
            btnTuChoi.Text = "Từ Chối";
            btnTuChoi.UseVisualStyleBackColor = true;
            btnTuChoi.Click += btnTuChoi_Click;
            // 
            // btnLuuY
            // 
            btnLuuY.Location = new Point(721, 460);
            btnLuuY.Name = "btnLuuY";
            btnLuuY.Size = new Size(75, 23);
            btnLuuY.TabIndex = 3;
            btnLuuY.Text = "* Lưu ý *";
            btnLuuY.UseVisualStyleBackColor = true;
            // 
            // Form1DuyetDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 506);
            Controls.Add(btnLuuY);
            Controls.Add(btnTuChoi);
            Controls.Add(btnDongY);
            Controls.Add(dgvData);
            Name = "Form1DuyetDon";
            Text = "Form1DuyetDon";
            Load += Form1DuyetDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvData;
        private Button btnDongY;
        private Button btnTuChoi;
        private Button btnLuuY;
    }
}