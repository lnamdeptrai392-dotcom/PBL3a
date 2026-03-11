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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            cboLopHoc = new ComboBox();
            date = new DateTimePicker();
            btnTimKiem = new Button();
            dgvDiemDanh = new DataGridView();
            btnSave = new Button();
            btnExit = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDiemDanh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 91);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 91);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày";
            // 
            // cboLopHoc
            // 
            cboLopHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLopHoc.FormattingEnabled = true;
            cboLopHoc.Location = new Point(149, 85);
            cboLopHoc.Name = "cboLopHoc";
            cboLopHoc.Size = new Size(107, 28);
            cboLopHoc.TabIndex = 2;
            // 
            // date
            // 
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(315, 85);
            date.Name = "date";
            date.Size = new Size(140, 27);
            date.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Azure;
            btnTimKiem.Location = new Point(501, 84);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(114, 29);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "🔍Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dgvDiemDanh
            // 
            dgvDiemDanh.AllowUserToAddRows = false;
            dgvDiemDanh.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dgvDiemDanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDiemDanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiemDanh.BackgroundColor = Color.White;
            dgvDiemDanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiemDanh.GridColor = Color.LightGray;
            dgvDiemDanh.Location = new Point(78, 143);
            dgvDiemDanh.Name = "dgvDiemDanh";
            dgvDiemDanh.RowHeadersVisible = false;
            dgvDiemDanh.RowHeadersWidth = 51;
            dgvDiemDanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiemDanh.Size = new Size(537, 331);
            dgvDiemDanh.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Honeydew;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSave.Location = new Point(360, 497);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu điểm danh";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightYellow;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExit.Location = new Point(511, 497);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(232, 32);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 9;
            label3.Text = "QUẢN LÝ ĐIỂM DANH";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 553);
            Controls.Add(label3);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(dgvDiemDanh);
            Controls.Add(btnTimKiem);
            Controls.Add(date);
            Controls.Add(cboLopHoc);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
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
        private Button btnExit;
        private Label label3;
    }
}