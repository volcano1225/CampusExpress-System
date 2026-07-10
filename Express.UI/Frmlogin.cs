using System;
using System.Data;
using System.Windows.Forms;
using Express.BLL;
using Express.Model;

namespace Express.UI
{
    public partial class FrmLogin : Form
    {
        private int errorCount = 0;

        public FrmLogin()
        {
            InitializeComponent();
            picCaptcha.Image = CaptchaHelper.GenerateCaptcha();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            { MessageBox.Show("账号不能为空"); return; }
            if (string.IsNullOrEmpty(txtPwd.Text.Trim()))
            { MessageBox.Show("密码不能为空"); return; }

            if (!CaptchaHelper.Validate(txtCaptcha.Text.Trim()))
            { MessageBox.Show("验证码错误"); picCaptcha.Image = CaptchaHelper.GenerateCaptcha(); return; }

            string md5Pwd = MD5Helper.Encrypt(txtPwd.Text.Trim());

            if (cmbRole.SelectedItem != null && cmbRole.SelectedItem.ToString() == "管理员")
            {
                AdminInfoBLL bll = new AdminInfoBLL();
                DataTable dt = bll.Login(txtUserName.Text.Trim(), md5Pwd);
                if (dt.Rows.Count > 0)
                {
                    Global.CurrentRole = "Admin";
                    Global.CurrentUserName = dt.Rows[0]["AdminName"].ToString();
                    Global.CurrentUserId = Convert.ToInt32(dt.Rows[0]["AdminId"]);
                    Global.CurrentRealName = dt.Rows[0]["RealName"].ToString();

                    FrmMain main = new FrmMain();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else { LoginFailed(); }
            }
            else
            {
                StudentInfoBLL bll = new StudentInfoBLL();
                DataTable dt = bll.Login(txtUserName.Text.Trim(), md5Pwd);
                if (dt.Rows.Count > 0)
                {
                    Global.CurrentRole = "Student";
                    Global.CurrentUserName = dt.Rows[0]["UserName"].ToString();
                    Global.CurrentUserId = Convert.ToInt32(dt.Rows[0]["StuId"]);
                    Global.CurrentRealName = dt.Rows[0]["RealName"].ToString();

                    FrmMain main = new FrmMain();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else { LoginFailed(); }
            }
        }

        private void LoginFailed()
        {
            errorCount++;
            if (errorCount >= 3)
            {
                MessageBox.Show("连续3次错误，登录框已锁定");
                btnLogin.Enabled = false;
            }
            else
            {
                MessageBox.Show("账号或密码错误，还剩" + (3 - errorCount) + "次");
                picCaptcha.Image = CaptchaHelper.GenerateCaptcha();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            picCaptcha.Image = CaptchaHelper.GenerateCaptcha();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "skins\\EighteenColor2.ssk";
        }
    }
}
