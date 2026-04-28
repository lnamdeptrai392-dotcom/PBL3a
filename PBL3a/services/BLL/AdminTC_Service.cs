using Microsoft.Data.SqlClient;
using PBL3a.UI.AdminTC;
using PBL3a.UI.Teacher;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace PBL3a.services.BLL
{
    internal class AdminTC_Service
    {
        private DatabaseHelper db = new DatabaseHelper();


        // HocPhi
        public List<string> GetClassIDsByKeyword(string keyword)
        {
            List<string> classList = new List<string>();

            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT classID FROM Class WHERE classID LIKE @text ORDER BY classID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@text", "%" + keyword + "%");

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classList.Add(reader["classID"].ToString());
                        }
                    }
                }
            }
            return classList;
        }

        public string GetClassNameByID(string classID)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT class_name FROM Class WHERE classID = @classID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@classID", classID);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "";
                }
            }
        }

        public DataTable GetTuitionByClass(string classID)
        {
            DataTable dtHocPhi = new DataTable();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        hp.HocPhiID AS [ID],
                        hp.AccountID AS [Mã HS],
                        a.name AS [Tên học sinh],
                        hp.TuitionMonth AS [Tháng],
                        hp.TuitionYear AS [Năm],
                        hp.SoTien AS [Số tiền],
                        hp.TrangThai AS [Trạng thái],
                        hp.NgayDong AS [Ngày đóng],
                        hp.GhiChu AS [Ghi chú]
                    FROM HocPhi hp
                    INNER JOIN accountList a ON hp.AccountID = a.Id
                    WHERE hp.ClassID = @classID
                    ORDER BY hp.TuitionYear DESC, hp.TuitionMonth DESC, a.Id";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@classID", classID);
                    adapter.Fill(dtHocPhi);
                }
            }
            return dtHocPhi;
        }

        // LuongGV
        public List<string> GetTeachersByID(string text)
        {
            List<string> list = new List<string>();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id FROM accountList WHERE Role = 'Teacher' AND Id LIKE @text ORDER BY Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@text", "%" + text + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(reader["Id"].ToString());
                        }
                    }
                }
            }
            return list;
        }

        public string GetNameTeacherByID(string teacherID)
        {
            string name = "";
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT name FROM accountList WHERE Id = @teacherID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherID", teacherID);
                    object result = cmd.ExecuteScalar();
                    name = result != null ? result.ToString() : "";
                }
            }
            return name;
        }

        public DataTable GetSalaryByID(string teacherID)
        {
            DataTable dtLuong = new DataTable();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        LuongID,
                        TeacherID AS [Mã GV],
                        SalaryMonth AS [Tháng],
                        SalaryYear AS [Năm],
                        SoLopDay AS [Số lớp dạy],
                        SoBuoiDay AS [Số buổi dạy],
                        LuongCoBan AS [Lương cơ bản],
                        Thuong AS [Thưởng],
                        Phat AS [Phạt],
                        TongLuong AS [Tổng lương],
                        TrangThai AS [Trạng thái],
                        NgayThanhToan AS [Ngày thanh toán],
                        GhiChu AS [Ghi chú]
                    FROM LuongGV
                    WHERE TeacherID = @teacherID
                    ORDER BY SalaryYear DESC, SalaryMonth DESC";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@teacherID", teacherID);
                    adapter.Fill(dtLuong);
                }
            }
            return dtLuong;
        }

        public void UpdateSalaryForTeacher(string teacherID, int month, int year)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string checkQuery = @"
                SELECT COUNT(*)
                FROM LuongGV
                WHERE TeacherID = @teacherID AND SalaryMonth = @month AND SalaryYear = @year";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@teacherID", teacherID);
                    checkCmd.Parameters.AddWithValue("@month", month);
                    checkCmd.Parameters.AddWithValue("@year", year);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Tháng này đã có bảng lương cho giảng viên.");
                        GetSalaryByID(teacherID);
                        return;
                    }
                }

                string classCountQuery = @"SELECT COUNT(*) FROM Class WHERE teacherID = @teacherID
                                        AND start_date <= EOMONTH(DATEFROMPARTS(@year, @month, 1))
                                        AND end_date >= DATEFROMPARTS(@year, @month, 1)";
                int soLopDay = 0;

                using (SqlCommand cmd = new SqlCommand(classCountQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherID", teacherID);
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    soLopDay = (int)cmd.ExecuteScalar();
                }

                int soBuoiDay = soLopDay * 8;
                decimal luongCoBan = soBuoiDay * 400000;
                decimal thuong = 0;
                decimal phat = 0;
                decimal tongLuong = luongCoBan + thuong - phat;

                string insertQuery = @"
                INSERT INTO LuongGV
                (TeacherID, SalaryMonth, SalaryYear, SoLopDay, SoBuoiDay, LuongCoBan, Thuong, Phat, TongLuong, TrangThai, NgayThanhToan, GhiChu)
                VALUES
                (@teacherID, @month, @year, @soLopDay, @soBuoiDay, @luongCoBan, @thuong, @phat, @tongLuong, N'Chưa thanh toán', NULL, NULL)";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@teacherID", teacherID);
                    insertCmd.Parameters.AddWithValue("@month", month);
                    insertCmd.Parameters.AddWithValue("@year", year);
                    insertCmd.Parameters.AddWithValue("@soLopDay", soLopDay);
                    insertCmd.Parameters.AddWithValue("@soBuoiDay", soBuoiDay);
                    insertCmd.Parameters.AddWithValue("@luongCoBan", luongCoBan);
                    insertCmd.Parameters.AddWithValue("@thuong", thuong);
                    insertCmd.Parameters.AddWithValue("@phat", phat);
                    insertCmd.Parameters.AddWithValue("@tongLuong", tongLuong);

                    insertCmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSalaryForTeacher(int luongID, decimal thuong, decimal phat, decimal tongLuong, string trangThai, DateTime ngay, string ghichu)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                                UPDATE LuongGV 
                                SET Thuong = @thuong, 
                                    Phat = @phat, 
                                    TongLuong = @tongLuong,
                                    TrangThai = @trangThai,
                                    NgayThanhToan = @ngay,
                                    GhiChu = @ghichu
                                WHERE LuongID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@thuong", thuong);
                    cmd.Parameters.AddWithValue("@phat", phat);
                    cmd.Parameters.AddWithValue("@tongLuong", tongLuong);
                    cmd.Parameters.AddWithValue("@id", luongID);

                    cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    cmd.Parameters.AddWithValue("@ghichu", ghichu);

                    cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = ngay;

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

        // KhoanThu

        public void UpdateIncome(int thuID, string loaiThu, string noiDung, decimal soTien, DateTime ngayThu, string ghiChu)
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

        public int InsertIncome(string loaiThu, string noiDung, decimal soTien, DateTime ngayThu, string ghiChu)
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

        public DataTable getIncomeByDate(DateTime day)
        {
            DataTable dt = new DataTable();
            string query = @"
                        SELECT ThuID AS [Mã], 
                               LoaiThu AS [Loại thu], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayThu AS [Ngày thu], 
                               GhiChu AS [Ghi chú]
                        FROM KhoanThu WHERE NgayThu = @date";
            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = day;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable getIncomeByMonth(int month, int year)
        {
            DataTable dt = new DataTable();
            string query = @"
                        SELECT ThuID AS [Mã], 
                               LoaiThu AS [Loại thu], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayThu AS [Ngày thu], 
                               GhiChu AS [Ghi chú]
                        FROM KhoanThu WHERE ThuMonth = @month AND ThuYear = @year";
            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable getIncomeByYear(int year)
        {
            DataTable dt = new DataTable();
            string query = @"
                        SELECT ThuID AS [Mã], 
                               LoaiThu AS [Loại thu], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayThu AS [Ngày thu], 
                               GhiChu AS [Ghi chú]
                        FROM KhoanThu WHERE ThuYear = @year";
            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@year", year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            return dt;
        }


        // KhoanChi

        public void UpdateExpense(int chiID, string loaiChi, string noiDung, decimal soTien, DateTime ngayChi, string ghiChu)
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

        public int InsertExpense(string loaiChi, string noiDung, decimal soTien, DateTime ngayChi, string ghiChu)
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

        public DataTable getExpenseByDate(DateTime day)
        {
            DataTable dt = new DataTable();
            string query = @"
                        SELECT ChiID AS [Mã], 
                               LoaiChi AS [Loại chi], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayChi AS [Ngày chi], 
                               GhiChu AS [Ghi chú]
                        FROM KhoanChi WHERE NgayChi = @date";
            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = day;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable getExpenseByMonth(int month, int year)
        {
            DataTable dt = new DataTable();
            string query = @"
                        SELECT ChiID AS [Mã], 
                               LoaiChi AS [Loại chi], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayChi AS [Ngày chi], 
                               GhiChu AS [Ghi chú]
                        FROM KhoanChi WHERE ChiMonth = @month AND ChiYear = @year";
            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable getExpenseByYear(int year)
        {
            DataTable dt = new DataTable();
            string query = @"
                        SELECT ChiID AS [Mã], 
                               LoaiChi AS [Loại chi], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayChi AS [Ngày chi], 
                               GhiChu AS [Ghi chú]
                        FROM KhoanChi WHERE ChiYear = @year";
            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@year", year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // Laisuat

        public DataTable getNetIncomeByDate(DateTime day)
        {
            DataTable dt = new DataTable();
            string query = @"
                        SELECT ThuID AS [Mã], 
                               LoaiThu AS [Loại thu], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayThu AS [Ngày thu], 
                               GhiChu AS [Ghi chú], 
                               'Thu' AS [Loại Giao Dịch]
                        FROM KhoanThu WHERE NgayThu = @date
                        UNION ALL
                        SELECT ChiID AS [Mã chi], 
                                LoaiChi AS [Loại chi], 
                                NoiDung AS [Nội dung], 
                                SoTien AS [Số tiền], 
                                NgayChi AS [Ngày chi], 
                                GhiChu AS [Ghi chú], 
                                'Chi' AS [Loại Giao Dịch]
                        FROM KhoanChi WHERE NgayChi = @date";
            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = day;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable getNetIncomeByMonth(int month, int year)
        {
            DataTable dt = new DataTable();
            string query = @"
                        SELECT ThuID AS [Mã], 
                               LoaiThu AS [Loại thu], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayThu AS [Ngày thu], 
                               GhiChu AS [Ghi chú], 
                               'Thu' AS [Loại Giao Dịch]
                        FROM KhoanThu WHERE ThuMonth = @month AND ThuYear = @year
                        UNION ALL
                        SELECT ChiID AS [Mã chi], 
                                LoaiChi AS [Loại chi], 
                                NoiDung AS [Nội dung], 
                                SoTien AS [Số tiền], 
                                NgayChi AS [Ngày chi], 
                                GhiChu AS [Ghi chú], 
                                'Chi' AS [Loại Giao Dịch]
                        FROM KhoanChi WHERE ChiMonth = @month AND ChiYear = @year";
            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable getNetIncomeByYear(int year)
        {
            DataTable dt = new DataTable();
            string query = @"
                        SELECT ThuID AS [Mã], 
                               LoaiThu AS [Loại thu], 
                               NoiDung AS [Nội dung], 
                               SoTien AS [Số tiền], 
                               NgayThu AS [Ngày thu], 
                               GhiChu AS [Ghi chú], 
                               'Thu' AS [Loại Giao Dịch]
                        FROM KhoanThu WHERE ThuYear = @year
                        UNION ALL
                        SELECT ChiID AS [Mã chi], 
                                LoaiChi AS [Loại chi], 
                                NoiDung AS [Nội dung], 
                                SoTien AS [Số tiền], 
                                NgayChi AS [Ngày chi], 
                                GhiChu AS [Ghi chú], 
                                'Chi' AS [Loại Giao Dịch]
                        FROM KhoanChi WHERE ChiYear = @year";
            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@year", year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // ThietlapHP

        public int UpdateTuition(string MaLop, decimal hocphi1)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE HocPhi SET SoTien = @tienTrenNg WHERE ClassID = @id AND TrangThai = N'Chưa đóng'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tienTrenNg", Convert.ToDecimal(hocphi1));
                    cmd.Parameters.AddWithValue("@id", MaLop);
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        public int getUnpaidCapacity(string idlop)
        {
            int cap = 0;
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT COUNT(AccountID) FROM HocPhi WHERE ClassID = @id AND TrangThai = N'Chưa đóng'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idlop);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        cap = Convert.ToInt32(result);
                    }
                }
            }
            return cap;
        }
    }
}
