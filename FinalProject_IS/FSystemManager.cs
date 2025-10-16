using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using FinalProject_IS.DAOs;

namespace FinalProject_IS
{
    public partial class FSystemManager : Form
    {
        private OracleConnection conn;

        public FSystemManager()
        {
            InitializeComponent();
        }

        private void FSystemManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 🔹 Đóng connection khi form tắt
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void FSystemManager_Load(object sender, EventArgs e)
        {
            try
            {
                conn = DataProvider.GetConnection();

                // User
                dgvUsers.DataSource = UserDAO.GetAllUsers();
                dgvRoles.DataSource = RoleDAO.GetAllRoles();
                dgvProfiles.DataSource = ProfileDAO.GetAllProfiles();
                cbDefaultTS.DataSource = GetList("SELECT tablespace_name FROM dba_tablespaces");
                cbTempTS.DataSource = GetList("SELECT tablespace_name FROM dba_tablespaces");
                cbProfile.DataSource = GetList("SELECT profile FROM dba_profiles GROUP BY profile");
                clbRoles.DataSource = GetList("SELECT role FROM dba_roles");

                // Role
                cboUsers.DataSource = GetList("SELECT USERNAME FROM dba_users");

                dgvUsers.CellClick += dgvUsers_CellClick;
                dgvRoles.CellClick += dgvRoles_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        #region User
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToUpper();
            string password = txtPassword.Text.Trim();
            string defaultTS = cbDefaultTS.Text.Trim();
            string tempTS = cbTempTS.Text.Trim();
            string quota = txtQuota.Text.Trim();
            string profile = cbProfile.Text.Trim();
            string status = cbStatus.Text.Trim().ToUpper(); 

            // 🔹 Kiểm tra nhập liệu cơ bản
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập Username và Password!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(defaultTS) || string.IsNullOrEmpty(tempTS) ||
                string.IsNullOrEmpty(quota) || string.IsNullOrEmpty(profile) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin Tablespace, Quota, Profile và Trạng thái!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool result = UserDAO.CreateUser(username, password, defaultTS, tempTS, quota, profile, status);
                if (result)
                {
                    dgvUsers.DataSource = UserDAO.GetAllUsers(); // refresh
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo user: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToUpper();
            string password = txtPassword.Text.Trim();
            string defaultTS = cbDefaultTS.Text.Trim();
            string tempTS = cbTempTS.Text.Trim();
            string quota = txtQuota.Text.Trim();
            string profile = cbProfile.Text.Trim();
            string status = cbStatus.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng chọn user cần cập nhật!");
                return;
            }

            // Kiểm tra nếu tất cả đều trống => không có gì để cập nhật
            if (string.IsNullOrEmpty(password) && string.IsNullOrEmpty(defaultTS)
                && string.IsNullOrEmpty(tempTS) && string.IsNullOrEmpty(quota)
                && string.IsNullOrEmpty(profile) && string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Vui lòng nhập ít nhất một thông tin để cập nhật!");
                return;
            }

            bool result = UserDAO.AlterUser(username, password, defaultTS, tempTS, quota, profile, status);

            if (result)
            {
                // Refresh lại danh sách user
                dgvUsers.DataSource = UserDAO.GetAllUsers();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên user cần xóa!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa user {txtUsername.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (UserDAO.DropUser(txtUsername.Text))
                {
                    dgvUsers.DataSource = UserDAO.GetAllUsers(); // refresh
                }
            }
        }

        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUsers.DataSource = UserDAO.GetAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách user: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

            // 🔹 Lấy dữ liệu theo tên cột đúng với DataSource (DBA_USERS)
            txtUsername.Text = row.Cells["USERNAME"].Value?.ToString().Trim();
            cbDefaultTS.Text = row.Cells["DEFAULT_TABLESPACE"].Value?.ToString().Trim();
            cbTempTS.Text = row.Cells["TEMPORARY_TABLESPACE"].Value?.ToString().Trim();
            cbProfile.Text = row.Cells["PROFILE"].Value?.ToString().Trim();

            // 🔹 Trạng thái tài khoản: ACTIVE, LOCKED, EXPIRED...
            string accStatus = row.Cells["ACCOUNT_STATUS"].Value?.ToString().ToUpper() ?? "";
            if (accStatus.Contains("LOCK"))
                cbStatus.Text = "LOCK";
            else
                cbStatus.Text = "UNLOCK";

            // 🔹 Reset các trường không có trong bảng (nếu cần)
            txtPassword.Text = "";
            txtQuota.Text = "";
        }

        #endregion

        #region Role

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            string roleName = txtRoleName.Text.Trim().ToUpper();
            string password = txtRolePassword.Text.Trim();

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Vui lòng nhập tên role!");
                return;
            }

            if (RoleDAO.CreateRole(roleName, string.IsNullOrEmpty(password) ? null : password))
            {
                dgvRoles.DataSource = RoleDAO.GetAllRoles(); // refresh danh sách
                txtRoleName.Clear();
                txtRolePassword.Clear();
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            string roleName = txtRoleName.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Vui lòng chọn role cần xóa!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa role {roleName}?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (RoleDAO.DropRole(roleName))
                {
                    MessageBox.Show("Xóa role thành công!");
                    dgvRoles.DataSource = RoleDAO.GetAllRoles();
                    txtRoleName.Clear();
                }
            }
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            string roleName = txtRoleName.Text.Trim().ToUpper();
            string newPassword = txtRolePassword.Text.Trim();

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Vui lòng chọn role cần cập nhật!");
                return;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới cho role!");
                return;
            }

            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = $"ALTER ROLE {roleName} IDENTIFIED BY \"{newPassword}\"";
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật mật khẩu role thành công!");
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi cập nhật role: " + ex.Message);
                }
            }
        }

        private void btnGrantRole_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToUpper();
            string roleName = txtRoleName.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Vui lòng nhập username và role cần gán!");
                return;
            }

            if (RoleDAO.GrantRoleToUser(username, roleName))
            {
                MessageBox.Show($"Đã gán role {roleName} cho user {username}!");
            }
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToUpper();
            string roleName = txtRoleName.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Vui lòng nhập username và role cần thu hồi!");
                return;
            }

            if (RoleDAO.RevokeRoleFromUser(username, roleName))
            {
                MessageBox.Show($"Đã thu hồi role {roleName} khỏi user {username}!");
            }
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvRoles.Rows[e.RowIndex];

            txtRoleName.Text = row.Cells["ROLE"].Value?.ToString().Trim();

            // 🔹 Reset các trường không có trong bảng (nếu cần)
            txtPassword.Text = "";
        }

        #endregion
        private List<string> GetList(string query)
        {
            var list = new List<string>();
            using (var conn = DataProvider.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = query;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(reader.GetString(0));
                }
            }
            return list;
        }
    }
}

