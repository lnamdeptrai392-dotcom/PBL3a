namespace PBL3a.UI.AdminDD
{
    partial class AttendanceForm
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
            btnExit = new Button();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDiemDanh).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 14);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày";
            // 
            // cboLopHoc
            // 
            cboLopHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLopHoc.FormattingEnabled = true;
            cboLopHoc.Location = new Point(109, 11);
            cboLopHoc.Name = "cboLopHoc";
            cboLopHoc.Size = new Size(180, 28);
            cboLopHoc.TabIndex = 2;
            // 
            // date
            // 
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(401, 9);
            date.Name = "date";
            date.Size = new Size(140, 27);
            date.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Azure;
            btnTimKiem.Location = new Point(584, 9);
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
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dgvDiemDanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDiemDanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiemDanh.BackgroundColor = Color.White;
            dgvDiemDanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiemDanh.Dock = DockStyle.Fill;
            dgvDiemDanh.GridColor = Color.LightGray;
            dgvDiemDanh.Location = new Point(96, 124);
            dgvDiemDanh.Name = "dgvDiemDanh";
            dgvDiemDanh.RowHeadersVisible = false;
            dgvDiemDanh.RowHeadersWidth = 51;
            dgvDiemDanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiemDanh.Size = new Size(833, 304);
            dgvDiemDanh.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(93, 156, 179);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(226, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(177, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu điểm danh";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(93, 156, 179);
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(538, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(130, 40);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(402, 17);
            label3.Name = "label3";
            label3.Size = new Size(221, 28);
            label3.TabIndex = 9;
            label3.Text = "QUẢN LÝ ĐIỂM DANH";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.972677F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.02732F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 3);
            tableLayoutPanel1.Controls.Add(dgvDiemDanh, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.205883F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.794117F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 310F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.Size = new Size(1000, 500);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(date);
            panel1.Controls.Add(cboLopHoc);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(96, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 52);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(96, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 63);
            panel2.TabIndex = 11;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(tableLayoutPanel1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttendanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Điểm danh";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiemDanh).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
    }
}