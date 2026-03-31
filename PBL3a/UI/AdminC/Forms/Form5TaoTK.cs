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
    public partial class Form5TaoTK : Form
    {
        DatabaseHelper dbHelper = new DatabaseHelper();

        // Tạo một bảng ảo để chứa dữ liệu xem trước
        DataTable dtPreview = new DataTable();
        public Form5TaoTK()
        {
            InitializeComponent();
        }

        private void Form5TaoTK_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu cho ComboBox
            cbbRole.Items.Add("Học sinh");
            cbbRole.Items.Add("Giáo viên");
            cbbRole.SelectedIndex = 0; // Mặc định chọn Học sinh

            // Khởi tạo các cột cho bảng ảo giống hệt cấu trúc DB
            dtPreview.Columns.Add("Id");
            dtPreview.Columns.Add("username");
            dtPreview.Columns.Add("Password");
            dtPreview.Columns.Add("name");
            dtPreview.Columns.Add("phone");
            dtPreview.Columns.Add("dateOfBirth");
            dtPreview.Columns.Add("sex");
            dtPreview.Columns.Add("Role");

            // Gắn bảng ảo vào DataGridView
            dgvData.DataSource = dtPreview;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private (string newId, string newUsername) GenerateIdAndUsername(string role, bool isNu, DateTime dob)
        {
            string id = "";
            string user = "";

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();
                if (role == "Học sinh")
                {
                    // Format: [101/102] + [2 số cuối năm sinh] + [3 số thứ tự]
                    string gioiTinhCode = isNu ? "101" : "102";
                    string namSinhCode = dob.ToString("yy"); // Ví dụ 2009 -> "09"
                    string prefix = gioiTinhCode + namSinhCode;

                    string query = "SELECT TOP 1 Id FROM accountList WHERE Id LIKE @prefix + '%' ORDER BY Id DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@prefix", prefix);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result.ToString() != "")
                        {
                            string maxId = result.ToString(); // VD: "10109010"
                            int stt = int.Parse(maxId.Substring(5, 3)); // Cắt lấy "010" -> 10
                            stt++; // Tăng lên 11
                            id = prefix + stt.ToString("D3"); // Ghép lại thành "10109011"
                        }
                        else
                        {
                            id = prefix + "001"; // Nếu chưa có ai khóa này
                        }
                    }
                    user = id; // Học sinh thì username giống hệt ID
                }
                else if (role == "Giáo viên")
                {
                    // Format: T + [3 số thứ tự]
                    string query = "SELECT TOP 1 Id FROM accountList WHERE Role = 'Teacher' ORDER BY Id DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result.ToString() != "")
                        {
                            string maxId = result.ToString(); // VD: "T001"
                            int stt = int.Parse(maxId.Substring(1)); // Cắt lấy "001" -> 1
                            stt++;
                            id = "T" + stt.ToString("D3");
                            user = "teacher" + stt.ToString();
                        }
                        else
                        {
                            id = "T001";
                            user = "teacher1";
                        }
                    }
                }
            }
            return (id, user);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu cơ bản
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!rdoNam.Checked && !rdoNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn Giới tính!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm sinh mã tự động
            string selectedRole = cbbRole.SelectedItem.ToString();
            var (newId, newUsername) = GenerateIdAndUsername(selectedRole, rdoNu.Checked, dtpDOB.Value);

            // Xóa rỗng bảng Preview hiện tại (để mỗi lần bấm Tạo chỉ hiện 1 người đang làm)
            dtPreview.Rows.Clear();

            // Thêm người mới vào bảng ảo
            string dbRole = (selectedRole == "Học sinh") ? "Student" : "Teacher";
            string dbSex = rdoNam.Checked ? "Male" : "Female";
            string password = "123456"; // Mật khẩu mặc định

            dtPreview.Rows.Add(newId, newUsername, password, txtFullName.Text.Trim(), txtPhone.Text.Trim(), dtpDOB.Value.ToString("yyyy-MM-dd"), dbSex, dbRole);
        }

        private void btnThemDB_Click(object sender, EventArgs e)
        {
            if (dtPreview.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có thông tin nào được tạo. Vui lòng bấm 'Tạo' trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy dòng dữ liệu duy nhất đang có trên DataGridView
            DataRow row = dtPreview.Rows[0];

            string query = @"INSERT INTO accountList (Id, username, Password, name, phone, dateOfBirth, sex, Role) 
                             VALUES (@id, @user, @pass, @name, @phone, @dob, @sex, @role)";

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", row["Id"]);
                        cmd.Parameters.AddWithValue("@user", row["username"]);
                        cmd.Parameters.AddWithValue("@pass", row["Password"]);
                        cmd.Parameters.AddWithValue("@name", row["name"]);
                        cmd.Parameters.AddWithValue("@phone", row["phone"]);
                        cmd.Parameters.AddWithValue("@dob", row["dateOfBirth"]);
                        cmd.Parameters.AddWithValue("@sex", row["sex"]);
                        cmd.Parameters.AddWithValue("@role", row["Role"]);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm tài khoản vào Database thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Thêm xong thì tự động dọn dẹp form
                    btnRefresh_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm vào DB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtPhone.Clear();
            dtpDOB.Value = DateTime.Now;
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            cbbRole.SelectedIndex = 0;

            // Xóa lưới Preview
            dtPreview.Rows.Clear();
        }
    }
}
