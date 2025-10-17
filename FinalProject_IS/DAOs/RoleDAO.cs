using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace FinalProject_IS.DAOs
{
    public class RoleDAO
    {
        // Lấy danh sách role
        public static DataTable GetAllRoles()
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = new OracleCommand(@"SELECT ROLE, ROLE_ID, PASSWORD_REQUIRED
                                               FROM DBA_ROLES
                                               ORDER BY ROLE", conn))
            using (var adapter = new OracleDataAdapter(cmd))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Tạo role
        public static bool CreateRole(string roleName, string password = null)
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                // Nếu có mật khẩu => IDENTIFIED BY
                if (!string.IsNullOrEmpty(password))
                    cmd.CommandText = $"CREATE ROLE {roleName} IDENTIFIED BY \"{password}\"";
                else
                    cmd.CommandText = $"CREATE ROLE {roleName}";

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo role thành công!");
                    return true;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi tạo role: " + ex.Message);
                    return false;
                }
            }
        }

        // Xóa role
        public static bool DropRole(string roleName)
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = $"DROP ROLE {roleName}";
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi xóa role: " + ex.Message);
                    return false;
                }
            }
        }

        // Cấp quyền cho role
        public static bool GrantPrivilegeToRole(string roleName, string privilege)
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = $"GRANT {privilege} TO {roleName}";
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi cấp quyền: " + ex.Message);
                    return false;
                }
            }
        }

        // Gán role cho user
        public static bool GrantRoleToUser(string username, string roleName)
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    // Dùng dấu ngoặc kép cho tên user và role để tránh lỗi nếu tên có ký tự đặc biệt hoặc viết thường
                    cmd.CommandText = $"GRANT \"{roleName}\" TO \"{username}\"";
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Lỗi gán role '{roleName}' cho user '{username}':\n{ex.Message}",
                                    "Grant Role Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Thu hồi role khỏi user
        public static bool RevokeRoleFromUser(string username, string roleName)
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = $"REVOKE \"{roleName}\" FROM  \"{username}\"";
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Lỗi thu hồi role '{roleName}' với user '{username}':\n{ex.Message}",
                                    "Grant Role Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public static DataTable SearchRoles(string keyword)
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT ROLE, AUTHENTICATION_TYPE, COMMON
            FROM DBA_ROLES
            WHERE UPPER(ROLE) LIKE :keyword
            ORDER BY ROLE";
                cmd.Parameters.Add(new OracleParameter("keyword", $"%{keyword.ToUpper()}%"));

                using (var adapter = new OracleDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
