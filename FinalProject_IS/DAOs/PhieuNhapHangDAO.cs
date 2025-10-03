using System;
using System.Collections;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_IS.DAOs
{
    public class PhieuNhapHangDAO
    {
        public static List<PhieuNhapHang> DSPhieuNhapHang()
        {
            List<PhieuNhapHang> dsPhieuNhapHang = new List<PhieuNhapHang>();

            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = "SELECT MaPhieuNhap, NgayTao, TinhTrangPhieuNhap FROM PhieuNhapHang";

                OracleDataAdapter dataAdapter = new OracleDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhapHang sp = new PhieuNhapHang
                    {
                        // Intentional mismatch between SQL column names and object properties
                        MaPhieuNhap = Convert.ToInt32(row["MaPhieuNhap"]), // Intentional mismatch: using "MaSP"
                        NgayTao = Convert.ToDateTime(row["NgayTao"]), // Intentional mismatch: using "NgayNhapKho"
                        TinhTrangPhieuNhap = row["TinhTrangPhieuNhap"].ToString()
                    };

                    dsPhieuNhapHang.Add(sp);
                }
            }

            return dsPhieuNhapHang;
        }

        public static void InsertPhieu(PhieuNhapHang phieu)
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = @"INSERT INTO PhieuNhapHang Values(:NgayTao, :TinhTrangPhieuNhap)";



                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("NgayTao", phieu.NgayTao);
                    cmd.Parameters.Add("TinhTrangPhieuNhap", phieu.TinhTrangPhieuNhap);

                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void InsertChiTietPhieu(ChiTietPhieuNhapHang chitiet)
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = @"INSERT INTO ChiTietPhieuNhapHang Values(:MaPhieuNhap, :MaSP, :TenSP, :SoLuongNhap, :SoLuongThieu)";



                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("MaPhieuNhap", chitiet.MaPhieuNhap);
                    cmd.Parameters.Add("MaSP", chitiet.MaSP);
                    cmd.Parameters.Add("TenSP", chitiet.TenSP);
                    cmd.Parameters.Add("SoLuongNhap", chitiet.SoLuongNhap);
                    cmd.Parameters.Add("SoLuongThieu", chitiet.SoLuongNhap);
                        

                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int GetNewPhieuNhapID()
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                

                string query = "SELECT ISNULL(MAX(MaPhieuNhap), 0) FROM PhieuNhapHang";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    int maxID = Convert.ToInt32(result);
                    return maxID + 1;
                }
            }
        }

        public static List<PhieuNhapHang> DSPhieuNhapHangTheoMa(string maphieu)
        {
            List<PhieuNhapHang> dsPhieuNhapHang = new List<PhieuNhapHang>();

            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = @"SELECT MaPhieuNhap, NgayTao, TinhTrangPhieuNhap 
                         FROM PhieuNhapHang 
                         WHERE MaPhieuNhap LIKE :maphieu";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("maphieu", maphieu + "%");

                    OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        PhieuNhapHang sp = new PhieuNhapHang
                        {
                            MaPhieuNhap = Convert.ToInt32(row["MaPhieuNhap"]),
                            NgayTao = Convert.ToDateTime(row["NgayTao"]),
                            TinhTrangPhieuNhap = row["TinhTrangPhieuNhap"].ToString()
                        };

                        dsPhieuNhapHang.Add(sp);
                    }
                }
            }

            return dsPhieuNhapHang;
        }

        public static List<ChiTietPhieuNhapHang> GetChiTietByID(int id)
        {
            List<ChiTietPhieuNhapHang> ChitietPhieuNhapHang = new List<ChiTietPhieuNhapHang>();

            using (OracleConnection conn = DataProvider.GetConnection())
            {

                string query = @"SELECT MaSP, TenSP, SoLuongNhap, SoLuongThieu FROM ChiTietPhieuNhapHang where MaPhieuNhap = :id";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("id", id);
                    OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        ChiTietPhieuNhapHang chitiet = new ChiTietPhieuNhapHang();
                        chitiet.MaPhieuNhap = id;
                        chitiet.MaSP = Convert.ToInt32(row["MaSP"]);
                        chitiet.TenSP = row["TenSP"].ToString();
                        chitiet.SoLuongNhap = Convert.ToInt32(row["SoLuongNhap"]);
                        chitiet.SoLuongThieu = Convert.ToInt32(row["SoLuongThieu"]);
                        ChitietPhieuNhapHang.Add(chitiet);
                    }
                    return ChitietPhieuNhapHang;
                }
            }
        }

        public static void UpdateChiTietPhieuNhapHang(int id, int soluong)
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                
                int soLuongCanTru = soluong;

                string selectQuery = "SELECT ChiTietPhieuNhapHang.MaPhieuNhap, SoLuongThieu FROM ChiTietPhieuNhapHang left join PhieuNhapHang " +
                    "on ChiTietPhieuNhapHang.MaPhieuNhap = PhieuNhapHang.MaPhieuNhap " +
                    "Where MaSP = :maSP and TinhTrangPhieuNhap = 'Dang cho' " +
                    "ORDER BY MaPhieuNhap ASC";
                OracleCommand selectCmd = new OracleCommand(selectQuery, conn);
                selectCmd.Parameters.Add("maSP", id);
                var reader = selectCmd.ExecuteReader();

                List<(int MaPhieuNhap, int SoLuongThieu)> danhSach = new List<(int, int)>();
                while (reader.Read())
                {
                    danhSach.Add((reader.GetInt32(0), reader.GetInt32(1)));
                }
                reader.Close();

                foreach (var item in danhSach)
                {
                    int tru = Math.Min(soLuongCanTru, item.SoLuongThieu);
                    string updateQuery = @"
                    UPDATE ChiTietPhieuNhapHang 
                    SET SoLuongThieu = SoLuongThieu - :tru 
                    WHERE MaPhieuNhap = :maPhieuNhap AND MaSP = :maSP";

                    OracleCommand updateCmd = new OracleCommand(updateQuery, conn);
                    updateCmd.Parameters.Add("tru", tru);
                    updateCmd.Parameters.Add("maPhieuNhap", item.MaPhieuNhap);
                    updateCmd.Parameters.Add("maSP", id);
                    updateCmd.ExecuteNonQuery();

                    soLuongCanTru -= tru;
                    if (soLuongCanTru <= 0) break;
                }
            }
        }

        public static void UpdateTinhTrangPhieuNhap()
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = @"
            UPDATE PhieuNhapHang
            SET TinhTrangPhieuNhap = N'Hoàn tất'
            WHERE MaPhieuNhap IN (
                SELECT MaPhieuNhap
                FROM ChiTietPhieuNhapHang
                GROUP BY MaPhieuNhap
                HAVING SUM(CASE WHEN SoLuongThieu > 0 THEN 1 ELSE 0 END) = 0
            );
        ";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
