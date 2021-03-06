﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Pms
{
    public partial class FrmQuery : BaseForm
    {
        public decimal PayAmount { get; set; }
        public FrmQueryAndPay FrmQueryAndPay { get; set; }
        public FrmQuery()
        {
            InitializeComponent();
            txtCardNo.Focus();
            SetMonthBalanceVisible(false);

        }
        public FrmQuery(FrmQueryAndPay frmQueryAndPay)
        {
            InitializeComponent();
            FrmQueryAndPay = frmQueryAndPay;
            txtCardNo.Focus();
            SetMonthBalanceVisible(false);

        }
        private void SetMonthBalanceVisible(bool isVisible)
        {
            lbl_MonthBalance.Visible = isVisible;
            label5.Visible = isVisible;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CardConn conn = new CardConn();
            string cardNo = txtCardNo.Text.Trim();
            string password = string.Empty;
            string shopId = conn.ShopId;
            string posId = conn.Posid;
            string cashierId = conn.Cashierid;
            Header queryHeader = new QueryCardHeader(cardNo, password, shopId, posId, cashierId);
            ProcessResult processResult = conn.ReadCard(queryHeader);
            if (processResult.IsProcessed)
            {
                lbl_cardNo.Text = processResult.Cardno;
                
                lbl_Amount.Text = processResult.Balance.Trim();
            }
        }

        private string GetCardNo(string input)
        {
            input = input.Replace("?", "").Replace("!", "");
            return input.Split(new[] {'='})[0];
        }
        private string GetCardPwd(string input)
        {
            input = input.Replace("?", "").Replace("!", "");
            string pwd = string.Empty;
            if (input.Contains("="))
            {
                pwd=input.Split(new[] { '=' })[1];
            }
            return pwd;
        }
        private void txtCardNo_KeyDown(object sender, KeyEventArgs e)
        {
            SetMonthBalanceVisible(false);
            F11Exit(e);
            if (e.KeyCode == Keys.Enter) //如果输入的是回车键
            {
              
                string input = txtCardNo.Text.Trim();
                CardConn conn = new CardConn();
                string cardNo = GetCardNo(input);
                string password = GetCardPwd(input);
                string shopId = conn.ShopId;
                string posId = conn.Posid;
                string cashierId = conn.Cashierid;
                Header queryHeader = new QueryCardHeader(cardNo, password, shopId, posId, cashierId);
                ProcessResult processResult = conn.ReadCard(queryHeader);
                Lbl_msg.Text = processResult.Result;
                if (processResult.IsProcessed)
                {
                    lbl_cardNo.Text = processResult.Cardno;
                  
                    lbl_Amount.Text = processResult.Balance.Trim();
                    bool isMonthCard = !string.IsNullOrEmpty(processResult.MonthBalance);
                    SetMonthBalanceVisible(isMonthCard);
                    if (isMonthCard)
                    {
                        lbl_MonthBalance.Text = processResult.MonthBalance;
                    }
                    decimal banlance = 0m;
                    decimal monthBanlace = 0m;
                    decimal.TryParse(processResult.Balance, out banlance);
                    decimal.TryParse(processResult.MonthBalance, out monthBanlace);
                    bool isGreatThan = IsCanPay(isMonthCard,PayAmount,monthBanlace,banlance);
                    if (IsPay && isGreatThan)
                    {
                        DialogResult dr = MessageBox.Show("卡金额足够，现在结账吗？", "付款",MessageBoxButtons.OKCancel);

                        if (dr == DialogResult.OK) 
                        {
                            Pay();
                        }
                       
                    }
                }
                
                if (FrmQueryAndPay != null)
                {
                    FrmQueryAndPay.ClearScreen();
                    this.Close();
                }
            }
        }

        private bool IsCanPay(bool isMonthCard,decimal payAmount,decimal banlance,decimal monthBanlance)
        {
            decimal acutalBalance = isMonthCard ? monthBanlance : banlance;
            return acutalBalance >= payAmount;
        }
        private void Pay()
        {
            CardConn conn = new CardConn();
            string input = txtCardNo.Text.Trim();
            string cardNo = GetCardNo(input);
            string password = GetCardPwd(input);
            string shopId = conn.ShopId;
            string posId = conn.Posid;
            string cashierId = conn.Cashierid;

            string payValue = PayAmount.ToString();
            CardPrint cardPrint = new CardPrint();
            string owenerId = cardPrint.GetOrder();
            string cdSeq = "555";
            string date = DateTime.Now.ToString("yyyyMMdd");
            string time = DateTime.Now.ToString("hhmmss");
            Header payCardHeader = new PayCardHeader(cardNo, password, shopId, posId, cashierId,date,time, payValue, owenerId, cdSeq);
            ProcessResult processResult = conn.PayCard(payCardHeader);
            bool isProcess = processResult.IsProcessed;
            if (isProcess)
            {
                this.Close();
              
                cardPrint.ProcessResult = processResult;
                if (processResult.Code == "0000")
                {
                    cardPrint.Print();

                    ConfigeHelper.SetConfigValue("Order", cardPrint.GetOrderNew());
                }
               
                MessageBox.Show(processResult.Result);

            }
           
        }

        private void FrmQuery_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        
        }
        
    }
}