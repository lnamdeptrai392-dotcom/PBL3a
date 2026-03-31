using Microsoft.Data.SqlClient;
using PBL3a.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3a.UI.AdminC.Forms
{
    public partial class Form1DuyetDon : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public Form1DuyetDon()
        {
            InitializeComponent();
        }
        private void Form1DuyetDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // Tải danh sách đơn "Chờ duyệt" lên DataGridView
        private void LoadData()
        {
            string query = @"
                SELECT 
                    r.RegistrationID,
                    r.AccountID AS [Mã HS],
                    a.name AS [Tên Học Sinh],
                    r.ClassID AS [Mã Lớp],
                    c.class_name AS [Tên Lớp],
                    r.RegistrationDate AS [Ngày Gửi],
                    r.Note AS [Ghi Chú]
                FROM Registration r
                INNER JOIN accountList a ON r.AccountID = a.Id
                INNER JOIN Class c ON r.ClassID = c.classID
                WHERE r.Status = N'Chờ duyệt'";

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvData.DataSource = dt;

                    // Ẩn cột RegistrationID đi
                    if (dgvData.Columns["RegistrationID"] != null)
                    {
                        dgvData.Columns["RegistrationID"].Visible = false;
                    }

                    // Chỉnh UI cho DataGridView
                    dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvData.AllowUserToAddRows = false;
                    dgvData.ReadOnly = true;
                    dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng khi click
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng nào chưa
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một đơn để duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ dòng đang chọn
            int regID = Convert.ToInt32(dgvData.CurrentRow.Cells["RegistrationID"].Value);
            string accountID = dgvData.CurrentRow.Cells["Mã HS"].Value.ToString();
            string classID = dgvData.CurrentRow.Cells["Mã Lớp"].Value.ToString();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();
                // Sử dụng SqlTransaction để đảm bảo 2 lệnh Update và Insert chạy thành công cùng nhau
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Cập nhật trạng thái thành Đã duyệt
                        string updateQuery = "UPDATE Registration SET Status = N'Đã duyệt' WHERE RegistrationID = @regID";
                        using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn, transaction))
                        {
                            cmdUpdate.Parameters.AddWithValue("@regID", regID);
                            cmdUpdate.ExecuteNonQuery();
                        }

                        // 2. Thêm học sinh vào lớp (bảng JoinClass)
                        string insertQuery = "INSERT INTO JoinClass (AccountID, classID) VALUES (@accountID, @classID)";
                        using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn, transaction))
                        {
                            cmdInsert.Parameters.AddWithValue("@accountID", accountID);
                            cmdInsert.Parameters.AddWithValue("@classID", classID);
                            cmdInsert.ExecuteNonQuery();
                        }

                        // Nếu không có lỗi gì xảy ra, Commit (lưu) dữ liệu
                        transaction.Commit();
                        MessageBox.Show("Đã duyệt đơn và thêm học sinh vào lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Tải lại danh sách (đơn vừa duyệt sẽ biến mất khỏi bảng này)
                        LoadData();
                    }
                    catch (SqlException sqlEx)
                    {
                        // Nếu có lỗi, Rollback (hủy bỏ) các lệnh vừa chạy
                        transaction.Rollback();

                        if (sqlEx.Number == 2627) // 2627 là mã lỗi của SQL khi bị trùng Primary Key
                        {
                            MessageBox.Show("Học sinh này đã tồn tại trong lớp rồi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi CSDL: " + sqlEx.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một đơn để từ chối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int regID = Convert.ToInt32(dgvData.CurrentRow.Cells["RegistrationID"].Value);

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn TỪ CHỐI đơn đăng ký này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string updateQuery = "UPDATE Registration SET Status = N'Từ chối' WHERE RegistrationID = @regID";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@regID", regID);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Đã từ chối đơn đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Cập nhật lại grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
    }
}
