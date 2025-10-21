using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_IS.DAOs;
using Oracle.ManagedDataAccess.Client;

namespace FinalProject_IS
{
    public partial class FUserDetail : Form
    {
        public FUserDetail()
        {
            InitializeComponent();
        }

        private string username;

        public FUserDetail(string username, string currentRole)
        {
            InitializeComponent();
            this.username = username;
            LoadUserDetail(currentRole);
        }

        private void LoadUserDetail(string currentRole)
        {
            try
            {
                using (var conn = DataProvider.GetConnection())
                {
                    // Thông tin cơ bản từ DBA_USERS
                    string queryUser = @"
                    SELECT 
                        USERNAME,
                        ACCOUNT_STATUS,
                        LOCK_DATE,
                        CREATED AS CREATED_DATE,
                        DEFAULT_TABLESPACE,
                        TEMPORARY_TABLESPACE,
                        PROFILE
                    FROM DBA_USERS
                    WHERE USERNAME = :username";

                    OracleCommand cmd = new OracleCommand(queryUser, conn);
                    cmd.Parameters.Add(":username", username);
                    OracleDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtUsernameDetail.Text = reader["USERNAME"].ToString();
                        textBox2.Text = reader["ACCOUNT_STATUS"].ToString(); // Account status
                        textBox1.Text = reader["LOCK_DATE"] == DBNull.Value ? "" : Convert.ToDateTime(reader["LOCK_DATE"]).ToString("dd/MM/yyyy");
                        textBox4.Text = reader["CREATED_DATE"] == DBNull.Value ? "" : Convert.ToDateTime(reader["CREATED_DATE"]).ToString("dd/MM/yyyy");
                        textBox5.Text = reader["DEFAULT_TABLESPACE"].ToString();
                        textBox3.Text = reader["TEMPORARY_TABLESPACE"].ToString();
                    }

                    reader.Close();

                    // Lấy quota (từ DBA_TS_QUOTAS)
                    string queryQuota = @"
                    SELECT 
                        TABLESPACE_NAME,
                        CASE
                            WHEN BYTES IS NULL THEN 'UNLIMITED'
                            ELSE TO_CHAR(ROUND(BYTES/1024/1024, 2))
                        END AS QUOTA_MB
                    FROM DBA_TS_QUOTAS
                    WHERE USERNAME = :username";

                    using (var daQuota = new OracleDataAdapter(queryQuota, conn))
                    {
                        daQuota.SelectCommand.Parameters.Add(":username", username);
                        DataTable dtQuota = new DataTable();
                        daQuota.Fill(dtQuota);

                        if (dtQuota.Rows.Count > 0)
                            txtQuota.Text = $"{dtQuota.Rows[0]["TABLESPACE_NAME"]} - {dtQuota.Rows[0]["QUOTA_MB"]} MB";
                        else
                            txtQuota.Text = "UNLIMITED";
                    }

                    // 3️⃣ Hiển thị các role được cấp cho user
                    string queryRoles = @"
                    SELECT GRANTED_ROLE, ADMIN_OPTION
                    FROM DBA_ROLE_PRIVS
                    WHERE GRANTEE = :username";

                    using (var daRole = new OracleDataAdapter(queryRoles, conn))
                    {
                        daRole.SelectCommand.Parameters.Add(":username", username);
                        DataTable dtRoles = new DataTable();
                        daRole.Fill(dtRoles);
                        dgvUserRole.DataSource = dtRoles;
                    }

                    // 4️⃣ Hiển thị các privilege
                    string queryPrivs;

                    if (currentRole == "SYSTEM_MANAGER") 
                    {
                        queryPrivs = @"
                            SELECT PRIVILEGE, ADMIN_OPTION, 'SYSTEM' AS TYPE
                            FROM DBA_SYS_PRIVS WHERE GRANTEE = :username
                            UNION ALL
                            SELECT PRIVILEGE, GRANTABLE AS ADMIN_OPTION, 'OBJECT' AS TYPE
                            FROM DBA_TAB_PRIVS WHERE GRANTEE = :username";
                    }
                    else
                    {
                        queryPrivs = @"
                            SELECT PRIVILEGE, ADMIN_OPTION, 'SYSTEM' AS TYPE FROM USER_SYS_PRIVS
                            UNION ALL
                            SELECT PRIVILEGE, GRANTABLE AS ADMIN_OPTION, 'OBJECT' AS TYPE FROM USER_TAB_PRIVS";
                    }

                    using (var daPrivs = new OracleDataAdapter(queryPrivs, conn))
                    {
                        daPrivs.SelectCommand.Parameters.Add(":username", username);
                        DataTable dtPrivs = new DataTable();
                        daPrivs.Fill(dtPrivs);
                        dgvPrivileges.DataSource = dtPrivs;
                    }

                    // Thông tin Profile 
                    string queryProfile = @"
                    SELECT PROFILE, RESOURCE_NAME, LIMIT
                    FROM DBA_PROFILES
                    WHERE PROFILE = (SELECT PROFILE FROM DBA_USERS WHERE USERNAME = :username)
                    ORDER BY RESOURCE_NAME";

                    using (var daProfile = new OracleDataAdapter(queryProfile, conn))
                    {
                        daProfile.SelectCommand.Parameters.Add(":username", username);
                        DataTable dtProfile = new DataTable();
                        daProfile.Fill(dtProfile);
                        dgvUserProfile.DataSource = dtProfile;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin user: " + ex.Message);
            }
        }
    }
}
