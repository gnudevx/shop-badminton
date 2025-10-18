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
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.btnRefreshProfileRole = new System.Windows.Forms.Button();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.txtFindUser = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.btnRefreshUserRole = new System.Windows.Forms.Button();
            this.btnFindRole = new System.Windows.Forms.Button();
            this.txtFindRole = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.clbUserRole = new System.Windows.Forms.CheckedListBox();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRolePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGrantRole = new System.Windows.Forms.Button();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.ManageTab.SuspendLayout();
            this.tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageTab
            // 
            this.ManageTab.Controls.Add(this.tabProfile);
            this.ManageTab.Controls.Add(this.tabUser);
            this.ManageTab.Controls.Add(this.tabRole);
            this.ManageTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageTab.Location = new System.Drawing.Point(7, 11);
            this.ManageTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManageTab.Name = "ManageTab";
            this.ManageTab.SelectedIndex = 0;
            this.ManageTab.Size = new System.Drawing.Size(1070, 561);
            this.ManageTab.TabIndex = 5;
            // 
            // tabProfile
            // 
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
            this.tabProfile.Controls.Add(this.btnDeleteProfile);
            this.tabProfile.Controls.Add(this.btnCreateProfile);
            this.tabProfile.Controls.Add(this.dgvProfiles);
            this.tabProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabProfile.Location = new System.Drawing.Point(4, 31);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabProfile.Size = new System.Drawing.Size(1062, 526);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // cbPasswordReuseTime
            // 
            this.cbPasswordReuseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPasswordReuseTime.FormattingEnabled = true;
            this.cbPasswordReuseTime.Location = new System.Drawing.Point(588, 106);
            this.cbPasswordReuseTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPasswordReuseTime.Name = "cbPasswordReuseTime";
            this.cbPasswordReuseTime.Size = new System.Drawing.Size(116, 30);
            this.cbPasswordReuseTime.TabIndex = 88;
            // 
            // cbPasswordGraceTime
            // 
            this.cbPasswordGraceTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPasswordGraceTime.FormattingEnabled = true;
            this.cbPasswordGraceTime.Location = new System.Drawing.Point(588, 15);
            this.cbPasswordGraceTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPasswordGraceTime.Name = "cbPasswordGraceTime";
            this.cbPasswordGraceTime.Size = new System.Drawing.Size(116, 30);
            this.cbPasswordGraceTime.TabIndex = 87;
            // 
            // cbFailedLoginAttempts
            // 
            this.cbFailedLoginAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFailedLoginAttempts.FormattingEnabled = true;
            this.cbFailedLoginAttempts.Location = new System.Drawing.Point(210, 44);
            this.cbFailedLoginAttempts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFailedLoginAttempts.Name = "cbFailedLoginAttempts";
            this.cbFailedLoginAttempts.Size = new System.Drawing.Size(121, 30);
            this.cbFailedLoginAttempts.TabIndex = 86;
            // 
            // btnRefreshUserProfile
            // 
            this.btnRefreshUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUserProfile.Location = new System.Drawing.Point(724, 91);
            this.btnRefreshUserProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefreshUserProfile.Name = "btnRefreshUserProfile";
            this.btnRefreshUserProfile.Size = new System.Drawing.Size(100, 32);
            this.btnRefreshUserProfile.TabIndex = 85;
            this.btnRefreshUserProfile.Text = "REFRESH";
            this.btnRefreshUserProfile.UseVisualStyleBackColor = true;
            this.btnRefreshUserProfile.Click += new System.EventHandler(this.btnRefreshUserProfile_Click);
            // 
            // btnFindProfile
            // 
            this.btnFindProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindProfile.Location = new System.Drawing.Point(724, 175);
            this.btnFindProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindProfile.Name = "btnFindProfile";
            this.btnFindProfile.Size = new System.Drawing.Size(100, 32);
            this.btnFindProfile.TabIndex = 80;
            this.btnFindProfile.Text = "FIND";
            this.btnFindProfile.UseVisualStyleBackColor = true;
            this.btnFindProfile.Click += new System.EventHandler(this.btnFindProfile_Click);
            // 
            // txtFindProfile
            // 
            this.txtFindProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindProfile.Location = new System.Drawing.Point(373, 184);
            this.txtFindProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFindProfile.Name = "txtFindProfile";
            this.txtFindProfile.Size = new System.Drawing.Size(348, 28);
            this.txtFindProfile.TabIndex = 79;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label25.Location = new System.Drawing.Point(370, 164);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(137, 22);
            this.label25.TabIndex = 78;
            this.label25.Text = "FIND PROFILE:";
            // 
            // clbUserProfile
            // 
            this.clbUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbUserProfile.FormattingEnabled = true;
            this.clbUserProfile.Location = new System.Drawing.Point(831, 46);
            this.clbUserProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clbUserProfile.Name = "clbUserProfile";
            this.clbUserProfile.Size = new System.Drawing.Size(229, 96);
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
            this.label13.Size = new System.Drawing.Size(143, 22);
            this.label13.TabIndex = 76;
            this.label13.Text = "CHOOSE USER";
            // 
            // cbIdleTime
            // 
            this.cbIdleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdleTime.FormattingEnabled = true;
            this.cbIdleTime.Location = new System.Drawing.Point(588, 74);
            this.cbIdleTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbIdleTime.Name = "cbIdleTime";
            this.cbIdleTime.Size = new System.Drawing.Size(116, 30);
            this.cbIdleTime.TabIndex = 75;
            // 
            // cbPasswordReuseMax
            // 
            this.cbPasswordReuseMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPasswordReuseMax.FormattingEnabled = true;
            this.cbPasswordReuseMax.Location = new System.Drawing.Point(922, 15);
            this.cbPasswordReuseMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPasswordReuseMax.Name = "cbPasswordReuseMax";
            this.cbPasswordReuseMax.Size = new System.Drawing.Size(138, 30);
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
            this.label18.Size = new System.Drawing.Size(168, 22);
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
            this.label22.Size = new System.Drawing.Size(239, 22);
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
            this.label23.Size = new System.Drawing.Size(240, 22);
            this.label23.TabIndex = 69;
            this.label23.Text = "PASSWORD_REUSE_MAX ";
            // 
            // cbConnectTime
            // 
            this.cbConnectTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConnectTime.FormattingEnabled = true;
            this.cbConnectTime.Location = new System.Drawing.Point(588, 44);
            this.cbConnectTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbConnectTime.Name = "cbConnectTime";
            this.cbConnectTime.Size = new System.Drawing.Size(116, 30);
            this.cbConnectTime.TabIndex = 67;
            // 
            // cbPasswordLifeTime
            // 
            this.cbPasswordLifeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPasswordLifeTime.FormattingEnabled = true;
            this.cbPasswordLifeTime.Location = new System.Drawing.Point(210, 106);
            this.cbPasswordLifeTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPasswordLifeTime.Name = "cbPasswordLifeTime";
            this.cbPasswordLifeTime.Size = new System.Drawing.Size(121, 30);
            this.cbPasswordLifeTime.TabIndex = 66;
            // 
            // cbSessionsPerUser
            // 
            this.cbSessionsPerUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSessionsPerUser.FormattingEnabled = true;
            this.cbSessionsPerUser.Location = new System.Drawing.Point(210, 74);
            this.cbSessionsPerUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSessionsPerUser.Name = "cbSessionsPerUser";
            this.cbSessionsPerUser.Size = new System.Drawing.Size(121, 30);
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
            this.label15.Size = new System.Drawing.Size(213, 44);
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
            this.label16.Size = new System.Drawing.Size(214, 44);
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
            this.label17.Size = new System.Drawing.Size(241, 44);
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
            this.label19.Size = new System.Drawing.Size(219, 22);
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
            this.label20.Size = new System.Drawing.Size(250, 22);
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
            this.label21.Size = new System.Drawing.Size(142, 22);
            this.label21.TabIndex = 55;
            this.label21.Text = "PROFILE NAME";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileName.Location = new System.Drawing.Point(210, 15);
            this.txtProfileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(121, 28);
            this.txtProfileName.TabIndex = 54;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(213, 175);
            this.btnUpdateProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnRevokeProfile.Location = new System.Drawing.Point(960, 175);
            this.btnRevokeProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnGrantProfile.Location = new System.Drawing.Point(856, 175);
            this.btnGrantProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrantProfile.Name = "btnGrantProfile";
            this.btnGrantProfile.Size = new System.Drawing.Size(99, 32);
            this.btnGrantProfile.TabIndex = 38;
            this.btnGrantProfile.Text = "GRANT";
            this.btnGrantProfile.UseVisualStyleBackColor = true;
            this.btnGrantProfile.Click += new System.EventHandler(this.btnGrantProfile_Click);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProfile.Location = new System.Drawing.Point(109, 175);
            this.btnDeleteProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteProfile.TabIndex = 37;
            this.btnDeleteProfile.Text = "DELETE";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProfile.Location = new System.Drawing.Point(4, 175);
            this.btnCreateProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(100, 32);
            this.btnCreateProfile.TabIndex = 36;
            this.btnCreateProfile.Text = "CREATE";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // dgvProfiles
            // 
            this.dgvProfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfiles.Location = new System.Drawing.Point(4, 212);
            this.dgvProfiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.RowHeadersWidth = 51;
            this.dgvProfiles.RowTemplate.Height = 24;
            this.dgvProfiles.Size = new System.Drawing.Size(1054, 315);
            this.dgvProfiles.TabIndex = 9;
            this.dgvProfiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfiles_CellClick);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.btnRefreshProfileRole);
            this.tabUser.Controls.Add(this.btnFindUser);
            this.tabUser.Controls.Add(this.txtFindUser);
            this.tabUser.Controls.Add(this.label14);
            this.tabUser.Controls.Add(this.label12);
            this.tabUser.Controls.Add(this.clbRoles);
            this.tabUser.Controls.Add(this.cbProfile);
            this.tabUser.Controls.Add(this.cbStatus);
            this.tabUser.Controls.Add(this.cbTempTS);
            this.tabUser.Controls.Add(this.cbDefaultTS);
            this.tabUser.Controls.Add(this.txtQuota);
            this.tabUser.Controls.Add(this.label11);
            this.tabUser.Controls.Add(this.label10);
            this.tabUser.Controls.Add(this.label9);
            this.tabUser.Controls.Add(this.label8);
            this.tabUser.Controls.Add(this.label7);
            this.tabUser.Controls.Add(this.label6);
            this.tabUser.Controls.Add(this.dgvUsers);
            this.tabUser.Controls.Add(this.btnUpdate);
            this.tabUser.Controls.Add(this.btnCreateUser);
            this.tabUser.Controls.Add(this.txtPassword);
            this.tabUser.Controls.Add(this.label2);
            this.tabUser.Controls.Add(this.label1);
            this.tabUser.Controls.Add(this.btnDeleteUser);
            this.tabUser.Controls.Add(this.txtUsername);
            this.tabUser.Location = new System.Drawing.Point(4, 31);
            this.tabUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUser.Size = new System.Drawing.Size(1062, 526);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // btnRefreshProfileRole
            // 
            this.btnRefreshProfileRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProfileRole.Location = new System.Drawing.Point(724, 91);
            this.btnRefreshProfileRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefreshProfileRole.Name = "btnRefreshProfileRole";
            this.btnRefreshProfileRole.Size = new System.Drawing.Size(100, 32);
            this.btnRefreshProfileRole.TabIndex = 86;
            this.btnRefreshProfileRole.Text = "REFRESH";
            this.btnRefreshProfileRole.UseVisualStyleBackColor = true;
            this.btnRefreshProfileRole.Click += new System.EventHandler(this.btnRefreshProfileRole_Click);
            // 
            // btnFindUser
            // 
            this.btnFindUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.Location = new System.Drawing.Point(724, 175);
            this.btnFindUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(100, 32);
            this.btnFindUser.TabIndex = 56;
            this.btnFindUser.Text = "FIND";
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // txtFindUser
            // 
            this.txtFindUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindUser.Location = new System.Drawing.Point(373, 184);
            this.txtFindUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFindUser.Name = "txtFindUser";
            this.txtFindUser.Size = new System.Drawing.Size(348, 28);
            this.txtFindUser.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(370, 164);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 22);
            this.label14.TabIndex = 54;
            this.label14.Text = "FIND USER:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(370, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(222, 22);
            this.label12.TabIndex = 53;
            this.label12.Text = "(NHẬP SỐ M/UNLIMITED)";
            // 
            // clbRoles
            // 
            this.clbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbRoles.FormattingEnabled = true;
            this.clbRoles.Location = new System.Drawing.Point(829, 52);
            this.clbRoles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clbRoles.Name = "clbRoles";
            this.clbRoles.Size = new System.Drawing.Size(229, 142);
            this.clbRoles.TabIndex = 52;
            // 
            // cbProfile
            // 
            this.cbProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(829, 15);
            this.cbProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(229, 30);
            this.cbProfile.TabIndex = 51;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "UNLOCK",
            "LOCK"});
            this.cbStatus.Location = new System.Drawing.Point(574, 99);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(147, 30);
            this.cbStatus.TabIndex = 50;
            // 
            // cbTempTS
            // 
            this.cbTempTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTempTS.FormattingEnabled = true;
            this.cbTempTS.Location = new System.Drawing.Point(574, 15);
            this.cbTempTS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTempTS.Name = "cbTempTS";
            this.cbTempTS.Size = new System.Drawing.Size(147, 30);
            this.cbTempTS.TabIndex = 49;
            // 
            // cbDefaultTS
            // 
            this.cbDefaultTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefaultTS.FormattingEnabled = true;
            this.cbDefaultTS.Location = new System.Drawing.Point(194, 95);
            this.cbDefaultTS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDefaultTS.Name = "cbDefaultTS";
            this.cbDefaultTS.Size = new System.Drawing.Size(154, 30);
            this.cbDefaultTS.TabIndex = 48;
            // 
            // txtQuota
            // 
            this.txtQuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuota.Location = new System.Drawing.Point(574, 54);
            this.txtQuota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuota.Name = "txtQuota";
            this.txtQuota.Size = new System.Drawing.Size(147, 28);
            this.txtQuota.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(752, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 22);
            this.label11.TabIndex = 46;
            this.label11.Text = "ROLE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(8, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 22);
            this.label10.TabIndex = 45;
            this.label10.Text = "DEFAULT TABLESPACE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(369, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 22);
            this.label9.TabIndex = 44;
            this.label9.Text = "TEMPORARY TABLESPACE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(369, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 43;
            this.label8.Text = "QUOTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(752, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 42;
            this.label7.Text = "PROFILE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(369, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 22);
            this.label6.TabIndex = 41;
            this.label6.Text = "ACCOUNT STATUS";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(4, 212);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1062, 315);
            this.dgvUsers.TabIndex = 40;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(213, 175);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 32);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(4, 175);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(100, 32);
            this.btnCreateUser.TabIndex = 37;
            this.btnCreateUser.Text = "CREATE";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(194, 54);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(154, 28);
            this.txtPassword.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "USERNAME";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(109, 175);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteUser.TabIndex = 33;
            this.btnDeleteUser.Text = "DELETE";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(194, 15);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(154, 28);
            this.txtUsername.TabIndex = 32;
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.btnRefreshUserRole);
            this.tabRole.Controls.Add(this.btnFindRole);
            this.tabRole.Controls.Add(this.txtFindRole);
            this.tabRole.Controls.Add(this.label26);
            this.tabRole.Controls.Add(this.clbUserRole);
            this.tabRole.Controls.Add(this.btnUpdateRole);
            this.tabRole.Controls.Add(this.btnRevoke);
            this.tabRole.Controls.Add(this.label5);
            this.tabRole.Controls.Add(this.txtRolePassword);
            this.tabRole.Controls.Add(this.label4);
            this.tabRole.Controls.Add(this.dgvRoles);
            this.tabRole.Controls.Add(this.label3);
            this.tabRole.Controls.Add(this.btnGrantRole);
            this.tabRole.Controls.Add(this.txtRoleName);
            this.tabRole.Controls.Add(this.btnDeleteRole);
            this.tabRole.Controls.Add(this.btnCreateRole);
            this.tabRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRole.Location = new System.Drawing.Point(4, 31);
            this.tabRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRole.Name = "tabRole";
            this.tabRole.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRole.Size = new System.Drawing.Size(1062, 526);
            this.tabRole.TabIndex = 2;
            this.tabRole.Text = "Role";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // btnRefreshUserRole
            // 
            this.btnRefreshUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUserRole.Location = new System.Drawing.Point(564, 50);
            this.btnRefreshUserRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefreshUserRole.Name = "btnRefreshUserRole";
            this.btnRefreshUserRole.Size = new System.Drawing.Size(100, 32);
            this.btnRefreshUserRole.TabIndex = 84;
            this.btnRefreshUserRole.Text = "REFRESH";
            this.btnRefreshUserRole.UseVisualStyleBackColor = true;
            this.btnRefreshUserRole.Click += new System.EventHandler(this.btnRefreshUserRole_Click);
            // 
            // btnFindRole
            // 
            this.btnFindRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindRole.Location = new System.Drawing.Point(724, 175);
            this.btnFindRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindRole.Name = "btnFindRole";
            this.btnFindRole.Size = new System.Drawing.Size(100, 32);
            this.btnFindRole.TabIndex = 83;
            this.btnFindRole.Text = "FIND";
            this.btnFindRole.UseVisualStyleBackColor = true;
            this.btnFindRole.Click += new System.EventHandler(this.btnFindRole_Click);
            // 
            // txtFindRole
            // 
            this.txtFindRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindRole.Location = new System.Drawing.Point(373, 184);
            this.txtFindRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFindRole.Name = "txtFindRole";
            this.txtFindRole.Size = new System.Drawing.Size(348, 28);
            this.txtFindRole.TabIndex = 82;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label26.Location = new System.Drawing.Point(370, 164);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(110, 22);
            this.label26.TabIndex = 81;
            this.label26.Text = "FIND ROLE:";
            // 
            // clbUserRole
            // 
            this.clbUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbUserRole.FormattingEnabled = true;
            this.clbUserRole.Location = new System.Drawing.Point(688, 17);
            this.clbUserRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clbUserRole.Name = "clbUserRole";
            this.clbUserRole.Size = new System.Drawing.Size(372, 142);
            this.clbUserRole.TabIndex = 61;
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRole.Location = new System.Drawing.Point(213, 175);
            this.btnUpdateRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(100, 32);
            this.btnUpdateRole.TabIndex = 35;
            this.btnUpdateRole.Text = "UPDATE";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnRevoke
            // 
            this.btnRevoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevoke.Location = new System.Drawing.Point(960, 175);
            this.btnRevoke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label5.Location = new System.Drawing.Point(561, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "CHOOSE USER:";
            // 
            // txtRolePassword
            // 
            this.txtRolePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRolePassword.Location = new System.Drawing.Point(148, 54);
            this.txtRolePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRolePassword.Name = "txtRolePassword";
            this.txtRolePassword.Size = new System.Drawing.Size(259, 28);
            this.txtRolePassword.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(8, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "ROLE PASSWORD";
            // 
            // dgvRoles
            // 
            this.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(4, 212);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 24;
            this.dgvRoles.Size = new System.Drawing.Size(1054, 315);
            this.dgvRoles.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "ROLE NAME";
            // 
            // btnGrantRole
            // 
            this.btnGrantRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantRole.Location = new System.Drawing.Point(856, 175);
            this.btnGrantRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrantRole.Name = "btnGrantRole";
            this.btnGrantRole.Size = new System.Drawing.Size(99, 32);
            this.btnGrantRole.TabIndex = 30;
            this.btnGrantRole.Text = "GRANT";
            this.btnGrantRole.UseVisualStyleBackColor = true;
            this.btnGrantRole.Click += new System.EventHandler(this.btnGrantRole_Click);
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleName.Location = new System.Drawing.Point(148, 15);
            this.txtRoleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(259, 28);
            this.txtRoleName.TabIndex = 24;
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRole.Location = new System.Drawing.Point(109, 175);
            this.btnDeleteRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(100, 32);
            this.btnDeleteRole.TabIndex = 28;
            this.btnDeleteRole.Text = "DELETE";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRole.Location = new System.Drawing.Point(4, 175);
            this.btnCreateRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(100, 32);
            this.btnCreateRole.TabIndex = 25;
            this.btnCreateRole.Text = "CREATE";
            this.btnCreateRole.UseVisualStyleBackColor = true;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // FSystemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 580);
            this.Controls.Add(this.ManageTab);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FSystemManager";
            this.Text = "FSystemManager";
            this.Load += new System.EventHandler(this.FSystemManager_Load);
            this.ManageTab.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabRole.ResumeLayout(false);
            this.tabRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ManageTab;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.DataGridView dgvProfiles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox clbRoles;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbTempTS;
        private System.Windows.Forms.ComboBox cbDefaultTS;
        private System.Windows.Forms.TextBox txtQuota;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRolePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGrantRole;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.ComboBox cbConnectTime;
        private System.Windows.Forms.ComboBox cbPasswordLifeTime;
        private System.Windows.Forms.ComboBox cbSessionsPerUser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnRevokeProfile;
        private System.Windows.Forms.Button btnGrantProfile;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.ComboBox cbIdleTime;
        private System.Windows.Forms.ComboBox cbPasswordReuseMax;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.TextBox txtFindUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox clbUserProfile;
        private System.Windows.Forms.CheckedListBox clbUserRole;
        private System.Windows.Forms.Button btnFindProfile;
        private System.Windows.Forms.TextBox txtFindProfile;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnFindRole;
        private System.Windows.Forms.TextBox txtFindRole;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnRefreshUserRole;
        private System.Windows.Forms.Button btnRefreshUserProfile;
        private System.Windows.Forms.ComboBox cbPasswordReuseTime;
        private System.Windows.Forms.ComboBox cbPasswordGraceTime;
        private System.Windows.Forms.ComboBox cbFailedLoginAttempts;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Button btnRefreshProfileRole;
    }
}