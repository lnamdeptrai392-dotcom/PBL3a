namespace PBL3a.UI.AdminC.Forms
{
    partial class Form2
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
            panel1 = new Panel();
            panel2 = new Panel();
            dgvTTGV = new DataGridView();
            btnDB = new Button();
            btnOK = new Button();
            label1 = new Label();
            dgvGV = new DataGridView();
            dgvLH = new DataGridView();
            txtSL = new TextBox();
            dtpNgayMo = new DateTimePicker();
            cbbKhoi = new ComboBox();
            cbbMH = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTTGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLH).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1443, 66);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvTTGV);
            panel2.Controls.Add(btnDB);
            panel2.Controls.Add(btnOK);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dgvGV);
            panel2.Controls.Add(dgvLH);
            panel2.Controls.Add(txtSL);
            panel2.Controls.Add(dtpNgayMo);
            panel2.Controls.Add(cbbKhoi);
            panel2.Controls.Add(cbbMH);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(1443, 989);
            panel2.TabIndex = 1;
            // 
            // dgvTTGV
            // 
            dgvTTGV.BackgroundColor = SystemColors.Window;
            dgvTTGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTTGV.Location = new Point(407, 199);
            dgvTTGV.Name = "dgvTTGV";
            dgvTTGV.RowHeadersWidth = 51;
            dgvTTGV.Size = new Size(1024, 455);
            dgvTTGV.TabIndex = 15;
            // 
            // btnDB
            // 
            btnDB.Location = new Point(520, 911);
            btnDB.Name = "btnDB";
            btnDB.Size = new Size(166, 36);
            btnDB.TabIndex = 13;
            btnDB.Text = "Thêm Vào Database";
            btnDB.UseVisualStyleBackColor = true;
            btnDB.Click += btnDB_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(520, 660);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(477, 36);
            btnOK.TabIndex = 12;
            btnOK.Text = "Tạo Lớp Học";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 130);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 11;
            label1.Text = "Chọn Giáo Viên Dạy:";
            // 
            // dgvGV
            // 
            dgvGV.BackgroundColor = SystemColors.Window;
            dgvGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGV.Location = new Point(55, 199);
            dgvGV.Name = "dgvGV";
            dgvGV.RowHeadersWidth = 51;
            dgvGV.Size = new Size(346, 455);
            dgvGV.TabIndex = 10;
            dgvGV.CellContentClick += dgvGV_CellContentClick;
            // 
            // dgvLH
            // 
            dgvLH.BackgroundColor = SystemColors.Window;
            dgvLH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLH.Location = new Point(55, 737);
            dgvLH.Name = "dgvLH";
            dgvLH.RowHeadersWidth = 51;
            dgvLH.Size = new Size(1228, 148);
            dgvLH.TabIndex = 9;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(736, 47);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(151, 27);
            txtSL.TabIndex = 8;
            // 
            // dtpNgayMo
            // 
            dtpNgayMo.Location = new Point(1053, 47);
            dtpNgayMo.Name = "dtpNgayMo";
            dtpNgayMo.Size = new Size(250, 27);
            dtpNgayMo.TabIndex = 7;
            // 
            // cbbKhoi
            // 
            cbbKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKhoi.FormattingEnabled = true;
            cbbKhoi.Location = new Point(427, 46);
            cbbKhoi.Name = "cbbKhoi";
            cbbKhoi.Size = new Size(151, 28);
            cbbKhoi.TabIndex = 6;
            // 
            // cbbMH
            // 
            cbbMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMH.FormattingEnabled = true;
            cbbMH.Location = new Point(144, 46);
            cbbMH.Name = "cbbMH";
            cbbMH.Size = new Size(151, 28);
            cbbMH.TabIndex = 5;
            cbbMH.SelectedIndexChanged += cbbMH_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(642, 49);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 4;
            label6.Text = "Số Lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 3);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 3;
            label5.Text = "Thêm Lớp Học Cho:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(946, 49);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 2;
            label4.Text = "Ngày Mở:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 49);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 1;
            label3.Text = "Khối:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 49);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Môn Học:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 1055);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = " ";
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTTGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgayMo;
        private ComboBox cbbKhoi;
        private ComboBox cbbMH;
        private Label label6;
        private DataGridView dgvLH;
        private TextBox txtSL;
        private DataGridView dgvGV;
        private Button btnOK;
        private Label label1;
        private Button btnDB;
        private DataGridView dgvTTGV;
    }
}