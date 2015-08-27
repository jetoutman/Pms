using System;
using System.Collections.Generic;

using System.Text;

namespace Pms
{
    internal class QueryCardHeader : Header
    {
        private const string LENGTH = "129";
        private const string TRANID = "3010";
        private const string CODE = "-001";
        public QueryCardHeader( string cardno, string password,string shopId,string posId,string cashierId)
            : base(LENGTH, TRANID, CODE)
        {
            Cardno = cardno;
            Passwd = password;
            Shopid = shopId;
            Posid = posId;
            Cashierid = cashierId;
        }
      
        
        
        
    }
}