using System;
using System.Collections.Generic;
using System.Text;

namespace Pms
{
    class ProcessResult
    {
        public string Length { get; set; }
        public string Tranid { get; set; }
        public string Code { get; set; }
        public string Cardno { get; set; }
        public string Passwd { get; set; }
        public string NewPasswd { get; set; }
        public string Recstat { get; set; }
        public string Stat { get; set; }
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
        public string Result { get; set; }
        public bool IsProcessed { get; set; }
      
        public ProcessResult(string result)
        {
            //4+5+5+20+9+9+1+1+5+5+5+9+9+13+13+11+5+13
            Length = result.Substring(0, 4).Replace("\0", "");
            Tranid = result.Substring(4, 5).Replace("\0", "");
            Code = result.Substring(9, 5).Replace("\0", "");
            Cardno = result.Substring(14, 20).Replace("\0", "");
            Passwd = result.Substring(34, 9).Replace("\0", "");
            NewPasswd = result.Substring(43, 9).Replace("\0", "");
            Recstat = result.Substring(52, 1).Replace("\0", "");
            Stat = result.Substring(53, 1).Replace("\0", "");
            Shopid = result.Substring(54, 5).Replace("\0", "");
            Posid = result.Substring(54, 5).Replace("\0", "");
            Cashierid = result.Substring(59, 5).Replace("\0", "");
            Date = result.Substring(69, 9).Replace("\0", "");
            Time = result.Substring(78, 9).Replace("\0", "");
            Payvalue = result.Substring(87, 13).Replace("\0", "");
            Balance = result.Substring(100, 13).Replace("\0", "");
            Owner = result.Substring(113, 11).Replace("\0", "");
            Cdseq = result.Substring(124, 5).Replace("\0", "");
           Guestname = result.Substring(129,13).Replace("\0", ""); 
          
           

           
        }

     /*   public string GetChsFromHex(string hex)
        {
            if (hex == null)
                throw new ArgumentNullException("hex");
            if (hex.Length % 2 != 0)
            {
                hex += "20";//空格
                //throw new ArgumentException("hex is not a valid number!", "hex");
            }
            // 需要将 hex 转换成 byte 数组。
            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    // 每两个字符是一个 byte。
                    bytes[i] = byte.Parse(hex.Substring(i * 2, 2),
                        System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    // Rethrow an exception with custom message.
                    throw new ArgumentException("hex is not a valid hex number!", "hex");
                }
            }

            // 获得 GB2312，Chinese Simplified。
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");

            return chs.GetString(bytes);
        }
        public string GetHexFromChs(string s)
        {
            if ((s.Length % 2) != 0)
            {
                s += " ";//空格
                //throw new ArgumentException("s is not valid chinese string!");
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");
            byte[] bytes = chs.GetBytes(s);
            string str = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                str += string.Format("{0:X}", bytes[i]);
            }
            return str;
        }*/

    }
}
