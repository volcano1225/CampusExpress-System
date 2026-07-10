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
    public partial class FrmSendManage : Form
    {
        SendRecordBLL sendBll = new SendRecordBLL();
        ExpressCategoryBLL cateBll = new ExpressCategoryBLL();
        StudentInfoBLL stuBll = new StudentInfoBLL();
        public FrmSendManage()
        {
            InitializeComponent();
        }

        private void btnCalcFee_Click(object sender, EventArgs e)
        {
            decimal weight = Convert.ToDecimal(txtWeight.Text.Trim());
            // 简单公式：首重10元 + 续重每公斤2元
            decimal fee = 10 + (weight > 1 ? (weight - 1) * 2 : 0);
            if (cmbSize.SelectedItem.ToString() == "大") fee += 5;
            txtFee.Text = fee.ToString("F2");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Global.CurrentRole == "Student")
            {
                // 校验限次
                int used = sendBll.GetTodaySendCount(Global.CurrentUserId);
                int limit = stuBll.GetSendLimit(Global.CurrentUserId);
                if (used >= limit)
                { MessageBox.Show("今日寄件次数已达上限"); return; }
            }

            SendRecord sr = new SendRecord();
            sr.StuId = Global.CurrentUserId;
            sr.SendAddress = txtSendAddress.Text.Trim();
            sr.TotalFee = Convert.ToDecimal(txtFee.Text);
            sr.PayWay = 2; // 线下现金
            sr.IsPay = 0;  // 未缴费

            if (sendBll.Add(sr))
            {
                MessageBox.Show("寄件提交成功，请前往柜台缴费");
                LoadSendRecord();
            }
        }
        private void LoadSendRecord()
        {
            if (Global.CurrentRole == "Student")
                dataGridView1.DataSource = sendBll.GetListByStudent(Global.CurrentUserId);
            else
                dataGridView1.DataSource = sendBll.GetList("");
        }

        private void FrmSendManage_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = cateBll.GetList("");
            cmbCategory.DisplayMember = "CateName";
            cmbCategory.ValueMember = "CateId";

            cmbSize.Items.Add("小"); cmbSize.Items.Add("中"); cmbSize.Items.Add("大");
            cmbSize.SelectedIndex = 0;

            // 直接写刷新逻辑，不调用方法
            if (Global.CurrentRole == "Student")
                dataGridView1.DataSource = sendBll.GetListByStudent(Global.CurrentUserId);
            else
                dataGridView1.DataSource = sendBll.GetList("");

            if (Global.CurrentRole == "Student")
            {
                int used = sendBll.GetTodaySendCount(Global.CurrentUserId);
                int limit = stuBll.GetSendLimit(Global.CurrentUserId);
                lblLimit.Text = "今日剩余寄件次数：" + (limit - used);
            }
        }
    }
    
}

