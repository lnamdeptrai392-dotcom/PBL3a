namespace PBL3a.UI.Teacher
{
    partial class TaiLieu
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
            listView1 = new ListView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btT = new Button();
            btUpload = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 7);
            label1.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(549, 24);
            label1.Name = "label1";
            label1.Size = new Size(200, 65);
            label1.TabIndex = 0;
            label1.Text = "TÀI LIỆU";
            // 
            // listView1
            // 
            tableLayoutPanel1.SetColumnSpan(listView1, 4);
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(65, 117);
            listView1.Name = "listView1";
            tableLayoutPanel1.SetRowSpan(listView1, 5);
            listView1.Size = new Size(959, 597);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 163F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 413F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 324F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 233F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btT, 5, 5);
            tableLayoutPanel1.Controls.Add(listView1, 1, 1);
            tableLayoutPanel1.Controls.Add(btUpload, 5, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 294F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1299, 744);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btT
            // 
            btT.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btT.Font = new Font("Segoe UI", 11.1428576F);
            btT.Location = new Point(1059, 615);
            btT.Name = "btT";
            btT.Size = new Size(198, 99);
            btT.TabIndex = 3;
            btT.Text = "Thoát";
            btT.UseVisualStyleBackColor = true;
            btT.Click += btT_Click;
            // 
            // btUpload
            // 
            btUpload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btUpload.Font = new Font("Segoe UI", 11.1428576F);
            btUpload.Location = new Point(1059, 462);
            btUpload.Name = "btUpload";
            btUpload.Size = new Size(198, 99);
            btUpload.TabIndex = 5;
            btUpload.Text = "Tải lên";
            btUpload.UseVisualStyleBackColor = true;
            // 
            // TaiLieu
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 744);
            Controls.Add(tableLayoutPanel1);
            Name = "TaiLieu";
            Text = "TaiLieu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btT;
        private ListView listView1;
        private Button btUpload;
    }
}