using Microsoft.Data.SqlClient;
using PBL3a.services;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3a.UI.Student
{
    public partial class StudentSchedule : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private readonly string currentID = "";

        public StudentSchedule(string id)
        {
            InitializeComponent();
            this.currentID = id;

            // Đăng ký sự kiện
            this.Load += StudentSchedule_Load;
            btnChange.Click += btnChange_Click;
        }

        private void StudentSchedule_Load(object? sender, EventArgs e)
        {
            SetupDataGridView();
            LoadComboBoxMonth();
            // Tự động hiển thị tháng hiện tại
            btnChange.PerformClick();
        }

        private void SetupDataGridView()
        {
            dgvSchedule.ReadOnly = true;
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Cho phép xuống dòng để hiện tên lớp dưới ngày
            dgvSchedule.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
        }

        private void LoadComboBoxMonth()
        {
            cbbWeekPick.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cbbWeekPick.Items.Add(new MonthItem { Text = $"Tháng {i}", Month = i, Year = 2026 });
            }
            // Chọn tháng hiện tại (mặc định theo simulated date của bạn)
            cbbWeekPick.SelectedIndex = 2; // Tháng 3
        }

        private void DisplayMonthCalendar(int month, int year)
        {
            dgvSchedule.Rows.Clear();
            dgvSchedule.ColumnCount = 7;
            string[] days = { "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ Nhật" };
            for (int i = 0; i < 7; i++) dgvSchedule.Columns[i].Name = days[i];

            DateTime firstDay = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int startCol = ((int)firstDay.DayOfWeek + 6) % 7;

            // Tạo các dòng (tối đa 6 tuần)
            for (int i = 0; i < 6; i++) dgvSchedule.Rows.Add();

            int dayCounter = 1;
            for (int row = 0; row < 6; row++)
            {
                for (int col = (row == 0 ? startCol : 0); col < 7; col++)
                {
                    if (dayCounter <= daysInMonth)
                    {
                        dgvSchedule.Rows[row].Cells[col].Value = dayCounter.ToString();
                        dgvSchedule.Rows[row].Cells[col].Tag = new DateTime(year, month, dayCounter);
                        dayCounter++;
                    }
                }
                dgvSchedule.Rows[row].Height = 100; // Độ cao đủ để hiện text
            }

            FillScheduleToCalendar(month, year);
        }

        private void FillScheduleToCalendar(int month, int year)
        {
            string query = @"
                SELECT c.class_name, cs.dayOfWeek, CAST(cs.startTime AS VARCHAR(5)) as startTime, 
                       c.start_date, c.end_date
                FROM JoinClass jc
                JOIN Class c ON jc.classID = c.classID
                JOIN ClassSchedule cs ON c.classID = cs.classID
                WHERE jc.AccountID = @id";

            try
            {
                using (SqlConnection con = db.GetConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", currentID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string clsName = reader["class_name"].ToString();
                                int dayOfW = Convert.ToInt32(reader["dayOfWeek"]);
                                string time = reader["startTime"].ToString();
                                DateTime start = Convert.ToDateTime(reader["start_date"]);
                                DateTime end = Convert.ToDateTime(reader["end_date"]);

                                UpdateCalendarCells(clsName, dayOfW, time, start, end);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch: " + ex.Message);
            }
        }

        private void UpdateCalendarCells(string name, int dayOfWeek, string time, DateTime start, DateTime end)
        {
            foreach (DataGridViewRow row in dgvSchedule.Rows)
            {
                for (int col = 0; col < 7; col++)
                {
                    var cell = row.Cells[col];
                    if (cell.Tag is DateTime cellDate)
                    {
                        // Chuyển DayOfWeek hệ thống sang hệ 2-8 của bạn
                        int cellDotW = ((int)cellDate.DayOfWeek + 6) % 7 + 2;

                        if (cellDotW == dayOfWeek && cellDate >= start && cellDate <= end)
                        {
                            cell.Value += $"\n● {name} ({time})";
                        }
                    }
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cbbWeekPick.SelectedItem is MonthItem selected)
            {
                DisplayMonthCalendar(selected.Month, selected.Year);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- Classes bổ trợ ---
        public class MonthItem
        {
            public string Text { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
            public override string ToString() => Text;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}