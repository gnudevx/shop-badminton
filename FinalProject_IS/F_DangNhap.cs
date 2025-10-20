using FinalProject_IS.DAOs;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                        //bool isSystemManager = false;
                        //bool isSecurityManager = false;

                        //while (reader.Read())
                        //{
                        //    string role = reader.GetString(0).ToUpper();
                        //    if (role == "ROLE_SYSTEM_MANAGER")
                        //    {
                        //        isSystemManager = true;
                        //        break;
                        //    }
                        //    else if (role == "ROLE_SECURITY_MANAGER")
                        //    {
                        //        isSystemManager = true;
                        //        break;
                        //    }
                        //}

                        //conn.Close();
                        List<string> roles = new List<string>();
                        while (reader.Read())
                        {
                            roles.Add(reader.GetString(0).ToUpper());
                        }


                        // Điều hướng theo vai trò
                        this.Hide();
                        if (roles.Contains("ROLE_SYSTEM_MANAGER"))
                        {
                            new FSystemManager().ShowDialog();
                        }
                        else if (roles.Contains("ROLE_SECURITY_MANAGER"))
                        {
                            new F_Security_Manager().ShowDialog();
                        }
                        else
                        {
                            new Form1().ShowDialog();
                        }
                        this.Show();

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
