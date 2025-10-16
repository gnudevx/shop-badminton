using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_IS.DAOs
{
    public static class DataProvider
    {
        private static readonly string _defaultUser = "tin";
        private static readonly string _defaultPass = "123";
        private static readonly string _dataSource = "20.6.131.54:1521/ORCLPDB"; // chỉnh theo DB của bạn

        // 🔹 Dùng ConnectionString động, để sau này form login thay vào        
        public static string ConnStr = $"Data Source={_dataSource};User Id={_defaultUser};Password={_defaultPass};";

        public static OracleConnection GetConnection()
        {
            try
            {
                var conn = new OracleConnection(ConnStr);
                conn.Open();

                using (var cmd = new OracleCommand("ALTER SESSION SET CURRENT_SCHEMA=SHOPBADMINTON", conn))
                {
                    cmd.ExecuteNonQuery();
                }

                return conn;
            }
            catch (OracleException ex)
            {
                throw new Exception($"Lỗi kết nối Oracle: {ex.Message}");
            }
        }


        // ✅ Chuẩn bị sẵn hàm cho form đăng nhập sau này
        public static void SetLogin(string username, string password)
        {
            ConnStr = $"Data Source={_dataSource};User Id={username};Password={password};";
        }
    }

}
