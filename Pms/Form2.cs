using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            Header payCardHeader = new PayCardHeader(cardNo, password, shopId, posId, cashierId,date,time, payValue, owenerId, cdSeq);
            CardConn cardCon=new CardConn();
            textBox1.Text = cardCon.PayCard(payCardHeader);
           
        }
    }
}
