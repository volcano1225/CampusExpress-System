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
    public partial class FrmNoticeManage : Form
    {
        SystemNoticeBLL bll = new SystemNoticeBLL();

        public FrmNoticeManage()
        {
            InitializeComponent();
        }

        private void FrmNoticeManage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.GetList(txtKeyword.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SystemNotice n = new SystemNotice();
            n.Title = txtTitle.Text.Trim();
            n.Content = txtContent.Text.Trim();
            n.CreateAdminId = Global.CurrentUserId;
            n.IsShow = chkIsShow.Checked ? 1 : 0;

            if (bll.Add(n))
            {
                MessageBox.Show("发布成功");
                LoadData();
                Clear();
            }
            else
                MessageBox.Show("发布失败");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            { MessageBox.Show("请先选择一行"); return; }

            SystemNotice n = new SystemNotice();
            n.NoticeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["NoticeId"].Value);
            n.Title = txtTitle.Text.Trim();
            n.Content = txtContent.Text.Trim();
            n.IsShow = chkIsShow.Checked ? 1 : 0;

            if (bll.Update(n))
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

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["NoticeId"].Value);
            if (MessageBox.Show("确定删除该公告？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bll.Delete(id))
                {
                    MessageBox.Show("删除成功");
                    LoadData();
                    Clear();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtTitle.Text = dataGridView1.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            txtContent.Text = dataGridView1.Rows[e.RowIndex].Cells["Content"].Value.ToString();
            chkIsShow.Checked = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IsShow"].Value) == 1;
        }

        private void LoadData()
        {
            dataGridView1.DataSource = bll.GetList("");
        }

        private void Clear()
        {
            txtTitle.Clear();
            txtContent.Clear();
            chkIsShow.Checked = true;
        }
    }
}
