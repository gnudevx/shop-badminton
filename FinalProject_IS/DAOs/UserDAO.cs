using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace FinalProject_IS.DAOs
{
    public class UserDAO
    {
        // Lấy danh sách user trong hệ thống
        public static DataTable GetAllUsers(string currentRole, string currentUsername)
        {
            using (var conn = DataProvider.GetConnection())
            {
                string query = @"
                SELECT 
                    USERNAME,
                    ACCOUNT_STATUS,
                    LOCK_DATE,
                    CREATED AS CREATED_DATE,
                    DEFAULT_TABLESPACE,
                    TEMPORARY_TABLESPACE,
                    PROFILE
                FROM DBA_USERS
                /**WHERE_CLAUSE**/
                ORDER BY USERNAME";

                // ✅ Nếu user có role ROLE_SYSTEM_MANAGER → xem được tất cả
                if (currentRole.Equals("ROLE_SYSTEM_MANAGER", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Replace("/**WHERE_CLAUSE**/", "");
                }
                else
                {
                    // ✅ Các user thường chỉ xem được thông tin của chính họ
                    query = query.Replace("/**WHERE_CLAUSE**/", "WHERE u.USERNAME = :currentUser");
                }

                using (var cmd = new OracleCommand(query, conn))
                {
                    if (!currentRole.Equals("ROLE_SYSTEM_MANAGER", StringComparison.OrdinalIgnoreCase))
                    {
                        cmd.Parameters.Add(new OracleParameter(":currentUser", currentUsername.ToUpper()));
                    }

                    using (var adapter = new OracleDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }



        public static List<string> GetListUser(string query)
        {
            var list = new List<string>();
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = query;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(reader.GetString(0));
                }
            }
            return list;
        }

        // Tạo user mới
        public static bool CreateUser(
    string username,
    string password,
    string defaultTS,
    string tempTS,
    string quota,
    string profile,
    string status,
    List<string> roles)
        {
            string quotaValue = quota.ToUpper().Contains("M") || quota.ToUpper() == "UNLIMITED"
                                ? quota.ToUpper()
                                : quota + "M";

            using (var conn = DataProvider.GetConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    var transaction = conn.BeginTransaction();
                    cmd.Transaction = transaction;

                    try
                    {
                        // 1️⃣ Tạo user
                        cmd.CommandText = $@"
                        CREATE USER {username}
                        IDENTIFIED BY {password}
                        DEFAULT TABLESPACE {defaultTS}
                        TEMPORARY TABLESPACE {tempTS}
                        QUOTA {quotaValue} ON {defaultTS}
                        PROFILE {profile}
                        ACCOUNT {status}";
                            cmd.ExecuteNonQuery();

                        // 2️⃣ Gán role (nếu có)
                        if (roles != null && roles.Count > 0)
                        {
                            foreach (var role in roles)
                            {
                                cmd.CommandText = $"GRANT {role} TO {username}";
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Tạo user và gán role thành công!");
                        return true;
                    }
                    catch (OracleException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi tạo user hoặc gán role: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public static bool AlterUser(
            string username,
            string password,
            string defaultTS,
            string tempTS,
            string quota,
            string profile,
            string status,
            List<string> selectedRoles)
        {
            using (var conn = DataProvider.GetConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    var transaction = conn.BeginTransaction();
                    cmd.Transaction = transaction;

                    try
                    {
                        // ALTER USER cơ bản ===
                        var sb = new System.Text.StringBuilder();
                        sb.Append($"ALTER USER {username} ");

                        if (!string.IsNullOrEmpty(password))
                            sb.Append($"IDENTIFIED BY \"{password}\" ");
                        if (!string.IsNullOrEmpty(defaultTS))
                            sb.Append($"DEFAULT TABLESPACE {defaultTS} ");
                        if (!string.IsNullOrEmpty(tempTS))
                            sb.Append($"TEMPORARY TABLESPACE {tempTS} ");
                        if (!string.IsNullOrEmpty(quota))
                        {
                            string quotaValue = quota.ToUpper().Contains("M") || quota.ToUpper() == "UNLIMITED"
                                                ? quota.ToUpper()
                                                : quota + "M";
                            sb.Append($"QUOTA {quotaValue} ON {defaultTS} ");
                        }
                        if (!string.IsNullOrEmpty(profile))
                            sb.Append($"PROFILE {profile} ");
                        if (!string.IsNullOrEmpty(status))
                            sb.Append($"ACCOUNT {status}");

                        string alterSql = sb.ToString().Trim();
                        if (!alterSql.Equals($"ALTER USER {username}", StringComparison.OrdinalIgnoreCase))
                        {
                            cmd.CommandText = alterSql;
                            cmd.ExecuteNonQuery();
                        }

                        // Cập nhật roles ===
                        if (selectedRoles != null)
                        {
                            // Lấy role hiện tại
                            cmd.CommandText = "SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = :username";
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                            List<string> currentRoles = new List<string>();
                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                    currentRoles.Add(reader.GetString(0));
                            }

                            // Roles cần thêm
                            var toAdd = selectedRoles.Except(currentRoles).ToList();
                            // Roles cần xóa
                            var toRemove = currentRoles.Except(selectedRoles).ToList();

                            // Thêm mới
                            foreach (var role in toAdd)
                            {
                                cmd.CommandText = $"GRANT {role} TO {username}";
                                cmd.Parameters.Clear();
                                cmd.ExecuteNonQuery();
                            }

                            // Xóa role không còn chọn
                            foreach (var role in toRemove)
                            {
                                cmd.CommandText = $"REVOKE {role} FROM {username}";
                                cmd.Parameters.Clear();
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Cập nhật user và role thành công!");
                        return true;
                    }
                    catch (OracleException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi cập nhật user hoặc role: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Xóa user
        public static bool DropUser(string username)
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = $"DROP USER {username} CASCADE";
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Đã xoá user: {username}");
                    return true;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi xóa user: " + ex.Message);
                    return false;
                }
            }
        }

        public static List<string> GetUserRoles(string username)
        {
            var roles = new List<string>();

            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                try
                {
                    cmd.CommandText = @"
                SELECT GRANTED_ROLE 
                FROM DBA_ROLE_PRIVS 
                WHERE GRANTEE = :username";

                    cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username.ToUpper();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(reader.GetString(0));
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi khi lấy danh sách role của user: " + ex.Message);
                }
            }

            return roles;
        }
        public static DataTable SearchUsers(string keyword)
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT USERNAME, ACCOUNT_STATUS, PROFILE, DEFAULT_TABLESPACE, TEMPORARY_TABLESPACE
            FROM DBA_USERS
            WHERE UPPER(USERNAME) LIKE :keyword
            ORDER BY USERNAME";
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
