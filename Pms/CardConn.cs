using System;
using System.Collections.Generic;

using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Pms
{
    class CardConn
    {
        public static readonly IList<KeyValuePair<string, string>> QueryResultList = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("0000","查询成功"),
                new KeyValuePair<string, string>("0099","无此卡号"),
                new KeyValuePair<string, string>("0098","密码错"),
                new KeyValuePair<string, string>("0097","帐款未到帐"),
                new KeyValuePair<string, string>("0096","冻结"),
                new KeyValuePair<string, string>("0095","余额不足"),
                new KeyValuePair<string, string>("0094","退卡"),
                new KeyValuePair<string, string>("0093","一般挂失卡"),
                 new KeyValuePair<string, string>("0092","已回收卡"),
                new KeyValuePair<string, string>("0091 ","严重挂失卡"),
                 new KeyValuePair<string, string>("0094","退卡"),
                new KeyValuePair<string, string>("0090","其它错误"),
            };
        public static readonly IList<KeyValuePair<string, string>> PayResultList = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("0000","支付成功"),
                new KeyValuePair<string, string>("0099","无此卡号"),
                new KeyValuePair<string, string>("0098","密码错"),
                new KeyValuePair<string, string>("0097","帐款未到帐"),
                new KeyValuePair<string, string>("0096","冻结"),
                new KeyValuePair<string, string>("0095","余额不足"),
                new KeyValuePair<string, string>("0094","退卡"),
                new KeyValuePair<string, string>("0093","一般挂失卡"),
                 new KeyValuePair<string, string>("0092","已回收卡"),
                new KeyValuePair<string, string>("0091 ","严重挂失卡"),
                 new KeyValuePair<string, string>("0094","退卡"),
                new KeyValuePair<string, string>("0090","其它错误"),
            };
        public static readonly IList<KeyValuePair<string, string>> NegativePayResultList = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("0000","支付成功"),
                new KeyValuePair<string, string>("0099","无此卡号"),
                new KeyValuePair<string, string>("0098","密码错"),
                new KeyValuePair<string, string>("0097","帐款未到帐"),
                new KeyValuePair<string, string>("0096","冻结"),
                new KeyValuePair<string, string>("0095","余额不足"),
                new KeyValuePair<string, string>("0094","退卡"),
                new KeyValuePair<string, string>("0093","一般挂失卡"),
                 new KeyValuePair<string, string>("0092","已回收卡"),
                new KeyValuePair<string, string>("0091 ","严重挂失卡"),
                 new KeyValuePair<string, string>("0094","退卡"),
                new KeyValuePair<string, string>("0090","其它错误"),
            };
        public string ReadCard(Header header)
        {
            return Process(header, QueryResultList);

        }

        public string PayCard(Header header)
        {
            return Process(header, PayResultList);

        }

        public string NegativePayCard(Header header)
        {
            return Process(header, NegativePayResultList);
        }

        private string Process(Header header,IList<KeyValuePair<string, string>> list)
        {
            string data = GetData(header);
            string showResult = "其它错误";
            string result = data.Substring(9, 5).Replace("\0", "");

            foreach (var keyValuePair in list)
            {
                if (keyValuePair.Key == result)
                {
                    showResult = keyValuePair.Value;
                    if (keyValuePair.Key == "0000")
                    {
                        showResult += data.Substring(81, 13).Replace("\0", "");
                    }
                }
            }
            return showResult;
        }

       
        private string GetData(Header header)
        {
            string querycard = header.ToTransData();
            string stringdata = string.Empty;
            byte[] data = new byte[1024];
            data = Encoding.UTF8.GetBytes(querycard);
            Socket newclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ie = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4006); //服务器的IP和端口
            try
            {
                newclient.Connect(ie);
            }
            catch (SocketException e)
            {
                stringdata = "未连接服务器" + e.ToString();
            }
            newclient.Send(data, data.Length, 0);
            int recv = newclient.Receive(data);
            stringdata = Encoding.UTF8.GetString(data, 0, recv);

            newclient.Shutdown(SocketShutdown.Both);
            newclient.Close();
            return stringdata;
        }
    }
}
