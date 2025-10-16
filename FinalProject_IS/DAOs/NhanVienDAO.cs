using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalProject_IS.DAOs
{
    public class NhanVienDAO
    {
        public static List<NhanVien> DsNhanVien()
        {
            List<NhanVien> dsNhanVien = new List<NhanVien>();

            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = "SELECT * FROM NhanVien";

                OracleDataAdapter dataAdapter = new OracleDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    NhanVien nv = new NhanVien
                    {
                        MaNV = Convert.ToInt32(row["MaNV"]),
                        HoTen = row["HoTen"].ToString(),
                        NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                        GioiTinh = row["GioiTinh"].ToString(),
                        Email = Convert.ToString(row["email"]),
                        MaChucVu = Convert.ToInt32(row["MaChucVu"]),
                        LuongCoBan = Convert.ToDecimal(row["LuongCoBan"])
                    };
                    dsNhanVien.Add(nv);
                }
            }

            return dsNhanVien;
        }
        public static void ThemNhanVien(NhanVien nv)
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = @"INSERT INTO NhanVien Values(:MaNV, :HoTen, :NgaySinh, :GioiTinh,
                                                                    :Email, :MaChucVu, :LuongCoBan)";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("MaNV", nv.MaNV);
                    cmd.Parameters.Add("HoTen", nv.HoTen);
                    cmd.Parameters.Add("NgaySinh", nv.NgaySinh);
                    cmd.Parameters.Add("GioiTinh", nv.GioiTinh);
                    cmd.Parameters.Add("Email", nv.Email);
                    cmd.Parameters.Add("MaChucVu", nv.MaChucVu);
                    cmd.Parameters.Add("LuongCoBan", nv.LuongCoBan);

                    
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
