//using Microsoft.Data.SqlClient;
//using Microsoft.Identity.Client;
using PBL3;
using System;
using PBL3a.services.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.AdminC.Forms
{
    public partial class Form1 : Form
    {
        private AdminC_Service adminService = new AdminC_Service();
        private DataTable dtActiveClasses;


        public Form1()
        {
            InitializeComponent();
            StyleDataGridView(dgvDonXin);
            StyleDataGridView(dgvTTHS);
            StyleDataGridView(dgvTTLH);
            StyleDataGridView(dgvHS1);
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
        private void Form1_Load(object sender, EventArgs e)
        {
            dtActiveClasses = adminService.GetActiveClasses();
            cbbMH.SelectedIndexChanged += cbbMH_SelectedIndexChanged;
            cbbKhoi.SelectedIndexChanged += cbbKhoi_SelectedIndexChanged;
            cbbMH.Items.Clear();
            cbbMH.Items.AddRange(new string[] { "Tất cả", "Toán học", "Vật lý", "Hóa học", "Sinh học", "Ngữ văn", "Tiếng Anh", "Tiếng Nhật", "Tiếng Trung" });
            cbbMH.SelectedIndex = 0;
            btnView.PerformClick();
            LoadData();
        }

        // Tải danh sách đơn "Chờ duyệt" lên DGV
        private void LoadData()
        {
            try
            {
                DataTable dt = adminService.GetPendingRegistrations();

                dgvDonXin.DataSource = dt;
                dgvDonXin.Columns["Mã HS"].FillWeight = 60;
                dgvDonXin.Columns["Tên Học Sinh"].FillWeight = 140;
                dgvDonXin.Columns["Mã Lớp"].FillWeight = 80;
                dgvDonXin.Columns["Tên Lớp"].FillWeight = 140;
                dgvDonXin.Columns["Ngày Gửi"].FillWeight = 70;
                dgvDonXin.Columns["Ghi Chú"].FillWeight = 200;
                dgvDonXin.DataBindingComplete += (s, ev) =>
                {
                    dgvDonXin.ClearSelection();
                    dgvDonXin.CurrentCell = null;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // TRUY XUẤT TỪ KHÓA MÔN HỌC
        private string GetKeyword(string monHoc)
        {
            if (monHoc == "Toán học") return "Toán";
            if (monHoc == "Vật lý") return "Lý";
            if (monHoc == "Hóa học") return "Hóa";
            if (monHoc == "Sinh học") return "Sinh";
            if (monHoc == "Ngữ văn") return "Văn";
            return monHoc; // Tiếng Anh, Tiếng Nhật, Tiếng Trung
        }

        // Load THÔNG TIN HỌC SINH
        private void LoadThongTinHocSinh(string accountId)
        {
            try
            {
                DataTable dtOriginal = adminService.GetStudentInfo(accountId);

                DataTable dtVertical = new DataTable();
                dtVertical.Columns.Add("Thuộc tính");
                dtVertical.Columns.Add("Giá trị");

                if (dtOriginal.Rows.Count > 0)
                {
                    DataRow row = dtOriginal.Rows[0];
                    dtVertical.Rows.Add("Mã Học Sinh:", row["Mã HS"].ToString());
                    dtVertical.Rows.Add("Họ và Tên:", row["Họ và Tên"].ToString());

                    DateTime dob;
                    if (DateTime.TryParse(row["Ngày Sinh"].ToString(), out dob))
                        dtVertical.Rows.Add("Ngày Sinh:", dob.ToString("dd/MM/yyyy"));
                    else
                        dtVertical.Rows.Add("Ngày Sinh:", row["Ngày Sinh"].ToString());

                    string sex = row["Giới Tính"].ToString();
                    dtVertical.Rows.Add("Giới Tính:", sex == "Male" ? "Nam" : (sex == "Female" ? "Nữ" : "Khác"));
                    dtVertical.Rows.Add("Số Điện Thoại:", row["Số Điện Thoại"].ToString());
                }

                dgvTTHS.DataSource = dtVertical;
                dgvTTHS.ColumnHeadersVisible = false;
                dgvTTHS.Height = dgvTTHS.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin học sinh: " + ex.Message);
            }
        }

        // Load THÔNG TIN LỚP HỌC
        private void LoadThongTinLopHoc(string classId)
        {
            try
            {
                DataTable dtOriginal = adminService.GetClassInfo(classId);

                DataTable dtVertical = new DataTable();
                dtVertical.Columns.Add("Thuộc tính");
                dtVertical.Columns.Add("Giá trị");

                if (dtOriginal.Rows.Count > 0)
                {
                    DataRow row = dtOriginal.Rows[0];
                    dtVertical.Rows.Add("Mã Lớp:", row["Mã Lớp"].ToString());
                    dtVertical.Rows.Add("Tên Lớp:", row["Tên Lớp"].ToString());
                    dtVertical.Rows.Add("GV Chủ Nhiệm:", row["GV Chủ Nhiệm"].ToString());
                    dtVertical.Rows.Add("Sức Chứa Tối Đa:", row["Sức Chứa"].ToString() + " học viên");
                    dtVertical.Rows.Add("Sĩ Số Hiện Tại:", row["Sĩ Số Hiện Tại"].ToString() + " học viên");
                }

                dgvTTLH.DataSource = dtVertical;
                dgvTTLH.ColumnHeadersVisible = false;
                dgvTTLH.Height = dgvTTLH.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin lớp học: " + ex.Message);
            }
        }

        private void LoadLichSuHocTap(string maHS)
        {
            try
            {
                dgvHS1.DataSource = adminService.GetStudentClassHistory(maHS);

                // Tùy chỉnh tỷ lệ cột cho đẹp
                if (dgvHS1.Columns.Count > 0)
                {
                    dgvHS1.Columns["Mã Lớp"].FillWeight = 80;
                    dgvHS1.Columns["Tên Lớp"].FillWeight = 150;
                    dgvHS1.Columns["Trạng Thái"].FillWeight = 100;
                }

                dgvHS1.ClearSelection();
                dgvHS1.CurrentCell = null;
                dgvHS1.DataBindingComplete += (s, ev) =>
                {
                    dgvHS1.ClearSelection();
                    dgvHS1.CurrentCell = null;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch sử học tập: " + ex.Message);
            }
        }

        // Click chọn dòng khác trên bảng chính
        private void dgvDonXin_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (dgvDonXin.CurrentRow == null || dgvDonXin.CurrentRow.Index < 0)
                return;

            string maHS = dgvDonXin.CurrentRow.Cells["Mã HS"].Value?.ToString();
            string maLop = dgvDonXin.CurrentRow.Cells["Mã Lớp"].Value?.ToString();

            if (!string.IsNullOrEmpty(maHS) && !string.IsNullOrEmpty(maLop))
            {
                LoadThongTinHocSinh(maHS);
                LoadThongTinLopHoc(maLop);
                LoadLichSuHocTap(maHS);
            }
        }

        // ĐỔI MÔN HỌC -> CẬP NHẬT KHỐI
        private void cbbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string monHoc = cbbMH.SelectedItem?.ToString() ?? "Tất cả";
            string keyword = GetKeyword(monHoc);
            HashSet<string> hashKhoi = new HashSet<string>();

            foreach (DataRow row in dtActiveClasses.Rows)
            {
                string className = row["class_name"].ToString();

                if (monHoc != "Tất cả" && !className.Contains(keyword))
                    continue;

                string[] parts = className.Split(' ');
                foreach (string p in parts)
                {
                    if (p == "10" || p == "11" || p == "12") hashKhoi.Add("Khối " + p);
                    else if (p == "N5" || p == "N4" || p == "N3" || p.StartsWith("HSK")) hashKhoi.Add(p);
                }
            }

            cbbKhoi.Items.Clear();
            cbbKhoi.Items.Add("Tất cả");
            List<string> sortedKhoi = hashKhoi.ToList();
            sortedKhoi.Sort();
            cbbKhoi.Items.AddRange(sortedKhoi.ToArray());
            cbbKhoi.SelectedIndex = 0;
        }

        // ĐỔI KHỐI -> CẬP NHẬT LỚP
        private void cbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string monHoc = cbbMH.SelectedItem?.ToString() ?? "Tất cả";
            string khoi = cbbKhoi.SelectedItem?.ToString() ?? "Tất cả";

            string monKeyword = GetKeyword(monHoc);
            string khoiKeyword = khoi.Replace("Khối ", "");

            // Tạo bảng rỗng để chứa các Lớp thỏa mãn
            DataTable dtFilteredClasses = dtActiveClasses.Clone();

            foreach (DataRow row in dtActiveClasses.Rows)
            {
                string className = row["class_name"].ToString();

                bool matchMon = (monHoc == "Tất cả" || className.Contains(monKeyword));
                bool matchKhoi = (khoi == "Tất cả" || className.Contains(" " + khoiKeyword + " "));

                if (matchMon && matchKhoi)
                {
                    dtFilteredClasses.ImportRow(row);
                }
            }

            DataRow drAll = dtFilteredClasses.NewRow();
            drAll["classID"] = "Tất cả";
            drAll["class_name"] = "Tất cả";
            dtFilteredClasses.Rows.InsertAt(drAll, 0);

            cbbLop.DataSource = dtFilteredClasses;
            cbbLop.DisplayMember = "class_name";
            cbbLop.ValueMember = "classID";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (dgvDonXin.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một đơn để duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string accountID = dgvDonXin.CurrentRow.Cells["Mã HS"].Value.ToString();
            string classID = dgvDonXin.CurrentRow.Cells["Mã Lớp"].Value.ToString();

            try
            {
                adminService.ApproveRegistration(accountID, classID);
                MessageBox.Show("Đã duyệt đơn và thêm học sinh vào lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (dgvDonXin.CurrentRow == null || dgvDonXin.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một đơn để từ chối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string accountID = dgvDonXin.CurrentRow.Cells["Mã HS"].Value.ToString();
            string classID = dgvDonXin.CurrentRow.Cells["Mã Lớp"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn TỪ CHỐI đơn đăng ký này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    adminService.RejectRegistration(accountID, classID);
                    MessageBox.Show("Đã từ chối đơn đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi từ chối đơn: " + ex.Message);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                string monHoc = cbbMH.SelectedItem?.ToString() ?? "Tất cả";
                string khoi = cbbKhoi.SelectedItem?.ToString() ?? "Tất cả";
                string classId = cbbLop.SelectedValue?.ToString() ?? "Tất cả";

                DataTable dt = adminService.FilterRegistrations(monHoc, khoi, classId);

                dgvDonXin.DataSource = dt;


                dgvDonXin.DataBindingComplete += (s, ev) =>
                {
                    dgvDonXin.ClearSelection();
                    dgvDonXin.CurrentCell = null;
                };

                dgvTTHS.DataSource = null;
                dgvTTLH.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

    }
}
