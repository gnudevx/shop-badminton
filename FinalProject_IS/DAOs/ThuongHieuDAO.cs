using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_IS.DAOs
{
    public class ThuongHieuDAO
    {
        public static string GetTenThuongHieuByID(int? id)
        {
            using (OracleConnection conn = new OracleConnection(DataProvider.ConnStr))
            {
                conn.Open();

                string query = "Select TenTH From ThuongHieu where MaTH = :productID;";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("productID", id);
                    object result = cmd.ExecuteScalar();
                    string name = result.ToString();
                    return name;
                }
            }
        }
    }
}
