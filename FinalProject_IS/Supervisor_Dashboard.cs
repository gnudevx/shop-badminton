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
                // Third Tab
                cb_audit_table.DataSource = AuditDAO.GetListTablesAudited("SELECT table_name FROM user_tables ORDER BY table_name");
                cb_audit_table.SelectedIndex = 0;


                string firstTableName = cb_audit_table.SelectedValue?.ToString();

                // Use the retrieved table name to filter the data source for the grid view
                if (!string.IsNullOrEmpty(firstTableName))
                {
                    string query = "SELECT * FROM vuong." + firstTableName;

                    dtgv_changeAudit.DataSource = AuditDAO.FilterDataBaseOnQuery(query);

                }



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
        /// Third TAB
       
        private void txt_Year_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_year.Text, out int year))
            {
                // ----- Fill Month -----
                cb_month.Items.Clear();
                cb_month.Items.Add("ALL");  // Thêm dòng đầu tiên
                for (int month = 1; month <= 12; month++)
                {
                    cb_month.Items.Add(month);
                }

                cb_month.SelectedIndex = 0;

                cb_day.Items.Clear();
                cb_day.Items.Add("ALL");
                cb_day.SelectedIndex = 0;
            }
            else
            {
                cb_month.Items.Clear();
                cb_day.Items.Clear();
            }
        }
        private void Update_Days(int year, int month)
        {
            cb_day.Items.Clear();
            cb_day.Items.Add("ALL"); // Thêm "ALL" đầu tiên

            int daysInMonth = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= daysInMonth; day++)
            {
                cb_day.Items.Add(day);
            }

            cb_day.SelectedIndex = 0;
        }
        private void cb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMonth.SelectedItem == null || cbMonth.SelectedItem.ToString() == "ALL")
            {
                // Nếu chọn ALL -> chỉ hiện ALL cho ngày
                cb_day.Items.Clear();
                cb_day.Items.Add("ALL");
                cb_day.SelectedIndex = 0;
                return;
            }

            if (int.TryParse(txtYear.Text, out int year))
            {
                int month = Convert.ToInt32(cb_month.SelectedItem);
                Update_Days(year, month);
            }
        }

        private void cb_audit_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgv_changeAudit.DataSource = null;

            string selected_table = cb_audit_table.Text;

            string query = "SELECT * FROM vuong." + selected_table;

            dtgv_changeAudit.DataSource = AuditDAO.FilterDataBaseOnQuery(query);
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            // 1. Retrieve all input values
            string search_username = txt_username.Text.Trim(); // Trim whitespace
            string action_type = cb_actions.Text.Trim();
            string day = cb_day.Text.Trim();
            string month = cb_month.Text.Trim();
            string year = txt_year.Text.Trim();
            string current_table = cb_audit_table.Text;

            // Start the base query, specifying the schema (vuong)
            // Using 1=1 allows easy, safe appending of 'AND' clauses
            string sqlQuery = $"SELECT * FROM vuong.{current_table} WHERE 1=1";

            // 2. Add Username Filter (Partial, Case-Insensitive)
            if (!string.IsNullOrEmpty(search_username))
            {
                // Use Oracle's UPPER and LIKE for case-insensitive partial matching
                sqlQuery += $" AND UPPER(USER_NAME) LIKE UPPER('%{search_username}%')";
            }

            // 3. Add Action Type Filter (Exact Match)
            // The check `action_type != "All"` handles the requirement for the "All" option.
            if (!string.IsNullOrEmpty(action_type) && action_type != "ALL")
            {
                // Ensure the comparison value is uppercase, matching data stored in the audit table (INSERT, UPDATE, DELETE)
                sqlQuery += $" AND ACTION_TYPE = '{action_type.ToUpper()}'";
            }

            // 4. Add Date Filter Components (Year, Month, Day)
            // The individual checks handle cases where one or more date fields are left empty.

            // Filter by Year
            if (!string.IsNullOrEmpty(year))
            {
                // Use TO_CHAR to compare the year part of the ACTION_DATE column
                sqlQuery += $" AND TO_CHAR(ACTION_DATE, 'YYYY') = '{year}'";
            }

            // Filter by Month
            if (!string.IsNullOrEmpty(month) && month != "ALL")
            {
                // Pad month with a leading zero if needed (e.g., '1' becomes '01')
                string paddedMonth = month.PadLeft(2, '0');
                sqlQuery += $" AND TO_CHAR(ACTION_DATE, 'MM') = '{paddedMonth}'";
            }

            // Filter by Day
            if (!string.IsNullOrEmpty(day) && day!= "ALL")
            {
                // Pad day with a leading zero if needed (e.g., '5' becomes '05')
                string paddedDay = day.PadLeft(2, '0');
                sqlQuery += $" AND TO_CHAR(ACTION_DATE, 'DD') = '{paddedDay}'";
            }
            // 5. Execute the final query
            dtgv_changeAudit.DataSource = AuditDAO.FilterDataBaseOnQuery(sqlQuery);
        }
    }
}
