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
    public partial class FrmShelfManage : Form
    {
        ShelfInfoBLL bll = new ShelfInfoBLL();

        public FrmShelfManage()
        {
            InitializeComponent();
        }

        private void FrmShelfManage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearchShelf_Click(object sender, EventArgs e)
        {
            dgvShelf.DataSource = bll.GetList(txtKeywordShelf.Text.Trim());
        }

        private void btnAddShelf_Click(object sender, EventArgs e)
        {
            ShelfInfo sh = new ShelfInfo();
            sh.ShelfName = txtShelfName.Text.Trim();
            sh.LayerCount = Convert.ToInt32(txtLayerCount.Text.Trim());
            sh.MaxCapacity = Convert.ToInt32(txtMaxCapacity.Text.Trim());
            sh.RemainSpace = Convert.ToInt32(txtRemainSpace.Text.Trim());
            sh.Remark = txtRemarkShelf.Text.Trim();

            if (bll.Add(sh))
            {
                MessageBox.Show("添加成功");
                LoadData();
                Clear();
            }
            else
                MessageBox.Show("添加失败");
        }

        private void btnUpdateShelf_Click(object sender, EventArgs e)
        {
            if (dgvShelf.CurrentRow == null)
            { MessageBox.Show("请先选择一行"); return; }

            ShelfInfo sh = new ShelfInfo();
            sh.ShelfId = Convert.ToInt32(dgvShelf.CurrentRow.Cells["ShelfId"].Value);
            sh.ShelfName = txtShelfName.Text.Trim();
            sh.LayerCount = Convert.ToInt32(txtLayerCount.Text.Trim());
            sh.MaxCapacity = Convert.ToInt32(txtMaxCapacity.Text.Trim());
            sh.RemainSpace = Convert.ToInt32(txtRemainSpace.Text.Trim());
            sh.Remark = txtRemarkShelf.Text.Trim();

            if (bll.Update(sh))
            {
                MessageBox.Show("修改成功");
                LoadData();
            }
            else
                MessageBox.Show("修改失败");
        }

        private void btnDeleteShelf_Click(object sender, EventArgs e)
        {
            if (dgvShelf.CurrentRow == null)
            { MessageBox.Show("请先选择一行"); return; }

            int id = Convert.ToInt32(dgvShelf.CurrentRow.Cells["ShelfId"].Value);
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

        private void dgvShelf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtShelfName.Text = dgvShelf.Rows[e.RowIndex].Cells["ShelfName"].Value.ToString();
            txtLayerCount.Text = dgvShelf.Rows[e.RowIndex].Cells["LayerCount"].Value.ToString();
            txtMaxCapacity.Text = dgvShelf.Rows[e.RowIndex].Cells["MaxCapacity"].Value.ToString();
            txtRemainSpace.Text = dgvShelf.Rows[e.RowIndex].Cells["RemainSpace"].Value.ToString();
            txtRemarkShelf.Text = dgvShelf.Rows[e.RowIndex].Cells["Remark"].Value.ToString();
        }

        private void LoadData()
        {
            dgvShelf.DataSource = bll.GetList("");
        }

        private void Clear()
        {
            txtShelfName.Clear();
            txtLayerCount.Clear();
            txtMaxCapacity.Clear();
            txtRemainSpace.Clear();
            txtRemarkShelf.Clear();
        }
    }
}
