using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace FinalProject_IS.DAOs
{
    public class ProfileDAO
    {
        // Lấy danh sách profile
        public static DataTable GetAllProfiles()
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = new OracleCommand(@"
                    SELECT PROFILE,
                        MAX(CASE WHEN RESOURCE_NAME='SESSIONS_PER_USER' THEN LIMIT END) AS SESSIONS_PER_USER,
                        MAX(CASE WHEN RESOURCE_NAME='CONNECT_TIME' THEN LIMIT END) AS CONNECT_TIME,
                        MAX(CASE WHEN RESOURCE_NAME='IDLE_TIME' THEN LIMIT END) AS IDLE_TIME,
                        MAX(CASE WHEN RESOURCE_NAME='PASSWORD_LIFE_TIME' THEN LIMIT END) AS PASSWORD_LIFE_TIME,
                        MAX(CASE WHEN RESOURCE_NAME='PASSWORD_GRACE_TIME' THEN LIMIT END) AS PASSWORD_GRACE_TIME,
                        MAX(CASE WHEN RESOURCE_NAME='PASSWORD_REUSE_TIME' THEN LIMIT END) AS PASSWORD_REUSE_TIME,
                        MAX(CASE WHEN RESOURCE_NAME='PASSWORD_REUSE_MAX' THEN LIMIT END) AS PASSWORD_REUSE_MAX,
                        MAX(CASE WHEN RESOURCE_NAME='FAILED_LOGIN_ATTEMPTS' THEN LIMIT END) AS FAILED_LOGIN_ATTEMPTS
                    FROM DBA_PROFILES
                    GROUP BY PROFILE
                    ORDER BY PROFILE", conn))
            using (var adapter = new OracleDataAdapter(cmd))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Tạo profile mới
        public static bool CreateProfile(string name,
        string sess, string connect, string idle,
        string passLife, string passGrace, string passReuseTime,
        string passReuseMax, string failed)
        {
            using (var conn = DataProvider.GetConnection())
            {
                string sql = $@"
                CREATE PROFILE {name} LIMIT
                    SESSIONS_PER_USER {sess}
                    CONNECT_TIME {connect}
                    IDLE_TIME {idle}
                    PASSWORD_LIFE_TIME {passLife}
                    PASSWORD_GRACE_TIME {passGrace}
                    PASSWORD_REUSE_TIME {passReuseTime}
                    PASSWORD_REUSE_MAX {passReuseMax}
                    FAILED_LOGIN_ATTEMPTS {failed}";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
        }

        public static bool UpdateProfile(string name,
            string sess, string connect, string idle,
            string passLife, string passGrace, string passReuseTime,
            string passReuseMax, string failed)
        {
            using (var conn = DataProvider.GetConnection())
            {
                string sql = $@"
                ALTER PROFILE {name} LIMIT
                    SESSIONS_PER_USER {sess}
                    CONNECT_TIME {connect}
                    IDLE_TIME {idle}
                    PASSWORD_LIFE_TIME {passLife}/1440
                    PASSWORD_GRACE_TIME {passGrace}/1440
                    PASSWORD_REUSE_TIME {passReuseTime}/1440
                    PASSWORD_REUSE_MAX {passReuseMax}
                    FAILED_LOGIN_ATTEMPTS {failed}";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
        }

        // Xóa profile
        public static bool DeleteProfile(string profileName)
        {
            using (var conn = DataProvider.GetConnection())
            {
                string sql = $"DROP PROFILE {profileName} CASCADE";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public static DataTable FindProfile(string name)
        {
            using (var conn = DataProvider.GetConnection())
            {
                string sql = $@"
                SELECT * FROM DBA_PROFILES
                WHERE PROFILE LIKE UPPER('%{name}%')";
                using (var cmd = new OracleCommand(sql, conn))
                using (var adapter = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static bool GrantProfileToUser(string username, string profile)
        {
            using (var conn = DataProvider.GetConnection())
            {
                string sql = $"ALTER USER {username} PROFILE {profile}";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public static bool RevokeProfileFromUser(string username)
        {
            using (var conn = DataProvider.GetConnection())
            {
                string sql = $"ALTER USER {username} PROFILE DEFAULT";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}
