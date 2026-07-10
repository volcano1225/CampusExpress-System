using System;
using System.Data;
using System.Windows.Forms;
using Express.BLL;
using Express.Model;

namespace Express.UI
{
    public partial class FrmPackageManage : Form
    {
        ExpressPackageBLL bll = new ExpressPackageBLL();
        ExpressCategoryBLL cateBll = new ExpressCategoryBLL();
        ShelfInfoBLL shelfBll = new ShelfInfoBLL();

        public FrmPackageManage()
        {
            InitializeComponent();
        }

        private void FrmPackageManage_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = cateBll.GetList("");
            cmbCategory.DisplayMember = "CateName";
            cmbCategory.ValueMember = "CateId";

            cmbShelf.DataSource = shelfBll.GetList("");
            cmbShelf.DisplayMember = "ShelfName";
            cmbShelf.ValueMember = "ShelfId";

            cmbSize.Items.Add("小"); cmbSize.Items.Add("中"); cmbSize.Items.Add("大"); cmbSize.SelectedIndex = 0;
            cmbStatus.Items.Add("待取件"); cmbStatus.Items.Add("已取件"); cmbStatus.Items.Add("滞留罚款"); cmbStatus.Items.Add("已弃件"); cmbStatus.SelectedIndex = 0;

            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.GetList(txtKeyword.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExpressPackage p = new ExpressPackage();
            p.ExpressNo = txtExpressNo.Text.Trim();
            p.CateId = Convert.ToInt32(cmbCategory.SelectedValue);
            p.ShelfId = Convert.ToInt32(cmbShelf.SelectedValue);
            p.ReceiverName = txtReceiverName.Text.Trim();
            p.ReceiverPhone = txtReceiverPhone.Text.Trim();
            p.SenderName = txtSenderName.Text.Trim();
            p.PackageWeight = string.IsNullOrEmpty(txtWeight.Text) ? 0 : Convert.ToDecimal(txtWeight.Text);
            p.PackageSize = cmbSize.SelectedItem.ToString();
            p.Status = cmbStatus.SelectedIndex + 1;

            if (bll.Add(p)) { MessageBox.Show("添加成功"); LoadData(); Clear(); }
            else MessageBox.Show("添加失败");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) { MessageBox.Show("请先选择一行"); return; }
            ExpressPackage p = new ExpressPackage();
            p.PackageId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PackageId"].Value);
            p.ExpressNo = txtExpressNo.Text.Trim();
            p.CateId = Convert.ToInt32(cmbCategory.SelectedValue);
            p.ShelfId = Convert.ToInt32(cmbShelf.SelectedValue);
            p.ReceiverName = txtReceiverName.Text.Trim();
            p.ReceiverPhone = txtReceiverPhone.Text.Trim();
            p.SenderName = txtSenderName.Text.Trim();
            p.PackageWeight = string.IsNullOrEmpty(txtWeight.Text) ? 0 : Convert.ToDecimal(txtWeight.Text);
            p.PackageSize = cmbSize.SelectedItem.ToString();
            p.Status = cmbStatus.SelectedIndex + 1;

            if (bll.Update(p)) { MessageBox.Show("修改成功"); LoadData(); }
            else MessageBox.Show("修改失败");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) { MessageBox.Show("请先选择一行"); return; }
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PackageId"].Value);
            if (MessageBox.Show("确定删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try { if (bll.Delete(id)) { MessageBox.Show("删除成功"); LoadData(); Clear(); } }
                catch (Exception ex) { MessageBox.Show("删除失败：" + ex.Message); }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtExpressNo.Text = dataGridView1.Rows[e.RowIndex].Cells["ExpressNo"].Value.ToString();
            txtReceiverName.Text = dataGridView1.Rows[e.RowIndex].Cells["ReceiverName"].Value.ToString();
            txtReceiverPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["ReceiverPhone"].Value.ToString();
            txtSenderName.Text = dataGridView1.Rows[e.RowIndex].Cells["SenderName"].Value.ToString();
            txtWeight.Text = dataGridView1.Rows[e.RowIndex].Cells["PackageWeight"].Value.ToString();
            cmbSize.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["PackageSize"].Value.ToString();
            cmbStatus.SelectedIndex = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Status"].Value) - 1;

            if (dataGridView1.Rows[e.RowIndex].Cells["CateId"].Value != null)
                cmbCategory.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["CateId"].Value;
            if (dataGridView1.Rows[e.RowIndex].Cells["ShelfId"].Value != null)
                cmbShelf.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["ShelfId"].Value;
        }

        private void LoadData()
        {
            dataGridView1.DataSource = bll.GetList("");
        }

        private void Clear()
        {
            txtExpressNo.Clear(); txtReceiverName.Clear(); txtReceiverPhone.Clear();
            txtSenderName.Clear(); txtWeight.Clear(); cmbSize.SelectedIndex = 0; cmbStatus.SelectedIndex = 0;
        }
    }
}
