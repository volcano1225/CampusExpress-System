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
    public partial class FrmStudentManage : Form
    {
        StudentInfoBLL bll = new StudentInfoBLL();

        public FrmStudentManage()
        {
            InitializeComponent();
        }

        private void FrmStudentManage_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("冻结");
            cmbStatus.Items.Add("正常");
            cmbStatus.SelectedIndex = 1;
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.GetList(txtKeyword.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentInfo s = new StudentInfo();
            s.UserName = txtUserName.Text.Trim();
            s.Password = MD5Helper.Encrypt(txtPwd.Text.Trim());
            s.RealName = txtRealName.Text.Trim();
            s.Phone = txtPhone.Text.Trim();
            s.ClassName = txtClassName.Text.Trim();
            s.DormAddress = txtDormAddress.Text.Trim();

            if (bll.Add(s))
            {
                MessageBox.Show("添加成功");
                LoadData();
                Clear();
            }
            else
                MessageBox.Show("添加失败");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            { MessageBox.Show("请先选择一行"); return; }

            StudentInfo s = new StudentInfo();
            s.StuId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StuId"].Value);
            s.RealName = txtRealName.Text.Trim();
            s.Phone = txtPhone.Text.Trim();
            s.ClassName = txtClassName.Text.Trim();
            s.DormAddress = txtDormAddress.Text.Trim();
            s.Status = cmbStatus.SelectedIndex;

            if (bll.Update(s))
            {
                MessageBox.Show("修改成功");
                LoadData();
            }
            else
                MessageBox.Show("修改失败");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            { MessageBox.Show("请先选择一行"); return; }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StuId"].Value);
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

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            { MessageBox.Show("请先选择一行"); return; }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StuId"].Value);
            if (bll.ResetPassword(id, MD5Helper.Encrypt("123456")))
                MessageBox.Show("密码已重置为123456");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            txtRealName.Text = dataGridView1.Rows[e.RowIndex].Cells["RealName"].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            txtClassName.Text = dataGridView1.Rows[e.RowIndex].Cells["ClassName"].Value.ToString();
            txtDormAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["DormAddress"].Value.ToString();
            cmbStatus.SelectedIndex = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Status"].Value);
        }

        private void LoadData()
        {
            dataGridView1.DataSource = bll.GetList("");
        }

        private void Clear()
        {
            txtUserName.Clear();
            txtPwd.Clear();
            txtRealName.Clear();
            txtPhone.Clear();
            txtClassName.Clear();
            txtDormAddress.Clear();
            cmbStatus.SelectedIndex = 1;
        }
    }
}
