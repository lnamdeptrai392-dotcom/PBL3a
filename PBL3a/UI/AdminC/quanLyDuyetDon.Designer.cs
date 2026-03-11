namespace PBL3a.UI.AdminC
{
    partial class quanLyDuyetDon
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
            buttonduyetdon1 = new Button();
            buttonduyetdon2 = new Button();
            dataGridView1 = new DataGridView();
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
            labelqlduyetdon1.Location = new Point(411, 29);
            labelqlduyetdon1.Name = "labelqlduyetdon1";
            labelqlduyetdon1.Size = new Size(356, 23);
            labelqlduyetdon1.TabIndex = 0;
            labelqlduyetdon1.Text = "Quản Lý Duyệt Đơn - Trung Tâm Gia Sư";
            // 
            // buttonduyetdon1
            // 
            buttonduyetdon1.Anchor = AnchorStyles.None;
            buttonduyetdon1.Location = new Point(671, 484);
            buttonduyetdon1.Name = "buttonduyetdon1";
            buttonduyetdon1.Size = new Size(156, 48);
            buttonduyetdon1.TabIndex = 2;
            buttonduyetdon1.Text = "Đồng ý";
            buttonduyetdon1.UseVisualStyleBackColor = true;
            // 
            // buttonduyetdon2
            // 
            buttonduyetdon2.Anchor = AnchorStyles.None;
            buttonduyetdon2.Location = new Point(852, 484);
            buttonduyetdon2.Name = "buttonduyetdon2";
            buttonduyetdon2.Size = new Size(156, 50);
            buttonduyetdon2.TabIndex = 3;
            buttonduyetdon2.Text = "Từ chối";
            buttonduyetdon2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(197, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(811, 410);
            dataGridView1.TabIndex = 4;
            // 
            // quanLyDuyetDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1144, 546);
            Controls.Add(dataGridView1);
            Controls.Add(buttonduyetdon2);
            Controls.Add(buttonduyetdon1);
            Controls.Add(labelqlduyetdon1);
            Name = "quanLyDuyetDon";
            Text = "Duyệt Đơn Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelqlduyetdon1;
        private Button buttonduyetdon1;
        private Button buttonduyetdon2;
        private DataGridView dataGridView1;
    }
}