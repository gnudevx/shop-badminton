namespace FinalProject_IS
{
    partial class F_RoleEditor
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
            this.dgvPrivileges = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.dgvObjPrivs = new System.Windows.Forms.DataGridView();
            this.clbCurrentPrivs = new System.Windows.Forms.CheckedListBox();
            this.clbAvailablePrivs = new System.Windows.Forms.CheckedListBox();
            this.btn_RSelected = new System.Windows.Forms.Button();
            this.btn_GSelected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivileges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjPrivs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrivileges
            // 
            this.dgvPrivileges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrivileges.Location = new System.Drawing.Point(33, 62);
            this.dgvPrivileges.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPrivileges.Name = "dgvPrivileges";
            this.dgvPrivileges.RowHeadersWidth = 51;
            this.dgvPrivileges.RowTemplate.Height = 24;
            this.dgvPrivileges.Size = new System.Drawing.Size(317, 311);
            this.dgvPrivileges.TabIndex = 27;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 44);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblRoleName
            // 
            this.lblRoleName.Location = new System.Drawing.Point(444, 9);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(157, 26);
            this.lblRoleName.TabIndex = 29;
            this.lblRoleName.Text = "role";
            // 
            // dgvObjPrivs
            // 
            this.dgvObjPrivs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjPrivs.Location = new System.Drawing.Point(410, 62);
            this.dgvObjPrivs.Margin = new System.Windows.Forms.Padding(2);
            this.dgvObjPrivs.Name = "dgvObjPrivs";
            this.dgvObjPrivs.RowHeadersWidth = 51;
            this.dgvObjPrivs.RowTemplate.Height = 24;
            this.dgvObjPrivs.Size = new System.Drawing.Size(317, 311);
            this.dgvObjPrivs.TabIndex = 27;
            // 
            // clbCurrentPrivs
            // 
            this.clbCurrentPrivs.FormattingEnabled = true;
            this.clbCurrentPrivs.Location = new System.Drawing.Point(818, 38);
            this.clbCurrentPrivs.Name = "clbCurrentPrivs";
            this.clbCurrentPrivs.Size = new System.Drawing.Size(303, 124);
            this.clbCurrentPrivs.TabIndex = 30;
            // 
            // clbAvailablePrivs
            // 
            this.clbAvailablePrivs.FormattingEnabled = true;
            this.clbAvailablePrivs.Location = new System.Drawing.Point(818, 249);
            this.clbAvailablePrivs.Name = "clbAvailablePrivs";
            this.clbAvailablePrivs.Size = new System.Drawing.Size(303, 124);
            this.clbAvailablePrivs.TabIndex = 30;
            // 
            // btn_RSelected
            // 
            this.btn_RSelected.Location = new System.Drawing.Point(917, 168);
            this.btn_RSelected.Name = "btn_RSelected";
            this.btn_RSelected.Size = new System.Drawing.Size(116, 23);
            this.btn_RSelected.TabIndex = 31;
            this.btn_RSelected.Text = "Revoke Selected";
            this.btn_RSelected.UseVisualStyleBackColor = true;
            this.btn_RSelected.Click += new System.EventHandler(this.btn_RSelected_Click);
            // 
            // btn_GSelected
            // 
            this.btn_GSelected.Location = new System.Drawing.Point(930, 394);
            this.btn_GSelected.Name = "btn_GSelected";
            this.btn_GSelected.Size = new System.Drawing.Size(120, 23);
            this.btn_GSelected.TabIndex = 32;
            this.btn_GSelected.Text = "Grant Selected";
            this.btn_GSelected.UseVisualStyleBackColor = true;
            this.btn_GSelected.Click += new System.EventHandler(this.btn_GSelected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "📋 Quyền hiện có (có thể thu hồi) ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(815, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "➕ Quyền có thể gán thêm";
            // 
            // lbl_Info
            // 
            this.lbl_Info.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Info.ForeColor = System.Drawing.Color.Red;
            this.lbl_Info.Location = new System.Drawing.Point(41, 9);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(224, 26);
            this.lbl_Info.TabIndex = 29;
            // 
            // FormRoleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GSelected);
            this.Controls.Add(this.btn_RSelected);
            this.Controls.Add(this.clbAvailablePrivs);
            this.Controls.Add(this.clbCurrentPrivs);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvObjPrivs);
            this.Controls.Add(this.dgvPrivileges);
            this.Name = "FormRoleEditor";
            this.Text = "FormRoleEditor";
            this.Load += new System.EventHandler(this.FormRoleEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivileges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjPrivs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrivileges;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.DataGridView dgvObjPrivs;
        private System.Windows.Forms.CheckedListBox clbCurrentPrivs;
        private System.Windows.Forms.CheckedListBox clbAvailablePrivs;
        private System.Windows.Forms.Button btn_RSelected;
        private System.Windows.Forms.Button btn_GSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Info;
    }
}