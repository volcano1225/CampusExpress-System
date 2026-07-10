using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Express.BLL;
using Express.Model;

namespace Express.UI
{
    public partial class FrmPersonal : Form
    {
        StudentInfoBLL stuBll = new StudentInfoBLL();
        AdminInfoBLL adminBll = new AdminInfoBLL();
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (Global.CurrentRole == "Student")
            {
                StudentInfo s = new StudentInfo();
                s.StuId = Global.CurrentUserId;
                s.RealName = txtRealName.Text.Trim();
                s.ClassName = txtClassName.Text.Trim();
                s.DormAddress = txtDormAddress.Text.Trim();
                s.Phone = txtPhone.Text.Trim();
                // Status 和 MaxSendNum 不改，保持原值
                if (stuBll.Update(s))
                {
                    MessageBox.Show("保存成功");
                    Global.CurrentRealName = s.RealName;
                }
                else
                    MessageBox.Show("保存失败");
            }
            else
            {
                // 管理员改电话和姓名
                AdminInfo a = new AdminInfo();
                a.AdminId = Global.CurrentUserId;
                a.RealName = txtRealName.Text.Trim();
                a.Phone = txtPhone.Text.Trim();
                if (adminBll.Update(a))
                {
                    MessageBox.Show("保存成功");
                    Global.CurrentRealName = a.RealName;
                }
                else
                    MessageBox.Show("保存失败");
            }
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPwd.Text) || string.IsNullOrEmpty(txtNewPwd.Text))
            { MessageBox.Show("密码不能为空"); return; }

            if (txtNewPwd.Text != txtConfirmPwd.Text)
            { MessageBox.Show("两次新密码不一致"); return; }

            string oldMd5 = MD5Helper.Encrypt(txtOldPwd.Text.Trim());
            string newMd5 = MD5Helper.Encrypt(txtNewPwd.Text.Trim());

            if (Global.CurrentRole == "Student")
            {
                // 验证原密码
                DataTable dt = stuBll.Login(Global.CurrentUserName, oldMd5);
                if (dt.Rows.Count == 0) { MessageBox.Show("原密码错误"); return; }

                if (stuBll.ResetPassword(Global.CurrentUserId, newMd5))
                    MessageBox.Show("密码修改成功");
            }
            else
            {
                DataTable dt = adminBll.Login(Global.CurrentUserName, oldMd5);
                if (dt.Rows.Count == 0) { MessageBox.Show("原密码错误"); return; }

                if (adminBll.ResetPassword(Global.CurrentUserId, newMd5))
                    MessageBox.Show("密码修改成功");
            }

            txtOldPwd.Clear(); txtNewPwd.Clear(); txtConfirmPwd.Clear();
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            if (Global.CurrentRole == "Student")
            {
                // 加载学生信息
                DataTable dt = stuBll.GetList("");
                DataRow[] rows = dt.Select("StuId = " + Global.CurrentUserId);
                if (rows.Length > 0)
                {
                    txtUserName.Text = rows[0]["UserName"].ToString();
                    txtRealName.Text = rows[0]["RealName"].ToString();
                    txtClassName.Text = rows[0]["ClassName"].ToString();
                    txtDormAddress.Text = rows[0]["DormAddress"].ToString();
                    txtPhone.Text = rows[0]["Phone"].ToString();
                    txtStatus.Text = Convert.ToInt32(rows[0]["Status"]) == 1 ? "正常" : "冻结";
                    txtMaxSendNum.Text = rows[0]["MaxSendNum"].ToString();
                }
            }
            else
            {
                // 管理员只显示基本信息
                DataTable dt = adminBll.GetList("");
                DataRow[] rows = dt.Select("AdminId = " + Global.CurrentUserId);
                if (rows.Length > 0)
                {
                    txtUserName.Text = rows[0]["AdminName"].ToString();
                    txtRealName.Text = rows[0]["RealName"].ToString();
                    txtPhone.Text = rows[0]["Phone"].ToString();
                    txtStatus.Text = "管理员";
                    txtMaxSendNum.Text = "无限制";
                    txtClassName.ReadOnly = true;
                    txtDormAddress.ReadOnly = true;
                }
            }
        }
    }
}
