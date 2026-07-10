using Express.BLL;
using Express.Model;
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
    public partial class FrmAdminManage : Form
    {
        AdminInfoBLL bll = new AdminInfoBLL();

        public FrmAdminManage()
        {
            InitializeComponent();
        }

        private void FrmAdminManage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            dgvAdmin.DataSource = bll.GetList(txtAdminKeyword.Text.Trim());
        }

        private void btnAdminAdd_Click(object sender, EventArgs e)
        {
            AdminInfo a = new AdminInfo();
            a.AdminName = txtAdminName.Text.Trim();
            a.Pwd = MD5Helper.Encrypt(txtAdminPwd.Text.Trim());
            a.RealName = txtAdminRealName.Text.Trim();
            a.Phone = txtAdminPhone.Text.Trim();

            if (bll.Add(a))
            {
                MessageBox.Show("添加成功");
                LoadData();
                Clear();
            }
            else
                MessageBox.Show("添加失败");
        }

        private void btnAdminUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.CurrentRow == null)
            { MessageBox.Show("请先选择一行"); return; }

            AdminInfo a = new AdminInfo();
            a.AdminId = Convert.ToInt32(dgvAdmin.CurrentRow.Cells["AdminId"].Value);
            a.RealName = txtAdminRealName.Text.Trim();
            a.Phone = txtAdminPhone.Text.Trim();

            if (bll.Update(a))
            {
                MessageBox.Show("修改成功");
                LoadData();
            }
            else
                MessageBox.Show("修改失败");
        }

        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.CurrentRow == null)
            { MessageBox.Show("请先选择一行"); return; }

            int id = Convert.ToInt32(dgvAdmin.CurrentRow.Cells["AdminId"].Value);
            if (MessageBox.Show("确定删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (bll.Delete(id))
                    {
                        MessageBox.Show("删除成功");
                        LoadData();
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除失败：" + ex.Message);
                }
            }
        }

        private void btnAdminResetPwd_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.CurrentRow == null)
            { MessageBox.Show("请先选择一行"); return; }

            int id = Convert.ToInt32(dgvAdmin.CurrentRow.Cells["AdminId"].Value);
            if (bll.ResetPassword(id, MD5Helper.Encrypt("123456")))
                MessageBox.Show("密码已重置为123456");
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtAdminName.Text = dgvAdmin.Rows[e.RowIndex].Cells["AdminName"].Value.ToString();
            txtAdminRealName.Text = dgvAdmin.Rows[e.RowIndex].Cells["RealName"].Value.ToString();
            txtAdminPhone.Text = dgvAdmin.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
        }

        private void LoadData()
        {
            dgvAdmin.DataSource = bll.GetList("");
        }

        private void Clear()
        {
            txtAdminName.Clear();
            txtAdminPwd.Clear();
            txtAdminRealName.Clear();
            txtAdminPhone.Clear();
        }
    }
}
