namespace PBL3a.UI.AdminC.Forms
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvDonXin = new DataGridView();
            btnDongY = new Button();
            btnTuChoi = new Button();
            dgvTTHS = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            dgvHS1 = new DataGridView();
            cbbLop = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnView = new Button();
            cbbKhoi = new ComboBox();
            label3 = new Label();
            cbbMH = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dgvTTLH = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDonXin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTTHS).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHS1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTTLH).BeginInit();
            SuspendLayout();
            // 
            // dgvDonXin
            // 
            dgvDonXin.AllowUserToResizeColumns = false;
            dgvDonXin.AllowUserToResizeRows = false;
            dgvDonXin.BackgroundColor = SystemColors.Window;
            dgvDonXin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvDonXin.DefaultCellStyle = dataGridViewCellStyle1;
            dgvDonXin.GridColor = SystemColors.WindowText;
            dgvDonXin.Location = new Point(14, 145);
            dgvDonXin.Margin = new Padding(3, 4, 3, 4);
            dgvDonXin.MultiSelect = false;
            dgvDonXin.Name = "dgvDonXin";
            dgvDonXin.RowHeadersWidth = 51;
            dgvDonXin.Size = new Size(929, 727);
            dgvDonXin.TabIndex = 0;
            dgvDonXin.SelectionChanged += dgvDonXin_SelectionChanged;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(553, 880);
            btnDongY.Margin = new Padding(3, 4, 3, 4);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(187, 31);
            btnDongY.TabIndex = 1;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnTuChoi
            // 
            btnTuChoi.Location = new Point(757, 880);
            btnTuChoi.Margin = new Padding(3, 4, 3, 4);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(186, 31);
            btnTuChoi.TabIndex = 2;
            btnTuChoi.Text = "Từ Chối";
            btnTuChoi.UseVisualStyleBackColor = true;
            btnTuChoi.Click += btnTuChoi_Click;
            // 
            // dgvTTHS
            // 
            dgvTTHS.AllowUserToResizeColumns = false;
            dgvTTHS.AllowUserToResizeRows = false;
            dgvTTHS.BackgroundColor = SystemColors.Window;
            dgvTTHS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTTHS.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTTHS.Location = new Point(950, 169);
            dgvTTHS.Margin = new Padding(3, 4, 3, 4);
            dgvTTHS.Name = "dgvTTHS";
            dgvTTHS.RowHeadersWidth = 51;
            dgvTTHS.Size = new Size(506, 186);
            dgvTTHS.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1677, 55);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dgvHS1);
            panel2.Controls.Add(cbbLop);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnView);
            panel2.Controls.Add(cbbKhoi);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cbbMH);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dgvTTLH);
            panel2.Controls.Add(dgvTTHS);
            panel2.Controls.Add(btnTuChoi);
            panel2.Controls.Add(btnDongY);
            panel2.Controls.Add(dgvDonXin);
            panel2.Location = new Point(0, 55);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1677, 2000);
            panel2.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(964, 632);
            label7.Name = "label7";
            label7.Size = new Size(215, 20);
            label7.TabIndex = 18;
            label7.Text = "Các Lớp Học Sinh Đã Tham Gia";
            // 
            // dgvHS1
            // 
            dgvHS1.BackgroundColor = SystemColors.ControlLightLight;
            dgvHS1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHS1.Location = new Point(950, 655);
            dgvHS1.Name = "dgvHS1";
            dgvHS1.RowHeadersWidth = 51;
            dgvHS1.Size = new Size(506, 217);
            dgvHS1.TabIndex = 17;
            // 
            // cbbLop
            // 
            cbbLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbLop.FormattingEnabled = true;
            cbbLop.Location = new Point(655, 60);
            cbbLop.Margin = new Padding(3, 4, 3, 4);
            cbbLop.Name = "cbbLop";
            cbbLop.Size = new Size(199, 28);
            cbbLop.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(737, 19);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 15;
            label6.Text = "Lớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 19);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 14;
            label5.Text = "Khối";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 19);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 13;
            label4.Text = "Môn Học";
            // 
            // btnView
            // 
            btnView.Location = new Point(891, 59);
            btnView.Margin = new Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(86, 31);
            btnView.TabIndex = 12;
            btnView.Text = "Xem";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // cbbKhoi
            // 
            cbbKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKhoi.FormattingEnabled = true;
            cbbKhoi.Location = new Point(419, 59);
            cbbKhoi.Margin = new Padding(3, 4, 3, 4);
            cbbKhoi.Name = "cbbKhoi";
            cbbKhoi.Size = new Size(199, 28);
            cbbKhoi.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 19);
            label3.Name = "label3";
            label3.Size = new Size(162, 20);
            label3.TabIndex = 10;
            label3.Text = "Xem Đơn Đăng Ký Của:";
            // 
            // cbbMH
            // 
            cbbMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMH.FormattingEnabled = true;
            cbbMH.Location = new Point(179, 59);
            cbbMH.Margin = new Padding(3, 4, 3, 4);
            cbbMH.Name = "cbbMH";
            cbbMH.Size = new Size(199, 28);
            cbbMH.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(964, 375);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 7;
            label2.Text = "Thông Tin Lớp Học";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(964, 145);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 6;
            label1.Text = "Thông Tin Học Sinh";
            // 
            // dgvTTLH
            // 
            dgvTTLH.AllowUserToResizeColumns = false;
            dgvTTLH.AllowUserToResizeRows = false;
            dgvTTLH.BackgroundColor = SystemColors.Window;
            dgvTTLH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTTLH.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTTLH.Location = new Point(950, 399);
            dgvTTLH.Margin = new Padding(3, 4, 3, 4);
            dgvTTLH.Name = "dgvTTLH";
            dgvTTLH.RowHeadersWidth = 51;
            dgvTTLH.Size = new Size(506, 210);
            dgvTTLH.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1533, 908);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDonXin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTTHS).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHS1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTTLH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDonXin;
        private Button btnDongY;
        private Button btnTuChoi;
        private DataGridView dgvTTHS;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvTTLH;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbMH;
        private ComboBox cbbLop;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnView;
        private ComboBox cbbKhoi;
        private DataGridView dgvHS1;
        private Label label7;
    }
}