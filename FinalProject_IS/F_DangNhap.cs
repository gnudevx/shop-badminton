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
                // Cập nhật thông tin đăng nhập động
                DataProvider.SetLogin(username, password);

                using (var conn = DataProvider.GetConnection())
                {
                    // Lấy danh sách ROLE của user hiện tại
                    string sql = @"SELECT GRANTED_ROLE 
                                   FROM USER_ROLE_PRIVS";

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

                        conn.Close();

                        // Điều hướng theo vai trò
                        this.Hide();
                        if (isSystemManager)
                        {
                            FSystemManager f = new FSystemManager();
                            f.ShowDialog();
                        }
                        else
                        {
                            // nếu không phải system manager thì qua form nhân viên
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
