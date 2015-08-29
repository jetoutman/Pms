using System;
using System.Collections.Generic;
using System.Text;

namespace Pms
{
    class PayCardHeader:Header
    {
      
        private const string C_TRANID = "3020";
        private const string C_CODE = "-001";
        private const string C_Recstat = "4";
        private const string C_Stat = "0";
        public PayCardHeader(string cardno, string password, string shopId, string posId, string cashierId, string date, string time, string payValue, string owner, string cdseq)
            : base(C_TRANID, C_CODE)
        {
            Cardno = cardno;
            Passwd = password;
            Shopid = shopId;
            Posid = posId;
            Cashierid = cashierId;
            Recstat = C_Recstat;
            Stat = C_Stat;
            Date = date;
            Time = time;
            Payvalue = payValue;
            Owner = owner;
            Cdseq = cdseq;
        }
      

       
    }
}
