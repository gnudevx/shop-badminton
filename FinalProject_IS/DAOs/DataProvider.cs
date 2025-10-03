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
        public static readonly string ConnStr = Properties.Settings.Default.conStr;

        public static OracleConnection GetConnection()
        {
            var conn = new OracleConnection(ConnStr);
            conn.Open();

            using (var cmd = new OracleCommand("ALTER SESSION SET CURRENT_SCHEMA=SHOPBADMINTON", conn))
            {
                cmd.ExecuteNonQuery();
            }

            return conn;
        }
    }

}
