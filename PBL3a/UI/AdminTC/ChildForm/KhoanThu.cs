using Microsoft.Data.SqlClient;
using PBL3a.services;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace PBL3a.UI.AdminTC
{
    public partial class KhoanThu : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtThu = new DataTable();

        public KhoanThu()
        {
            InitializeComponent();
            Load += KhoanThu_Load;
        }

        private void KhoanThu_Load(object? sender, EventArgs e)
        {
            SetupDataGridView();
            cbbT.SelectedIndex = 0;
            ngay.Value = DateTime.Now;
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = false;
        }

        private void TinhTongKhoanThu()
        {
            decimal tong = 0;

            foreach (DataRow row in dtThu.Rows)
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

        private void CapNhatKhoanThuXuongDB(int thuID, string loaiThu, string noiDung, decimal soTien, DateTime ngayThu, string ghiChu)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                                UPDATE KhoanThu 
                                SET LoaiThu = @loai, 
                                    NoiDung = @nd, 
                                    SoTien = @tien, 
                                    NgayThu = @ngay,
                                    ThuMonth = @month,
                                    ThuYear = @year,
                                    GhiChu = @gc
                                WHERE ThuID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@loai", loaiThu);
                    cmd.Parameters.AddWithValue("@nd", noiDung);
                    cmd.Parameters.AddWithValue("@tien", soTien);

                    cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngayThu;

                    cmd.Parameters.AddWithValue("@month", ngayThu.Month);
                    cmd.Parameters.AddWithValue("@year", ngayThu.Year);

                    cmd.Parameters.AddWithValue("@gc", ghiChu);
                    cmd.Parameters.AddWithValue("@id", thuID);

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

        private int ThemMoiKhoanThuXuongDB(string loaiThu, string noiDung, decimal soTien, DateTime ngayThu, string ghiChu)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    INSERT INTO KhoanThu (LoaiThu, NoiDung, SoTien, NgayThu, ThuMonth, ThuYear, GhiChu)
                    OUTPUT INSERTED.ThuID 
                    VALUES (@loai, @nd, @tien, @ngay, @month, @year, @gc)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@loai", loaiThu);
                    cmd.Parameters.AddWithValue("@nd", noiDung);
                    cmd.Parameters.AddWithValue("@tien", soTien);
                    cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngayThu;
                    cmd.Parameters.AddWithValue("@month", ngayThu.Month);
                    cmd.Parameters.AddWithValue("@year", ngayThu.Year);
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

        private void btOK_Click(object sender, EventArgs e)
        {
            if (cbbT.SelectedItem == null)
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

                    if (cbbT.SelectedItem.ToString() == "ngày")
                    {
                        query = @"
                        SELECT ThuID AS [Mã], 
                               LoaiThu AS [Loại thu], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayThu AS [Ngày thu], 
                               GhiChu AS [Ghi chú]
                        FROM KhoanThu WHERE NgayThu = @date";

                        cmd.Parameters.Add("@date", SqlDbType.Date).Value = today;
                    }
                    else if (cbbT.SelectedItem.ToString() == "tháng")
                    {
                        query = @"
                        SELECT ThuID AS [Mã], 
                               LoaiThu AS [Loại thu], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayThu AS [Ngày thu], 
                               GhiChu AS [Ghi chú]
                        FROM KhoanThu WHERE ThuMonth = @month AND ThuYear = @year";

                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);
                    }
                    else if (cbbT.SelectedItem.ToString() == "năm")
                    {
                        query = @"
                        SELECT ThuID AS [Mã], 
                               LoaiThu AS [Loại thu], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayThu AS [Ngày thu], 
                               GhiChu AS [Ghi chú]
                        FROM KhoanThu WHERE ThuYear = @year";

                        cmd.Parameters.AddWithValue("@year", year);
                    }

                    if (string.IsNullOrEmpty(query)) return;

                    cmd.CommandText = query;

                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            dtThu = new DataTable();
                            adapter.Fill(dtThu);
                            dataGridView1.DataSource = dtThu;
                            dataGridView1.RowHeadersVisible = true;
                            dataGridView1.AllowUserToAddRows = true;
                            dataGridView1.ReadOnly = false;
                            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

                            if (dataGridView1.Columns.Contains("Mã"))
                            {
                                dataGridView1.Columns["Mã"].DefaultCellStyle.BackColor = Color.LightGray;
                            }
                            if (dataGridView1.Columns.Contains("Ngày thu"))
                            {
                                dataGridView1.Columns["Ngày thu"].DefaultCellStyle.Format = "yyyy-MM-dd";
                            }
                        }
                        TinhTongKhoanThu();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    }
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Loại thu" || colName == "Nội dung" || colName == "Số tiền" || colName == "Ngày thu" || colName == "Ghi chú")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                try
                {
                    string loaiThu = row.Cells["Loại thu"].Value?.ToString() ?? "";
                    string soTienStr = row.Cells["Số tiền"].Value?.ToString() ?? "";
                    string idStr = row.Cells["Mã"].Value?.ToString() ?? "";
                    if (string.IsNullOrEmpty(idStr) && (string.IsNullOrWhiteSpace(loaiThu) || string.IsNullOrWhiteSpace(soTienStr)))
                    {
                        return;
                    }

                    decimal.TryParse(soTienStr, out decimal soTien);
                    string noiDung = row.Cells["Nội dung"].Value?.ToString() ?? "";
                    string ghiChu = row.Cells["Ghi chú"].Value?.ToString() ?? "";

                    DateTime ngayThu = ngay.Value.Date;
                    var cellNgay = row.Cells["Ngày thu"].Value;

                    if (cellNgay != null && cellNgay != DBNull.Value && cellNgay.ToString().Trim() != "")
                    {
                        try
                        {
                            ngayThu = Convert.ToDateTime(cellNgay);
                        }
                        catch
                        {
                            ngayThu = ngay.Value.Date;
                        }
                    }
                    if (string.IsNullOrEmpty(idStr))
                    {
                        int newID = ThemMoiKhoanThuXuongDB(loaiThu, noiDung, soTien, ngayThu, ghiChu);
                        MessageBox.Show("Them thanh cong!!!");
                        if (newID > 0)
                        {
                            dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                            row.Cells["Mã"].Value = newID;
                            row.Cells["Ngày thu"].Value = ngayThu;
                            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                        }
                    }
                    else
                    {
                        int thuID = int.Parse(idStr);
                        CapNhatKhoanThuXuongDB(thuID, loaiThu, noiDung, soTien, ngayThu, ghiChu);
                    }
                    dataGridView1.EndEdit();
                    TinhTongKhoanThu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi đọc dữ liệu trên lưới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

