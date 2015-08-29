using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pms
{
    public partial class FrmPay : BaseForm
    {
        public FrmPay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardConn conn = new CardConn();
           // string cardNo = txtCardNo.Text.Trim();
            string password = string.Empty;
            string shopId = conn.ShopId;
            string posId = conn.Posid;
            string cashierId = conn.Cashierid;
          
            string payValue = txtPayValue.Text.Trim();
            string owenerId ="11111";
            string cdSeq = "555";
            string date = DateTime.Now.ToString("YYYYMMdd");
            string time = DateTime.Now.ToString("hhmmss");
          //  Header payCardHeader = new PayCardHeader(cardNo, password, shopId, posId, cashierId,date,time, payValue, owenerId, cdSeq);

           // txtCardNo.Text = conn.PayCard(payCardHeader);

        }

        private void txtPayValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
                FrmQuery frmQuery=new FrmQuery();
                frmQuery.PayAmount = decimal.Parse(txtPayValue.Text.Trim());
                frmQuery.IsPay = true;
                frmQuery.ShowDialog();
              
            }
        }

        private void FrmPay_Load(object sender, EventArgs e)
        {
            txtPayValue.Focus();
        }
    }
}
