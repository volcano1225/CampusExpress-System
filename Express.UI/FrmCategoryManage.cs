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
    public partial class FrmCategoryManage : Form
    {
        ExpressCategoryBLL bll = new ExpressCategoryBLL();

        public FrmCategoryManage()
        {
            InitializeComponent();
        }

        private void FrmCategoryManage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearchCat_Click(object sender, EventArgs e)
        {
            dgvCategory.DataSource = bll.GetList(txtKeywordCat.Text.Trim());
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            ExpressCategory c = new ExpressCategory();
            c.CateName = txtCateName.Text.Trim();
            c.Remark = txtRemark.Text.Trim();

            if (bll.Add(c))
            {
                MessageBox.Show("添加成功");
                LoadData();
                Clear();
            }
            else
                MessageBox.Show("添加失败");
        }

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            if (dgvCategory.CurrentRow == null)
            { MessageBox.Show("请先选择一行"); return; }

            ExpressCategory c = new ExpressCategory();
            c.CateId = Convert.ToInt32(dgvCategory.CurrentRow.Cells["CateId"].Value);
            c.CateName = txtCateName.Text.Trim();
            c.Remark = txtRemark.Text.Trim();

            if (bll.Update(c))
            {
                MessageBox.Show("修改成功");
                LoadData();
            }
            else
                MessageBox.Show("修改失败");
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            if (dgvCategory.CurrentRow == null)
            { MessageBox.Show("请先选择一行"); return; }

            int id = Convert.ToInt32(dgvCategory.CurrentRow.Cells["CateId"].Value);
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

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtCateName.Text = dgvCategory.Rows[e.RowIndex].Cells["CateName"].Value.ToString();
            txtRemark.Text = dgvCategory.Rows[e.RowIndex].Cells["Remark"].Value.ToString();
        }

        private void LoadData()
        {
            dgvCategory.DataSource = bll.GetList("");
        }

        private void Clear()
        {
            txtCateName.Clear();
            txtRemark.Clear();
        }
    }
}
