using PBL3a.services.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.AdminC.Forms
{
    public partial class Form2 : Form
    {
        private AdminC_Service adminService = new AdminC_Service();
        private DataTable dtTempClasses; // Bảng tạm lưu các lớp học chờ đưa vào DB
        private string selectedTeacherId = "";

        public Form2()
        {
            InitializeComponent();

            StyleDataGridView(dgvGV);
            StyleDataGridView(dgvTTGV);
            StyleDataGridView(dgvLH);
        }

        // Giao diện Datagridview
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToResizeRows = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.FromArgb(231, 229, 255);
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(42, 45, 86);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;

            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(42, 45, 86);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 245, 250);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbbMH.Items.Clear();
            cbbKhoi.Items.Clear();

            // 1. Khởi tạo dữ liệu cho cbbMH và cbbKhoi
            string[] subjects = { "Toán Học", "Văn Học", "Hóa Học", "Vật Lý", "Sinh Học", "Tiếng Anh" };
            cbbMH.Items.AddRange(subjects);

            string[] grades = { "Khối 8", "Khối 9", "Khối 10", "Khối 11", "Khối 12" };
            cbbKhoi.Items.AddRange(grades);

            // 2. Khởi tạo cấu trúc bảng tạm để hiển thị lên dgvLH
            dtTempClasses = new DataTable();
            dtTempClasses.Columns.Add("Mã Lớp", typeof(string));
            dtTempClasses.Columns.Add("Tên Lớp", typeof(string));
            dtTempClasses.Columns.Add("Mã Khóa Học", typeof(string));
            dtTempClasses.Columns.Add("Mã GV", typeof(string));
            dtTempClasses.Columns.Add("Ngày Bắt Đầu", typeof(DateTime));
            dtTempClasses.Columns.Add("Ngày Kết Thúc", typeof(DateTime));
            dtTempClasses.Columns.Add("Sức Chứa", typeof(int));

            dgvLH.DataSource = dtTempClasses;

            // Định dạng hiển thị ngày tháng cho các cột Date trong dgvLH
            dgvLH.Columns["Ngày Bắt Đầu"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvLH.Columns["Ngày Kết Thúc"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void cbbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMH.SelectedItem != null)
            {
                string subject = cbbMH.SelectedItem.ToString();
                dgvGV.DataSource = adminService.GetTeachersBySubjectForm2(subject);
                selectedTeacherId = ""; // Reset GV đã chọn
            }
        }

        private void dgvGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGV.Rows[e.RowIndex];
                selectedTeacherId = row.Cells["Mã GV"].Value.ToString();

                // Load dữ liệu lên dgvTTGV (Bạn cần đảm bảo trong Designer đã có control tên là dgvTTGV)
                DataTable dtTeacherInfo = adminService.GetTeacherDetailsAndClasses(selectedTeacherId);
                dgvTTGV.DataSource = dtTeacherInfo;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện đầu vào
            if (cbbMH.SelectedItem == null) { MessageBox.Show("Vui lòng chọn Môn Học!"); return; }
            if (cbbKhoi.SelectedItem == null) { MessageBox.Show("Vui lòng chọn Khối!"); return; }
            if (string.IsNullOrEmpty(txtSL.Text) || !int.TryParse(txtSL.Text, out int capacity) || capacity <= 0)
            { MessageBox.Show("Vui lòng nhập Sức Chứa hợp lệ (số nguyên > 0)!"); return; }
            if (string.IsNullOrEmpty(selectedTeacherId)) { MessageBox.Show("Vui lòng click chọn 1 Giáo Viên từ danh sách!"); return; }

            string subject = cbbMH.SelectedItem.ToString();
            string khoi = cbbKhoi.SelectedItem.ToString();
            DateTime startDate = dtpNgayMo.Value.Date;
            DateTime endDate = startDate.AddMonths(5);

            // Sinh mã lớp tự động từ Service
            adminService.GenerateClassIdentifiers(subject, khoi, startDate, out string courseId, out string classId, out string className);

            dtTempClasses.Rows.Add(classId, className, courseId, selectedTeacherId, startDate, endDate, capacity);

            MessageBox.Show($"Đã tạo tạm thành công {className}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            if (dtTempClasses.Rows.Count == 0)
            {
                MessageBox.Show("Không có lớp học nào trong danh sách tạm để thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                adminService.SaveNewClasses(dtTempClasses);
                MessageBox.Show("Đã lưu thành công tất cả các lớp học vào cơ sở dữ liệu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa bảng tạm sau khi lưu thành công
                dtTempClasses.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
