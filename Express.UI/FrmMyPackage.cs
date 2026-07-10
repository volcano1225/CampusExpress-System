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
    public partial class FrmMyPackage : Form
    {
        ExpressPackageBLL bll = new ExpressPackageBLL();

        public FrmMyPackage()
        {
            InitializeComponent();
        }

        private void FrmMyPackage_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("全部");
            cmbStatus.Items.Add("待取件");
            cmbStatus.Items.Add("已取件");
            cmbStatus.Items.Add("滞留罚款");
            cmbStatus.SelectedIndex = 0;
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.GetList("");
            string filter = "ReceiverStuId = " + Global.CurrentUserId;

            if (cmbStatus.SelectedIndex == 1) filter += " AND Status = 1";
            else if (cmbStatus.SelectedIndex == 2) filter += " AND Status = 2";
            else if (cmbStatus.SelectedIndex == 3) filter += " AND Status = 3";

            if (!string.IsNullOrEmpty(txtExpressNo.Text.Trim()))
                filter += " AND ExpressNo LIKE '%" + txtExpressNo.Text.Trim() + "%'";

            DataRow[] rows = dt.Select(filter);
            DataTable result = dt.Clone();
            foreach (DataRow r in rows) result.ImportRow(r);
            dataGridView1.DataSource = result;
        }

        private void LoadData()
        {
            DataTable dt = bll.GetList("");
            DataRow[] rows = dt.Select("ReceiverStuId = " + Global.CurrentUserId);
            DataTable result = dt.Clone();
            foreach (DataRow r in rows) result.ImportRow(r);
            dataGridView1.DataSource = result;
        }
    }
}
