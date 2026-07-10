namespace Express.UI
{
    partial class FrmShelfManage
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
            this.dgvShelf = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKeywordShelf = new System.Windows.Forms.TextBox();
            this.btnSearchShelf = new System.Windows.Forms.Button();
            this.btnDeleteShelf = new System.Windows.Forms.Button();
            this.btnUpdateShelf = new System.Windows.Forms.Button();
            this.btnAddShelf = new System.Windows.Forms.Button();
            this.txtRemainSpace = new System.Windows.Forms.TextBox();
            this.txtMaxCapacity = new System.Windows.Forms.TextBox();
            this.txtLayerCount = new System.Windows.Forms.TextBox();
            this.txtShelfName = new System.Windows.Forms.TextBox();
            this.txtRemarkShelf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelf)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShelf
            // 
            this.dgvShelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShelf.Location = new System.Drawing.Point(50, 400);
            this.dgvShelf.Name = "dgvShelf";
            this.dgvShelf.RowHeadersWidth = 62;
            this.dgvShelf.RowTemplate.Height = 30;
            this.dgvShelf.Size = new System.Drawing.Size(1085, 362);
            this.dgvShelf.TabIndex = 0;
            this.dgvShelf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShelf_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "关键词";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "剩余空位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "最大容量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "层数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "货架名";
            // 
            // txtKeywordShelf
            // 
            this.txtKeywordShelf.Location = new System.Drawing.Point(198, 102);
            this.txtKeywordShelf.Name = "txtKeywordShelf";
            this.txtKeywordShelf.Size = new System.Drawing.Size(365, 28);
            this.txtKeywordShelf.TabIndex = 7;
            // 
            // btnSearchShelf
            // 
            this.btnSearchShelf.Location = new System.Drawing.Point(96, 314);
            this.btnSearchShelf.Name = "btnSearchShelf";
            this.btnSearchShelf.Size = new System.Drawing.Size(152, 60);
            this.btnSearchShelf.TabIndex = 8;
            this.btnSearchShelf.Text = "查找";
            this.btnSearchShelf.UseVisualStyleBackColor = true;
            this.btnSearchShelf.Click += new System.EventHandler(this.btnSearchShelf_Click);
            // 
            // btnDeleteShelf
            // 
            this.btnDeleteShelf.Location = new System.Drawing.Point(920, 314);
            this.btnDeleteShelf.Name = "btnDeleteShelf";
            this.btnDeleteShelf.Size = new System.Drawing.Size(152, 60);
            this.btnDeleteShelf.TabIndex = 9;
            this.btnDeleteShelf.Text = "删除";
            this.btnDeleteShelf.UseVisualStyleBackColor = true;
            this.btnDeleteShelf.Click += new System.EventHandler(this.btnDeleteShelf_Click);
            // 
            // btnUpdateShelf
            // 
            this.btnUpdateShelf.Location = new System.Drawing.Point(641, 316);
            this.btnUpdateShelf.Name = "btnUpdateShelf";
            this.btnUpdateShelf.Size = new System.Drawing.Size(152, 60);
            this.btnUpdateShelf.TabIndex = 10;
            this.btnUpdateShelf.Text = "修改";
            this.btnUpdateShelf.UseVisualStyleBackColor = true;
            this.btnUpdateShelf.Click += new System.EventHandler(this.btnUpdateShelf_Click);
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.Location = new System.Drawing.Point(377, 314);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(152, 60);
            this.btnAddShelf.TabIndex = 11;
            this.btnAddShelf.Text = "新增";
            this.btnAddShelf.UseVisualStyleBackColor = true;
            this.btnAddShelf.Click += new System.EventHandler(this.btnAddShelf_Click);
            // 
            // txtRemainSpace
            // 
            this.txtRemainSpace.Location = new System.Drawing.Point(198, 201);
            this.txtRemainSpace.Name = "txtRemainSpace";
            this.txtRemainSpace.Size = new System.Drawing.Size(365, 28);
            this.txtRemainSpace.TabIndex = 12;
            // 
            // txtMaxCapacity
            // 
            this.txtMaxCapacity.Location = new System.Drawing.Point(707, 149);
            this.txtMaxCapacity.Name = "txtMaxCapacity";
            this.txtMaxCapacity.Size = new System.Drawing.Size(365, 28);
            this.txtMaxCapacity.TabIndex = 13;
            // 
            // txtLayerCount
            // 
            this.txtLayerCount.Location = new System.Drawing.Point(707, 102);
            this.txtLayerCount.Name = "txtLayerCount";
            this.txtLayerCount.Size = new System.Drawing.Size(365, 28);
            this.txtLayerCount.TabIndex = 14;
            // 
            // txtShelfName
            // 
            this.txtShelfName.Location = new System.Drawing.Point(198, 149);
            this.txtShelfName.Name = "txtShelfName";
            this.txtShelfName.Size = new System.Drawing.Size(365, 28);
            this.txtShelfName.TabIndex = 15;
            // 
            // txtRemarkShelf
            // 
            this.txtRemarkShelf.Location = new System.Drawing.Point(707, 201);
            this.txtRemarkShelf.Name = "txtRemarkShelf";
            this.txtRemarkShelf.Size = new System.Drawing.Size(365, 28);
            this.txtRemarkShelf.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "备注";
            // 
            // FrmShelfManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 804);
            this.Controls.Add(this.txtRemarkShelf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtShelfName);
            this.Controls.Add(this.txtLayerCount);
            this.Controls.Add(this.txtMaxCapacity);
            this.Controls.Add(this.txtRemainSpace);
            this.Controls.Add(this.btnAddShelf);
            this.Controls.Add(this.btnUpdateShelf);
            this.Controls.Add(this.btnDeleteShelf);
            this.Controls.Add(this.btnSearchShelf);
            this.Controls.Add(this.txtKeywordShelf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvShelf);
            this.Name = "FrmShelfManage";
            this.Text = "FrmShelfManage";
            this.Load += new System.EventHandler(this.FrmShelfManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShelf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKeywordShelf;
        private System.Windows.Forms.Button btnSearchShelf;
        private System.Windows.Forms.Button btnDeleteShelf;
        private System.Windows.Forms.Button btnUpdateShelf;
        private System.Windows.Forms.Button btnAddShelf;
        private System.Windows.Forms.TextBox txtRemainSpace;
        private System.Windows.Forms.TextBox txtMaxCapacity;
        private System.Windows.Forms.TextBox txtLayerCount;
        private System.Windows.Forms.TextBox txtShelfName;
        private System.Windows.Forms.TextBox txtRemarkShelf;
        private System.Windows.Forms.Label label7;
    }
}