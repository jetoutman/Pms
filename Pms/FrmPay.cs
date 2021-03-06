﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
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
            F11Exit(e);
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
              
                FrmQuery frmQuery=new FrmQuery();
                frmQuery.PayAmount = decimal.Parse(txtPayValue.Text.Trim());
                frmQuery.IsPay = true;
                frmQuery.ShowDialog();
                txtPayValue.Text = string.Empty;
                txtPayValue.Focus();

            }
        }

        private void FrmPay_Load(object sender, EventArgs e)
        {
            txtPayValue.Focus();
        }

        private void txtPayValue_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"!/^\d+[.]?\d{0,2}$");
            var matchs = regex.Match(txtPayValue.Text);
            //txtPayValue.Text = ss;
        }

        private void txtPayValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isNotExistDot = txtPayValue.Text.Contains(".") == false;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((isNotExistDot && e.KeyChar == '.') || e.KeyChar == '\b')
            {
                e.Handled = false;
            } 
        }

        private void FrmPay_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            HotKeySets[1] = false;
        }
    }
}
