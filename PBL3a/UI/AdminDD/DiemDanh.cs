using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using PBL3a.services;
using PBL3a.UI.Login;

namespace PBL3a.UI.AdminDD
{
    public partial class Form1 : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadClass();
            SetupGrid();

            btnTimKiem.Click += btnTimKiem_Click;
            btnSave.Click += btnSave_Click;
        }

        // Load danh sách lớp vào combobox
        private void LoadClass()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT classID, class_name FROM Class";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboLopHoc.DataSource = dt;
                cboLopHoc.DisplayMember = "class_name";
                cboLopHoc.ValueMember = "classID";
                cboLopHoc.SelectedIndex = -1;
            }
        }

        // Tạo cột DataGridView
        private void SetupGrid()
        {
            dgvDiemDanh.Columns.Clear();
            dgvDiemDanh.AutoGenerateColumns = false;

            dgvDiemDanh.Columns.Add("AccountID", "Mã HS");
            dgvDiemDanh.Columns["AccountID"].ReadOnly = true;

            dgvDiemDanh.Columns.Add("StudentName", "Tên học sinh");
            dgvDiemDanh.Columns["StudentName"].ReadOnly = true;

            DataGridViewComboBoxColumn status = new DataGridViewComboBoxColumn();
            status.Name = "Status";
            status.HeaderText = "Trạng thái";
            status.Items.AddRange("Có mặt", "Vắng", "Muộn");
            dgvDiemDanh.Columns.Add(status);

            dgvDiemDanh.Columns.Add("Note", "Ghi chú");
        }

        // Tìm danh sách học sinh theo lớp
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboLopHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp");
                return;
            }

            int classID = Convert.ToInt32(cboLopHoc.SelectedValue);
            DateTime dateValue = date.Value.Date;

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    jc.AccountID,
                    al.name AS StudentName,
                    ISNULL(a.Status,N'Có mặt') AS Status,
                    ISNULL(a.Note,'') AS Note
                FROM JoinClass jc
                JOIN accountList al ON jc.AccountID = al.Id
                LEFT JOIN Attendance a 
                    ON a.AccountID = jc.AccountID 
                    AND a.ClassID = jc.classID
                    AND a.AttendanceDate = @date
                WHERE jc.classID = @classID
                ";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@classID", classID);
                cmd.Parameters.AddWithValue("@date", dateValue);

                SqlDataReader reader = cmd.ExecuteReader();

                dgvDiemDanh.Rows.Clear();

                while (reader.Read())
                {
                    dgvDiemDanh.Rows.Add(
                        reader["AccountID"].ToString(),
                        reader["StudentName"].ToString(),
                        reader["Status"].ToString(),
                        reader["Note"].ToString()
                    );
                }
            }
        }

        // Lưu điểm danh
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboLopHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn lớp trước");
                return;
            }

            int classID = Convert.ToInt32(cboLopHoc.SelectedValue);
            DateTime attendanceDate = date.Value.Date;

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                foreach (DataGridViewRow row in dgvDiemDanh.Rows)
                {
                    if (row.IsNewRow) continue;

                    string accountID = row.Cells["AccountID"].Value.ToString();
                    string status = row.Cells["Status"].Value?.ToString() ?? "Có mặt";
                    string note = row.Cells["Note"].Value?.ToString() ?? "";

                    // kiểm tra tồn tại
                    string check = @"SELECT COUNT(*) 
                                     FROM Attendance 
                                     WHERE AccountID=@acc 
                                     AND ClassID=@class 
                                     AND AttendanceDate=@date";

                    SqlCommand checkCmd = new SqlCommand(check, conn);
                    checkCmd.Parameters.AddWithValue("@acc", accountID);
                    checkCmd.Parameters.AddWithValue("@class", classID);
                    checkCmd.Parameters.AddWithValue("@date", attendanceDate);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        string update = @"UPDATE Attendance 
                                          SET Status=@status, Note=@note
                                          WHERE AccountID=@acc 
                                          AND ClassID=@class 
                                          AND AttendanceDate=@date";

                        SqlCommand updateCmd = new SqlCommand(update, conn);

                        updateCmd.Parameters.AddWithValue("@status", status);
                        updateCmd.Parameters.AddWithValue("@note", note);
                        updateCmd.Parameters.AddWithValue("@acc", accountID);
                        updateCmd.Parameters.AddWithValue("@class", classID);
                        updateCmd.Parameters.AddWithValue("@date", attendanceDate);

                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        string insert = @"INSERT INTO Attendance
                        (AccountID,ClassID,AttendanceDate,Status,Note)
                        VALUES(@acc,@class,@date,@status,@note)";

                        SqlCommand insertCmd = new SqlCommand(insert, conn);

                        insertCmd.Parameters.AddWithValue("@acc", accountID);
                        insertCmd.Parameters.AddWithValue("@class", classID);
                        insertCmd.Parameters.AddWithValue("@date", attendanceDate);
                        insertCmd.Parameters.AddWithValue("@status", status);
                        insertCmd.Parameters.AddWithValue("@note", note);

                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Lưu điểm danh thành công!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();

        }
    }
}