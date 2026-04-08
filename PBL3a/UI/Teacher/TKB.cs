using Microsoft.Data.SqlClient;
using PBL3a.services;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3a.UI.Teacher
{
    public partial class TKB : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private string currentTeacherID;

        public TKB(string teacherId)
        {
            InitializeComponent();
            currentTeacherID = teacherId;

            this.Load += TKB_Load;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void TKB_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentTeacherID))
            {
                MessageBox.Show("Không tìm thấy mã giảng viên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadClassList();
            FormatDataGridView();
        }

        private void LoadClassList()
        {
            string query = @"
                SELECT classID, class_name
                FROM Class
                WHERE teacherID = @TeacherID
                ORDER BY classID";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TeacherID", currentTeacherID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                comboBox1.DataSource = null;
                                textBox1.Clear();
                                dataGridView1.DataSource = null;

                                MessageBox.Show("Giảng viên này chưa được phân công lớp nào.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            comboBox1.DataSource = dt;
                            comboBox1.DisplayMember = "classID";
                            comboBox1.ValueMember = "classID";

                            if (comboBox1.SelectedItem != null)
                            {
                                DataRowView row = (DataRowView)comboBox1.SelectedItem;
                                textBox1.Text = row["class_name"].ToString();
                                LoadScheduleByClass(comboBox1.SelectedValue.ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is DataRowView row)
            {
                textBox1.Text = row["class_name"].ToString();

                if (comboBox1.SelectedValue != null)
                {
                    LoadScheduleByClass(comboBox1.SelectedValue.ToString());
                }
            }
        }

        private void LoadScheduleByClass(string classID)
        {
            string query = @"
                SELECT
                    CASE dayOfWeek
                        WHEN 1 THEN N'Thứ 2'
                        WHEN 2 THEN N'Thứ 3'
                        WHEN 3 THEN N'Thứ 4'
                        WHEN 4 THEN N'Thứ 5'
                        WHEN 5 THEN N'Thứ 6'
                        WHEN 6 THEN N'Thứ 7'
                        WHEN 7 THEN N'Chủ nhật'
                    END AS [Ngày học],
                    CONVERT(VARCHAR(5), startTime, 108) AS [Giờ bắt đầu],
                    CONVERT(VARCHAR(5), endTime, 108) AS [Giờ kết thúc]
                FROM ClassSchedule
                WHERE classID = @ClassID
                ORDER BY dayOfWeek, startTime";

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClassID", classID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thời khóa biểu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
        }
    }
}