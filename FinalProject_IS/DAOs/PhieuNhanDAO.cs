using System;
using System.Collections;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace FinalProject_IS.DAOs
{
    public class PhieuNhanDAO
    {
        public static List<PhieuNhan> DSPhieuNhan()
        {
            List<PhieuNhan> dsPhieuNhan = new List<PhieuNhan>();

            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = "SELECT * FROM PhieuNhan";

                OracleDataAdapter dataAdapter = new OracleDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhan pn = new PhieuNhan
                    {
                        MaPhieuNhan = Convert.ToInt32(row["MaPhieuNhan"]),
                        NgayTao = Convert.ToDateTime(row["NgayTao"]),
                    };
                    dsPhieuNhan.Add(pn);
                }
            }

            return dsPhieuNhan;
        }
        public static List<PhieuNhan> DSPhieuNhanTheoMa(string maphieu)
        {
            List<PhieuNhan> dsPhieuNhan = new List<PhieuNhan>();

            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = @"SELECT * FROM PhieuNhan
                         WHERE MaPhieuNhan LIKE :maphieu";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("maphieu", maphieu + "%");

                    OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        PhieuNhan sp = new PhieuNhan
                        {
                            MaPhieuNhan = Convert.ToInt32(row["MaPhieuNhan"]),
                            NgayTao = Convert.ToDateTime(row["NgayTao"])
                        };

                        dsPhieuNhan.Add(sp);
                    }
                }
            }

            return dsPhieuNhan;
        }
        public static List<PhieuNhan> DSSapXepPhieuNhan(string columnName, bool ascending)
        {
            List<PhieuNhan> dsPhieuNhan = new List<PhieuNhan>();

            if (!IsValidColumnName(columnName))
            {
                throw new ArgumentException("Tên cột không hợp lệ.");
            }

            string order = ascending ? "ASC" : "DESC"; // Chọn thứ tự sắp xếp
            string query = $@"SELECT * FROM PhieuNhan ORDER BY {columnName} {order}";

            using (OracleConnection conn = DataProvider.GetConnection())
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PhieuNhan sp = new PhieuNhan
                        {
                            MaPhieuNhan = reader.GetInt32(reader.GetOrdinal("MaPhieuNhan")),
                            NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao"))
                        };

                        dsPhieuNhan.Add(sp);
                    }
                }
            }

            return dsPhieuNhan;
        }

        // Phương thức để kiểm tra tên cột
        private static bool IsValidColumnName(string columnName)
        {
            // Kiểm tra tên cột với danh sách các tên cột hợp lệ
            var validColumns = new List<string> { "MaPhieuNhan", "NgayTao" }; // Thêm các cột hợp lệ ở đây
            return validColumns.Contains(columnName);
        }

        public static void InsertPhieu(PhieuNhan phieu)
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = @"INSERT INTO PhieuNhan Values(:NgayTao)";



                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("NgayTao", phieu.NgayTao);

                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void InsertChiTietPhieu(ChiTietPhieuNhan chitiet)
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = @"INSERT INTO ChiTietPhieuNhan Values(:MaPhieuNhan, :MaSP, :TenSP, :LoaiSP
                                                                        ,:SoLuongNhap, :DonGiaNhap, :ThuongHieu
                                                                        ,:ThoiGianBaoHanh, :MoTa, :TongTien, :NgayNhan)";



                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("MaPhieuNhan", chitiet.MaPhieuNhan);
                    cmd.Parameters.Add("MaSP", chitiet.MaSP);
                    cmd.Parameters.Add("TenSP", chitiet.TenSP);
                    cmd.Parameters.Add("LoaiSP", chitiet.LoaiSP);
                    cmd.Parameters.Add("SoLuongNhap", chitiet.SoLuongNhap);
                    cmd.Parameters.Add("DonGiaNhap", chitiet.DonGiaNhap);
                    cmd.Parameters.Add("ThuongHieu", chitiet.ThuongHieu);
                    cmd.Parameters.Add("ThoiGianBaoHanh", chitiet.ThoiGianBaoHanh);
                    cmd.Parameters.Add("MoTa", chitiet.MoTa);
                    cmd.Parameters.Add("TongTien", chitiet.TongTien);
                    cmd.Parameters.Add("NgayNhan", chitiet.NgayNhan);

                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int GetNewPhieuNhanID()
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                

                string query = "SELECT ISNULL(MAX(MaPhieuNhan), 0) FROM PhieuNhan";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    int maxID = Convert.ToInt32(result);
                    return maxID + 1;
                }
            }
        }

        public static List<ChiTietPhieuNhan> GetChiTietByID(int id)
        {
            List<ChiTietPhieuNhan> ChitietPhieuNhanHang = new List<ChiTietPhieuNhan>();

            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = @"SELECT * FROM ChiTietPhieuNhan where MaPhieuNhan = :id";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("id", id);
                    OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        ChiTietPhieuNhan chitiet = new ChiTietPhieuNhan();
                        chitiet.MaPhieuNhan = id;
                        chitiet.MaSP = Convert.ToInt32(row["MaSP"]);
                        chitiet.TenSP = row["TenSP"].ToString();
                        chitiet.LoaiSP = row["LoaiSP"].ToString();
                        chitiet.SoLuongNhap = Convert.ToInt32(row["SoLuongNhap"]);
                        chitiet.DonGiaNhap = Convert.ToDecimal(row["DonGiaNhap"]);
                        chitiet.ThuongHieu = row["ThuongHieu"].ToString();
                        chitiet.ThoiGianBaoHanh = Convert.ToInt32(row["ThoiGianBaoHanh"]);
                        chitiet.MoTa = row["Mota"].ToString();
                        chitiet.TongTien = Convert.ToDecimal(row["TongTien"]);
                        ChitietPhieuNhanHang.Add(chitiet);
                    }
                    return ChitietPhieuNhanHang;
                }
            }

        }
    }
}
