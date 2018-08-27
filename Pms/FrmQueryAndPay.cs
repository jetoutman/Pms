using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using log4net;

namespace Pms
{
    public partial class FrmQueryAndPay : BaseForm
    {
        private ILog log = LogManager.GetLogger("pms");
        public FrmQueryAndPay()
        {
            InitializeComponent();
            SetMonthBalanceVisible(false);
        }
        private void SetMonthBalanceVisible(bool isVisible)
        {
            lbl_MonthBalance.Visible = isVisible;
            label5.Visible = isVisible;
        }
        private string GetCardNo(string input)
        {
            var carNo = FilterChars(input);
            return carNo.Split(new[] { '=' })[0];
        }
        private string GetCardPwd(string input)
        {
            var input2 = FilterChars(input);
            string pwd = string.Empty;
            if (input2.Contains("="))
            {
                pwd = input2.Split(new[] { '=' })[1];
            }
            return pwd;
        }

        private string FilterChars(string input)
        {
            return input;
            //return input.Replace("?", "").Replace("!", "");
        }
        private void txtCardNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                SetMonthBalanceVisible(false);
                F11Exit(e);
                if (e.KeyCode == Keys.Enter) //如果输入的是回车键
                {
                    var input = txtCardNo.Text.Trim();
                    var conn = new CardConn();
                    var cardNo = GetCardNo(input);
                    txtCardNo.Text = cardNo;
                    var password = GetCardPwd(input);
                    var shopId = conn.ShopId;
                    var posId = conn.Posid;
                    var cashierId = conn.Cashierid;
                    Header queryHeader = new QueryCardHeader(cardNo, password, shopId, posId, cashierId);
                    var processResult = conn.ReadCard(queryHeader);
                    Lbl_msg.Text = processResult.Result;
                    if (processResult.IsProcessed)
                    {
                        lbl_cardNo.Text = processResult.Cardno;

                        lbl_Amount.Text = processResult.Balance.Trim();
                        var isMonthCard = !string.IsNullOrEmpty(processResult.MonthBalance);
                        SetMonthBalanceVisible(isMonthCard);
                        if (isMonthCard)
                        {
                            lbl_MonthBalance.Text = processResult.MonthBalance;
                        }
                        /*
                    decimal banlance = 0m;
                    decimal monthBanlace = 0m;
                    decimal.TryParse(processResult.Balance, out banlance);
                    decimal.TryParse(processResult.MonthBalance, out monthBanlace);
                    bool isGreatThan = IsCanPay(isMonthCard, PayAmount, monthBanlace, banlance);
                    if (IsPay && isGreatThan)
                    {
                        DialogResult dr = MessageBox.Show("卡金额足够，现在结账吗？", "付款", MessageBoxButtons.OKCancel);

                        if (dr == DialogResult.OK)
                        {
                            Pay();
                        }

                    }
                     * */
                    }
                }
            }
            catch (Exception error)
            {
                log.Error(error);
            }
            
           
        }

        public void ClearScreen()
        {
            this.txtCardNo.Text = string.Empty;
            this.txtPayValue.Text = string.Empty;
            this.lbl_cardNo.Text = string.Empty;
            this.lbl_Amount.Text = string.Empty;
            SetMonthBalanceVisible(false);
        }
        private void txtPayValue_KeyDown(object sender, KeyEventArgs e)
        {
            F11Exit(e);
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {

                FrmQuery frmQuery = new FrmQuery(this);
                frmQuery.PayAmount = decimal.Parse(txtPayValue.Text.Trim());
                frmQuery.IsPay = true;
                frmQuery.ShowDialog();
                txtPayValue.Text = string.Empty;
                txtPayValue.Focus();

            }
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
    }
}
