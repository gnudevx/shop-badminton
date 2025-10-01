using System;
using System.Collections;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;

namespace FinalProject_IS.DAOs
{
    public class SanPhamDAO
    {
        public static List<SanPham> DSSanPham()
        {
            List<SanPham> dsSanPham = new List<SanPham>();

            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = "SELECT TOP 100 * FROM SanPham";

                OracleDataAdapter dataAdapter = new OracleDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    SanPham sp = new SanPham
                    {
                        MaSP = Convert.ToInt32(row["MaSP"]),
                        TenSP = row["TenSP"].ToString(),
                        LoaiSP = row["LoaiSP"].ToString(),
                        GiaBan = Convert.ToDecimal(row["GiaBan"]),
                        SoLuongTon = Convert.ToInt32(row["SoLuongTon"]),
                        NgayNhapKho = Convert.ToDateTime(row["NgayNhapKho"]),
                        ThoiGianBaoHanh = row["ThoiGianBaoHanh"] != DBNull.Value ? Convert.ToInt32(row["ThoiGianBaoHanh"]) : (int?)null,
                        GiaGoc = Convert.ToDecimal(row["GiaGoc"]),
                        MoTa = row["MoTa"].ToString()
                    };
                    dsSanPham.Add(sp);
                }
            }

            return dsSanPham;
        }

        public static int GetNewProductID()
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                

                string query = "SELECT ISNULL(MAX(MaSP), 0) FROM SanPham";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    int maxID = Convert.ToInt32(result);
                    return maxID + 1; 
                }
            }
        }

        public static string GetProductNameByID(int productID)  
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                

                string query = "Select TenSP From SanPham where MaSP = :productID;";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("productID", productID);
                    object result = cmd.ExecuteScalar();
                    string name = result.ToString();
                    return name;
                }
            }
        }

        public static SanPham GetProductByID(int id)
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                

                string query = "SELECT * FROM SanPham WHERE MaSP = :productID;";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("productID", id);

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            SanPham product = new SanPham();
                            product.MaSP = reader.GetInt32(reader.GetOrdinal("MaSP"));
                            product.TenSP = reader.GetString(reader.GetOrdinal("TenSP"));
                            product.LoaiSP = reader.GetString(reader.GetOrdinal("LoaiSP"));
                            product.GiaBan = reader.GetDecimal(reader.GetOrdinal("GiaBan"));
                            product.SoLuongTon = reader.GetInt32(reader.GetOrdinal("SoLuongTon"));
                            product.NgayNhapKho = reader.GetDateTime(reader.GetOrdinal("NgayNhapKho"));
                            product.ThoiGianBaoHanh = reader.GetInt32(reader.GetOrdinal("ThoiGianBaoHanh"));
                            product.MaTH = reader.GetInt32(reader.GetOrdinal("MaTH"));
                            product.GiaGoc = reader.GetDecimal(reader.GetOrdinal("GiaGoc"));
                            product.MoTa = reader.GetString(reader.GetOrdinal("MoTa"));
                            return product;
                        }
                        else
                        {
                            return null; // or throw an exception, depending on your needs
                        }
                    }
                }
            }
        }
        public static SanPham TimSanPhamTheoMaSP(string maSP)
        {
            SanPham sanPham = null;

            using (OracleConnection conn = DataProvider.GetConnection())
            {
                 // Mở kết nối đến database

                string query = "SELECT * FROM SanPham WHERE MaSP = :MaSP;";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("MaSP", maSP); // Truyền tham số an toàn

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Nếu tìm thấy sản phẩm
                        {
                            sanPham = new SanPham
                            {
                                MaSP = Convert.ToInt32(reader["MaSP"]),
                                TenSP = reader["TenSP"].ToString(),
                                LoaiSP = reader["LoaiSP"].ToString(),
                                GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                                SoLuongTon = reader["SoLuongTon"] as int?,
                                NgayNhapKho = Convert.ToDateTime(reader["NgayNhapKho"]),
                                ThoiGianBaoHanh = reader["ThoiGianBaoHanh"] as int?,
                                MaTH = reader["MaTH"] as int?,
                                GiaGoc = Convert.ToDecimal(reader["GiaGoc"]),
                                MoTa = reader["MoTa"].ToString()
                            };
                        }
                    }

                    return sanPham;
                }
            }
        }

        public static void UpdateSanPhamNhan(int id, int soluong)
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = @"UPDATE SanPham
                        SET SoLuongTon = SoLuongTon + :soluong
                        WHERE MaSP = :id;
                        ";



                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("soluong", soluong);
                    cmd.Parameters.Add("id", id);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
