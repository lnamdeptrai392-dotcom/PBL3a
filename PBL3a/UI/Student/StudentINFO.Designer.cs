namespace PBL3a.UI.Student
{
    partial class StudentINFO
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
<<<<<<< Updated upstream
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
=======
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGioiTinh = new ComboBox();
            btn_update = new Button();
            btn_back = new Button();
>>>>>>> Stashed changes
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(305, 18);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 0;
            label1.Text = "Thông tin cá nhân";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(38, 83);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(38, 138);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(38, 193);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(38, 241);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(38, 288);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(38, 333);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 6;
            label7.Text = "Địa chỉ:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.942029F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.05797F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 370F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 205F));
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 1, 6);
<<<<<<< Updated upstream
            tableLayoutPanel1.Controls.Add(textBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 2, 4);
            tableLayoutPanel1.Controls.Add(textBox3, 2, 5);
            tableLayoutPanel1.Controls.Add(textBox4, 2, 6);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 2, 2);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 3);
            tableLayoutPanel1.Controls.Add(button1, 1, 7);
            tableLayoutPanel1.Controls.Add(button2, 2, 7);
=======
            tableLayoutPanel1.Controls.Add(txtHoTen, 2, 1);
            tableLayoutPanel1.Controls.Add(txtEmail, 2, 4);
            tableLayoutPanel1.Controls.Add(txtSDT, 2, 5);
            tableLayoutPanel1.Controls.Add(txtDiaChi, 2, 6);
            tableLayoutPanel1.Controls.Add(dtpNgaySinh, 2, 2);
            tableLayoutPanel1.Controls.Add(cboGioiTinh, 2, 3);
            tableLayoutPanel1.Controls.Add(btn_update, 1, 7);
            tableLayoutPanel1.Controls.Add(btn_back, 2, 7);
>>>>>>> Stashed changes
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.30252F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.69748F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.None;
            txtHoTen.Location = new Point(227, 79);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(364, 27);
            txtHoTen.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(227, 237);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(364, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.None;
            txtSDT.Location = new Point(227, 284);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(364, 27);
            txtSDT.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.None;
            txtDiaChi.Location = new Point(227, 330);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(364, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // dtpNgaySinh
            // 
<<<<<<< Updated upstream
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(227, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(364, 27);
            dateTimePicker1.TabIndex = 11;
=======
            dtpNgaySinh.Anchor = AnchorStyles.None;
            dtpNgaySinh.Location = new Point(227, 135);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(364, 27);
            dtpNgaySinh.TabIndex = 11;
>>>>>>> Stashed changes
            // 
            // cboGioiTinh
            // 
<<<<<<< Updated upstream
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(227, 186);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(364, 28);
            comboBox1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.Location = new Point(497, 392);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
=======
            cboGioiTinh.Anchor = AnchorStyles.None;
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Location = new Point(227, 189);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(364, 28);
            cboGioiTinh.TabIndex = 12;
            // 
            // btn_update
>>>>>>> Stashed changes
            // 
            btn_update.Anchor = AnchorStyles.Right;
            btn_update.Location = new Point(127, 392);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 15;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // StudentINFO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "StudentINFO";
            Text = "Form1";
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
<<<<<<< Updated upstream
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
=======
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGioiTinh;
        private Button btn_back;
        private Button btn_update;
>>>>>>> Stashed changes
    }
}