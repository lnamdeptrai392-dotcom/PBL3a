using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using PBL3;
using PBL3a.services;
using PBL3a.services.BLL;
using System;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PBL3a.UI.AdminTC
{
    public partial class LuongGV : Form
    {
        private DataTable dtLuong = new DataTable();
        private AdminTC_Service admin_sv = new AdminTC_Service();
        public LuongGV()
        {
            InitializeComponent();
            Load += LuongGV_Load;
            cbbMGV.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void LuongGV_Load(object? sender, EventArgs e)
        {
            SetupDataGridView();
            LoadDanhSachGiangVien(cbbMGV.Text);
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadDanhSachGiangVien(string text)
        {
            cbbMGV.Items.Clear();
            List<string> dsgv = admin_sv.GetTeachersByID(text);
            if (dsgv.Count > 0)
            {
                cbbMGV.Items.AddRange(dsgv.ToArray());
                cbbMGV.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbbMGV.SelectedItem == null) return;

            string teacherID = cbbMGV.SelectedItem.ToString();
            LoadTenGiangVien(teacherID);
            LoadLuongTheoGV(teacherID);
            txtNam.Text = DateTime.Now.Year.ToString();
        }

        private void LoadTenGiangVien(string teacherID)
        {
            tbTL.Text = admin_sv.GetNameTeacherByID(teacherID);
        }

        private void LoadLuongTheoGV(string teacherID)
        {
            dtLuong = admin_sv.GetSalaryByID(teacherID);
            dataGridView1.DataSource = dtLuong;

            if (dataGridView1.Columns["LuongID"] != null)
                dataGridView1.Columns["LuongID"].ReadOnly = true;

            if (dataGridView1.Columns["Mã GV"] != null)
                dataGridView1.Columns["Mã GV"].ReadOnly = true;

            if (dataGridView1.Columns["Tháng"] != null)
                dataGridView1.Columns["Tháng"].ReadOnly = true;

            if (dataGridView1.Columns["Năm"] != null)
                dataGridView1.Columns["Năm"].ReadOnly = true;

            if (dataGridView1.Columns["Số lớp dạy"] != null)
                dataGridView1.Columns["Số lớp dạy"].ReadOnly = true;

            if (dataGridView1.Columns["Số buổi dạy"] != null)
                dataGridView1.Columns["Số buổi dạy"].ReadOnly = true;

            if (dataGridView1.Columns["Tổng lương"] != null)
                dataGridView1.Columns["Tổng lương"].ReadOnly = true;
        }

        private void btCheckL_Click(object sender, EventArgs e)
        {
            if (cbbMGV.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giảng viên.");
                return;
            }

            string teacherID = cbbMGV.SelectedItem.ToString();
            LoadLuongTheoGV(teacherID);
        }

        private void btSetL_Click(object sender, EventArgs e)
        {
            if (cbbMGV.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giảng viên.");
                return;
            }

            string teacherID = cbbMGV.SelectedItem.ToString();
            LoadLuongTheoGV(teacherID);

            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            if (cbbThang.SelectedItem != null && txtNam.Text != "")
            {
                month = Convert.ToInt32(cbbThang.SelectedItem.ToString());
                year = Convert.ToInt32(txtNam.Text);
            }
            else if ((cbbThang.SelectedItem != null || txtNam.Text == "") && (cbbThang.SelectedItem == null || txtNam.Text != ""))
            {
                MessageBox.Show("Hay chon thang va nam");
                return;
            }
            admin_sv.UpdateSalaryForTeacher(teacherID, month, year);

            MessageBox.Show("Đã tính toán lương thành công.");
            LoadLuongTheoGV(teacherID);
        }

        private void btSetL_MouseEnter(object sender, EventArgs e)
        {
            but_chform.bt_MouseEnter(sender, e);
        }

        private void btSetL_MouseLeave(object sender, EventArgs e)
        {
            but_chform.bt_MouseLeave(sender, e);
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                string keyword = cbbMGV.Text;
                int cursorPosition = cbbMGV.SelectionStart;
                cbbMGV.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
                LoadDanhSachGiangVien(keyword);

                cbbMGV.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

                cbbMGV.Text = keyword;
                cbbMGV.SelectionStart = cursorPosition;

                if (cbbMGV.Items.Count > 0)
                {
                    cbbMGV.DroppedDown = true;
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    cbbMGV.DroppedDown = false;
                }
            }
            catch (Exception)
            {
                cbbMGV.DroppedDown = false;
            }
        }

        private void CapNhatLuongGV(int luongID, decimal thuong, decimal phat, decimal tongLuong, string trangThai, DateTime ngay, string ghichu)
        {
            admin_sv.UpdateSalaryForTeacher(luongID, thuong, phat, tongLuong, trangThai, ngay, ghichu);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "Thưởng" || colName == "Phạt" || colName == "Trạng thái" || colName == "Ngày thanh toán" || colName == "Ghi chú")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                try
                {
                    decimal luongCB = 0, thuong = 0, phat = 0;

                    if (row.Cells["Lương cơ bản"].Value != null)
                        decimal.TryParse(row.Cells["Lương cơ bản"].Value.ToString(), out luongCB);

                    if (row.Cells["Thưởng"].Value != null)
                        decimal.TryParse(row.Cells["Thưởng"].Value.ToString(), out thuong);

                    if (row.Cells["Phạt"].Value != null)
                        decimal.TryParse(row.Cells["Phạt"].Value.ToString(), out phat);

                    string trangThai = row.Cells["Trạng thái"].Value?.ToString() ?? "Chưa trả";
                    string ghiChu = row.Cells["Ghi chú"].Value?.ToString() ?? "";

                    DateTime ngayTT = DateTime.Now;
                    if (row.Cells["Ngày thanh toán"].Value != null)
                    {
                        DateTime.TryParse(row.Cells["Ngày thanh toán"].Value.ToString(), out ngayTT);
                    }

                    decimal tongLuong = luongCB + thuong - phat;

                    dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                    row.Cells["Tổng lương"].Value = tongLuong;
                    dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;

                    if (int.TryParse(row.Cells["LuongID"].Value?.ToString(), out int luongID))
                    {
                        CapNhatLuongGV(luongID, thuong, phat, tongLuong, trangThai, ngayTT, ghiChu);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi tính toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}