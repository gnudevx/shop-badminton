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
    public class HoaDonDAO
    {
        public static List<HoaDon> DSHoaDon()
        {
            List<HoaDon> dsHoaDon = new List<HoaDon>();

            using (OracleConnection conn = new OracleConnection(DataProvider.ConnStr))
            {
                string query = "SELECT * FROM HoaDon";

                OracleDataAdapter dataAdapter = new OracleDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    HoaDon hd = new HoaDon
                    {
                        MaHD = row["MAHD"].ToString(),
                        NgayGioTao = Convert.ToDateTime(row["NGAYGIOTAO"]),
                        MaKH = Convert.ToInt32(row["MAKH"]),
                        MaNV = Convert.ToInt32(row["MANV"]),
                        TongTien = Convert.ToInt32(row["TONGTIEN"]),
                        MaKM = row["MAKM"] != DBNull.Value ? Convert.ToInt32(row["MAKM"]) : (int?)null,
                        LoaiHoaDon = row["LOAIHOADON"].ToString()
                    };
                    dsHoaDon.Add(hd);
                }
            }

            return dsHoaDon;
        }

        public static List<ChiTietHD_SanPham> LayChiTietTheoMaHD(string id)
        {
            List<ChiTietHD_SanPham> ChiTietHD_SanPham = new List<ChiTietHD_SanPham>();

            using (OracleConnection conn = new OracleConnection(DataProvider.ConnStr))
            {
                string query = @"SELECT MASP, SOLUONGSP, DONGIA, THANHTIEN 
                                 FROM CHITIETHD_SANPHAM 
                                 WHERE MAHD = :id";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("id", id));

                    OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        ChiTietHD_SanPham chitiet = new ChiTietHD_SanPham();
                        chitiet.MaHD = id;
                        chitiet.MaSP = Convert.ToInt32(row["MASP"]);
                        chitiet.SoLuongSP = Convert.ToInt32(row["SOLUONGSP"]);
                        chitiet.DonGia = Convert.ToDecimal(row["DONGIA"]);
                        chitiet.ThanhTien = Convert.ToDecimal(row["THANHTIEN"]);
                        ChiTietHD_SanPham.Add(chitiet);
                    }
                }
            }

            return ChiTietHD_SanPham;
        }
    }
}
