using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_IS.DAOs
{
    public class KhachHangDAO
    {
        public static List<KhachHang> DSKhachHang()
        {
            List<KhachHang> dsKhachHang = new List<KhachHang>();

            using (OracleConnection conn = new OracleConnection(DataProvider.ConnStr))
            {
                string query = "SELECT * FROM KhachHang";

                OracleDataAdapter dataAdapter = new OracleDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    KhachHang kh = new KhachHang
                    {
                        MaKH = Convert.ToInt32(row["MaKH"]),
                        HoTen = row["HoTen"].ToString(),
                        SoDienThoai = row["SoDienThoai"].ToString(),
                        TongChiTieu = Convert.ToDecimal(row["TongChiTieu"]),
                        MaLoaiKH = Convert.ToInt32(row["MaLoaiKH"]),
                    };
                    dsKhachHang.Add(kh);
                }
            }

            return dsKhachHang;
        }
        public static KhachHang TimKiemKhachHangTheoSDT(string soDienThoai)
        {
            KhachHang khachHang = null;

            using (OracleConnection conn = new OracleConnection(DataProvider.ConnStr))
            {
                conn.Open();

                string query = "SELECT * FROM KhachHang WHERE SoDienThoai = :SoDienThoai";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("SoDienThoai", soDienThoai);

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            khachHang = new KhachHang
                            {
                                MaKH = Convert.ToInt32(reader["MaKH"]),
                                HoTen = reader["HoTen"].ToString(),
                                SoDienThoai = reader["SoDienThoai"].ToString(),
                                TongChiTieu = reader["TongChiTieu"] as decimal?,
                                MaLoaiKH = reader["MaLoaiKH"] as int?
                            };
                        }
                    }
                }
            }

            return khachHang;
        }
        public static bool ThemKhachHang(KhachHang khachHang)
        {
            using (OracleConnection conn = new OracleConnection(DataProvider.ConnStr))
            {
                conn.Open(); // Mở kết nối đến cơ sở dữ liệu

                string query = "INSERT INTO KhachHang (HoTen, SoDienThoai, TongChiTieu, MaLoaiKH) " +
                               "VALUES (:HoTen, :SoDienThoai, :TongChiTieu, :MaLoaiKH);";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("HoTen", khachHang.HoTen);
                    cmd.Parameters.Add("SoDienThoai", khachHang.SoDienThoai);
                    cmd.Parameters.Add("TongChiTieu", khachHang.TongChiTieu ?? (object)DBNull.Value);
                    cmd.Parameters.Add("MaLoaiKH", khachHang.MaLoaiKH ?? (object)DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh INSERT

                    return rowsAffected > 0; // Trả về true nếu thêm thành công
                }
            }
        }
    }
}
