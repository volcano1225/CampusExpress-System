using System;
using System.Data;
using System.Windows.Forms;
using Express.BLL;
using Express.Model;
using Express.DAL;  // 需要用到 ExpressPackageDAL

namespace Express.UI
{
    public partial class FrmMySend : Form
    {
        SendRecordBLL sendBll = new SendRecordBLL();
        StudentInfoBLL stuBll = new StudentInfoBLL();
        ExpressCategoryBLL cateBll = new ExpressCategoryBLL();
        ExpressPackageDAL packageDal = new ExpressPackageDAL();  // 新增：用于创建包裹

        public FrmMySend()
        {
            InitializeComponent();
        }

        private void FrmMySend_Load(object sender, EventArgs e)
        {
            // 加载快递公司到下拉框
            DataTable dt = cateBll.GetList("");
            cmbCompany.DataSource = dt;
            cmbCompany.DisplayMember = "CateName";
            cmbCompany.ValueMember = "CateId";

            LoadData();
            UpdateLimit();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWeight.Text)) return;

            decimal weight = Convert.ToDecimal(txtWeight.Text);
            decimal fee = 10 + (weight - 1) * 5;
            if (fee < 10) fee = 10;
            txtFee.Text = fee.ToString("0.00");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // ========== 1. 保留：校验上限 ==========
            DataTable dt = stuBll.GetList("");
            DataRow[] rows = dt.Select("StuId = " + Global.CurrentUserId);
            if (rows.Length == 0) return;

            int max = Convert.ToInt32(rows[0]["MaxSendNum"]);
            if (dgvSend.Rows.Count >= max)
            {
                MessageBox.Show("今日寄件次数已达上限");
                return;
            }

            // ========== 2. 新增：先创建包裹记录（解决外键冲突） ==========
            ExpressPackage pkg = new ExpressPackage();
            pkg.ExpressNo = "SJ" + DateTime.Now.ToString("yyyyMMddHHmmss");
            pkg.CateId = Convert.ToInt32(cmbCompany.SelectedValue);

            // 窗体没有收件人姓名/电话控件，用地址前10字作为收件人，学生手机号作为收件电话
            string addr = txtAddress.Text.Trim();
            pkg.ReceiverName = addr.Length > 0 ? addr.Substring(0, Math.Min(10, addr.Length)) : "未知";
            pkg.ReceiverPhone = rows[0]["Phone"] != DBNull.Value ? rows[0]["Phone"].ToString() : "13800000000";
            pkg.PackageWeight = Convert.ToDecimal(txtWeight.Text.Trim());
            pkg.PackageSize = "中";  // 窗体无尺寸控件，默认中
            pkg.Price = Convert.ToDecimal(txtFee.Text.Trim());
            pkg.SenderName = Global.CurrentRealName;
            pkg.SenderPhone = rows[0]["Phone"] != DBNull.Value ? rows[0]["Phone"].ToString() : "";
            pkg.Status = 5;  // 5=已寄出（自定义状态）

            int packageId = packageDal.AddPackage(pkg);
            if (packageId <= 0)
            {
                MessageBox.Show("包裹创建失败");
                return;
            }

            // ========== 3. 保留：插入寄件记录（带上 PackageId） ==========
            SendRecord sr = new SendRecord();
            sr.StuId = Global.CurrentUserId;
            sr.PackageId = packageId;  // ← 关键：外键，带上刚创建的包裹ID
            sr.SendAddress = txtAddress.Text.Trim();
            sr.TotalFee = Convert.ToDecimal(txtFee.Text.Trim());
            sr.PayWay = 2;  // 线下现金
            sr.IsPay = 0;   // 未缴费

            if (sendBll.Add(sr))
            {
                MessageBox.Show("寄件申请提交成功，请到驿站缴费");
                LoadData();
                Clear();
                UpdateLimit();
            }
            else
            {
                MessageBox.Show("寄件记录插入失败");
            }
        }

        void LoadData()
        {
            DataTable dt = sendBll.GetList("");
            DataView dv = dt.DefaultView;
            dv.RowFilter = "StuId = " + Global.CurrentUserId;
            dgvSend.DataSource = dv.ToTable();
        }

        void UpdateLimit()
        {
            DataTable dt = stuBll.GetList("");
            DataRow[] rows = dt.Select("StuId = " + Global.CurrentUserId);
            if (rows.Length > 0)
            {
                int max = Convert.ToInt32(rows[0]["MaxSendNum"]);
                int used = dgvSend.Rows.Count;
                int remain = max - used;
                if (remain < 0) remain = 0;
                lblLimit.Text = "今日剩余寄件次数：" + remain;
            }
        }

        void Clear()
        {
            txtAddress.Clear();
            txtWeight.Clear();
            txtFee.Clear();
        }
    }
}