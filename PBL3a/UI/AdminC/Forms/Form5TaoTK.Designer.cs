namespace PBL3a.UI.AdminC.Forms
{
    partial class Form5TaoTK
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
            lbChon = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cbbRole = new ComboBox();
            txtFullName = new TextBox();
            label1 = new Label();
            dtpDOB = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            btnTao = new Button();
            btnRefresh = new Button();
            dgvData = new DataGridView();
            btnThemDB = new Button();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lbChon
            // 
            lbChon.AutoSize = true;
            lbChon.Location = new Point(73, 14);
            lbChon.Name = "lbChon";
            lbChon.Size = new Size(110, 15);
            lbChon.TabIndex = 0;
            lbChon.Text = "Tạo Tài Khoản Cho:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cbbRole
            // 
            cbbRole.FormattingEnabled = true;
            cbbRole.Location = new Point(217, 9);
            cbbRole.Margin = new Padding(3, 2, 3, 2);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(133, 23);
            cbbRole.TabIndex = 1;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(217, 42);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(266, 23);
            txtFullName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 47);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 4;
            label1.Text = "Họ và tên:";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(217, 75);
            dtpDOB.Margin = new Padding(3, 2, 3, 2);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(219, 23);
            dtpDOB.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 80);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 112);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 7;
            label3.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(217, 110);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(266, 23);
            txtPhone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(547, 30);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Giới tính:";
            // 
            // btnTao
            // 
            btnTao.Location = new Point(388, 157);
            btnTao.Margin = new Padding(3, 2, 3, 2);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(114, 22);
            btnTao.TabIndex = 12;
            btnTao.Text = "Tạo";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(519, 157);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 22);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 193);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(1198, 70);
            dgvData.TabIndex = 14;
            // 
            // btnThemDB
            // 
            btnThemDB.Location = new Point(455, 289);
            btnThemDB.Margin = new Padding(3, 2, 3, 2);
            btnThemDB.Name = "btnThemDB";
            btnThemDB.Size = new Size(202, 22);
            btnThemDB.TabIndex = 15;
            btnThemDB.Text = "Thêm Vào Database";
            btnThemDB.UseVisualStyleBackColor = true;
            btnThemDB.Click += btnThemDB_Click;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(530, 47);
            rdoNam.Margin = new Padding(3, 2, 3, 2);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(51, 19);
            rdoNam.TabIndex = 16;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(603, 47);
            rdoNu.Margin = new Padding(3, 2, 3, 2);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(41, 19);
            rdoNu.TabIndex = 17;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // Form5TaoTK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 474);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(btnThemDB);
            Controls.Add(dgvData);
            Controls.Add(btnRefresh);
            Controls.Add(btnTao);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpDOB);
            Controls.Add(label1);
            Controls.Add(txtFullName);
            Controls.Add(cbbRole);
            Controls.Add(lbChon);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form5TaoTK";
            Text = "Form5TaoTK";
            Load += Form5TaoTK_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbChon;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cbbRole;
        private TextBox txtFullName;
        private Label label1;
        private DateTimePicker dtpDOB;
        private Label label2;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private Button btnTao;
        private Button btnRefresh;
        private DataGridView dgvData;
        private Button btnThemDB;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
    }
}