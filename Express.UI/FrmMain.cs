using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Express.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "skins\\EighteenColor2.ssk";
            this.Text = "校园快递驿站管理系统 —— 当前用户：" + Global.CurrentRealName
                        + " [" + (Global.CurrentRole == "Admin" ? "管理员" : "学生") + "]";

            if (Global.CurrentRole == "Admin")
            {
                menuSystem.Visible = true;
                menuStudent.Visible = false;  // 学生菜单隐藏
            }
            else
            {
                menuSystem.Visible = false;   // 管理菜单隐藏
                menuStudent.Visible = true;   // 学生菜单显示
            }
            menuExit.Click += menuExit_Click;
        }

        private void OpenForm(Form frm)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frm.Name) { f.Activate(); return; }
            }
            frm.MdiParent = this;
            frm.WindowState =FormWindowState.Maximized;
            frm.Show();
        }

        private void menuStudentManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmStudentManage());
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuAdminManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAdminManage());
        }

        private void MenuCategoryManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCategoryManage());
        }

        private void MenuShelfManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmShelfManage());
        }

        private void menuNoticeManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmNoticeManage());
        }

        private void menuPackageManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPackageManage());
        }

        private void menuPersonal_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPersonal());
        }

        private void menuMyPackage_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmMyPackage());
        }

        private void menuMySend_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmMySend());
        }

        private void menuPickup_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPickup());
        }

        private void menuSendManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmSendManage());
        }

        private void menuStatistics_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmStatistics());
        }
    }

}
