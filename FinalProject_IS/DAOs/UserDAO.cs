using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProject_IS.DAOs
{
    public class UserDAO
    {
        // Lấy danh sách user trong hệ thống
        public static DataTable GetAllUsers()
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = new OracleCommand(@"SELECT 
                                                    USERNAME, 
                                                    ACCOUNT_STATUS, 
                                                    DEFAULT_TABLESPACE, 
                                                    TEMPORARY_TABLESPACE,
                                                    PROFILE,
                                                    CREATED
                                                FROM DBA_USERS
                                                ORDER BY USERNAME", conn))
            using (var adapter = new OracleDataAdapter(cmd))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Tạo user mới
        public static bool CreateUser(
            string username,
            string password,
            string defaultTS,
            string tempTS,
            string quota,
            string profile,
            string status)
        {
            string quotaValue = quota.ToUpper().Contains("M") || quota.ToUpper() == "UNLIMITED"
                                ? quota.ToUpper()
                                : quota + "M";

            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                // Tạo câu lệnh CREATE USER đầy đủ
                cmd.CommandText = $@"
                    CREATE USER {username}
                    IDENTIFIED BY {password}
                    DEFAULT TABLESPACE {defaultTS}
                    TEMPORARY TABLESPACE {tempTS}
                    QUOTA {quotaValue} ON {defaultTS}
                    PROFILE {profile}
                    ACCOUNT {status}";

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo user thành công!");
                    return true;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi tạo user: " + ex.Message);
                    return false;
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
            string status)
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                // Xây dựng từng phần động để tránh null
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

                cmd.CommandText = sb.ToString().Trim();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật user thành công!");
                    return true;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi cập nhật user: " + ex.Message);
                    return false;
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
        
    }
}
