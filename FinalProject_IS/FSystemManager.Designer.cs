namespace FinalProject_IS
{
    partial class FSystemManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ManageTab = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.tabUserRole = new System.Windows.Forms.TabPage();
            this.gbRole = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.txtRolePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGrantRole = new System.Windows.Forms.Button();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.clbRoles = new System.Windows.Forms.CheckedListBox();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbTempTS = new System.Windows.Forms.ComboBox();
            this.cbDefaultTS = new System.Windows.Forms.ComboBox();
            this.txtQuota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnLoadUsers = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tabPolicy = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.ManageTab.SuspendLayout();
            this.tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            this.tabUserRole.SuspendLayout();
            this.gbRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabPolicy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageTab
            // 
            this.ManageTab.Controls.Add(this.tabProfile);
            this.ManageTab.Controls.Add(this.tabUserRole);
            this.ManageTab.Controls.Add(this.tabPolicy);
            this.ManageTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageTab.Location = new System.Drawing.Point(12, 12);
            this.ManageTab.Name = "ManageTab";
            this.ManageTab.SelectedIndex = 0;
            this.ManageTab.Size = new System.Drawing.Size(1426, 690);
            this.ManageTab.TabIndex = 5;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.dgvProfiles);
            this.tabProfile.Location = new System.Drawing.Point(4, 34);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(1418, 652);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // dgvProfiles
            // 
            this.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfiles.Location = new System.Drawing.Point(6, 201);
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.RowHeadersWidth = 51;
            this.dgvProfiles.RowTemplate.Height = 24;
            this.dgvProfiles.Size = new System.Drawing.Size(1406, 445);
            this.dgvProfiles.TabIndex = 9;
            // 
            // tabUserRole
            // 
            this.tabUserRole.Controls.Add(this.gbRole);
            this.tabUserRole.Controls.Add(this.gbUser);
            this.tabUserRole.Location = new System.Drawing.Point(4, 34);
            this.tabUserRole.Name = "tabUserRole";
            this.tabUserRole.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserRole.Size = new System.Drawing.Size(1418, 652);
            this.tabUserRole.TabIndex = 1;
            this.tabUserRole.Text = "User/Role";
            this.tabUserRole.UseVisualStyleBackColor = true;
            // 
            // gbRole
            // 
            this.gbRole.Controls.Add(this.btnUpdateRole);
            this.gbRole.Controls.Add(this.btnRevoke);
            this.gbRole.Controls.Add(this.label5);
            this.gbRole.Controls.Add(this.cboUsers);
            this.gbRole.Controls.Add(this.txtRolePassword);
            this.gbRole.Controls.Add(this.label4);
            this.gbRole.Controls.Add(this.dgvRoles);
            this.gbRole.Controls.Add(this.label3);
            this.gbRole.Controls.Add(this.btnGrantRole);
            this.gbRole.Controls.Add(this.txtRoleName);
            this.gbRole.Controls.Add(this.btnDeleteRole);
            this.gbRole.Controls.Add(this.btnCreateRole);
            this.gbRole.Location = new System.Drawing.Point(726, 6);
            this.gbRole.Name = "gbRole";
            this.gbRole.Size = new System.Drawing.Size(686, 640);
            this.gbRole.TabIndex = 11;
            this.gbRole.TabStop = false;
            this.gbRole.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Choose User:";
            // 
            // cboUsers
            // 
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(454, 125);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(226, 33);
            this.cboUsers.TabIndex = 21;
            // 
            // txtRolePassword
            // 
            this.txtRolePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRolePassword.Location = new System.Drawing.Point(167, 78);
            this.txtRolePassword.Name = "txtRolePassword";
            this.txtRolePassword.Size = new System.Drawing.Size(348, 27);
            this.txtRolePassword.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Role Password";
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(6, 274);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 24;
            this.dgvRoles.Size = new System.Drawing.Size(674, 360);
            this.dgvRoles.TabIndex = 17;
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Role name";
            // 
            // btnGrantRole
            // 
            this.btnGrantRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantRole.Location = new System.Drawing.Point(454, 242);
            this.btnGrantRole.Name = "btnGrantRole";
            this.btnGrantRole.Size = new System.Drawing.Size(95, 26);
            this.btnGrantRole.TabIndex = 18;
            this.btnGrantRole.Text = "Grant";
            this.btnGrantRole.UseVisualStyleBackColor = true;
            this.btnGrantRole.Click += new System.EventHandler(this.btnGrantRole_Click);
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleName.Location = new System.Drawing.Point(167, 34);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(348, 27);
            this.txtRoleName.TabIndex = 16;
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRole.Location = new System.Drawing.Point(6, 188);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(100, 26);
            this.btnDeleteRole.TabIndex = 17;
            this.btnDeleteRole.Text = "Delete";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRole.Location = new System.Drawing.Point(6, 130);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(100, 26);
            this.btnCreateRole.TabIndex = 16;
            this.btnCreateRole.Text = "Create";
            this.btnCreateRole.UseVisualStyleBackColor = true;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.clbRoles);
            this.gbUser.Controls.Add(this.cbProfile);
            this.gbUser.Controls.Add(this.cbStatus);
            this.gbUser.Controls.Add(this.cbTempTS);
            this.gbUser.Controls.Add(this.cbDefaultTS);
            this.gbUser.Controls.Add(this.txtQuota);
            this.gbUser.Controls.Add(this.label11);
            this.gbUser.Controls.Add(this.label10);
            this.gbUser.Controls.Add(this.label9);
            this.gbUser.Controls.Add(this.label8);
            this.gbUser.Controls.Add(this.label7);
            this.gbUser.Controls.Add(this.label6);
            this.gbUser.Controls.Add(this.dgvUsers);
            this.gbUser.Controls.Add(this.btnLoadUsers);
            this.gbUser.Controls.Add(this.btnUpdate);
            this.gbUser.Controls.Add(this.btnCreateUser);
            this.gbUser.Controls.Add(this.txtPassword);
            this.gbUser.Controls.Add(this.label2);
            this.gbUser.Controls.Add(this.label1);
            this.gbUser.Controls.Add(this.btnDeleteUser);
            this.gbUser.Controls.Add(this.txtUsername);
            this.gbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUser.Location = new System.Drawing.Point(6, 6);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(714, 640);
            this.gbUser.TabIndex = 4;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User";
            // 
            // clbRoles
            // 
            this.clbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbRoles.FormattingEnabled = true;
            this.clbRoles.Location = new System.Drawing.Point(456, 104);
            this.clbRoles.Name = "clbRoles";
            this.clbRoles.Size = new System.Drawing.Size(252, 140);
            this.clbRoles.TabIndex = 30;
            // 
            // cbProfile
            // 
            this.cbProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(456, 65);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(252, 24);
            this.cbProfile.TabIndex = 29;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "UNLOCK",
            "LOCK"});
            this.cbStatus.Location = new System.Drawing.Point(536, 26);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(172, 24);
            this.cbStatus.TabIndex = 28;
            // 
            // cbTempTS
            // 
            this.cbTempTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTempTS.FormattingEnabled = true;
            this.cbTempTS.Location = new System.Drawing.Point(217, 135);
            this.cbTempTS.Name = "cbTempTS";
            this.cbTempTS.Size = new System.Drawing.Size(135, 28);
            this.cbTempTS.TabIndex = 27;
            // 
            // cbDefaultTS
            // 
            this.cbDefaultTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefaultTS.FormattingEnabled = true;
            this.cbDefaultTS.Location = new System.Drawing.Point(217, 96);
            this.cbDefaultTS.Name = "cbDefaultTS";
            this.cbDefaultTS.Size = new System.Drawing.Size(135, 28);
            this.cbDefaultTS.TabIndex = 26;
            // 
            // txtQuota
            // 
            this.txtQuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuota.Location = new System.Drawing.Point(217, 174);
            this.txtQuota.Name = "txtQuota";
            this.txtQuota.Size = new System.Drawing.Size(135, 27);
            this.txtQuota.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(382, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Role";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Default Tablespace";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Temporary Tablespace";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Quota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Profile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Account Status";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(6, 274);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(702, 360);
            this.dgvUsers.TabIndex = 18;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // btnLoadUsers
            // 
            this.btnLoadUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadUsers.Location = new System.Drawing.Point(606, 243);
            this.btnLoadUsers.Name = "btnLoadUsers";
            this.btnLoadUsers.Size = new System.Drawing.Size(102, 25);
            this.btnLoadUsers.TabIndex = 17;
            this.btnLoadUsers.Text = "Refresh";
            this.btnLoadUsers.UseVisualStyleBackColor = true;
            this.btnLoadUsers.Click += new System.EventHandler(this.btnLoadUsers_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(250, 243);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 25);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(6, 243);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(89, 25);
            this.btnCreateUser.TabIndex = 14;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(217, 63);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(135, 27);
            this.txtPassword.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(129, 243);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(94, 25);
            this.btnDeleteUser.TabIndex = 10;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(217, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(135, 27);
            this.txtUsername.TabIndex = 9;
            // 
            // tabPolicy
            // 
            this.tabPolicy.Controls.Add(this.dataGridView3);
            this.tabPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPolicy.Location = new System.Drawing.Point(4, 34);
            this.tabPolicy.Name = "tabPolicy";
            this.tabPolicy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPolicy.Size = new System.Drawing.Size(1418, 652);
            this.tabPolicy.TabIndex = 2;
            this.tabPolicy.Text = "Policy";
            this.tabPolicy.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 256);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1406, 390);
            this.dataGridView3.TabIndex = 9;
            // 
            // btnRevoke
            // 
            this.btnRevoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevoke.Location = new System.Drawing.Point(585, 242);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(95, 26);
            this.btnRevoke.TabIndex = 22;
            this.btnRevoke.Text = "Revoke";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRole.Location = new System.Drawing.Point(6, 242);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(100, 26);
            this.btnUpdateRole.TabIndex = 23;
            this.btnUpdateRole.Text = "Update";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // FSystemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 714);
            this.Controls.Add(this.ManageTab);
            this.Name = "FSystemManager";
            this.Text = "FSystemManager";
            this.Load += new System.EventHandler(this.FSystemManager_Load);
            this.ManageTab.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            this.tabUserRole.ResumeLayout(false);
            this.gbRole.ResumeLayout(false);
            this.gbRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabPolicy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ManageTab;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabUserRole;
        private System.Windows.Forms.TabPage tabPolicy;
        private System.Windows.Forms.DataGridView dgvProfiles;
        private System.Windows.Forms.GroupBox gbRole;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGrantRole;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.TextBox txtRolePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox clbRoles;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbTempTS;
        private System.Windows.Forms.ComboBox cbDefaultTS;
        private System.Windows.Forms.TextBox txtQuota;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Button btnRevoke;
    }
}