using System;
using System.Collections.Generic;

using System.Text;

namespace Pms
{
    internal class QueryCardHeader : Header
    {
       
        private const string TRANID = "3010";
        private const string CODE = "-001";
        private const string C_Recstat = "0";
        private const string C_Stat = "0";
        public QueryCardHeader( string cardno, string password,string shopId,string posId,string cashierId)
            : base(TRANID, CODE)
        {
            Cardno = cardno;
            Passwd = password;
            Shopid = shopId;
            Posid = posId;
            Cashierid = cashierId;
            Recstat = C_Recstat;
            Stat = C_Stat;
        }
      
        
        
        
    }
}