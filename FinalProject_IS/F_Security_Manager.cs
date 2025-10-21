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
    public partial class F_Security_Manager : Form
    {
        private HashSet<string> initialCheckedUsers = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private HashSet<string> usersWithProfile = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private OracleConnection conn;
        private void F_Security_Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 🔹 Đóng connection khi form tắt
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        public F_Security_Manager()
        {
            InitializeComponent();
        }
        private void F_Security_Manager_Load(object sender, EventArgs e)
        {
            lblRoleName.Visible = false;
            try
            {
                 conn = DataProvider.GetConnection();
                string query = @"
                SELECT ROLE, PRIVILEGE
                FROM ROLE_SYS_PRIVS
                WHERE ROLE IN (SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS)";

                using (var cmd = new OracleCommand(query, conn))
                using (var adapter = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_privilege.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách privilege: " + ex.Message);
            }
        }

        private void ManageTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabManager.SelectedTab == tabRole) // tabRole là tab hiển thị danh sách role
            {
                LoadRoles();
            }else if (tabManager.SelectedTab == tabProfile)
            {
                LoadProfiles();
            }else if (tabManager.SelectedTab == tabPrivileges)
            {
                loadPrivilege();
            } else if (tabManager.SelectedTab == tabPoliy)
            {
                pn_listapplypolicy.Visible = false;
                panel_applypolicy.Visible = false;
                loadPolicy();
            }

        }

        #region PRIVILEGE
        private void loadPrivilege()
        {
            try
            {
                 conn = DataProvider.GetConnection();
                string query = @"
                SELECT ROLE, PRIVILEGE
                FROM ROLE_SYS_PRIVS
                WHERE ROLE IN (SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS)";

                using (var cmd = new OracleCommand(query, conn))
                using (var adapter = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_privilege.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách privilege: " + ex.Message);
            }
        }
        #endregion

        #region PROFILE
        private void LoadProfiles()
            {
                try
                {
                    conn = DataProvider.GetConnection();
                    string query = "SELECT PROFILE FROM DBA_PROFILES GROUP BY PROFILE";

                    using (var cmd = new OracleCommand(query, conn))
                    using (var adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvProfiles.DataSource = dt;
                        AddGrantUserButtonColumn();
                        dgvProfiles.Columns["GrantUser"].DisplayIndex = dgvProfiles.Columns.Count - 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách roles: " + ex.Message);
                }
            }
            private void AddGrantUserButtonColumn()
            {
                if (!dgvProfiles.Columns.Contains("GrantUser"))
                {
                    DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "GrantUser";
                    btnCol.HeaderText = "Cấp quyền";
                    btnCol.Text = "Cấp quyền";
                    btnCol.UseColumnTextForButtonValue = true;
                    btnCol.Width = 50;
                    dgvProfiles.Columns.Add(btnCol);

                    btnCol.DisplayIndex = dgvProfiles.Columns.Count - 1;
                }
            }
            private void dgvProfiles_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                    if (dgvProfiles.Columns[e.ColumnIndex].Name == "GrantUser")
                    {
                        string selectedProfile = dgvProfiles.Rows[e.RowIndex].Cells["PROFILE"].Value.ToString();
                        lblProfileName.Text = $"Profile: {selectedProfile}";
                        LoadUsersForProfile(selectedProfile);
                }
            }
        private void LoadUsersForProfile(string profileName)
        {
            clbUserProfile.Items.Clear();
            usersWithProfile.Clear(); // 🔥 reset danh sách cũ để không bị sai dữ liệu

            using (var conn = DataProvider.GetConnection())
            {
                // 1️⃣ Lấy tất cả user đang mở
                string sqlAllUsers = @"SELECT USERNAME FROM DBA_USERS 
                               WHERE ACCOUNT_STATUS='OPEN' 
                               AND USERNAME NOT IN ('SYS','SYSTEM')";
                var allUsers = new List<string>();
                using (var cmd = new OracleCommand(sqlAllUsers, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        allUsers.Add(reader.GetString(0));
                }

                // 2️⃣ Lấy danh sách user đang dùng profile này
                string sqlHasProfile = "SELECT USERNAME FROM DBA_USERS WHERE PROFILE = :profile";

                using (var cmd = new OracleCommand(sqlHasProfile, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("profile", profileName));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            usersWithProfile.Add(reader.GetString(0)); // ✅ cập nhật field toàn cục
                    }
                }

                // 3️⃣ Hiển thị lên CheckedListBox
                foreach (var user in allUsers)
                {
                    int index = clbUserProfile.Items.Add(user);
                    if (usersWithProfile.Contains(user))
                        clbUserProfile.SetItemChecked(index, true);
                }
            }
        }
        private void dgvProfiles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0 || dgvProfiles.Columns[e.ColumnIndex].Name == "GrantButton") return;

                string profileName = dgvProfiles.Rows[e.RowIndex].Cells["PROFILE"].Value.ToString();
                LoadProfileDetails(profileName);

            }
            private void LoadProfileDetails(string profileName)
            {
                try
                {
                    conn = DataProvider.GetConnection();
                    string query = "SELECT RESOURCE_NAME, LIMIT FROM DBA_PROFILES WHERE PROFILE = :p";

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(":p", OracleDbType.Varchar2).Value = profileName;

                        using (var reader = cmd.ExecuteReader())
                        {
                            // Xóa dữ liệu cũ
                            txtProfileName.Text = profileName;
                            cbIdleTime.Text = "";
                            cbSessionsPerUser.Text = "";
                            cbFailedLoginAttempts.Text = "";
                            cbPasswordLifeTime.Text = "";
                            cbPasswordGraceTime.Text = "";
                            cbConnectTime.Text = "";
                            cbPasswordReuseTime.Text = "";
                            cbPasswordReuseMax.Text = "";

                            while (reader.Read())
                            {
                                string resource = reader.GetString(0);
                                string limit = reader.GetString(1);

                                switch (resource)
                                {
                                    case "IDLE_TIME":
                                    cbIdleTime.Text = limit;
                                        break;
                                    case "SESSIONS_PER_USER":
                                        cbSessionsPerUser.Text = limit;
                                        break;
                                    case "FAILED_LOGIN_ATTEMPTS":
                                        cbFailedLoginAttempts.Text = limit;
                                        break;
                                    case "PASSWORD_LIFE_TIME":
                                        cbPasswordLifeTime.Text = limit;
                                        break;
                                    case "PASSWORD_GRACE_TIME":
                                        cbPasswordGraceTime.Text = limit;
                                        break;
                                    case "CONNECT_TIME":
                                        cbConnectTime.Text = limit;
                                        break;
                                    case "PASSWORD_REUSE_TIME":
                                        cbPasswordReuseTime.Text = limit;
                                        break;
                                    case "PASSWORD_REUSE_MAX":
                                        cbPasswordReuseMax.Text = limit;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thông tin Profile: " + ex.Message);
                }
            }
            private void btnUpdateProfile_Click(object sender, EventArgs e)
            {
                string profileName = txtProfileName.Text.Trim();
                if (string.IsNullOrEmpty(profileName))
                {
                    MessageBox.Show("Vui lòng chọn profile để cập nhật!");
                    return;
                }

                try
                {
                    using (OracleConnection conn = DataProvider.GetConnection())
                    {
                        // Ghép câu lệnh ALTER PROFILE
                        string query = $@"
                        ALTER PROFILE {profileName}
                        LIMIT 
                            IDLE_TIME {cbIdleTime.Text}
                            SESSIONS_PER_USER {cbSessionsPerUser.Text}
                            FAILED_LOGIN_ATTEMPTS {cbFailedLoginAttempts.Text}
                            PASSWORD_LIFE_TIME {cbPasswordLifeTime.Text}
                            PASSWORD_GRACE_TIME {cbPasswordGraceTime.Text}
                            CONNECT_TIME {cbConnectTime.Text}
                            PASSWORD_REUSE_TIME {cbPasswordReuseTime.Text}
                            PASSWORD_REUSE_MAX {cbPasswordReuseMax.Text}";

                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật profile thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật profile: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
             private void btnGrantProfile_Click(object sender, EventArgs e)
             {
                string profileName = lblProfileName.Text.Replace("Profile: ", "").Trim();

                var checkedUsers = clbUserProfile.CheckedItems.Cast<string>().ToList();
                if (checkedUsers.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một user để gán profile!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔍 Chỉ gán cho user mới tick (chưa có profile trước đó)
                var newUsers = checkedUsers.Except(usersWithProfile).ToList();
                if (newUsers.Count == 0)
                {
                    MessageBox.Show("Không có user mới nào để gán profile!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int successCount = 0, failCount = 0;

                using (var conn = DataProvider.GetConnection())
                {
                    foreach (var username in newUsers)
                    {
                        string sql = $"BEGIN tin.assign_profile('{username}', '{profileName}'); END;";
                        using (var cmd = new OracleCommand(sql, conn))
                        {
                            try
                            {
                                cmd.ExecuteNonQuery();
                                successCount++;
                            }
                            catch (Exception ex)
                            {
                                failCount++;
                                MessageBox.Show($"❌ Lỗi khi gán profile {profileName} cho {username}:\n{ex.Message}");
                            }
                        }
                    }
                }

                MessageBox.Show(
                    $"Gán profile {profileName} hoàn tất.\n\nThành công: {successCount}\nThất bại: {failCount}",
                    "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                // Cập nhật danh sách user có profile (để lần sau so sánh đúng)
                LoadUsersForProfile(profileName);
                }

            private void btnRevokeProfile_Click(object sender, EventArgs e)
            {
                string profileName = lblProfileName.Text.Replace("Profile: ", "").Trim();
                var checkedUsers = clbUserProfile.CheckedItems.Cast<string>().ToList();

                // 🔍 Chỉ thu hồi cho user đã có profile nhưng bây giờ bị bỏ tick
                var usersToRevoke = usersWithProfile.Except(checkedUsers).ToList();

                if (usersToRevoke.Count == 0)
                {
                    MessageBox.Show("Không có thay đổi nào để thu hồi!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string users = string.Join(", ", usersToRevoke);
                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn thu hồi profile {profileName} khỏi các user sau không?\n{users}",
                    "Xác nhận thu hồi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                int successCount = 0, failCount = 0;
                using (var conn = DataProvider.GetConnection())
                {
                    foreach (var username in usersToRevoke)
                    {
                        string sql = $"BEGIN tin.assign_profile('{username}', 'DEFAULT'); END;";
                        using (var cmd = new OracleCommand(sql, conn))
                            {
                            try
                            {
                                cmd.ExecuteNonQuery();
                                successCount++;
                            }
                            catch (Exception ex)
                            {
                                failCount++;
                                MessageBox.Show($"Lỗi khi thu hồi profile {profileName} từ {username}: {ex.Message}");
                            }
                        }
                    }
                }

                MessageBox.Show(
                    $"Đã thu hồi profile {profileName} hoàn tất.\n\nThành công: {successCount}\nThất bại: {failCount}",
                    "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                LoadUsersForProfile(profileName);
            }
        #endregion

        #region ROLE
        private void LoadRoles()
        {
            try
            {
                conn = DataProvider.GetConnection();
                string query = @"SELECT ROLE, GRANTED_ROLE FROM ROLE_ROLE_PRIVS WHERE ROLE = 'ROLE_SECURITY_MANAGER'";

                using (var cmd = new OracleCommand(query, conn))
                using (var adapter = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRoles.DataSource = dt;
                    AddGrantButtonColumn();
                    dgvRoles.Columns["GrantButton"].DisplayIndex = dgvRoles.Columns.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách roles: " + ex.Message);
            }
        }
       
        private void AddGrantButtonColumn()
        {
            if (!dgvRoles.Columns.Contains("GrantButton"))
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "GrantButton";
                btnCol.HeaderText = "Cấp quyền";
                btnCol.Text = "Cấp quyền";
                btnCol.UseColumnTextForButtonValue = true;
                btnCol.Width = 50;
                dgvRoles.Columns.Add(btnCol);

                btnCol.DisplayIndex = dgvRoles.Columns.Count - 1;
            }
        }

        private void LoadUsersForRole(string roleName)
        {
            clbUserRole.Items.Clear();
            initialCheckedUsers.Clear();

            using (var conn = DataProvider.GetConnection())
            {
                // 1. Lấy tất cả user hiện có
                string sqlAllUsers = @"SELECT USERNAME FROM DBA_USERS WHERE ACCOUNT_STATUS='OPEN' AND USERNAME NOT IN ('SYS','SYSTEM')";
                var allUsers = new List<string>();

                using (var cmd = new OracleCommand(sqlAllUsers, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        allUsers.Add(reader.GetString(0));
                }

                // 2. Lấy danh sách user đã có role này
                string sqlHasRole = "SELECT GRANTEE FROM DBA_ROLE_PRIVS WHERE GRANTED_ROLE = :role";
                var usersWithRole = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                using (var cmd = new OracleCommand(sqlHasRole, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("role", roleName));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            usersWithRole.Add(reader.GetString(0));
                    }
                }

                // 3. Hiển thị lên CheckedListBox và tick nếu user đã có role
                for (int i = 0; i < allUsers.Count; i++)
                {
                    string user = allUsers[i];
                    int index = clbUserRole.Items.Add(user);
                    if (usersWithRole.Contains(user))
                    {
                        clbUserRole.SetItemChecked(index, true);
                        initialCheckedUsers.Add(user); // nhớ user có quyền lúc load
                    }
                }
            }
        }

        private void dgvRoles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvRoles.Columns[e.ColumnIndex].Name == "GrantButton") return;
          

            string selectedRole = dgvRoles.Rows[e.RowIndex].Cells["GRANTED_ROLE"].Value.ToString();


            var form = new F_RoleEditor(selectedRole, conn);
            form.ShowDialog();
        }
        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvRoles.Columns[e.ColumnIndex].Name == "GrantButton")
            {
                string selectedRole = dgvRoles.Rows[e.RowIndex].Cells["GRANTED_ROLE"].Value.ToString();
                lblRoleName.Text = $"Role: {selectedRole}";
                LoadUsersForRole(selectedRole);
            }
        }
        private void btnRevoke_Click(object sender, EventArgs e)
        {

            string roleName = lblRoleName.Text.Replace("Role: ", "").Trim();

            // danh sách hiện tại checked
            var currentlyChecked = clbUserRole.CheckedItems.Cast<string>().ToHashSet(StringComparer.OrdinalIgnoreCase);

            // user trước đó có role nhưng giờ KHÔNG được checked => cần revoke
            var usersToRevoke = initialCheckedUsers.Except(currentlyChecked).ToList();

            if (usersToRevoke.Count == 0)
            {
                MessageBox.Show("Không có user nào bị bỏ tick để thu hồi quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string confirmMsg = $"Bạn có chắc muốn thu hồi role {roleName} khỏi {usersToRevoke.Count} user sau không?\n\n" + string.Join("\n", usersToRevoke);
            if (MessageBox.Show(confirmMsg, "Xác nhận thu hồi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            using (var conn = DataProvider.GetConnection())
            {
                foreach (var username in usersToRevoke)
                {
                    string sql = $"REVOKE {roleName} FROM {username}";
                    using (var cmd = new OracleCommand(sql, conn))
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi thu hồi role {roleName} từ {username}: {ex.Message}");
                        }
                    }
                }
            }

            MessageBox.Show("Đã thu hồi quyền xong.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsersForRole(roleName); // reload và cập nhật initialCheckedUsers
        }

        private void btnGrantRole_Click(object sender, EventArgs e)
        {
            string roleName = lblRoleName.Text.Replace("Role: ", "").Trim();

            // danh sách hiện tại checked
            var currentlyChecked = clbUserRole.CheckedItems.Cast<string>().ToHashSet(StringComparer.OrdinalIgnoreCase);
            // những user cần cấp là hiện tại checked nhưng trước đó chưa có
            var usersToGrant = currentlyChecked.Except(initialCheckedUsers).ToList();

            if (usersToGrant.Count == 0)
            {
                MessageBox.Show("Không có user mới nào được chọn để cấp quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string confirmMsg = $"Bạn có chắc muốn cấp role {roleName} cho {usersToGrant.Count} user sau không?\n\n" + string.Join("\n", usersToGrant);
            if (MessageBox.Show(confirmMsg, "Xác nhận cấp quyền", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            using (var conn = DataProvider.GetConnection())
            {
                foreach (var username in usersToGrant)
                {
                    string sql = $"GRANT {roleName} TO {username}";
                    using (var cmd = new OracleCommand(sql, conn))
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi cấp role {roleName} cho {username}: {ex.Message}");
                        }
                    }
                }
            }

            MessageBox.Show("Đã cấp quyền xong.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsersForRole(roleName); // reload và cập nhật initialCheckedUsers
        }
        #endregion

        #region POLICY
        private void loadPolicy()
            {
                try
                {
                    using (var conn = DataProvider.GetConnection())
                    {
                        string query = @"
                        SELECT DISTINCT 
                            p.GRANTEE,
                            p.OWNER,
                            p.TABLE_NAME AS FUNCTION_NAME,
                            o.OBJECT_TYPE
                        FROM 
                            DBA_TAB_PRIVS p
                            JOIN DBA_OBJECTS o 
                                ON p.TABLE_NAME = o.OBJECT_NAME 
                                AND p.OWNER = o.OWNER
                        WHERE 
                            p.PRIVILEGE = 'EXECUTE'
                            AND p.GRANTEE = 'ROLE_SECURITY_MANAGER'
                            AND o.OBJECT_TYPE = 'FUNCTION'
                        ORDER BY FUNCTION_NAME";

                        using (var cmd = new OracleCommand(query, conn))
                        using (var adapter = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvPolicy.DataSource = dt;

                            // Thêm nút Apply Policy nếu chưa có
                            AddPolicyButtonColumn();
                            DropPolicyButtonColumn();
                            // Đưa cột nút ra cuối
                            dgvPolicy.Columns["ApplyPolicy"].DisplayIndex = dgvPolicy.Columns.Count - 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách policy: " + ex.Message);
                }
             }
            private void AddPolicyButtonColumn()
            {
                if (!dgvPolicy.Columns.Contains("ApplyPolicy"))
                {
                    DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "applypolicy";
                    btnCol.HeaderText = "Apply Policy";
                    btnCol.Text = "Apply Policy";
                    btnCol.UseColumnTextForButtonValue = true;
                    btnCol.Width = 50;
                    dgvPolicy.Columns.Add(btnCol);
                    btnCol.DisplayIndex = dgvPolicy.Columns.Count - 1;
                }
            }
            private void DropPolicyButtonColumn()
            {
                if (!dgvPolicy.Columns.Contains("DropPolicy"))
                {
                    DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "droppolicy";
                    btnCol.HeaderText = "Drop Policy";
                    btnCol.Text = "drop Policy";
                    btnCol.UseColumnTextForButtonValue = true;
                    btnCol.Width = 50;
                    dgvPolicy.Columns.Add(btnCol);

                    btnCol.DisplayIndex = dgvPolicy.Columns.Count - 1;
                }
            }
        private void dgvPolicy_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPolicy.Columns[e.ColumnIndex].Name == "applypolicy") { return; }
            if (e.RowIndex >= 0)
            {
                string owner = dgvPolicy.Rows[e.RowIndex].Cells["OWNER"].Value.ToString();
                string funcName = dgvPolicy.Rows[e.RowIndex].Cells["FUNCTION_NAME"].Value.ToString();

                string query = $@"
                SELECT TEXT 
                FROM ALL_SOURCE 
                WHERE NAME = '{funcName}' 
                    AND OWNER = '{owner}'
                ORDER BY LINE";

                using (var conn = DataProvider.GetConnection())
                using (var cmd = new OracleCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    StringBuilder sb = new StringBuilder();
                    while (reader.Read())
                    {
                        sb.Append(reader["TEXT"].ToString());
                    }

                    MessageBox.Show(sb.ToString(), $"Source code of {funcName}");
                }
            }

        }
        private void btn_applyPolicy_Click(object sender, EventArgs e)
        {
            string secColsClause = "";
                if (!string.IsNullOrEmpty(txtSecCols.Text))
                {
                    secColsClause = $@",
                    sec_relevant_cols => '{txtSecCols.Text}',
                    sec_relevant_cols_opt => DBMS_RLS.ALL_ROWS";
                }

            string sql = $@"
                BEGIN
                  DBMS_RLS.ADD_POLICY(
                    object_schema   => '{cbObjectSchema.Text}',
                    object_name     => '{cbObjectName.Text}',
                    policy_name     => '{txtPolicyName.Text}',
                    function_schema => '{cbFunctionSchema.Text}',
                    policy_function => '{txt_policyFuntion.Text}',
                    statement_types => '{GetStatementTypes()}'
                   {secColsClause}
                  );
                END;";

            using (var conn = DataProvider.GetConnection())
            {
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("✅ Policy applied successfully!");
            panel_applypolicy.Visible = false;
        }
        private string GetStatementTypes()
        {
            List<string> list = new List<string>();
            if (checkBox1.Checked) list.Add("SELECT");
            if (checkBox3.Checked) list.Add("UPDATE");
            if (checkBox2.Checked) list.Add("DELETE");
            return string.Join(",", list);
        }


        private void dgvPolicy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPolicy.Columns[e.ColumnIndex].Name == "applypolicy")
            {
                // Lấy thông tin của dòng được chọn
                string owner = dgvPolicy.Rows[e.RowIndex].Cells["OWNER"].Value.ToString();
                string funcName = dgvPolicy.Rows[e.RowIndex].Cells["FUNCTION_NAME"].Value.ToString();

                // Gán vào các control trong panel
                txt_policyFuntion.Text = funcName;

                // Hiện panel lên
                panel_applypolicy.Visible = true;
                panel_applypolicy.BringToFront();
            }
            else if (dgvPolicy.Columns[e.ColumnIndex].Name == "droppolicy")
            {
                pn_listapplypolicy.Visible = true;
                pn_listapplypolicy.BringToFront();
                string funcName = dgvPolicy.Rows[e.RowIndex].Cells["FUNCTION_NAME"].Value.ToString();
                LoadAppliedPolicies(funcName);
            }
        }
        private void LoadAppliedPolicies(string functionName)
        {
            try
            {
                conn = DataProvider.GetConnection();
                string query = $@"
                SELECT 
                    OBJECT_OWNER,
                    OBJECT_NAME,
                    POLICY_NAME,
                    PF_OWNER,
                    FUNCTION
                FROM DBA_POLICIES
                WHERE FUNCTION= '{functionName}'";

                using (var cmd = new OracleCommand(query, conn))
                using (var adapter = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAppliedPolicies.DataSource = dt;
                    dgvAppliedPolicies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AddDeleteButtonColumn(); // thêm nút “Xóa policy”
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách chính sách đã áp dụng: " + ex.Message);
            }
        }

        private void AddDeleteButtonColumn()
        {
            if (!dgvAppliedPolicies.Columns.Contains("dropPolicyForUser"))
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "dropPolicyForUser";
                btnCol.HeaderText = "Drop Policy";
                btnCol.Text = "Drop Policy";
                btnCol.UseColumnTextForButtonValue = true;
                btnCol.Width = 50;
                dgvAppliedPolicies.Dock = DockStyle.Fill;
                dgvAppliedPolicies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAppliedPolicies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvAppliedPolicies.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvAppliedPolicies.AllowUserToResizeColumns = false;
                dgvAppliedPolicies.Columns.Add(btnCol);

                btnCol.DisplayIndex = dgvAppliedPolicies.Columns.Count - 1;
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            pn_listapplypolicy.Visible = false;
        }

        private void btn_hide_policy_Click(object sender, EventArgs e)
        {
            panel_applypolicy.Visible = false;
        }
        private void dgvAppliedPolicies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAppliedPolicies.Columns[e.ColumnIndex].Name == "dropPolicyForUser")
            {
                string schema = dgvAppliedPolicies.Rows[e.RowIndex].Cells["OBJECT_OWNER"].Value.ToString();
                string table = dgvAppliedPolicies.Rows[e.RowIndex].Cells["OBJECT_NAME"].Value.ToString();
                string policy = dgvAppliedPolicies.Rows[e.RowIndex].Cells["POLICY_NAME"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa policy '{policy}' khỏi bảng '{table}' không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var conn = DataProvider.GetConnection())
                        {
                            string sql = $@"
                    BEGIN
                        DBMS_RLS.DROP_POLICY(
                            object_schema => '{schema}',
                            object_name   => '{table}',
                            policy_name   => '{policy}'
                        );
                    END;";

                            using (var cmd = new OracleCommand(sql, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Đã xóa policy thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAppliedPolicies(dgvPolicy.Rows[e.RowIndex].Cells["FUNCTION_NAME"].Value.ToString()); // load lại danh sách
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa policy: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        #endregion

      
    }
}
