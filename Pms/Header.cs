using System;
using System.Collections.Generic;

using System.Text;

namespace Pms
{
   abstract class Header
    {
        public string Length { get; set; }
        public string Tranid { get; set; }
        public string Code { get; set; }
        public string Cardno { get; set; }
        public string Passwd { get; set; }
        public string Recstat { get; set; }
        public  string Stat { get; set; }
        public string Shopid { get; set; }
        public string Posid { get; set; }
        public string Cashierid { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Payvalue { get; set; }
        public string Balance { get; set; }
        public string Owner { get; set; }
        public string Cdseq { get; set; }
        public string Guestname { get; set; }

       protected Header(string length, string tranid, string code)
        {
            Length = length;
            Tranid = tranid;
            Code = code;
           
        }
        
       public virtual string ToTransData()
       {
           StringBuilder builder = new StringBuilder(1024);
           builder.AppendFormat(RepeartChar(Length, 4));
           builder.AppendFormat(RepeartChar(Tranid, 5));
           builder.AppendFormat(RepeartChar(Code, 5));
           builder.AppendFormat(RepeartChar(Cardno, 20));
           builder.AppendFormat(RepeartChar(Passwd, 9));
           builder.AppendFormat(RepeartChar(Recstat, 1));
           builder.AppendFormat(RepeartChar(Stat, 1));
           builder.AppendFormat(RepeartChar(Shopid, 5));
           builder.AppendFormat(RepeartChar(Posid, 5));
           builder.AppendFormat(RepeartChar(Cashierid, 5));
           builder.AppendFormat(RepeartChar(Date, 9));
           builder.AppendFormat(RepeartChar(Time, 9));
           builder.AppendFormat(RepeartChar(Payvalue, 13));
           builder.AppendFormat(RepeartChar(Balance, 13));
           builder.AppendFormat(RepeartChar(Owner, 11));
           builder.AppendFormat(RepeartChar(Cdseq, 5));
           builder.AppendFormat(RepeartChar(Guestname, 13));
           return builder.ToString();
       }

       protected string RepeartChar(string str,char charstr, int repeartCount)
       {
           if (string.IsNullOrEmpty(str))
           {
               str = string.Empty;
           }
           return str.PadRight(repeartCount, charstr);

       }
       protected string RepeartChar(string str, int repeartCount)
       {
           return RepeartChar(str, '\0',repeartCount);
          
       }
    }
}
