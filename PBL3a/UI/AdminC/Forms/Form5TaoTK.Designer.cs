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
            lbChon.Location = new Point(61, 20);
            lbChon.Name = "lbChon";
            lbChon.Size = new Size(135, 20);
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
            cbbRole.Location = new Point(226, 13);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(151, 28);
            cbbRole.TabIndex = 1;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(226, 57);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(303, 27);
            txtFullName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 64);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 4;
            label1.Text = "Họ và tên:";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(226, 101);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(250, 27);
            dtpDOB.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 108);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 6;
            label2.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 150);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 7;
            label3.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(226, 148);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(303, 27);
            txtPhone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(603, 41);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 10;
            label4.Text = "Giới tính:";
            // 
            // btnTao
            // 
            btnTao.Location = new Point(400, 187);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(130, 29);
            btnTao.TabIndex = 12;
            btnTao.Text = "Tạo";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(550, 187);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(130, 29);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = Color.White;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(32, 234);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(732, 154);
            dgvData.TabIndex = 14;
            // 
            // btnThemDB
            // 
            btnThemDB.Location = new Point(277, 403);
            btnThemDB.Name = "btnThemDB";
            btnThemDB.Size = new Size(231, 29);
            btnThemDB.TabIndex = 15;
            btnThemDB.Text = "Thêm Vào Database";
            btnThemDB.UseVisualStyleBackColor = true;
            btnThemDB.Click += btnThemDB_Click;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(584, 64);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 16;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(667, 64);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 17;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // Form5TaoTK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
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
            FormBorderStyle = FormBorderStyle.None;
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