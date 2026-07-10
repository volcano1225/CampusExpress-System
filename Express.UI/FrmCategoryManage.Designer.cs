namespace Express.UI
{
    partial class FrmCategoryManage
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
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchCat = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnUpdateCat = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.txtKeywordCat = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtCateName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(33, 402);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 62;
            this.dgvCategory.RowTemplate.Height = 30;
            this.dgvCategory.Size = new System.Drawing.Size(1085, 362);
            this.dgvCategory.TabIndex = 1;
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "关键词";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "备注";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "分类名称";
            // 
            // btnSearchCat
            // 
            this.btnSearchCat.Location = new System.Drawing.Point(118, 310);
            this.btnSearchCat.Name = "btnSearchCat";
            this.btnSearchCat.Size = new System.Drawing.Size(152, 60);
            this.btnSearchCat.TabIndex = 5;
            this.btnSearchCat.Text = "查询";
            this.btnSearchCat.UseVisualStyleBackColor = true;
            this.btnSearchCat.Click += new System.EventHandler(this.btnSearchCat_Click);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Location = new System.Drawing.Point(842, 310);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(152, 60);
            this.btnDeleteCat.TabIndex = 6;
            this.btnDeleteCat.Text = "删除";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnUpdateCat
            // 
            this.btnUpdateCat.Location = new System.Drawing.Point(592, 310);
            this.btnUpdateCat.Name = "btnUpdateCat";
            this.btnUpdateCat.Size = new System.Drawing.Size(152, 60);
            this.btnUpdateCat.TabIndex = 7;
            this.btnUpdateCat.Text = "修改";
            this.btnUpdateCat.UseVisualStyleBackColor = true;
            this.btnUpdateCat.Click += new System.EventHandler(this.btnUpdateCat_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(355, 310);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(152, 60);
            this.btnAddCat.TabIndex = 8;
            this.btnAddCat.Text = "新增";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // txtKeywordCat
            // 
            this.txtKeywordCat.Location = new System.Drawing.Point(399, 86);
            this.txtKeywordCat.Name = "txtKeywordCat";
            this.txtKeywordCat.Size = new System.Drawing.Size(478, 28);
            this.txtKeywordCat.TabIndex = 9;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(399, 232);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(478, 28);
            this.txtRemark.TabIndex = 10;
            // 
            // txtCateName
            // 
            this.txtCateName.Location = new System.Drawing.Point(399, 154);
            this.txtCateName.Name = "txtCateName";
            this.txtCateName.Size = new System.Drawing.Size(478, 28);
            this.txtCateName.TabIndex = 11;
            // 
            // FrmCategoryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 804);
            this.Controls.Add(this.txtCateName);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtKeywordCat);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.btnUpdateCat);
            this.Controls.Add(this.btnDeleteCat);
            this.Controls.Add(this.btnSearchCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCategory);
            this.Name = "FrmCategoryManage";
            this.Text = "FrmCategoryManage";
            this.Load += new System.EventHandler(this.FrmCategoryManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchCat;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnUpdateCat;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.TextBox txtKeywordCat;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtCateName;
    }
}