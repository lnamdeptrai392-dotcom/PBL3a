using Microsoft.Data.SqlClient;
using PBL3a.services;
using PBL3a.UI.AdminC.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class KhoanChi : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtChi = new DataTable();
        private int selectedChiID = -1;

        public KhoanChi()
        {
            InitializeComponent();
            Load += KhoanChi_Load;
        }

        private void KhoanChi_Load(object? sender, EventArgs e)
        {
            SetupDataGridView();
            cbbC.SelectedIndex = 0;
            ngay.Value = DateTime.Now;
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = false;
            dataGridView1.RowHeadersVisible = true;
        }

        private void btOK_Click(object? sender, EventArgs e)
        {
            if (cbbC.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tùy chọn thời gian để xem");
                return;
            }
            DateTime today = ngay.Value.Date;
            int month = ngay.Value.Month;
            int year = ngay.Value.Year;

            string query = "";

            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    if (cbbC.SelectedItem.ToString() == "ngày")
                    {
                        query = @"
                        SELECT ChiID AS [Mã], 
                               LoaiChi AS [Loại chi], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayChi AS [Ngày chi], 
                               GhiChu AS [Ghi chú]
                        FROM KhoanChi WHERE NgayChi = @date";

                        cmd.Parameters.Add("@date", SqlDbType.Date).Value = today;
                    }
                    else if (cbbC.SelectedItem.ToString() == "tháng")
                    {
                        query = @"
                        SELECT ChiID AS [Mã], 
                               LoaiChi AS [Loại chi], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayChi AS [Ngày chi], 
                               GhiChu AS [Ghi chú]
                        FROM KhoanChi WHERE ChiMonth = @month AND ChiYear = @year";

                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);
                    }
                    else if (cbbC.SelectedItem.ToString() == "năm")
                    {
                        query = @"
                        SELECT ChiID AS [Mã], 
                               LoaiChi AS [Loại chi], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayChi AS [Ngày chi], 
                               GhiChu AS [Ghi chú]
                        FROM KhoanChi WHERE ChiYear = @year";

                        cmd.Parameters.AddWithValue("@year", year);
                    }

                    if (string.IsNullOrEmpty(query)) return;

                    cmd.CommandText = query;

                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            dtChi = new DataTable();
                            adapter.Fill(dtChi);
                            dataGridView1.DataSource = dtChi;
                            dataGridView1.RowHeadersVisible = true;
                            dataGridView1.AllowUserToAddRows = true;
                            dataGridView1.ReadOnly = false;
                            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

                            if (dataGridView1.Columns.Contains("Mã"))
                            {
                                dataGridView1.Columns["Mã"].DefaultCellStyle.BackColor = Color.LightGray;
                            }
                            if (dataGridView1.Columns.Contains("Ngày chi"))
                            {
                                dataGridView1.Columns["Ngày chi"].DefaultCellStyle.Format = "yyyy-MM-dd";
                            }
                        }
                        TinhTongKhoanChi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    }
                }
            }
        }

        private void TinhTongKhoanChi()
        {
            decimal tong = 0;

            foreach (DataRow row in dtChi.Rows)
            {
                if (row["Số tiền"] != DBNull.Value)
                {
                    tong += Convert.ToDecimal(row["Số tiền"]);
                }
            }

            tbKT.Text = tong.ToString("N0") + " VNĐ";
        }


        private void btOK_MouseEnter(object sender, EventArgs e)
        {
            but_chform.bt_MouseEnter(sender, e);
        }

        private void btOK_MouseLeave(object sender, EventArgs e)
        {
            but_chform.bt_MouseLeave(sender, e);
        }

        private void CapNhatKhoanChiXuongDB(int chiID, string loaiChi, string noiDung, decimal soTien, DateTime ngayChi, string ghiChu)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                                UPDATE KhoanChi 
                                SET LoaiChi = @loai, 
                                    NoiDung = @nd, 
                                    SoTien = @tien, 
                                    NgayChi = @ngay,
                                    ChiMonth = @month,
                                    ChiYear = @year,
                                    GhiChu = @gc
                                WHERE ChiID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@loai", loaiChi);
                    cmd.Parameters.AddWithValue("@nd", noiDung);
                    cmd.Parameters.AddWithValue("@tien", soTien);

                    cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngayChi;

                    cmd.Parameters.AddWithValue("@month", ngayChi.Month);
                    cmd.Parameters.AddWithValue("@year", ngayChi.Year);

                    cmd.Parameters.AddWithValue("@gc", ghiChu);
                    cmd.Parameters.AddWithValue("@id", chiID);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi đồng bộ CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private int ThemMoiKhoanChiXuongDB(string loaiChi, string noiDung, decimal soTien, DateTime ngayChi, string ghiChu)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                                INSERT INTO KhoanChi (LoaiChi, NoiDung, SoTien, NgayChi, ChiMonth, ChiYear, GhiChu)
                                OUTPUT INSERTED.ChiID 
                                VALUES (@loai, @nd, @tien, @ngay, @month, @year, @gc)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@loai", loaiChi);
                    cmd.Parameters.AddWithValue("@nd", noiDung);
                    cmd.Parameters.AddWithValue("@tien", soTien);
                    cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngayChi;
                    cmd.Parameters.AddWithValue("@month", ngayChi.Month);
                    cmd.Parameters.AddWithValue("@year", ngayChi.Year);
                    cmd.Parameters.AddWithValue("@gc", ghiChu);

                    try
                    {
                        conn.Open();
                        int newID = (int)cmd.ExecuteScalar();
                        return newID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Loại chi" || colName == "Nội dung" || colName == "Số tiền" || colName == "Ngày chi" || colName == "Ghi chú")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                try
                {
                    string loaiChi = row.Cells["Loại chi"].Value?.ToString() ?? "";
                    string soTienStr = row.Cells["Số tiền"].Value?.ToString() ?? "";
                    string idStr = row.Cells["Mã"].Value?.ToString() ?? "";
                    if (string.IsNullOrEmpty(idStr) && (string.IsNullOrWhiteSpace(loaiChi) || string.IsNullOrWhiteSpace(soTienStr)))
                    {
                        return;
                    }
                    decimal.TryParse(soTienStr, out decimal soTien);
                    string noiDung = row.Cells["Nội dung"].Value?.ToString() ?? "";
                    string ghiChu = row.Cells["Ghi chú"].Value?.ToString() ?? "";

                    DateTime ngayChi = ngay.Value.Date;
                    var cellNgay = row.Cells["Ngày chi"].Value;

                    if (cellNgay != null && cellNgay != DBNull.Value && cellNgay.ToString().Trim() != "")
                    {
                        try
                        {
                            ngayChi = Convert.ToDateTime(cellNgay);
                        }
                        catch
                        {
                            ngayChi = ngay.Value.Date;
                        }
                    }
                    if (string.IsNullOrEmpty(idStr))
                    {
                        int newID = ThemMoiKhoanChiXuongDB(loaiChi, noiDung, soTien, ngayChi, ghiChu);
                        MessageBox.Show("Them thanh cong!!!");
                        if (newID > 0)
                        {
                            dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                            row.Cells["Mã"].Value = newID;
                            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                        }
                    }
                    else
                    {
                        int chiID = int.Parse(idStr);
                        CapNhatKhoanChiXuongDB(chiID, loaiChi, noiDung, soTien, ngayChi, ghiChu);
                    }
                    TinhTongKhoanChi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (colName == "Mã")
            {
                var cellValue = row.Cells["Mã"].Value;
                if (cellValue != null && cellValue.ToString() != "")
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

