using Express.BLL;
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
    public partial class FrmPickup : Form
    {
        ExpressPackageBLL packageBll = new ExpressPackageBLL();
        ShelfInfoBLL shelfBll = new ShelfInfoBLL();
        public FrmPickup()
        {
            InitializeComponent();
        }
        private void FrmPickup_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            dataGridView1.DataSource = packageBll.GetList(""); // 显示所有未取包裹
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = packageBll.GetList(txtExpressNo.Text.Trim());
        }

        private void btnPickup_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            { MessageBox.Show("请先选择要取件的包裹"); return; }

            int packageId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PackageId"].Value);
            int shelfId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ShelfId"].Value);
            int isPickUp = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IsPickUp"].Value);

            if (isPickUp == 1)
            { MessageBox.Show("该包裹已取件"); return; }

            // 1. 更新包裹状态为已取
            if (packageBll.Pickup(packageId))
            {
                // 2. 货架空位+1
                shelfBll.IncreaseRemainSpace(shelfId);
                MessageBox.Show("取件核销成功");
                LoadData();
            }
            else
                MessageBox.Show("核销失败");
        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int packageId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PackageId"].Value);
            decimal fine = Convert.ToDecimal(txtFineMoney.Text.Trim());

            if (packageBll.UpdateFine(packageId, fine))
            {
                MessageBox.Show("罚款登记成功");
                LoadData();
            }
        }

       private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtExpressNo.Text = dataGridView1.Rows[e.RowIndex].Cells["ExpressNo"].Value.ToString();
            txtFineMoney.Text = dataGridView1.Rows[e.RowIndex].Cells["FineMoney"].Value.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 直接调用你已有的 CellClick 逻辑
            dataGridView1_CellClick(sender, e);
        }


    }
}
