using System;
using System.Collections.Generic;

using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Pms
{
    class CardConn
    {
        private static readonly string cardServer = ConfigeHelper.GetConfigString("CardServer");
        private static readonly int point = ConfigeHelper.GetConfigInt("Point");
        public readonly string ShopId = ConfigeHelper.GetConfigString("ShopId");
        public readonly string Posid = ConfigeHelper.GetConfigString("Posid");
        public readonly string Cashierid = ConfigeHelper.GetConfigString("Cashierid");

        public static readonly IList<KeyValuePair<string, string>> QueryResultList = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("0000", "查询成功"),
            new KeyValuePair<string, string>("0071", "卡号：不是储值卡"),
            new KeyValuePair<string, string>("0099", "无此卡号"),
            new KeyValuePair<string, string>("0098", "密码错"),
            new KeyValuePair<string, string>("0097", "帐款未到帐"),
            new KeyValuePair<string, string>("0096", "冻结"),
            new KeyValuePair<string, string>("0095", "余额不足"),
            new KeyValuePair<string, string>("0094", "退卡"),
            new KeyValuePair<string, string>("0093", "一般挂失卡"),
            new KeyValuePair<string, string>("0092", "已回收卡"),
            new KeyValuePair<string, string>("0091 ", "严重挂失卡"),
            new KeyValuePair<string, string>("0094", "退卡"),
            new KeyValuePair<string, string>("0090", "其它错误"),
        };

        public static readonly IList<KeyValuePair<string, string>> PayResultList = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("0000", "支付成功"),
            new KeyValuePair<string, string>("0099", "无此卡号"),
            new KeyValuePair<string, string>("0098", "密码错"),
            new KeyValuePair<string, string>("0097", "帐款未到帐"),
            new KeyValuePair<string, string>("0096", "冻结"),
            new KeyValuePair<string, string>("0095", "余额不足"),
            new KeyValuePair<string, string>("0094", "退卡"),
            new KeyValuePair<string, string>("0093", "一般挂失卡"),
            new KeyValuePair<string, string>("0092", "已回收卡"),
            new KeyValuePair<string, string>("0091 ", "严重挂失卡"),
            new KeyValuePair<string, string>("0094", "退卡"),
            new KeyValuePair<string, string>("0090", "其它错误"),
        };

        public static readonly IList<KeyValuePair<string, string>> NegativePayResultList = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("0000", "支付成功"),
        };
        public ProcessResult ReadCard(Header header)
        {
            return Process(header, QueryResultList);

        }

        public ProcessResult PayCard(Header header)
        {
            return Process(header, PayResultList);

        }

        public ProcessResult NegativePayCard(Header header)
        {
            return Process(header, NegativePayResultList);
        }

        private ProcessResult Process(Header header, IList<KeyValuePair<string, string>> list)
        {
            string data = GetData(header);
            int i = data.Length;
            bool isProcess = false;
            ProcessResult processResult = new ProcessResult(data);
            string result = "其它错误";
            string code = processResult.Code;

            foreach (var keyValuePair in list)
            {
                if (keyValuePair.Key == code)
                {
                    result = keyValuePair.Value;
                    isProcess = true;
                    break;

                }
            }
            processResult.Result = result;
            processResult.IsProcessed = isProcess;
            return processResult;
        }
      
      
    

        public void Print(string str)
        {
            
        }

        private string GetData(Header header)
        {
            string querycard = header.ToTransData();
            string stringdata = string.Empty;
            byte[] data = new byte[1024];

            data = Encoding.ASCII.GetBytes(querycard);
            Socket newclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            try
            {
                IPEndPoint ie = new IPEndPoint(IPAddress.Parse(cardServer), point); //服务器的IP和端口
                newclient.Connect(ie);
            }
            catch (SocketException e)
            {
                stringdata = "未连接服务器" + e.ToString();
            }
            catch (Exception error)
            {
                stringdata = error.ToString();
            }
            newclient.Send(data, data.Length, 0);
            int recv = newclient.Receive(data);
            stringdata = Encoding.ASCII.GetString(data, 0, recv);

            newclient.Shutdown(SocketShutdown.Both);
            newclient.Close();
            return stringdata;
        }
    }
}
