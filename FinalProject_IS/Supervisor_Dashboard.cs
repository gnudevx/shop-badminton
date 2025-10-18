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
                cbUsername.DataSource = AuditDAO.GetListUser("SELECT DISTINCT(DB_USER) FROM DBA_FGA_AUDIT_TRAIL");
                cbAuditTable.DataSource = AuditDAO.GetListTablesAudited("SELECT DISTINCT(OBJECT_NAME) FROM DBA_AUDIT_POLICIES");


                //dgvUsers.CellClick += dgvUsers_CellClick;
                //dgvRoles.CellClick += dgvRoles_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            string query = "SELECT DB_USER, OBJECT_NAME, SQL_TEXT, TIMESTAMP FROM DBA_FGA_AUDIT_TRAIL where ";
            string user_keyword = txtFindUser.Text.Trim();
            string table_keyword = cbAuditTable.Text.Trim();
            string usercb_keyword = cbUsername.Text.Trim();
            string action_keyword = cbActionType.Text.Trim();
            
            if (String.IsNullOrEmpty(user_keyword) && !String.IsNullOrEmpty(usercb_keyword))
            {
                query = query + " DB_USER like '%" + usercb_keyword + "%' and STATEMENT_TYPE like'%" + action_keyword +"%' and OBJECT_NAME='" + table_keyword + "'";
            }
            else if (!String.IsNullOrEmpty(user_keyword))
            {
                query = query + " DB_USER like '%" + user_keyword + "%' and STATEMENT_TYPE like'%" + action_keyword + "%' and OBJECT_NAME='" + table_keyword + "'";
            }
            MessageBox.Show(query);
            

            DataTable dt = AuditDAO.FilterDataBaseOnQuery(query);
            dgvUserActivities.DataSource = dt;
        }
    }
}
