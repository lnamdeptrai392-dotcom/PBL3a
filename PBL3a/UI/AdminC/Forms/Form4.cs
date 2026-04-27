using System;
using System.Data;
using System.Windows.Forms;
using PBL3a.services.BLL;
using System.Drawing;

namespace PBL3a.UI.AdminC.Forms
{
    public partial class Form4 : Form
    {
        private AdminC_Service adminCService;

        public Form4()
        {
            InitializeComponent();
            adminCService = new AdminC_Service();

            StyleDataGridView(dgvData);
            StyleDataGridView(dgvGV);
            StyleDataGridView(dgvHS);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

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

        private void LoadComboBoxes()
        {
            try
            {
                cbbMH.DataSource = null;
                cbbMH.Items.Clear();
                cbbMH.Items.AddRange(new string[] { "Toán học", "Vật lý", "Hóa học", "Sinh học", "Ngữ văn", "Tiếng Anh", "Tiếng Nhật", "Tiếng Trung" });
                cbbMH.SelectedIndex = -1;

                cbbTTL.Items.Clear();
                cbbTTL.Items.AddRange(new object[] { "Đã kết thúc", "Đang học", "Sắp mở" });
                cbbTTL.SelectedIndex = -1;

                cbbKhoi.DataSource = null;

                cbbSearch.Items.Clear();
                cbbSearch.Items.AddRange(new string[] {
                    "Mã Học Sinh", "Tên Học Sinh",
                    "Mã Giáo Viên", "Tên Giáo Viên",
                    "Mã Lớp Học", "Tên Lớp Học"
                });
                cbbSearch.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu ComboBox: " + ex.Message);
            }
        }

        // Load THÔNG TIN GIÁO VIÊN
        private void LoadDanhSachGiaoVien(string classId)
        {
            try
            {
                dgvGV.DataSource = adminCService.GetTeacherByClass(classId);
                dgvGV.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin giáo viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load THÔNG TIN HỌC SINH
        private void LoadDanhSachHocSinh(string classId)
        {
            try
            {
                dgvHS.DataSource = adminCService.GetStudentsByClass(classId);
                dgvHS.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin học sinh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetKeyword(string monHoc)
        {
            if (monHoc == "Toán học") return "Toán";
            if (monHoc == "Vật lý") return "Lý";
            if (monHoc == "Hóa học") return "Hóa";
            if (monHoc == "Sinh học") return "Sinh";
            if (monHoc == "Ngữ văn") return "Văn";
            return monHoc; // Tiếng Anh, Tiếng Nhật, Tiếng Trung
        }

        // Hàm xóa trắng các lựa chọn của Cách 1 (Lọc theo ComboBox)
        private void ResetCach1()
        {
            cbbMH.SelectedIndex = -1;
            cbbTTL.SelectedIndex = -1;
            cbbKhoi.DataSource = null; // Xóa danh sách khối
        }

        // Hàm xóa trắng các lựa chọn của Cách 2 (Tìm kiếm đích danh)
        private void ResetCach2()
        {
            cbbSearch.SelectedIndex = -1;
            txtNhapDuLieu.Clear();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cbbMH.SelectedIndex == -1 || cbbKhoi.SelectedIndex == -1 || cbbTTL.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin ở Cách 1!", "Thông báo");
                return;
            }

            string displaySubject = cbbMH.SelectedItem.ToString();
            string selectedKhoi = cbbKhoi.SelectedValue.ToString();
            string selectedStatus = cbbTTL.SelectedItem.ToString();

            string dbSubject = GetKeyword(displaySubject);

            DataTable dtClasses = adminCService.GetClassesByFilter(dbSubject, selectedKhoi, selectedStatus);
            dgvData.DataSource = dtClasses;

            dgvGV.DataSource = null;
            dgvHS.DataSource = null;

            if (dtClasses.Rows.Count == 0)
            {
                MessageBox.Show("Hiện không có lớp nào thuộc trạng thái '" + selectedStatus + "' cho khối này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvData.ClearSelection();
                dgvData.CurrentCell = null;
            }
        }

        // nhấn vào 1 dòng trên dgvData
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dgvData.Rows[e.RowIndex].Cells["Mã Lớp"].Value;
                if (cellValue != null)
                {
                    string classId = cellValue.ToString();

                    // Nạp dữ liệu
                    dgvGV.DataSource = adminCService.GetTeacherByClass(classId);
                    dgvHS.DataSource = adminCService.GetStudentsByClass(classId);

                    if (dgvHS.Columns.Count > 0)
                    {
                        dgvHS.Columns["Mã HS"].FillWeight = 30;
                        dgvHS.Columns["Tên Học Sinh"].FillWeight = 70;
                        dgvHS.Columns["Ngày Sinh"].FillWeight = 30;
                        dgvHS.Columns["Giới Tính"].FillWeight = 25;
                        dgvHS.Columns["SĐT"].FillWeight = 55;
                    }

                    dgvGV.ClearSelection();
                    dgvHS.ClearSelection();
                }
            }
        }

        // Khi chọn môn học ở cbbMH
        private void cbbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ reset Cách 2 nếu người dùng thực sự thao tác chuột/phím trên cbbMH
            if (cbbMH.Focused && cbbMH.SelectedIndex != -1)
            {
                ResetCach2();
            }

            // ... Giữ nguyên logic load cbbKhoi cũ của bạn ở đây ...
            if (cbbMH.SelectedIndex != -1 && cbbMH.SelectedItem != null)
            {
                if (cbbMH.SelectedItem is DataRowView) return;
                string displaySubject = cbbMH.SelectedItem.ToString();
                string dbSubject = GetKeyword(displaySubject);
                DataTable dtBlocks = adminCService.GetBlocksBySubject(dbSubject);
                cbbKhoi.DataSource = dtBlocks;
                cbbKhoi.DisplayMember = "Khoi";
                cbbKhoi.ValueMember = "Khoi";
                cbbKhoi.SelectedIndex = -1;
            }
        }

        private void btnView2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn tiêu chí tìm kiếm chưa
            if (cbbSearch.SelectedIndex == -1 || string.IsNullOrEmpty(txtNhapDuLieu.Text))
            {
                MessageBox.Show("Vui lòng nhập từ khóa và tiêu chí tìm kiếm ở Cách 2!", "Thông báo");
                return;
            }

            // Kiểm tra xem đã nhập từ khóa chưa (bạn đã đổi tên là txtNhapDuLieu)
            string keyword = txtNhapDuLieu.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchType = cbbSearch.SelectedItem.ToString();

            try
            {
                // Gọi BLL để tìm kiếm
                DataTable dtResult = adminCService.SearchClasses(searchType, keyword);

                // Đổ dữ liệu lên dgvData
                dgvData.DataSource = dtResult;

                // Xóa trắng 2 bảng con bên phải (đợi user click vào 1 dòng cụ thể mới hiện)
                dgvGV.DataSource = null;
                dgvHS.DataSource = null;

                if (dtResult.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp với từ khóa: " + keyword, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Bỏ chọn dòng đầu tiên mặc định
                    dgvData.ClearSelection();
                    dgvData.CurrentCell = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbTTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTTL.Focused && cbbTTL.SelectedIndex != -1)
            {
                ResetCach2();
            }
        }

        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSearch.Focused && cbbSearch.SelectedIndex != -1)
            {
                ResetCach1();
            }
        }

        private void txtNhapDuLieu_Enter(object sender, EventArgs e)
        {
            ResetCach1();
        }
    }
}