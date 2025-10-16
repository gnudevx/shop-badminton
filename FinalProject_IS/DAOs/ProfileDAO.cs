using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace FinalProject_IS.DAOs
{
    public class ProfileDAO
    {
        // Lấy danh sách profile
        public static DataTable GetAllProfiles()
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = new OracleCommand("SELECT PROFILE FROM DBA_PROFILES GROUP BY PROFILE", conn))
            using (var adapter = new OracleDataAdapter(cmd))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Tạo profile mới
        public static bool CreateProfile(string profileName, string passwordLifeTime = "UNLIMITED")
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = $"CREATE PROFILE {profileName} LIMIT PASSWORD_LIFE_TIME {passwordLifeTime}";
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (OracleException ex)
                {
                    System.Windows.Forms.MessageBox.Show("Lỗi tạo profile: " + ex.Message);
                    return false;
                }
            }
        }

        // Xóa profile
        public static bool DropProfile(string profileName)
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = $"DROP PROFILE {profileName} CASCADE";
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (OracleException ex)
                {
                    System.Windows.Forms.MessageBox.Show("Lỗi xóa profile: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
