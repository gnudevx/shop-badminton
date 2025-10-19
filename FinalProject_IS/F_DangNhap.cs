using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_IS.DAOs;
using Oracle.ManagedDataAccess.Client;

namespace FinalProject_IS
{
    public partial class F_DangNhap : Form
    {
        public F_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string username = txt_TK.Text.Trim().ToUpper();
            string password = txt_MatKhau.Text.Trim();

            try
            {
                // Thiết lập thông tin kết nối cho user hiện tại
                DataProvider.SetLogin(username, password);

                using (var conn = DataProvider.GetConnection())
                {
                    // Lấy danh sách role mà user có
                    string sql = @"SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS";
                    using (var cmd = new OracleCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        bool isSystemManager = false;

                        while (reader.Read())
                        {
                            string role = reader.GetString(0).ToUpper();
                            if (role == "ROLE_SYSTEM_MANAGER")
                            {
                                isSystemManager = true;
                                break;
                            }
                        }

                        // 🔸 Lưu username và role hiện tại để các form khác dùng
                        SessionInfo.CurrentUsername = username;
                        SessionInfo.CurrentRole = isSystemManager ? "ROLE_SYSTEM_MANAGER" : "USER";

                        conn.Close();

                        // Điều hướng form
                        this.Hide();
                        if (isSystemManager)
                        {
                            FSystemManager f = new FSystemManager();
                            f.ShowDialog();
                        }
                        else
                        {
                            Form1 f = new Form1();
                            f.ShowDialog();
                        }

                        this.Show();
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Đăng nhập thất bại: " + ex.Message,
                                "Lỗi đăng nhập",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
