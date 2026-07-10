namespace Express.UI
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStudentManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdminManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategoryManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuShelfManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPackageManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPickup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSendManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNoticeManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMyPackage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMySend = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuNoticeManage,
            this.menuExit,
            this.menuPersonal,
            this.menuStudent,
            this.menuStatistics});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStudentManage,
            this.menuAdminManage,
            this.MenuCategoryManage,
            this.MenuShelfManage,
            this.menuPackageManage,
            this.menuPickup,
            this.menuSendManage});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(98, 28);
            this.menuSystem.Text = "系统管理";
            // 
            // menuStudentManage
            // 
            this.menuStudentManage.Name = "menuStudentManage";
            this.menuStudentManage.Size = new System.Drawing.Size(236, 34);
            this.menuStudentManage.Text = "学生信息管理";
            this.menuStudentManage.Click += new System.EventHandler(this.menuStudentManage_Click);
            // 
            // menuAdminManage
            // 
            this.menuAdminManage.Name = "menuAdminManage";
            this.menuAdminManage.Size = new System.Drawing.Size(236, 34);
            this.menuAdminManage.Text = "管理员账号管理";
            this.menuAdminManage.Click += new System.EventHandler(this.menuAdminManage_Click);
            // 
            // MenuCategoryManage
            // 
            this.MenuCategoryManage.Name = "MenuCategoryManage";
            this.MenuCategoryManage.Size = new System.Drawing.Size(236, 34);
            this.MenuCategoryManage.Text = "快递公司分类";
            this.MenuCategoryManage.Click += new System.EventHandler(this.MenuCategoryManage_Click);
            // 
            // MenuShelfManage
            // 
            this.MenuShelfManage.Name = "MenuShelfManage";
            this.MenuShelfManage.Size = new System.Drawing.Size(236, 34);
            this.MenuShelfManage.Text = "货架管理";
            this.MenuShelfManage.Click += new System.EventHandler(this.MenuShelfManage_Click);
            // 
            // menuPackageManage
            // 
            this.menuPackageManage.Name = "menuPackageManage";
            this.menuPackageManage.Size = new System.Drawing.Size(236, 34);
            this.menuPackageManage.Text = "包裹管理";
            this.menuPackageManage.Click += new System.EventHandler(this.menuPackageManage_Click);
            // 
            // menuPickup
            // 
            this.menuPickup.Name = "menuPickup";
            this.menuPickup.Size = new System.Drawing.Size(236, 34);
            this.menuPickup.Text = "取件核销";
            this.menuPickup.Click += new System.EventHandler(this.menuPickup_Click);
            // 
            // menuSendManage
            // 
            this.menuSendManage.Name = "menuSendManage";
            this.menuSendManage.Size = new System.Drawing.Size(236, 34);
            this.menuSendManage.Text = "寄件管理";
            this.menuSendManage.Click += new System.EventHandler(this.menuSendManage_Click);
            // 
            // menuNoticeManage
            // 
            this.menuNoticeManage.Name = "menuNoticeManage";
            this.menuNoticeManage.Size = new System.Drawing.Size(98, 28);
            this.menuNoticeManage.Text = "公告管理";
            this.menuNoticeManage.Click += new System.EventHandler(this.menuNoticeManage_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(98, 28);
            this.menuExit.Text = "退出系统";
            // 
            // menuPersonal
            // 
            this.menuPersonal.Name = "menuPersonal";
            this.menuPersonal.Size = new System.Drawing.Size(98, 28);
            this.menuPersonal.Text = "个人中心";
            this.menuPersonal.Click += new System.EventHandler(this.menuPersonal_Click);
            // 
            // menuStudent
            // 
            this.menuStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMyPackage,
            this.menuMySend});
            this.menuStudent.Name = "menuStudent";
            this.menuStudent.Size = new System.Drawing.Size(98, 28);
            this.menuStudent.Text = "学生服务";
            // 
            // menuMyPackage
            // 
            this.menuMyPackage.Name = "menuMyPackage";
            this.menuMyPackage.Size = new System.Drawing.Size(182, 34);
            this.menuMyPackage.Text = "我的包裹";
            this.menuMyPackage.Click += new System.EventHandler(this.menuMyPackage_Click);
            // 
            // menuMySend
            // 
            this.menuMySend.Name = "menuMySend";
            this.menuMySend.Size = new System.Drawing.Size(182, 34);
            this.menuMySend.Text = "我的寄件";
            this.menuMySend.Click += new System.EventHandler(this.menuMySend_Click);
            // 
            // menuStatistics
            // 
            this.menuStatistics.Name = "menuStatistics";
            this.menuStatistics.Size = new System.Drawing.Size(98, 28);
            this.menuStatistics.Text = "数据统计";
            this.menuStatistics.Click += new System.EventHandler(this.menuStatistics_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "校园快递驿站管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuStudentManage;
        private System.Windows.Forms.ToolStripMenuItem menuNoticeManage;
        private System.Windows.Forms.ToolStripMenuItem menuAdminManage;
        private System.Windows.Forms.ToolStripMenuItem MenuCategoryManage;
        private System.Windows.Forms.ToolStripMenuItem MenuShelfManage;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuPackageManage;
        private System.Windows.Forms.ToolStripMenuItem menuPersonal;
        private System.Windows.Forms.ToolStripMenuItem menuStudent;
        private System.Windows.Forms.ToolStripMenuItem menuMyPackage;
        private System.Windows.Forms.ToolStripMenuItem menuMySend;
        private System.Windows.Forms.ToolStripMenuItem menuPickup;
        private System.Windows.Forms.ToolStripMenuItem menuSendManage;
        private System.Windows.Forms.ToolStripMenuItem menuStatistics;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}
