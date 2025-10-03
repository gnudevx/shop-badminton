using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_IS.DAOs
{
    public class KhuyenMaiDAO
    {
        public static List<KhuyenMai> DsKhuyenMai()
        {
            List<KhuyenMai> dsKhuyenMai = new List<KhuyenMai>();

            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = "SELECT * FROM KhuyenMai";

                OracleDataAdapter dataAdapter = new OracleDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    KhuyenMai km = new KhuyenMai
                    {
                        MaKM = Convert.ToInt32(row["MaKM"]),
                        TenChuongTrinh = row["TenChuongTrinh"].ToString(),
                        GiaTriKhuyenMai = Convert.ToDouble(row["GiaTriKhuyenMai"]),
                        DieuKienKhuyenMai = row["DieuKienKhuyenMai"].ToString(),
                        NgayBatDau = Convert.ToDateTime(row["NgayBatDau"]),
                        NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]),
                        SoLuong = Convert.ToInt32(row["SoLuong"])
                    };
                    dsKhuyenMai.Add(km);
                }
            }

            return dsKhuyenMai;
        }
        public static void InsertKhuyenMai(KhuyenMai khuyenMai)
        {
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = @"INSERT INTO KhuyenMai Values(:TenChuongTrinh, :GiaTriKhuyenMai, :DieuKienKhuyenMai,
                                :NgayBatDau,:NgayKetThuc,:SoLuong)";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("TenChuongTrinh", khuyenMai.TenChuongTrinh);
                    cmd.Parameters.Add("GiaTriKhuyenMai", khuyenMai.GiaTriKhuyenMai);
                    cmd.Parameters.Add("DieuKienKhuyenMai", khuyenMai.DieuKienKhuyenMai);
                    cmd.Parameters.Add("NgayBatDau", khuyenMai.NgayBatDau);
                    cmd.Parameters.Add("NgayKetThuc", khuyenMai.NgayKetThuc);
                    cmd.Parameters.Add("SoLuong", khuyenMai.SoLuong);

                    
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static int XoaKhuyenMai(int maKM)
        {
            int rowsAffected = 0;
            using (OracleConnection conn = DataProvider.GetConnection())
            {
                string query = @"DELETE FROM KhuyenMai WHERE MaKM = :MaKM";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add("MaKM", maKM);

                    
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;

        }

        
        public static int XoaNhieuKhuyenMai(List<int> danhSachMaKM)
        {
            int rowsAffected = 0;
            foreach (int maKM in danhSachMaKM)
            {
                rowsAffected += XoaKhuyenMai(maKM);
            }
            return rowsAffected;
        }
    }
}
