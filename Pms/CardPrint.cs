using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Reporting.WinForms;

namespace Pms
{
    internal class CardPrint
    {
        private static readonly string MKTNAME = ConfigeHelper.GetConfigString("MKTNAME");
        private static readonly string MKT = ConfigeHelper.GetConfigString("MKT");
        private static readonly string OPER = ConfigeHelper.GetConfigString("OPER");
        private static readonly string OPERNAME = ConfigeHelper.GetConfigString("OPERNAME");
        public static int Order = ConfigeHelper.GetConfigInt("Order");
        private static readonly int PrintType = ConfigeHelper.GetConfigInt("pttype");
        public readonly string Posid = ConfigeHelper.GetConfigString("Posid");
        public ProcessResult ProcessResult { get; set; }
        public string PrintContent { get; set; }
        private int m_currentPageIndex;
        private IList<Stream> m_streams;

        private string PrintReceiptTemplate()
        {
            StringBuilder stringBuilder = new StringBuilder(1024);
            stringBuilder.AppendLine("        顾客卡消费存根");
            stringBuilder.AppendLine("-------------------------------");
            stringBuilder.AppendFormat("卖场名称: {0}", MKTNAME);
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("卖 场 号: {0}", MKT);
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("终 端 号: {0}", Posid);
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("小 票 号: {0}", GetOrder());
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("收银员号: [{0}]{1}", OPER, OPERNAME);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("-------------------------------");
            stringBuilder.AppendFormat("卡    号: {0}", ProcessResult.Cardno);
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("交易类别: {0}", "消费");
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("交易时间: {0}", DateTime.Now);
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("交易金额: {0}   卡余额 {1}", ProcessResult.Payvalue, ProcessResult.Balance);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("1.本人同意支付上述款项");
            stringBuilder.AppendLine("2.持卡人签字:");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("");

            return stringBuilder.ToString();
        }

        public string GetOrderNew()
        {
            Order++;
            return Order.ToString();
        }

        private string GetOrder()
        {
            string orderStr = Order.ToString();
            return orderStr;
        }

        private void PrintTextFileHandler(object sender, PrintPageEventArgs args)
        {
           
            Graphics g = args.Graphics;
            float leftMargin = args.MarginBounds.Left;

            float topMargin = args.MarginBounds.Top;

            string line = null;
            Font verdana10Font = new Font("Verdana", 10);
            verdana10Font.GetHeight(g);
            float linesPerPage = 17;

            float yPos = 0;

            int count = 0;

            using (StringReader reader = new StringReader(PrintContent))
            {
                while (count < linesPerPage && ((line = reader.ReadLine()) != null))
                {
                    yPos = topMargin + (count*verdana10Font.GetHeight(g));
                    g.DrawString(line, verdana10Font, Brushes.Black,
                        leftMargin, yPos, new StringFormat());
                    count++;
                }

                if (line != null)
                {
                    args.HasMorePages = true;
                }

                else
                {
                    args.HasMorePages = false;
                }
            }
        }

       

        public void Print()
        {
            WriteLog();
          
            if (PrintType == 1)
            {
                PrintBills();
            }
            else
            {
                PrintReceipt();
               
            }
          
        }
        private void WriteLog()
        {
            PrintContent = PrintReceiptTemplate();
            string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string logFile = Path.Combine(appPath, DateTime.Now.ToString("yyyyMMdd") + @".txt");
            using (FileStream fs = new FileStream(logFile, FileMode.Append))
            {
                byte[] byteData = Encoding.Default.GetBytes(PrintContent);
                fs.Write(byteData, 0, byteData.Length);
                fs.Close();
            }
        }
        private void PrintReceipt()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            pd.Print();
           
        }

        private void PrintBills()
        {
            LocalReport report = new LocalReport();
            string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string rptPath = Path.Combine(appPath, "RptBill.rdlc");
            report.ReportPath = rptPath;
            report.SetParameters(new ReportParameter("Cardno", ProcessResult.Cardno));
            report.SetParameters(new ReportParameter("Mkt", MKT));
            report.SetParameters(new ReportParameter("PayValue", ProcessResult.Payvalue));
            report.SetParameters(new ReportParameter("Banlance", ProcessResult.Balance));
            report.SetParameters(new ReportParameter("Order", GetOrder()));
            report.SetParameters(new ReportParameter("Oper", OPER));
            report.SetParameters(new ReportParameter("OperName", OPERNAME));
            report.SetParameters(new ReportParameter("CardType", ProcessResult.Guestname));
            ExportBillsReport(report);
            PrintReport();
        }

        private void PrintBillsPage(object sender, PrintPageEventArgs ev)
        {
            try
            {
                Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);
                Rectangle adjustedRect = new Rectangle(
                    ev.PageBounds.Left - (int) ev.PageSettings.HardMarginX,
                    ev.PageBounds.Top - (int) ev.PageSettings.HardMarginY,
                    ev.PageBounds.Width,
                    ev.PageBounds.Height);
                ev.Graphics.FillRectangle(Brushes.White, adjustedRect);
                ev.Graphics.DrawImage(pageImage, adjustedRect);
                ev.HasMorePages = false;
                m_currentPageIndex++;
                /*ev.HasMorePages = (m_currentPageIndex < m_streams.Count);*/
            }
            catch (Exception error)
            {
                string ss = error.ToString();
                throw;
            }
        }

        private void PrintReport()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintBillsPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        // ExportBillsReport the given report as an EMF (Enhanced Metafile) file.
        private void ExportBillsReport(LocalReport report)
        {
            string deviceInfo =
                @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0.25in</MarginTop>
                <MarginLeft>0.25in</MarginLeft>
                <MarginRight>0.25in</MarginRight>
                <MarginBottom>0.25in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,out warnings);
            foreach (Stream stream in m_streams)
            stream.Position = 0;
        }

       

        // Routine to provide to the report renderer, in order to
        //    save an image for each page of the report.
        private Stream CreateStream(string name,string fileNameExtension, Encoding encoding,string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }
    }
}