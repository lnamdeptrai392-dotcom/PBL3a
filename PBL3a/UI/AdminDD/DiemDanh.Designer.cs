namespace PBL3a.UI.AdminDD
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            cboLopHoc = new ComboBox();
            date = new DateTimePicker();
            btnTimKiem = new Button();
            dgvDiemDanh = new DataGridView();
            btnSave = new Button();
            btnHistory = new Button();
            btnExport = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDiemDanh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 68);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Chọn lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 68);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày";
            // 
            // cboLopHoc
            // 
            cboLopHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLopHoc.FormattingEnabled = true;
            cboLopHoc.Location = new Point(130, 64);
            cboLopHoc.Margin = new Padding(3, 2, 3, 2);
            cboLopHoc.Name = "cboLopHoc";
            cboLopHoc.Size = new Size(94, 23);
            cboLopHoc.TabIndex = 2;
            // 
            // date
            // 
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(276, 64);
            date.Margin = new Padding(3, 2, 3, 2);
            date.Name = "date";
            date.Size = new Size(123, 23);
            date.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Azure;
            btnTimKiem.Location = new Point(438, 63);
            btnTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 22);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "🔍Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dgvDiemDanh
            // 
            dgvDiemDanh.AllowUserToAddRows = false;
            dgvDiemDanh.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dgvDiemDanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDiemDanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiemDanh.BackgroundColor = Color.White;
            dgvDiemDanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiemDanh.GridColor = Color.LightGray;
            dgvDiemDanh.Location = new Point(68, 107);
            dgvDiemDanh.Margin = new Padding(3, 2, 3, 2);
            dgvDiemDanh.Name = "dgvDiemDanh";
            dgvDiemDanh.RowHeadersVisible = false;
            dgvDiemDanh.RowHeadersWidth = 51;
            dgvDiemDanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiemDanh.Size = new Size(470, 248);
            dgvDiemDanh.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSave.Location = new Point(217, 373);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 22);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu điểm danh";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.LightYellow;
            btnHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHistory.Location = new Point(340, 373);
            btnHistory.Margin = new Padding(3, 2, 3, 2);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(91, 22);
            btnHistory.TabIndex = 7;
            btnHistory.Text = "Xem lịch sử";
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.LavenderBlush;
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExport.Location = new Point(436, 373);
            btnExport.Margin = new Padding(3, 2, 3, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(102, 22);
            btnExport.TabIndex = 8;
            btnExport.Text = "Xuất báo cáo";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(203, 24);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 9;
            label3.Text = "QUẢN LÝ ĐIỂM DANH";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 415);
            Controls.Add(label3);
            Controls.Add(btnExport);
            Controls.Add(btnHistory);
            Controls.Add(btnSave);
            Controls.Add(dgvDiemDanh);
            Controls.Add(btnTimKiem);
            Controls.Add(date);
            Controls.Add(cboLopHoc);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Điểm danh";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiemDanh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboLopHoc;
        private DateTimePicker date;
        private Button btnTimKiem;
        private DataGridView dgvDiemDanh;
        private Button btnSave;
        private Button btnHistory;
        private Button btnExport;
        private Label label3;
    }
}