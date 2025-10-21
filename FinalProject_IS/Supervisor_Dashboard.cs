using FinalProject_IS.DAOs;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_IS
{
    public partial class Supervisor_Dashboard : Form
    {
        private OracleConnection conn;
        public Supervisor_Dashboard()
        {
            InitializeComponent();
        }

        private void Supervisor_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                conn = DataProvider.GetConnection();

                // Audit Logs
                dgvAudit.DataSource = AuditDAO.GetAllData();

                // User Activities
                dgvUserActivities.DataSource = AuditDAO.GetAllData();
                // --- Load Username ComboBox ---
                List<string> users = AuditDAO.GetListUser("SELECT DISTINCT(DB_USER) FROM DBA_FGA_AUDIT_TRAIL");

                // Thêm "ALL" ở đầu danh sách
                users.Insert(0, "ALL");

                cbUsername.DataSource = users;
                cbUsername.SelectedIndex = 0;


                // --- Load Table ComboBox ---
                List<string> tables = AuditDAO.GetListTablesAudited("SELECT DISTINCT(OBJECT_NAME) FROM DBA_AUDIT_POLICIES");

                tables.Insert(0, "ALL");

                cbAuditTable.DataSource = tables;
                cbAuditTable.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            string query = @"
    SELECT DB_USER, OBJECT_NAME, SQL_TEXT, STATEMENT_TYPE, TIMESTAMP
    FROM DBA_FGA_AUDIT_TRAIL
    WHERE 1=1
";

            string user_keyword = txtFindUser.Text.Trim();
            string table_keyword = cbAuditTable.Text.Trim();
            string usercb_keyword = cbUsername.Text.Trim();
            string action_keyword = cbActionType.Text.Trim();
            string year_keyword = txtYear.Text.Trim();
            string month_keyword = cbMonth.Text.Trim();
            string day_keyword = cbDay.Text.Trim();

            // --- USER / TABLE / ACTION filters ---
            if (!string.IsNullOrEmpty(usercb_keyword) && usercb_keyword != "ALL")
            {
                query += $" AND DB_USER LIKE '%{usercb_keyword}%'";
            }
            else if (!string.IsNullOrEmpty(user_keyword))
            {
                query += $" AND DB_USER LIKE '%{user_keyword}%'";
            }

            if (!string.IsNullOrEmpty(action_keyword) && action_keyword != "ALL")
            {
                query += $" AND STATEMENT_TYPE LIKE '%{action_keyword}%'";
            }

            if (!string.IsNullOrEmpty(table_keyword) && table_keyword != "ALL")
            {
                query += $" AND OBJECT_NAME = '{table_keyword}'";
            }

            // --- DATE filters ---
            if (int.TryParse(year_keyword, out int year))
            {
                query += $" AND EXTRACT(YEAR FROM TIMESTAMP) = {year}";
            }

            if (!string.IsNullOrEmpty(month_keyword) && month_keyword != "ALL" && int.TryParse(month_keyword, out int month))
            {
                query += $" AND EXTRACT(MONTH FROM TIMESTAMP) = {month}";
            }

            if (!string.IsNullOrEmpty(day_keyword) && day_keyword != "ALL" && int.TryParse(day_keyword, out int day))
            {
                query += $" AND EXTRACT(DAY FROM TIMESTAMP) = {day}";
            }


            // --- Execute ---
            DataTable dt = AuditDAO.FilterDataBaseOnQuery(query);
            dgvUserActivities.DataSource = dt;

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtYear.Text, out int year))
            {
                // ----- Fill Month -----
                cbMonth.Items.Clear();
                cbMonth.Items.Add("ALL");  // Thêm dòng đầu tiên
                for (int month = 1; month <= 12; month++)
                {
                    cbMonth.Items.Add(month);
                }

                cbMonth.SelectedIndex = 0;

                cbDay.Items.Clear();
                cbDay.Items.Add("ALL");
                cbDay.SelectedIndex = 0;
            }
            else
            {
                cbMonth.Items.Clear();
                cbDay.Items.Clear();
            }
        }

        private void UpdateDays(int year, int month)
        {
            cbDay.Items.Clear();
            cbDay.Items.Add("ALL"); // Thêm "ALL" đầu tiên

            int daysInMonth = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= daysInMonth; day++)
            {
                cbDay.Items.Add(day);
            }

            cbDay.SelectedIndex = 0;
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMonth.SelectedItem == null || cbMonth.SelectedItem.ToString() == "ALL")
            {
                // Nếu chọn ALL -> chỉ hiện ALL cho ngày
                cbDay.Items.Clear();
                cbDay.Items.Add("ALL");
                cbDay.SelectedIndex = 0;
                return;
            }

            if (int.TryParse(txtYear.Text, out int year))
            {
                int month = Convert.ToInt32(cbMonth.SelectedItem);
                UpdateDays(year, month);
            }
        }
    }
}
