using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_IS
{
    public partial class F_RoleEditor : Form
    {
        private string roleName;
        private OracleConnection conn;
        private readonly bool canEdit;
        public F_RoleEditor(string role, OracleConnection connection)
        {
            InitializeComponent();
            roleName = role;
            conn = connection;
            lblRoleName.Text = $"Role: {roleName}";
            LoadPrivileges();
        }
  
        
        private void LoadPrivileges()
        {
            // --- System Privileges ---
            string sysSql = "SELECT PRIVILEGE FROM ROLE_SYS_PRIVS WHERE ROLE = :role";
            DataTable dtSys = ExecuteQuery(sysSql);

            // --- Object Privileges ---
            string objSql = "SELECT TABLE_NAME, PRIVILEGE FROM ROLE_TAB_PRIVS WHERE ROLE = :role";
            DataTable dtObj = ExecuteQuery(objSql);

            dgvPrivileges.DataSource = dtSys;
            dgvObjPrivs.DataSource = dtObj;

            // --- Tổng hợp danh sách quyền hiện có (system + object) ---
            var currentPrivs = new List<string>();

            foreach (DataRow row in dtSys.Rows)
                currentPrivs.Add(row["PRIVILEGE"].ToString());

            foreach (DataRow row in dtObj.Rows)
                currentPrivs.Add($"{row["PRIVILEGE"]} ON {row["TABLE_NAME"]}");

            // --- Hiển thị danh sách quyền có thể thu hồi ---
            clbCurrentPrivs.Items.Clear();
            foreach (var p in currentPrivs)
                clbCurrentPrivs.Items.Add(p);

            // --- Lấy toàn bộ quyền hệ thống Oracle có thể cấp ---
            string allSql = "SELECT NAME FROM SYSTEM_PRIVILEGE_MAP ORDER BY NAME";
            DataTable dtAll = ExecuteQuery(allSql);

            var allPrivs = dtAll.AsEnumerable().Select(r => r["NAME"].ToString()).ToList();

            // Chỉ chọn quyền chưa có
            var availablePrivs = allPrivs.Except(dtSys.AsEnumerable()
                .Select(r => r["PRIVILEGE"].ToString())).ToList();

            clbAvailablePrivs.Items.Clear();
            foreach (var p in availablePrivs)
                clbAvailablePrivs.Items.Add(p);
        }

        private DataTable ExecuteQuery(string sql)
        {
            using (var cmd = new OracleCommand(sql, conn))
            {
                cmd.Parameters.Add(new OracleParameter("role", roleName));
                using (var adapter = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        private void btn_GSelected_Click(object sender, EventArgs e)
        {
            foreach (var item in clbAvailablePrivs.CheckedItems)
            {
                string privilege = item.ToString();
                string sql = $"GRANT {privilege} TO {roleName}";

                using (var cmd = new OracleCommand(sql, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi gán quyền {privilege}: {ex.Message}");
                    }
                }
            }

            MessageBox.Show("Đã gán quyền thành công!");
            LoadPrivileges(); // Cập nhật lại danh sách
        }

        private void btn_RSelected_Click(object sender, EventArgs e)
        {
            foreach (var item in clbCurrentPrivs.CheckedItems)
            {
                string privilege = item.ToString();

                // Nếu quyền có dạng "UPDATE ON NHANVIEN" thì phải tách riêng phần TABLE_NAME
                string sql;
                if (privilege.Contains(" ON "))
                {
                    var parts = privilege.Split(new[] { " ON " }, StringSplitOptions.None);
                    string priv = parts[0];
                    string table = parts[1];
                    sql = $"REVOKE {priv} ON {table} FROM {roleName}";
                }
                else
                {
                    sql = $"REVOKE {privilege} FROM {roleName}";
                }

                using (var cmd = new OracleCommand(sql, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi thu hồi {privilege}: {ex.Message}");
                    }
                }
            }

            MessageBox.Show("Đã thu hồi quyền thành công!");
            LoadPrivileges(); // Cập nhật lại danh sách
        }

        private void FormRoleEditor_Load(object sender, EventArgs e)
        {
            btn_GSelected.Enabled = canEdit;
            btn_RSelected.Enabled = canEdit;

            if (!canEdit)
            {
                lbl_Info.Text = "⚠️ Bạn chỉ được xem chứ không có quyền chỉnh sửa role này";
            }

            LoadPrivileges();
        }
    }
}
