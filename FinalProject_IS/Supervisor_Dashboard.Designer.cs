namespace FinalProject_IS
{
    partial class Supervisor_Dashboard
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
            this.tabUserActivities = new System.Windows.Forms.TabPage();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbActionType = new System.Windows.Forms.ComboBox();
            this.cbUsername = new System.Windows.Forms.ComboBox();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.txtFindUser = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbAuditTable = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvUserActivities = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAuditLogs = new System.Windows.Forms.TabPage();
            this.dgvAudit = new System.Windows.Forms.DataGridView();
            this.ManageTab = new System.Windows.Forms.TabControl();
            this.tabChangeActivities = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_day = new System.Windows.Forms.ComboBox();
            this.cb_actions = new System.Windows.Forms.ComboBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_audit_table = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgv_changeAudit = new System.Windows.Forms.DataGridView();
            this.tabUserActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserActivities)).BeginInit();
            this.tabAuditLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).BeginInit();
            this.ManageTab.SuspendLayout();
            this.tabChangeActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_changeAudit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUserActivities
            // 
            this.tabUserActivities.Controls.Add(this.txtYear);
            this.tabUserActivities.Controls.Add(this.label4);
            this.tabUserActivities.Controls.Add(this.label3);
            this.tabUserActivities.Controls.Add(this.cbMonth);
            this.tabUserActivities.Controls.Add(this.label2);
            this.tabUserActivities.Controls.Add(this.cbDay);
            this.tabUserActivities.Controls.Add(this.cbActionType);
            this.tabUserActivities.Controls.Add(this.cbUsername);
            this.tabUserActivities.Controls.Add(this.btnFindUser);
            this.tabUserActivities.Controls.Add(this.txtFindUser);
            this.tabUserActivities.Controls.Add(this.label14);
            this.tabUserActivities.Controls.Add(this.cbAuditTable);
            this.tabUserActivities.Controls.Add(this.label9);
            this.tabUserActivities.Controls.Add(this.label7);
            this.tabUserActivities.Controls.Add(this.dgvUserActivities);
            this.tabUserActivities.Controls.Add(this.label1);
            this.tabUserActivities.Location = new System.Drawing.Point(4, 31);
            this.tabUserActivities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUserActivities.Name = "tabUserActivities";
            this.tabUserActivities.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUserActivities.Size = new System.Drawing.Size(1419, 655);
            this.tabUserActivities.TabIndex = 1;
            this.tabUserActivities.Text = "User Activities";
            this.tabUserActivities.UseVisualStyleBackColor = true;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(1105, 87);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(198, 28);
            this.txtYear.TabIndex = 95;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(899, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 94;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(498, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 92;
            this.label3.Text = "Month";
            // 
            // cbMonth
            // 
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(660, 87);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(195, 30);
            this.cbMonth.TabIndex = 91;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 90;
            this.label2.Text = "Day";
            // 
            // cbDay
            // 
            this.cbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(212, 84);
            this.cbDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(204, 30);
            this.cbDay.TabIndex = 89;
            // 
            // cbActionType
            // 
            this.cbActionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActionType.FormattingEnabled = true;
            this.cbActionType.Items.AddRange(new object[] {
            "ALL",
            "SELECT",
            "UPDATE",
            "INSERT",
            "DELETE"});
            this.cbActionType.Location = new System.Drawing.Point(660, 17);
            this.cbActionType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbActionType.Name = "cbActionType";
            this.cbActionType.Size = new System.Drawing.Size(195, 30);
            this.cbActionType.TabIndex = 88;
            // 
            // cbUsername
            // 
            this.cbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsername.FormattingEnabled = true;
            this.cbUsername.Location = new System.Drawing.Point(212, 17);
            this.cbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Size = new System.Drawing.Size(204, 30);
            this.cbUsername.TabIndex = 87;
            // 
            // btnFindUser
            // 
            this.btnFindUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.Location = new System.Drawing.Point(1008, 144);
            this.btnFindUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(133, 39);
            this.btnFindUser.TabIndex = 56;
            this.btnFindUser.Text = "FIND";
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // txtFindUser
            // 
            this.txtFindUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindUser.Location = new System.Drawing.Point(521, 146);
            this.txtFindUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFindUser.Name = "txtFindUser";
            this.txtFindUser.Size = new System.Drawing.Size(463, 28);
            this.txtFindUser.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(341, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 22);
            this.label14.TabIndex = 54;
            this.label14.Text = "FIND USER:";
            // 
            // cbAuditTable
            // 
            this.cbAuditTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuditTable.FormattingEnabled = true;
            this.cbAuditTable.Location = new System.Drawing.Point(1105, 18);
            this.cbAuditTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAuditTable.Name = "cbAuditTable";
            this.cbAuditTable.Size = new System.Drawing.Size(304, 30);
            this.cbAuditTable.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(492, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 22);
            this.label9.TabIndex = 44;
            this.label9.Text = "ACTIONS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(896, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 22);
            this.label7.TabIndex = 42;
            this.label7.Text = "AUDITED TABLE";
            // 
            // dgvUserActivities
            // 
            this.dgvUserActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserActivities.Location = new System.Drawing.Point(5, 214);
            this.dgvUserActivities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUserActivities.Name = "dgvUserActivities";
            this.dgvUserActivities.RowHeadersWidth = 51;
            this.dgvUserActivities.RowTemplate.Height = 24;
            this.dgvUserActivities.Size = new System.Drawing.Size(1416, 435);
            this.dgvUserActivities.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "USERNAME";
            // 
            // tabAuditLogs
            // 
            this.tabAuditLogs.Controls.Add(this.dgvAudit);
            this.tabAuditLogs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabAuditLogs.Location = new System.Drawing.Point(4, 31);
            this.tabAuditLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAuditLogs.Name = "tabAuditLogs";
            this.tabAuditLogs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAuditLogs.Size = new System.Drawing.Size(1419, 655);
            this.tabAuditLogs.TabIndex = 0;
            this.tabAuditLogs.Text = "Audit Logs";
            this.tabAuditLogs.UseVisualStyleBackColor = true;
            // 
            // dgvAudit
            // 
            this.dgvAudit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudit.Location = new System.Drawing.Point(5, 2);
            this.dgvAudit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAudit.Name = "dgvAudit";
            this.dgvAudit.RowHeadersWidth = 51;
            this.dgvAudit.RowTemplate.Height = 24;
            this.dgvAudit.Size = new System.Drawing.Size(1405, 646);
            this.dgvAudit.TabIndex = 9;
            // 
            // ManageTab
            // 
            this.ManageTab.Controls.Add(this.tabAuditLogs);
            this.ManageTab.Controls.Add(this.tabUserActivities);
            this.ManageTab.Controls.Add(this.tabChangeActivities);
            this.ManageTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageTab.Location = new System.Drawing.Point(12, 12);
            this.ManageTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManageTab.Name = "ManageTab";
            this.ManageTab.SelectedIndex = 0;
            this.ManageTab.Size = new System.Drawing.Size(1427, 690);
            this.ManageTab.TabIndex = 6;
            // 
            // tabChangeActivities
            // 
            this.tabChangeActivities.Controls.Add(this.label13);
            this.tabChangeActivities.Controls.Add(this.label12);
            this.tabChangeActivities.Controls.Add(this.txt_year);
            this.tabChangeActivities.Controls.Add(this.label5);
            this.tabChangeActivities.Controls.Add(this.cb_month);
            this.tabChangeActivities.Controls.Add(this.label6);
            this.tabChangeActivities.Controls.Add(this.cb_day);
            this.tabChangeActivities.Controls.Add(this.cb_actions);
            this.tabChangeActivities.Controls.Add(this.btn_find);
            this.tabChangeActivities.Controls.Add(this.txt_username);
            this.tabChangeActivities.Controls.Add(this.label8);
            this.tabChangeActivities.Controls.Add(this.cb_audit_table);
            this.tabChangeActivities.Controls.Add(this.label10);
            this.tabChangeActivities.Controls.Add(this.dtgv_changeAudit);
            this.tabChangeActivities.Location = new System.Drawing.Point(4, 31);
            this.tabChangeActivities.Name = "tabChangeActivities";
            this.tabChangeActivities.Size = new System.Drawing.Size(1419, 655);
            this.tabChangeActivities.TabIndex = 2;
            this.tabChangeActivities.Text = "Change Audit";
            this.tabChangeActivities.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(932, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 22);
            this.label13.TabIndex = 111;
            this.label13.Text = "Year";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(776, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 22);
            this.label12.TabIndex = 110;
            this.label12.Text = "AUDITED TABLE";
            // 
            // txt_year
            // 
            this.txt_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_year.Location = new System.Drawing.Point(1101, 81);
            this.txt_year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(198, 28);
            this.txt_year.TabIndex = 109;
            this.txt_year.TextChanged += new System.EventHandler(this.txt_Year_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(494, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 108;
            this.label5.Text = "Month";
            // 
            // cb_month
            // 
            this.cb_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Location = new System.Drawing.Point(656, 81);
            this.cb_month.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(195, 30);
            this.cb_month.TabIndex = 107;
            this.cb_month.SelectedIndexChanged += new System.EventHandler(this.cb_Month_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(4, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 106;
            this.label6.Text = "Day";
            // 
            // cb_day
            // 
            this.cb_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_day.FormattingEnabled = true;
            this.cb_day.Location = new System.Drawing.Point(208, 78);
            this.cb_day.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_day.Name = "cb_day";
            this.cb_day.Size = new System.Drawing.Size(204, 30);
            this.cb_day.TabIndex = 105;
            // 
            // cb_actions
            // 
            this.cb_actions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_actions.FormattingEnabled = true;
            this.cb_actions.Items.AddRange(new object[] {
            "ALL",
            "SELECT",
            "UPDATE",
            "INSERT",
            "DELETE"});
            this.cb_actions.Location = new System.Drawing.Point(358, 7);
            this.cb_actions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_actions.Name = "cb_actions";
            this.cb_actions.Size = new System.Drawing.Size(195, 30);
            this.cb_actions.TabIndex = 104;
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.Location = new System.Drawing.Point(1004, 138);
            this.btn_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(133, 39);
            this.btn_find.TabIndex = 102;
            this.btn_find.Text = "FIND";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(517, 140);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(463, 28);
            this.txt_username.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(337, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 22);
            this.label8.TabIndex = 100;
            this.label8.Text = "FIND USER:";
            // 
            // cb_audit_table
            // 
            this.cb_audit_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_audit_table.FormattingEnabled = true;
            this.cb_audit_table.Location = new System.Drawing.Point(970, 12);
            this.cb_audit_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_audit_table.Name = "cb_audit_table";
            this.cb_audit_table.Size = new System.Drawing.Size(304, 30);
            this.cb_audit_table.TabIndex = 99;
            this.cb_audit_table.SelectedIndexChanged += new System.EventHandler(this.cb_audit_table_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(229, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 98;
            this.label10.Text = "ACTIONS";
            // 
            // dtgv_changeAudit
            // 
            this.dtgv_changeAudit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_changeAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_changeAudit.Location = new System.Drawing.Point(1, 208);
            this.dtgv_changeAudit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_changeAudit.Name = "dtgv_changeAudit";
            this.dtgv_changeAudit.RowHeadersWidth = 51;
            this.dtgv_changeAudit.RowTemplate.Height = 24;
            this.dtgv_changeAudit.Size = new System.Drawing.Size(1416, 435);
            this.dtgv_changeAudit.TabIndex = 97;
            // 
            // Supervisor_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 714);
            this.Controls.Add(this.ManageTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Supervisor_Dashboard";
            this.Text = "Supervisor_Dashboard";
            this.Load += new System.EventHandler(this.Supervisor_Dashboard_Load);
            this.tabUserActivities.ResumeLayout(false);
            this.tabUserActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserActivities)).EndInit();
            this.tabAuditLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).EndInit();
            this.ManageTab.ResumeLayout(false);
            this.tabChangeActivities.ResumeLayout(false);
            this.tabChangeActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_changeAudit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabUserActivities;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbAuditTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvUserActivities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAuditLogs;
        private System.Windows.Forms.DataGridView dgvAudit;
        private System.Windows.Forms.TabControl ManageTab;
        public System.Windows.Forms.ComboBox cbUsername;
        private System.Windows.Forms.ComboBox cbActionType;
        public System.Windows.Forms.TextBox txtFindUser;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbMonth;
        public System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TabPage tabChangeActivities;
        public System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cb_day;
        private System.Windows.Forms.ComboBox cb_actions;
        private System.Windows.Forms.Button btn_find;
        public System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_audit_table;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgv_changeAudit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}