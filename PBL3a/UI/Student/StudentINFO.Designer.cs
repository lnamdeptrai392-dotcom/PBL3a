namespace PBL3a.UI.Student
{
    partial class StudentINFO
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtHoTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGioiTinh = new ComboBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            btn_update = new Button();
            btn_back = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(336, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 0;
            label1.Text = "Thông tin cá nhân";
            // 
            // label2
            // 
            label2.Location = new Point(83, 50);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.Location = new Point(83, 100);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            label4.Location = new Point(83, 150);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.Location = new Point(83, 200);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.Location = new Point(83, 250);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 5;
            label6.Text = "SĐT:";
            // 
            // label7
            // 
            label7.Location = new Point(83, 300);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 6;
            label7.Text = "Địa chỉ:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 1, 6);
            tableLayoutPanel1.Controls.Add(txtHoTen, 2, 1);
            tableLayoutPanel1.Controls.Add(dtpNgaySinh, 2, 2);
            tableLayoutPanel1.Controls.Add(cboGioiTinh, 2, 3);
            tableLayoutPanel1.Controls.Add(txtEmail, 2, 4);
            tableLayoutPanel1.Controls.Add(txtSDT, 2, 5);
            tableLayoutPanel1.Controls.Add(txtDiaChi, 2, 6);
            tableLayoutPanel1.Controls.Add(btn_update, 1, 7);
            tableLayoutPanel1.Controls.Add(btn_back, 2, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Dock = DockStyle.Fill;
            txtHoTen.Location = new Point(243, 53);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(394, 27);
            txtHoTen.TabIndex = 7;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Dock = DockStyle.Fill;
            dtpNgaySinh.Location = new Point(243, 103);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(394, 27);
            dtpNgaySinh.TabIndex = 8;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Dock = DockStyle.Fill;
            cboGioiTinh.Location = new Point(243, 153);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(394, 28);
            cboGioiTinh.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(243, 203);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(394, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.Dock = DockStyle.Fill;
            txtSDT.Location = new Point(243, 253);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(394, 27);
            txtSDT.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Dock = DockStyle.Fill;
            txtDiaChi.Location = new Point(243, 303);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(394, 27);
            txtDiaChi.TabIndex = 12;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(83, 353);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(119, 42);
            btn_update.TabIndex = 13;
            btn_update.Text = "Cập nhật";
            btn_update.Click += btn_update_Click;
            // 
            // btn_back
            // 
            btn_back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_back.Location = new Point(541, 353);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(96, 42);
            btn_back.TabIndex = 14;
            btn_back.Text = "Quay lại";
            // 
            // StudentINFO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "StudentINFO";
            Text = "Thông tin sinh viên";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGioiTinh;
        private Button btn_update;
        private Button btn_back;
    }
}