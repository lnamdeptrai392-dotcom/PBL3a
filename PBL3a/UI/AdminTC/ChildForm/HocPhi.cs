using Microsoft.Data.SqlClient;
using PBL3a.services;
using PBL3a.services.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBL3a.UI.AdminTC
{
    public partial class HocPhi : Form
    {
        private DataTable dtHocPhi = new DataTable();
        private AdminTC_Service admin_sv = new AdminTC_Service();

        public HocPhi()
        {
            InitializeComponent();
            Load += HocPhi_Load;
            cbbML.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void HocPhi_Load(object? sender, EventArgs e)
        {
            LoadDanhSachLop(cbbML.Text);
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadDanhSachLop(string text)
        {
            cbbML.Items.Clear();
            List<string> dslop = admin_sv.GetClassIDsByKeyword(text);
            if (dslop.Count > 0)
            {
                cbbML.Items.AddRange(dslop.ToArray());
                cbbML.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbbML.SelectedItem == null) return;
            else
            {
                string classID = cbbML.SelectedItem.ToString();
                LoadTenLop(classID);
                LoadHocPhiTheoLop(classID);
            }
        }

        private void LoadTenLop(string classID)
        {
            tbTL.Text = admin_sv.GetClassNameByID(classID);
        }

        private void LoadHocPhiTheoLop(string classID)
        {
            DataTable dtHocPhi = admin_sv.GetTuitionByClass(classID);
            dataGridView1.DataSource = dtHocPhi;

            if (dataGridView1.Columns["HocPhiID"] != null)
                dataGridView1.Columns["HocPhiID"].ReadOnly = true;

            if (dataGridView1.Columns["Mã HS"] != null)
                dataGridView1.Columns["Mã HS"].ReadOnly = true;

            if (dataGridView1.Columns["Tên học sinh"] != null)
                dataGridView1.Columns["Tên học sinh"].ReadOnly = true;

            if (dataGridView1.Columns["Tháng"] != null)
                dataGridView1.Columns["Tháng"].ReadOnly = true;

            if (dataGridView1.Columns["Năm"] != null)
                dataGridView1.Columns["Năm"].ReadOnly = true;
        }

        private void btSetHP_Click(object sender, EventArgs e)
        {
            string malop = cbbML.Text;
            ThietLapHP thietLap = new ThietLapHP(malop);
            this.Hide();
            thietLap.ShowDialog();
            this.Show();
            LoadHocPhiTheoLop(malop);
        }

        private void btSetHP_MouseEnter(object sender, EventArgs e)
        {
            but_chform.bt_MouseEnter(sender, e);
        }

        private void btSetHP_MouseLeave(object sender, EventArgs e)
        {
            but_chform.bt_MouseLeave(sender, e);
        }

        private void cbbML_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                string keyword = cbbML.Text;
                int cursorPosition = cbbML.SelectionStart;
                cbbML.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
                LoadDanhSachLop(keyword);

                cbbML.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

                cbbML.Text = keyword;
                cbbML.SelectionStart = cursorPosition;

                if (cbbML.Items.Count > 0 && !string.IsNullOrWhiteSpace(keyword))
                {
                    cbbML.DroppedDown = true;
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    cbbML.DroppedDown = false;
                }
            }
            catch (Exception)
            {
                cbbML.DroppedDown = false;
            }
        }
    }
}