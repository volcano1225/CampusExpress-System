namespace Express.UI
{
    partial class FrmAdminManage
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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdminPhone = new System.Windows.Forms.TextBox();
            this.txtAdminRealName = new System.Windows.Forms.TextBox();
            this.txtAdminPwd = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.txtAdminKeyword = new System.Windows.Forms.TextBox();
            this.btnAdminAdd = new System.Windows.Forms.Button();
            this.btnAdminDelete = new System.Windows.Forms.Button();
            this.btnAdminUpdate = new System.Windows.Forms.Button();
            this.btnAdminSearch = new System.Windows.Forms.Button();
            this.btnAdminResetPwd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(50, 414);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 62;
            this.dgvAdmin.RowTemplate.Height = 30;
            this.dgvAdmin.Size = new System.Drawing.Size(1085, 362);
            this.dgvAdmin.TabIndex = 0;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "关键词";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "手机";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "管理员账号";
            // 
            // txtAdminPhone
            // 
            this.txtAdminPhone.Location = new System.Drawing.Point(711, 149);
            this.txtAdminPhone.Name = "txtAdminPhone";
            this.txtAdminPhone.Size = new System.Drawing.Size(278, 28);
            this.txtAdminPhone.TabIndex = 9;
            // 
            // txtAdminRealName
            // 
            this.txtAdminRealName.Location = new System.Drawing.Point(711, 95);
            this.txtAdminRealName.Name = "txtAdminRealName";
            this.txtAdminRealName.Size = new System.Drawing.Size(278, 28);
            this.txtAdminRealName.TabIndex = 10;
            // 
            // txtAdminPwd
            // 
            this.txtAdminPwd.Location = new System.Drawing.Point(237, 203);
            this.txtAdminPwd.Name = "txtAdminPwd";
            this.txtAdminPwd.Size = new System.Drawing.Size(278, 28);
            this.txtAdminPwd.TabIndex = 11;
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(237, 149);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(278, 28);
            this.txtAdminName.TabIndex = 12;
            // 
            // txtAdminKeyword
            // 
            this.txtAdminKeyword.Location = new System.Drawing.Point(237, 95);
            this.txtAdminKeyword.Name = "txtAdminKeyword";
            this.txtAdminKeyword.Size = new System.Drawing.Size(278, 28);
            this.txtAdminKeyword.TabIndex = 13;
            // 
            // btnAdminAdd
            // 
            this.btnAdminAdd.Location = new System.Drawing.Point(346, 313);
            this.btnAdminAdd.Name = "btnAdminAdd";
            this.btnAdminAdd.Size = new System.Drawing.Size(152, 60);
            this.btnAdminAdd.TabIndex = 17;
            this.btnAdminAdd.Text = "新增";
            this.btnAdminAdd.UseVisualStyleBackColor = true;
            this.btnAdminAdd.Click += new System.EventHandler(this.btnAdminAdd_Click);
            // 
            // btnAdminDelete
            // 
            this.btnAdminDelete.Location = new System.Drawing.Point(691, 313);
            this.btnAdminDelete.Name = "btnAdminDelete";
            this.btnAdminDelete.Size = new System.Drawing.Size(152, 60);
            this.btnAdminDelete.TabIndex = 18;
            this.btnAdminDelete.Text = "删除";
            this.btnAdminDelete.UseVisualStyleBackColor = true;
            this.btnAdminDelete.Click += new System.EventHandler(this.btnAdminDelete_Click);
            // 
            // btnAdminUpdate
            // 
            this.btnAdminUpdate.Location = new System.Drawing.Point(521, 313);
            this.btnAdminUpdate.Name = "btnAdminUpdate";
            this.btnAdminUpdate.Size = new System.Drawing.Size(152, 60);
            this.btnAdminUpdate.TabIndex = 19;
            this.btnAdminUpdate.Text = "修改";
            this.btnAdminUpdate.UseVisualStyleBackColor = true;
            this.btnAdminUpdate.Click += new System.EventHandler(this.btnAdminUpdate_Click);
            // 
            // btnAdminSearch
            // 
            this.btnAdminSearch.Location = new System.Drawing.Point(168, 313);
            this.btnAdminSearch.Name = "btnAdminSearch";
            this.btnAdminSearch.Size = new System.Drawing.Size(152, 60);
            this.btnAdminSearch.TabIndex = 20;
            this.btnAdminSearch.Text = "查询";
            this.btnAdminSearch.UseVisualStyleBackColor = true;
            this.btnAdminSearch.Click += new System.EventHandler(this.btnAdminSearch_Click);
            // 
            // btnAdminResetPwd
            // 
            this.btnAdminResetPwd.Location = new System.Drawing.Point(865, 313);
            this.btnAdminResetPwd.Name = "btnAdminResetPwd";
            this.btnAdminResetPwd.Size = new System.Drawing.Size(152, 60);
            this.btnAdminResetPwd.TabIndex = 21;
            this.btnAdminResetPwd.Text = "重置密码";
            this.btnAdminResetPwd.UseVisualStyleBackColor = true;
            this.btnAdminResetPwd.Click += new System.EventHandler(this.btnAdminResetPwd_Click);
            // 
            // FrmAdminManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 804);
            this.Controls.Add(this.btnAdminResetPwd);
            this.Controls.Add(this.btnAdminSearch);
            this.Controls.Add(this.btnAdminUpdate);
            this.Controls.Add(this.btnAdminDelete);
            this.Controls.Add(this.btnAdminAdd);
            this.Controls.Add(this.txtAdminKeyword);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.txtAdminPwd);
            this.Controls.Add(this.txtAdminRealName);
            this.Controls.Add(this.txtAdminPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAdmin);
            this.Name = "FrmAdminManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminManage";
            this.Load += new System.EventHandler(this.FrmAdminManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdminPhone;
        private System.Windows.Forms.TextBox txtAdminRealName;
        private System.Windows.Forms.TextBox txtAdminPwd;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.TextBox txtAdminKeyword;
        private System.Windows.Forms.Button btnAdminAdd;
        private System.Windows.Forms.Button btnAdminDelete;
        private System.Windows.Forms.Button btnAdminUpdate;
        private System.Windows.Forms.Button btnAdminSearch;
        private System.Windows.Forms.Button btnAdminResetPwd;
    }
}