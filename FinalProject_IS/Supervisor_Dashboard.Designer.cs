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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUserActivities = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAuditTable = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFindUser = new System.Windows.Forms.TextBox();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.tabAuditLogs = new System.Windows.Forms.TabPage();
            this.dgvAudit = new System.Windows.Forms.DataGridView();
            this.ManageTab = new System.Windows.Forms.TabControl();
            this.cbUsername = new System.Windows.Forms.ComboBox();
            this.cbActionType = new System.Windows.Forms.ComboBox();
            this.tabUserActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserActivities)).BeginInit();
            this.tabAuditLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).BeginInit();
            this.ManageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUserActivities
            // 
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
            this.tabUserActivities.Margin = new System.Windows.Forms.Padding(2);
            this.tabUserActivities.Name = "tabUserActivities";
            this.tabUserActivities.Padding = new System.Windows.Forms.Padding(2);
            this.tabUserActivities.Size = new System.Drawing.Size(1062, 526);
            this.tabUserActivities.TabIndex = 1;
            this.tabUserActivities.Text = "User Activities";
            this.tabUserActivities.UseVisualStyleBackColor = true;
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
            // dgvUserActivities
            // 
            this.dgvUserActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserActivities.Location = new System.Drawing.Point(4, 212);
            this.dgvUserActivities.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUserActivities.Name = "dgvUserActivities";
            this.dgvUserActivities.RowHeadersWidth = 51;
            this.dgvUserActivities.RowTemplate.Height = 24;
            this.dgvUserActivities.Size = new System.Drawing.Size(1062, 315);
            this.dgvUserActivities.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(672, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 22);
            this.label7.TabIndex = 42;
            this.label7.Text = "AUDITED TABLE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(369, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 22);
            this.label9.TabIndex = 44;
            this.label9.Text = "ACTIONS";
            // 
            // cbAuditTable
            // 
            this.cbAuditTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuditTable.FormattingEnabled = true;
            this.cbAuditTable.Location = new System.Drawing.Point(829, 15);
            this.cbAuditTable.Margin = new System.Windows.Forms.Padding(2);
            this.cbAuditTable.Name = "cbAuditTable";
            this.cbAuditTable.Size = new System.Drawing.Size(229, 30);
            this.cbAuditTable.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(256, 122);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 22);
            this.label14.TabIndex = 54;
            this.label14.Text = "FIND USER:";
            // 
            // txtFindUser
            // 
            this.txtFindUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindUser.Location = new System.Drawing.Point(391, 119);
            this.txtFindUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindUser.Name = "txtFindUser";
            this.txtFindUser.Size = new System.Drawing.Size(348, 28);
            this.txtFindUser.TabIndex = 55;
            // 
            // btnFindUser
            // 
            this.btnFindUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.Location = new System.Drawing.Point(756, 117);
            this.btnFindUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(100, 32);
            this.btnFindUser.TabIndex = 56;
            this.btnFindUser.Text = "FIND";
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // tabAuditLogs
            // 
            this.tabAuditLogs.Controls.Add(this.dgvAudit);
            this.tabAuditLogs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabAuditLogs.Location = new System.Drawing.Point(4, 31);
            this.tabAuditLogs.Margin = new System.Windows.Forms.Padding(2);
            this.tabAuditLogs.Name = "tabAuditLogs";
            this.tabAuditLogs.Padding = new System.Windows.Forms.Padding(2);
            this.tabAuditLogs.Size = new System.Drawing.Size(1062, 526);
            this.tabAuditLogs.TabIndex = 0;
            this.tabAuditLogs.Text = "Audit Logs";
            this.tabAuditLogs.UseVisualStyleBackColor = true;
            // 
            // dgvAudit
            // 
            this.dgvAudit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudit.Location = new System.Drawing.Point(4, 2);
            this.dgvAudit.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAudit.Name = "dgvAudit";
            this.dgvAudit.RowHeadersWidth = 51;
            this.dgvAudit.RowTemplate.Height = 24;
            this.dgvAudit.Size = new System.Drawing.Size(1054, 525);
            this.dgvAudit.TabIndex = 9;
            // 
            // ManageTab
            // 
            this.ManageTab.Controls.Add(this.tabAuditLogs);
            this.ManageTab.Controls.Add(this.tabUserActivities);
            this.ManageTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageTab.Location = new System.Drawing.Point(9, 10);
            this.ManageTab.Margin = new System.Windows.Forms.Padding(2);
            this.ManageTab.Name = "ManageTab";
            this.ManageTab.SelectedIndex = 0;
            this.ManageTab.Size = new System.Drawing.Size(1070, 561);
            this.ManageTab.TabIndex = 6;
            // 
            // cbUsername
            // 
            this.cbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsername.FormattingEnabled = true;
            this.cbUsername.Location = new System.Drawing.Point(159, 14);
            this.cbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Size = new System.Drawing.Size(154, 30);
            this.cbUsername.TabIndex = 87;
            // 
            // cbActionType
            // 
            this.cbActionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActionType.FormattingEnabled = true;
            this.cbActionType.Items.AddRange(new object[] {
            "SELECT",
            "UPDATE",
            "INSERT",
            "DELETE"});
            this.cbActionType.Location = new System.Drawing.Point(495, 14);
            this.cbActionType.Margin = new System.Windows.Forms.Padding(2);
            this.cbActionType.Name = "cbActionType";
            this.cbActionType.Size = new System.Drawing.Size(147, 30);
            this.cbActionType.TabIndex = 88;
            // 
            // Supervisor_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 580);
            this.Controls.Add(this.ManageTab);
            this.Name = "Supervisor_Dashboard";
            this.Text = "Supervisor_Dashboard";
            this.Load += new System.EventHandler(this.Supervisor_Dashboard_Load);
            this.tabUserActivities.ResumeLayout(false);
            this.tabUserActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserActivities)).EndInit();
            this.tabAuditLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).EndInit();
            this.ManageTab.ResumeLayout(false);
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
    }
}