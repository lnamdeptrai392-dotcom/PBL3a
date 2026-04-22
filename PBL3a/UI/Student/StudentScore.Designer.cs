namespace PBL3a.UI.Student
{
    partial class StudentScore
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            btnExport = new Button();
            dgvScore = new DataGridView();
            panel1 = new Panel();
            btnShowData = new Button();
            cboSemester = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScore).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.28015566F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.71984F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(btnExport, 1, 3);
            tableLayoutPanel1.Controls.Add(dgvScore, 1, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.1481476F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.8518524F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 353F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.Size = new Size(804, 500);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(297, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 31);
            label1.TabIndex = 0;
            label1.Text = "KẾT QUẢ HỌC TẬP";
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.None;
            btnExport.Location = new Point(357, 463);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 29);
            btnExport.TabIndex = 3;
            btnExport.Text = "Xuất";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // dgvScore
            // 
            dgvScore.BackgroundColor = SystemColors.ButtonHighlight;
            dgvScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScore.Dock = DockStyle.Fill;
            dgvScore.Location = new Point(36, 105);
            dgvScore.Name = "dgvScore";
            dgvScore.RowHeadersWidth = 51;
            dgvScore.Size = new Size(736, 347);
            dgvScore.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnShowData);
            panel1.Controls.Add(cboSemester);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(36, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 47);
            panel1.TabIndex = 4;
            // 
            // btnShowData
            // 
            btnShowData.Anchor = AnchorStyles.Bottom;
            btnShowData.Location = new Point(148, 9);
            btnShowData.Name = "btnShowData";
            btnShowData.Size = new Size(94, 29);
            btnShowData.TabIndex = 3;
            btnShowData.Text = "Dữ liệu";
            btnShowData.UseVisualStyleBackColor = true;
            btnShowData.Click += btnShowData_Click;
            // 
            // cboSemester
            // 
            cboSemester.Anchor = AnchorStyles.Bottom;
            cboSemester.FormattingEnabled = true;
            cboSemester.Location = new Point(-38, 11);
            cboSemester.Name = "cboSemester";
            cboSemester.Size = new Size(158, 28);
            cboSemester.TabIndex = 2;
            cboSemester.SelectedIndexChanged += cboSemester_SelectedIndexChanged;
            // 
            // StudentScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 500);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentScore";
            Text = "Form1";
            Load += StudentScore_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScore).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView dgvScore;
        private Button btnExport;
        private Panel panel1;
        private ComboBox cboSemester;
        private Button btnShowData;
    }
}