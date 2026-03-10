namespace PBL3a.UI.AdminC
{
    partial class quanLyKhoaHoc
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
            labelqlduyetdon1 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelqlduyetdon1
            // 
            labelqlduyetdon1.Anchor = AnchorStyles.None;
            labelqlduyetdon1.AutoSize = true;
            labelqlduyetdon1.BackColor = SystemColors.Info;
            labelqlduyetdon1.BorderStyle = BorderStyle.Fixed3D;
            labelqlduyetdon1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelqlduyetdon1.Location = new Point(307, 80);
            labelqlduyetdon1.Name = "labelqlduyetdon1";
            labelqlduyetdon1.Size = new Size(2, 23);
            labelqlduyetdon1.TabIndex = 1;
            labelqlduyetdon1.Click += labelqlduyetdon1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(880, 377);
            dataGridView1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 32);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 4;
            label1.Text = "Chọn khóa học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 32);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "Chọn lớp học";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(531, 29);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 83);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 7;
            label3.Text = "Thông tin:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 110);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // quanLyKhoaHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 539);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(labelqlduyetdon1);
            Name = "quanLyKhoaHoc";
            Text = "Khóa Học/ Lớp Học";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelqlduyetdon1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
    }
}