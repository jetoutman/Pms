using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace Pms
{
    public partial class Form1 : Form
    {
        public Form1()
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
            Header queryHeader = new QueryCardHeader(cardNo, password, shopId, posId, cashierId);
            CardConn conn = new CardConn();
            //textBox1.Text = conn.ReadCard(queryHeader);
        }
    }
}
