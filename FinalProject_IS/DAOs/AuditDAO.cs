using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_IS.DAOs
{

    public class AuditDAO
    {
        public static DataTable GetAllData()
        {
            using (var conn = DataProvider.GetConnection())
            using (var cmd = new OracleCommand(@"SELECT DB_USER, OBJECT_NAME, SQL_TEXT, TIMESTAMP
                    FROM DBA_FGA_AUDIT_TRAIL", conn))
            using (var adapter = new OracleDataAdapter(cmd))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
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

        public static List<string> GetListTablesAudited(string query)
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

        public static DataTable FilterDataBaseOnQuery(string query)
        {
            DataTable dataTable = new DataTable();

            // 1. Get the connection and cast it to the specific OracleConnection type.
            using (var conn = (OracleConnection)DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = query;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                // 2. Explicitly use the OracleDataAdapter.
                using (OracleDataAdapter adapter = new OracleDataAdapter((OracleCommand)cmd))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }


}
