using System.Drawing;

namespace FinalProject_IS
{
    partial class F_Security_Manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabManager = new System.Windows.Forms.TabControl();
            this.tabPrivileges = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.dgv_privilege = new System.Windows.Forms.DataGridView();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.cbPasswordReuseTime = new System.Windows.Forms.ComboBox();
            this.cbPasswordGraceTime = new System.Windows.Forms.ComboBox();
            this.cbFailedLoginAttempts = new System.Windows.Forms.ComboBox();
            this.btnRefreshUserProfile = new System.Windows.Forms.Button();
            this.btnFindProfile = new System.Windows.Forms.Button();
            this.txtFindProfile = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.clbUserProfile = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbIdleTime = new System.Windows.Forms.ComboBox();
            this.cbPasswordReuseMax = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbConnectTime = new System.Windows.Forms.ComboBox();
            this.cbPasswordLifeTime = new System.Windows.Forms.ComboBox();
            this.cbSessionsPerUser = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnRevokeProfile = new System.Windows.Forms.Button();
            this.btnGrantProfile = new System.Windows.Forms.Button();
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.btnRefreshUserRole = new System.Windows.Forms.Button();
            this.btnFindRole = new System.Windows.Forms.Button();
            this.txtFindRole = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.clbUserRole = new System.Windows.Forms.CheckedListBox();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.btnGrantRole = new System.Windows.Forms.Button();
            this.tabPoliy = new System.Windows.Forms.TabPage();
            this.pn_listapplypolicy = new System.Windows.Forms.Panel();
            this.btn_hide = new System.Windows.Forms.Button();
            this.dgvAppliedPolicies = new System.Windows.Forms.DataGridView();
            this.panel_applypolicy = new System.Windows.Forms.Panel();
            this.txt_policyFuntion = new System.Windows.Forms.TextBox();
            this.btn_hide_policy = new System.Windows.Forms.Button();
            this.btn_applyPolicy = new System.Windows.Forms.Button();
            this.txtSecCols = new System.Windows.Forms.TextBox();
            this.txtPolicyName = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sec_relevant_cols = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.policy_function = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFunctionSchema = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbObjectName = new System.Windows.Forms.ComboBox();
            this.cbObjectSchema = new System.Windows.Forms.ComboBox();
            this.dgvPolicy = new System.Windows.Forms.DataGridView();
            this.tabManager.SuspendLayout();
            this.tabPrivileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_privilege)).BeginInit();
            this.tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            this.tabRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.tabPoliy.SuspendLayout();
            this.pn_listapplypolicy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliedPolicies)).BeginInit();
            this.panel_applypolicy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicy)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManager
            // 
            this.tabManager.Controls.Add(this.tabPrivileges);
            this.tabManager.Controls.Add(this.tabProfile);
            this.tabManager.Controls.Add(this.tabRole);
            this.tabManager.Controls.Add(this.tabPoliy);
            this.tabManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabManager.Location = new System.Drawing.Point(11, 0);
            this.tabManager.Margin = new System.Windows.Forms.Padding(2);
            this.tabManager.Name = "tabManager";
            this.tabManager.SelectedIndex = 0;
            this.tabManager.Size = new System.Drawing.Size(1223, 647);
            this.tabManager.TabIndex = 6;
            this.tabManager.SelectedIndexChanged += new System.EventHandler(this.ManageTab_SelectedIndexChanged);
            // 
            // tabPrivileges
            // 
            this.tabPrivileges.Controls.Add(this.label24);
            this.tabPrivileges.Controls.Add(this.dgv_privilege);
            this.tabPrivileges.Location = new System.Drawing.Point(4, 26);
            this.tabPrivileges.Name = "tabPrivileges";
            this.tabPrivileges.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrivileges.Size = new System.Drawing.Size(1215, 617);
            this.tabPrivileges.TabIndex = 3;
            this.tabPrivileges.Text = "Privileges";
            this.tabPrivileges.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.ForeColor = System.Drawing.Color.Firebrick;
            this.label24.Location = new System.Drawing.Point(393, 62);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(238, 32);
            this.label24.TabIndex = 11;
            this.label24.Text = "Tất cả các quyền mà USER có";
            // 
            // dgv_privilege
            // 
            this.dgv_privilege.AllowUserToAddRows = false;
            this.dgv_privilege.AllowUserToDeleteRows = false;
            this.dgv_privilege.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_privilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_privilege.Location = new System.Drawing.Point(40, 136);
            this.dgv_privilege.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_privilege.Name = "dgv_privilege";
            this.dgv_privilege.ReadOnly = true;
            this.dgv_privilege.RowHeadersWidth = 51;
            this.dgv_privilege.RowTemplate.Height = 24;
            this.dgv_privilege.Size = new System.Drawing.Size(1054, 315);
            this.dgv_privilege.TabIndex = 10;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.lblProfileName);
            this.tabProfile.Controls.Add(this.cbPasswordReuseTime);
            this.tabProfile.Controls.Add(this.cbPasswordGraceTime);
            this.tabProfile.Controls.Add(this.cbFailedLoginAttempts);
            this.tabProfile.Controls.Add(this.btnRefreshUserProfile);
            this.tabProfile.Controls.Add(this.btnFindProfile);
            this.tabProfile.Controls.Add(this.txtFindProfile);
            this.tabProfile.Controls.Add(this.label25);
            this.tabProfile.Controls.Add(this.clbUserProfile);
            this.tabProfile.Controls.Add(this.label13);
            this.tabProfile.Controls.Add(this.cbIdleTime);
            this.tabProfile.Controls.Add(this.cbPasswordReuseMax);
            this.tabProfile.Controls.Add(this.label18);
            this.tabProfile.Controls.Add(this.label22);
            this.tabProfile.Controls.Add(this.label23);
            this.tabProfile.Controls.Add(this.cbConnectTime);
            this.tabProfile.Controls.Add(this.cbPasswordLifeTime);
            this.tabProfile.Controls.Add(this.cbSessionsPerUser);
            this.tabProfile.Controls.Add(this.label15);
            this.tabProfile.Controls.Add(this.label16);
            this.tabProfile.Controls.Add(this.label17);
            this.tabProfile.Controls.Add(this.label19);
            this.tabProfile.Controls.Add(this.label20);
            this.tabProfile.Controls.Add(this.label21);
            this.tabProfile.Controls.Add(this.txtProfileName);
            this.tabProfile.Controls.Add(this.btnUpdateProfile);
            this.tabProfile.Controls.Add(this.btnRevokeProfile);
            this.tabProfile.Controls.Add(this.btnGrantProfile);
            this.tabProfile.Controls.Add(this.dgvProfiles);
            this.tabProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabProfile.Location = new System.Drawing.Point(4, 26);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(2);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(2);
            this.tabProfile.Size = new System.Drawing.Size(1215, 617);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(1173, 597);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(46, 18);
            this.lblProfileName.TabIndex = 89;
            this.lblProfileName.Text = "label1";
            this.lblProfileName.Visible = false;
            // 
            // cbPasswordReuseTime
            // 
            this.cbPasswordReuseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPasswordReuseTime.FormattingEnabled = true;
            this.cbPasswordReuseTime.Location = new System.Drawing.Point(588, 106);
            this.cbPasswordReuseTime.Margin = new System.Windows.Forms.Padding(2);
            this.cbPasswordReuseTime.Name = "cbPasswordReuseTime";
            this.cbPasswordReuseTime.Size = new System.Drawing.Size(116, 25);
            this.cbPasswordReuseTime.TabIndex = 88;
            // 
            // cbPasswordGraceTime
            // 
            this.cbPasswordGraceTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPasswordGraceTime.FormattingEnabled = true;
            this.cbPasswordGraceTime.Location = new System.Drawing.Point(588, 15);
            this.cbPasswordGraceTime.Margin = new System.Windows.Forms.Padding(2);
            this.cbPasswordGraceTime.Name = "cbPasswordGraceTime";
            this.cbPasswordGraceTime.Size = new System.Drawing.Size(116, 25);
            this.cbPasswordGraceTime.TabIndex = 87;
            // 
            // cbFailedLoginAttempts
            // 
            this.cbFailedLoginAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFailedLoginAttempts.FormattingEnabled = true;
            this.cbFailedLoginAttempts.Location = new System.Drawing.Point(210, 44);
            this.cbFailedLoginAttempts.Margin = new System.Windows.Forms.Padding(2);
            this.cbFailedLoginAttempts.Name = "cbFailedLoginAttempts";
            this.cbFailedLoginAttempts.Size = new System.Drawing.Size(121, 25);
            this.cbFailedLoginAttempts.TabIndex = 86;
            // 
            // btnRefreshUserProfile
            // 
            this.btnRefreshUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUserProfile.Location = new System.Drawing.Point(724, 91);
            this.btnRefreshUserProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshUserProfile.Name = "btnRefreshUserProfile";
            this.btnRefreshUserProfile.Size = new System.Drawing.Size(100, 32);
            this.btnRefreshUserProfile.TabIndex = 85;
            this.btnRefreshUserProfile.Text = "REFRESH";
            this.btnRefreshUserProfile.UseVisualStyleBackColor = true;
            // 
            // btnFindProfile
            // 
            this.btnFindProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindProfile.Location = new System.Drawing.Point(724, 175);
            this.btnFindProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindProfile.Name = "btnFindProfile";
            this.btnFindProfile.Size = new System.Drawing.Size(100, 32);
            this.btnFindProfile.TabIndex = 80;
            this.btnFindProfile.Text = "FIND";
            this.btnFindProfile.UseVisualStyleBackColor = true;
            // 
            // txtFindProfile
            // 
            this.txtFindProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindProfile.Location = new System.Drawing.Point(373, 180);
            this.txtFindProfile.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindProfile.Name = "txtFindProfile";
            this.txtFindProfile.Size = new System.Drawing.Size(348, 24);
            this.txtFindProfile.TabIndex = 79;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label25.Location = new System.Drawing.Point(370, 155);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 18);
            this.label25.TabIndex = 78;
            this.label25.Text = "FIND PROFILE:";
            // 
            // clbUserProfile
            // 
            this.clbUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbUserProfile.FormattingEnabled = true;
            this.clbUserProfile.Location = new System.Drawing.Point(856, 44);
            this.clbUserProfile.Margin = new System.Windows.Forms.Padding(2);
            this.clbUserProfile.Name = "clbUserProfile";
            this.clbUserProfile.Size = new System.Drawing.Size(229, 99);
            this.clbUserProfile.TabIndex = 77;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(717, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 18);
            this.label13.TabIndex = 76;
            this.label13.Text = "CHOOSE USER";
            // 
            // cbIdleTime
            // 
            this.cbIdleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdleTime.FormattingEnabled = true;
            this.cbIdleTime.Location = new System.Drawing.Point(588, 74);
            this.cbIdleTime.Margin = new System.Windows.Forms.Padding(2);
            this.cbIdleTime.Name = "cbIdleTime";
            this.cbIdleTime.Size = new System.Drawing.Size(116, 25);
            this.cbIdleTime.TabIndex = 75;
            // 
            // cbPasswordReuseMax
            // 
            this.cbPasswordReuseMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPasswordReuseMax.FormattingEnabled = true;
            this.cbPasswordReuseMax.Location = new System.Drawing.Point(922, 15);
            this.cbPasswordReuseMax.Margin = new System.Windows.Forms.Padding(2);
            this.cbPasswordReuseMax.Name = "cbPasswordReuseMax";
            this.cbPasswordReuseMax.Size = new System.Drawing.Size(138, 25);
            this.cbPasswordReuseMax.TabIndex = 74;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label18.Location = new System.Drawing.Point(338, 76);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 18);
            this.label18.TabIndex = 71;
            this.label18.Text = "IDLE_TIME (PHÚT)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label22.Location = new System.Drawing.Point(338, 109);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(199, 18);
            this.label22.TabIndex = 70;
            this.label22.Text = "PASSWORD_REUSE_TIME";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label23.Location = new System.Drawing.Point(717, 17);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(200, 18);
            this.label23.TabIndex = 69;
            this.label23.Text = "PASSWORD_REUSE_MAX ";
            // 
            // cbConnectTime
            // 
            this.cbConnectTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConnectTime.FormattingEnabled = true;
            this.cbConnectTime.Location = new System.Drawing.Point(588, 44);
            this.cbConnectTime.Margin = new System.Windows.Forms.Padding(2);
            this.cbConnectTime.Name = "cbConnectTime";
            this.cbConnectTime.Size = new System.Drawing.Size(116, 25);
            this.cbConnectTime.TabIndex = 67;
            // 
            // cbPasswordLifeTime
            // 
            this.cbPasswordLifeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPasswordLifeTime.FormattingEnabled = true;
            this.cbPasswordLifeTime.Location = new System.Drawing.Point(210, 106);
            this.cbPasswordLifeTime.Margin = new System.Windows.Forms.Padding(2);
            this.cbPasswordLifeTime.Name = "cbPasswordLifeTime";
            this.cbPasswordLifeTime.Size = new System.Drawing.Size(121, 25);
            this.cbPasswordLifeTime.TabIndex = 66;
            // 
            // cbSessionsPerUser
            // 
            this.cbSessionsPerUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSessionsPerUser.FormattingEnabled = true;
            this.cbSessionsPerUser.Location = new System.Drawing.Point(210, 74);
            this.cbSessionsPerUser.Margin = new System.Windows.Forms.Padding(2);
            this.cbSessionsPerUser.Name = "cbSessionsPerUser";
            this.cbSessionsPerUser.Size = new System.Drawing.Size(121, 25);
            this.cbSessionsPerUser.TabIndex = 65;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.Location = new System.Drawing.Point(6, 69);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 36);
            this.label15.TabIndex = 62;
            this.label15.Text = "SESSIONS_PER_USER \r\n(PHÚT)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label16.Location = new System.Drawing.Point(6, 109);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 36);
            this.label16.TabIndex = 61;
            this.label16.Text = "PASSWORD_LIFE_TIME\r\n(PHÚT)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label17.Location = new System.Drawing.Point(338, 11);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 36);
            this.label17.TabIndex = 60;
            this.label17.Text = "PASSWORD_GRACE_TIME\r\n(PHÚT)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label19.Location = new System.Drawing.Point(338, 46);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(181, 18);
            this.label19.TabIndex = 58;
            this.label19.Text = "CONNECT_TIME (PHÚT)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(6, 46);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(203, 18);
            this.label20.TabIndex = 56;
            this.label20.Text = "FAILED_LOGIN_ATTEMPTS ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label21.Location = new System.Drawing.Point(6, 17);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 18);
            this.label21.TabIndex = 55;
            this.label21.Text = "PROFILE NAME";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileName.Location = new System.Drawing.Point(210, 15);
            this.txtProfileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(121, 24);
            this.txtProfileName.TabIndex = 54;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(97, 175);
            this.btnUpdateProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(100, 32);
            this.btnUpdateProfile.TabIndex = 40;
            this.btnUpdateProfile.Text = "UPDATE";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnRevokeProfile
            // 
            this.btnRevokeProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevokeProfile.Location = new System.Drawing.Point(961, 172);
            this.btnRevokeProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnRevokeProfile.Name = "btnRevokeProfile";
            this.btnRevokeProfile.Size = new System.Drawing.Size(99, 32);
            this.btnRevokeProfile.TabIndex = 39;
            this.btnRevokeProfile.Text = "REVOKE";
            this.btnRevokeProfile.UseVisualStyleBackColor = true;
            this.btnRevokeProfile.Click += new System.EventHandler(this.btnRevokeProfile_Click);
            // 
            // btnGrantProfile
            // 
            this.btnGrantProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantProfile.Location = new System.Drawing.Point(857, 172);
            this.btnGrantProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrantProfile.Name = "btnGrantProfile";
            this.btnGrantProfile.Size = new System.Drawing.Size(99, 32);
            this.btnGrantProfile.TabIndex = 38;
            this.btnGrantProfile.Text = "GRANT";
            this.btnGrantProfile.UseVisualStyleBackColor = true;
            this.btnGrantProfile.Click += new System.EventHandler(this.btnGrantProfile_Click);
            // 
            // dgvProfiles
            // 
            this.dgvProfiles.AllowUserToAddRows = false;
            this.dgvProfiles.AllowUserToDeleteRows = false;
            this.dgvProfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfiles.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfiles.Location = new System.Drawing.Point(170, 228);
            this.dgvProfiles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.ReadOnly = true;
            this.dgvProfiles.RowHeadersWidth = 51;
            this.dgvProfiles.RowTemplate.Height = 24;
            this.dgvProfiles.Size = new System.Drawing.Size(796, 315);
            this.dgvProfiles.TabIndex = 26;
            this.dgvProfiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfiles_CellClick);
            this.dgvProfiles.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfiles_CellContentDoubleClick);
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.lblRoleName);
            this.tabRole.Controls.Add(this.btnRefreshUserRole);
            this.tabRole.Controls.Add(this.btnFindRole);
            this.tabRole.Controls.Add(this.txtFindRole);
            this.tabRole.Controls.Add(this.label26);
            this.tabRole.Controls.Add(this.clbUserRole);
            this.tabRole.Controls.Add(this.btnRevoke);
            this.tabRole.Controls.Add(this.label5);
            this.tabRole.Controls.Add(this.dgvRoles);
            this.tabRole.Controls.Add(this.btnGrantRole);
            this.tabRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRole.Location = new System.Drawing.Point(4, 26);
            this.tabRole.Margin = new System.Windows.Forms.Padding(2);
            this.tabRole.Name = "tabRole";
            this.tabRole.Padding = new System.Windows.Forms.Padding(2);
            this.tabRole.Size = new System.Drawing.Size(1215, 617);
            this.tabRole.TabIndex = 2;
            this.tabRole.Text = "Role";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Enabled = false;
            this.lblRoleName.Location = new System.Drawing.Point(5, 2);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(76, 26);
            this.lblRoleName.TabIndex = 85;
            this.lblRoleName.Text = "label1";
            // 
            // btnRefreshUserRole
            // 
            this.btnRefreshUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUserRole.Location = new System.Drawing.Point(350, 62);
            this.btnRefreshUserRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshUserRole.Name = "btnRefreshUserRole";
            this.btnRefreshUserRole.Size = new System.Drawing.Size(100, 32);
            this.btnRefreshUserRole.TabIndex = 84;
            this.btnRefreshUserRole.Text = "REFRESH";
            this.btnRefreshUserRole.UseVisualStyleBackColor = true;
            // 
            // btnFindRole
            // 
            this.btnFindRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindRole.Location = new System.Drawing.Point(537, 184);
            this.btnFindRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindRole.Name = "btnFindRole";
            this.btnFindRole.Size = new System.Drawing.Size(85, 24);
            this.btnFindRole.TabIndex = 83;
            this.btnFindRole.Text = "FIND";
            this.btnFindRole.UseVisualStyleBackColor = true;
            // 
            // txtFindRole
            // 
            this.txtFindRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindRole.Location = new System.Drawing.Point(170, 184);
            this.txtFindRole.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindRole.Name = "txtFindRole";
            this.txtFindRole.Size = new System.Drawing.Size(348, 24);
            this.txtFindRole.TabIndex = 82;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label26.Location = new System.Drawing.Point(167, 164);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 18);
            this.label26.TabIndex = 81;
            this.label26.Text = "FIND ROLE:";
            // 
            // clbUserRole
            // 
            this.clbUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbUserRole.FormattingEnabled = true;
            this.clbUserRole.Location = new System.Drawing.Point(504, 17);
            this.clbUserRole.Margin = new System.Windows.Forms.Padding(2);
            this.clbUserRole.Name = "clbUserRole";
            this.clbUserRole.Size = new System.Drawing.Size(372, 137);
            this.clbUserRole.TabIndex = 61;
            // 
            // btnRevoke
            // 
            this.btnRevoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevoke.Location = new System.Drawing.Point(897, 17);
            this.btnRevoke.Margin = new System.Windows.Forms.Padding(2);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(99, 32);
            this.btnRevoke.TabIndex = 34;
            this.btnRevoke.Text = "REVOKE";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(347, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "CHOOSE USER:";
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(10, 228);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 24;
            this.dgvRoles.Size = new System.Drawing.Size(1201, 315);
            this.dgvRoles.TabIndex = 26;
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick);
            this.dgvRoles.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellContentDoubleClick);
            // 
            // btnGrantRole
            // 
            this.btnGrantRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantRole.Location = new System.Drawing.Point(897, 122);
            this.btnGrantRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrantRole.Name = "btnGrantRole";
            this.btnGrantRole.Size = new System.Drawing.Size(99, 32);
            this.btnGrantRole.TabIndex = 30;
            this.btnGrantRole.Text = "GRANT";
            this.btnGrantRole.UseVisualStyleBackColor = true;
            this.btnGrantRole.Click += new System.EventHandler(this.btnGrantRole_Click);
            // 
            // tabPoliy
            // 
            this.tabPoliy.Controls.Add(this.pn_listapplypolicy);
            this.tabPoliy.Controls.Add(this.panel_applypolicy);
            this.tabPoliy.Controls.Add(this.dgvPolicy);
            this.tabPoliy.Location = new System.Drawing.Point(4, 26);
            this.tabPoliy.Name = "tabPoliy";
            this.tabPoliy.Size = new System.Drawing.Size(1215, 617);
            this.tabPoliy.TabIndex = 4;
            this.tabPoliy.Text = "Policy";
            this.tabPoliy.UseVisualStyleBackColor = true;
            // 
            // pn_listapplypolicy
            // 
            this.pn_listapplypolicy.Controls.Add(this.btn_hide);
            this.pn_listapplypolicy.Controls.Add(this.dgvAppliedPolicies);
            this.pn_listapplypolicy.Location = new System.Drawing.Point(17, 17);
            this.pn_listapplypolicy.Name = "pn_listapplypolicy";
            this.pn_listapplypolicy.Size = new System.Drawing.Size(765, 218);
            this.pn_listapplypolicy.TabIndex = 94;
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(239, 191);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(101, 24);
            this.btn_hide.TabIndex = 1;
            this.btn_hide.Text = "Hide";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // dgvAppliedPolicies
            // 
            this.dgvAppliedPolicies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppliedPolicies.Location = new System.Drawing.Point(3, 3);
            this.dgvAppliedPolicies.Name = "dgvAppliedPolicies";
            this.dgvAppliedPolicies.Size = new System.Drawing.Size(749, 182);
            this.dgvAppliedPolicies.TabIndex = 0;
            this.dgvAppliedPolicies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppliedPolicies_CellClick);
            // 
            // panel_applypolicy
            // 
            this.panel_applypolicy.Controls.Add(this.txt_policyFuntion);
            this.panel_applypolicy.Controls.Add(this.btn_hide_policy);
            this.panel_applypolicy.Controls.Add(this.btn_applyPolicy);
            this.panel_applypolicy.Controls.Add(this.txtSecCols);
            this.panel_applypolicy.Controls.Add(this.txtPolicyName);
            this.panel_applypolicy.Controls.Add(this.checkBox3);
            this.panel_applypolicy.Controls.Add(this.checkBox2);
            this.panel_applypolicy.Controls.Add(this.checkBox1);
            this.panel_applypolicy.Controls.Add(this.sec_relevant_cols);
            this.panel_applypolicy.Controls.Add(this.label7);
            this.panel_applypolicy.Controls.Add(this.policy_function);
            this.panel_applypolicy.Controls.Add(this.label4);
            this.panel_applypolicy.Controls.Add(this.label3);
            this.panel_applypolicy.Controls.Add(this.cbFunctionSchema);
            this.panel_applypolicy.Controls.Add(this.label2);
            this.panel_applypolicy.Controls.Add(this.cbObjectName);
            this.panel_applypolicy.Controls.Add(this.cbObjectSchema);
            this.panel_applypolicy.Location = new System.Drawing.Point(737, 228);
            this.panel_applypolicy.Name = "panel_applypolicy";
            this.panel_applypolicy.Size = new System.Drawing.Size(454, 357);
            this.panel_applypolicy.TabIndex = 93;
            // 
            // txt_policyFuntion
            // 
            this.txt_policyFuntion.Location = new System.Drawing.Point(147, 121);
            this.txt_policyFuntion.Name = "txt_policyFuntion";
            this.txt_policyFuntion.ReadOnly = true;
            this.txt_policyFuntion.Size = new System.Drawing.Size(194, 24);
            this.txt_policyFuntion.TabIndex = 6;
            // 
            // btn_hide_policy
            // 
            this.btn_hide_policy.Location = new System.Drawing.Point(16, 298);
            this.btn_hide_policy.Name = "btn_hide_policy";
            this.btn_hide_policy.Size = new System.Drawing.Size(180, 39);
            this.btn_hide_policy.TabIndex = 5;
            this.btn_hide_policy.Text = "Hide";
            this.btn_hide_policy.UseVisualStyleBackColor = true;
            this.btn_hide_policy.Click += new System.EventHandler(this.btn_hide_policy_Click);
            // 
            // btn_applyPolicy
            // 
            this.btn_applyPolicy.Location = new System.Drawing.Point(259, 298);
            this.btn_applyPolicy.Name = "btn_applyPolicy";
            this.btn_applyPolicy.Size = new System.Drawing.Size(180, 39);
            this.btn_applyPolicy.TabIndex = 5;
            this.btn_applyPolicy.Text = "Apply Policy";
            this.btn_applyPolicy.UseVisualStyleBackColor = true;
            this.btn_applyPolicy.Click += new System.EventHandler(this.btn_applyPolicy_Click);
            // 
            // txtSecCols
            // 
            this.txtSecCols.Location = new System.Drawing.Point(154, 244);
            this.txtSecCols.Name = "txtSecCols";
            this.txtSecCols.Size = new System.Drawing.Size(216, 24);
            this.txtSecCols.TabIndex = 4;
            // 
            // txtPolicyName
            // 
            this.txtPolicyName.Location = new System.Drawing.Point(154, 197);
            this.txtPolicyName.Name = "txtPolicyName";
            this.txtPolicyName.Size = new System.Drawing.Size(216, 24);
            this.txtPolicyName.TabIndex = 4;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(167, 169);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(87, 22);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "UPDATE";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(286, 169);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 22);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "DELETE";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 169);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 22);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "SELECT";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // sec_relevant_cols
            // 
            this.sec_relevant_cols.AutoSize = true;
            this.sec_relevant_cols.Location = new System.Drawing.Point(11, 250);
            this.sec_relevant_cols.Name = "sec_relevant_cols";
            this.sec_relevant_cols.Size = new System.Drawing.Size(127, 18);
            this.sec_relevant_cols.TabIndex = 1;
            this.sec_relevant_cols.Text = "sec_relevant_cols";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "policy_name";
            // 
            // policy_function
            // 
            this.policy_function.AutoSize = true;
            this.policy_function.Location = new System.Drawing.Point(11, 121);
            this.policy_function.Name = "policy_function";
            this.policy_function.Size = new System.Drawing.Size(106, 18);
            this.policy_function.TabIndex = 1;
            this.policy_function.Text = "policy_function";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "function_schema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "object_name";
            // 
            // cbFunctionSchema
            // 
            this.cbFunctionSchema.FormattingEnabled = true;
            this.cbFunctionSchema.Location = new System.Drawing.Point(147, 84);
            this.cbFunctionSchema.Name = "cbFunctionSchema";
            this.cbFunctionSchema.Size = new System.Drawing.Size(194, 25);
            this.cbFunctionSchema.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "object_schema";
            // 
            // cbObjectName
            // 
            this.cbObjectName.FormattingEnabled = true;
            this.cbObjectName.Location = new System.Drawing.Point(147, 46);
            this.cbObjectName.Name = "cbObjectName";
            this.cbObjectName.Size = new System.Drawing.Size(194, 25);
            this.cbObjectName.TabIndex = 0;
            // 
            // cbObjectSchema
            // 
            this.cbObjectSchema.FormattingEnabled = true;
            this.cbObjectSchema.Location = new System.Drawing.Point(147, 8);
            this.cbObjectSchema.Name = "cbObjectSchema";
            this.cbObjectSchema.Size = new System.Drawing.Size(194, 25);
            this.cbObjectSchema.TabIndex = 0;
            // 
            // dgvPolicy
            // 
            this.dgvPolicy.AllowUserToAddRows = false;
            this.dgvPolicy.AllowUserToDeleteRows = false;
            this.dgvPolicy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPolicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolicy.Location = new System.Drawing.Point(26, 240);
            this.dgvPolicy.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPolicy.Name = "dgvPolicy";
            this.dgvPolicy.ReadOnly = true;
            this.dgvPolicy.RowHeadersWidth = 51;
            this.dgvPolicy.RowTemplate.Height = 24;
            this.dgvPolicy.Size = new System.Drawing.Size(706, 307);
            this.dgvPolicy.TabIndex = 85;
            this.dgvPolicy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolicy_CellContentClick);
            this.dgvPolicy.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolicy_CellContentDoubleClick);
            // 
            // F_Security_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 658);
            this.Controls.Add(this.tabManager);
            this.Name = "F_Security_Manager";
            this.Text = "F_Security_Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Security_Manager_FormClosed);
            this.Load += new System.EventHandler(this.F_Security_Manager_Load);
            this.tabManager.ResumeLayout(false);
            this.tabPrivileges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_privilege)).EndInit();
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            this.tabRole.ResumeLayout(false);
            this.tabRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.tabPoliy.ResumeLayout(false);
            this.pn_listapplypolicy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliedPolicies)).EndInit();
            this.panel_applypolicy.ResumeLayout(false);
            this.panel_applypolicy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManager;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.ComboBox cbPasswordReuseTime;
        private System.Windows.Forms.ComboBox cbPasswordGraceTime;
        private System.Windows.Forms.ComboBox cbFailedLoginAttempts;
        private System.Windows.Forms.Button btnRefreshUserProfile;
        private System.Windows.Forms.Button btnFindProfile;
        private System.Windows.Forms.TextBox txtFindProfile;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckedListBox clbUserProfile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbIdleTime;
        private System.Windows.Forms.ComboBox cbPasswordReuseMax;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbConnectTime;
        private System.Windows.Forms.ComboBox cbPasswordLifeTime;
        private System.Windows.Forms.ComboBox cbSessionsPerUser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnRevokeProfile;
        private System.Windows.Forms.Button btnGrantProfile;
        private System.Windows.Forms.DataGridView dgvProfiles;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.Button btnRefreshUserRole;
        private System.Windows.Forms.Button btnFindRole;
        private System.Windows.Forms.TextBox txtFindRole;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckedListBox clbUserRole;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button btnGrantRole;
        private System.Windows.Forms.TabPage tabPrivileges;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dgv_privilege;
        private System.Windows.Forms.TabPage tabPoliy;
        private System.Windows.Forms.DataGridView dgvPolicy;
        private System.Windows.Forms.Panel panel_applypolicy;
        private System.Windows.Forms.Label policy_function;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFunctionSchema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbObjectName;
        private System.Windows.Forms.ComboBox cbObjectSchema;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_applyPolicy;
        private System.Windows.Forms.TextBox txtPolicyName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sec_relevant_cols;
        private System.Windows.Forms.TextBox txtSecCols;
        private System.Windows.Forms.Panel pn_listapplypolicy;
        private System.Windows.Forms.DataGridView dgvAppliedPolicies;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_hide_policy;
        private System.Windows.Forms.TextBox txt_policyFuntion;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label lblProfileName;
    }
}