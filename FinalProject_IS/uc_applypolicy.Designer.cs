namespace FinalProject_IS
{
    partial class uc_applypolicy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_applypolicy = new System.Windows.Forms.Panel();
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
            this.cbPolicyFunction = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFunctionSchema = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbObjectName = new System.Windows.Forms.ComboBox();
            this.cbObjectSchema = new System.Windows.Forms.ComboBox();
            this.panel_applypolicy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_applypolicy
            // 
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
            this.panel_applypolicy.Controls.Add(this.cbPolicyFunction);
            this.panel_applypolicy.Controls.Add(this.label3);
            this.panel_applypolicy.Controls.Add(this.cbFunctionSchema);
            this.panel_applypolicy.Controls.Add(this.label2);
            this.panel_applypolicy.Controls.Add(this.cbObjectName);
            this.panel_applypolicy.Controls.Add(this.cbObjectSchema);
            this.panel_applypolicy.Location = new System.Drawing.Point(80, 70);
            this.panel_applypolicy.Name = "panel_applypolicy";
            this.panel_applypolicy.Size = new System.Drawing.Size(413, 389);
            this.panel_applypolicy.TabIndex = 94;
            // 
            // btn_applyPolicy
            // 
            this.btn_applyPolicy.Location = new System.Drawing.Point(138, 302);
            this.btn_applyPolicy.Name = "btn_applyPolicy";
            this.btn_applyPolicy.Size = new System.Drawing.Size(180, 39);
            this.btn_applyPolicy.TabIndex = 5;
            this.btn_applyPolicy.Text = "Apply Policy";
            this.btn_applyPolicy.UseVisualStyleBackColor = true;
            // 
            // txtSecCols
            // 
            this.txtSecCols.Location = new System.Drawing.Point(154, 244);
            this.txtSecCols.Name = "txtSecCols";
            this.txtSecCols.Size = new System.Drawing.Size(216, 20);
            this.txtSecCols.TabIndex = 4;
            // 
            // txtPolicyName
            // 
            this.txtPolicyName.Location = new System.Drawing.Point(154, 197);
            this.txtPolicyName.Name = "txtPolicyName";
            this.txtPolicyName.ReadOnly = true;
            this.txtPolicyName.Size = new System.Drawing.Size(216, 20);
            this.txtPolicyName.TabIndex = 4;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(167, 169);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(70, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "UPDATE";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(286, 169);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "DELETE";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 169);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "SELECT";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // sec_relevant_cols
            // 
            this.sec_relevant_cols.AutoSize = true;
            this.sec_relevant_cols.Location = new System.Drawing.Point(11, 250);
            this.sec_relevant_cols.Name = "sec_relevant_cols";
            this.sec_relevant_cols.Size = new System.Drawing.Size(93, 13);
            this.sec_relevant_cols.TabIndex = 1;
            this.sec_relevant_cols.Text = "sec_relevant_cols";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "policy_name";
            // 
            // policy_function
            // 
            this.policy_function.AutoSize = true;
            this.policy_function.Location = new System.Drawing.Point(11, 121);
            this.policy_function.Name = "policy_function";
            this.policy_function.Size = new System.Drawing.Size(78, 13);
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
            // cbPolicyFunction
            // 
            this.cbPolicyFunction.FormattingEnabled = true;
            this.cbPolicyFunction.Location = new System.Drawing.Point(147, 121);
            this.cbPolicyFunction.Name = "cbPolicyFunction";
            this.cbPolicyFunction.Size = new System.Drawing.Size(121, 21);
            this.cbPolicyFunction.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "object_name";
            // 
            // cbFunctionSchema
            // 
            this.cbFunctionSchema.FormattingEnabled = true;
            this.cbFunctionSchema.Location = new System.Drawing.Point(147, 84);
            this.cbFunctionSchema.Name = "cbFunctionSchema";
            this.cbFunctionSchema.Size = new System.Drawing.Size(121, 21);
            this.cbFunctionSchema.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "object_schema";
            // 
            // cbObjectName
            // 
            this.cbObjectName.FormattingEnabled = true;
            this.cbObjectName.Location = new System.Drawing.Point(147, 46);
            this.cbObjectName.Name = "cbObjectName";
            this.cbObjectName.Size = new System.Drawing.Size(121, 21);
            this.cbObjectName.TabIndex = 0;
            // 
            // cbObjectSchema
            // 
            this.cbObjectSchema.FormattingEnabled = true;
            this.cbObjectSchema.Location = new System.Drawing.Point(147, 8);
            this.cbObjectSchema.Name = "cbObjectSchema";
            this.cbObjectSchema.Size = new System.Drawing.Size(121, 21);
            this.cbObjectSchema.TabIndex = 0;
            // 
            // uc_applypolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_applypolicy);
            this.Name = "uc_applypolicy";
            this.Size = new System.Drawing.Size(629, 564);
            this.panel_applypolicy.ResumeLayout(false);
            this.panel_applypolicy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_applypolicy;
        private System.Windows.Forms.Button btn_applyPolicy;
        private System.Windows.Forms.TextBox txtSecCols;
        private System.Windows.Forms.TextBox txtPolicyName;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label sec_relevant_cols;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label policy_function;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPolicyFunction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFunctionSchema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbObjectName;
        private System.Windows.Forms.ComboBox cbObjectSchema;
    }
}
