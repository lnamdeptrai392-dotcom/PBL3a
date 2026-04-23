namespace PBL3a.UI.AdminC.Forms
{
    partial class DuyetDon
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
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = SystemColors.ControlLightLight;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(50, 26);
            dgvData.Margin = new Padding(3, 4, 3, 4);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(700, 400);
            dgvData.TabIndex = 0;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(284, 443);
            btnDongY.Margin = new Padding(3, 4, 3, 4);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(86, 31);
            btnDongY.TabIndex = 1;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnTuChoi
            // 
            btnTuChoi.Location = new Point(456, 443);
            btnTuChoi.Margin = new Padding(3, 4, 3, 4);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(86, 31);
            btnTuChoi.TabIndex = 2;
            btnTuChoi.Text = "Từ Chối";
            btnTuChoi.UseVisualStyleBackColor = true;
            btnTuChoi.Click += btnTuChoi_Click;
            // 
            // DuyetDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(btnTuChoi);
            Controls.Add(btnDongY);
            Controls.Add(dgvData);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DuyetDon";
            Text = "Form1DuyetDon";
            Load += Form1DuyetDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvData;
        private Button btnDongY;
        private Button btnTuChoi;
    }
}