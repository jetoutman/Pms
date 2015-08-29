using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pms
{
    public partial class FrmNavPay :BaseForm
    {
        public FrmNavPay()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string cardNo = txtCardNo.Text.Trim();
            string password = txtPassword.Text.Trim();
            string shopId = txtShopId.Text.Trim();
            string posId = txtPosId.Text.Trim();
            string cashierId = txtCashierId.Text.Trim();
            string payValue = txtPayValue.Text.Trim();
            string owenerId = txtOwner.Text.Trim();
            string cdSeq = txtCdseq.Text.Trim();
            string date = DateTime.Now.ToString("YYYYMMdd");
            string time = DateTime.Now.ToString("hhmmss");
            Header negativePayHeader = new NegativePayHeader(cardNo, password, shopId, posId, cashierId, date, time, payValue, owenerId, cdSeq);
            CardConn cardCon = new CardConn();
            ProcessResult proccessResult = cardCon.NegativePayCard(negativePayHeader);
        }
    }
}
