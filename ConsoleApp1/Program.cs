using Gemstar.BSPMS.Common.Tools;
using System;
using System.Timers;

namespace ConsoleApp1
{
    class Program
    {
        static Timer timer = null;
        static int time = 120;
        static void Main(string[] args)
        {
            #region MyRegion

            /*timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 1000; //执行间隔时间,单位为毫秒; 这里实际间隔为10分钟  
            timer.Start();
            timer.Elapsed += new ElapsedEventHandler(test);

            Console.ReadKey();*/

            /*var xmlInfo = @"<?xml version='1.0' encoding='gbk'?>    
                            <RoomFolio>  
                                <Rows>  
                                    <Row>
                                        <RegId>0002501316</RegId>
                                        <RoomNo>0602</RoomNo>
                                        <GuestCname>迟付账测试</GuestCname>
                                        <ArrDate>2019-07-29 09:28:00</ArrDate>
                                        <Payment></Payment>
                                        <isTransfer>1</isTransfer>
                                        <ExcutiveRate>298</ExcutiveRate>
                                        <Balance>1296</Balance>
                                        <ApprovalAmt>0</ApprovalAmt>
                                        <EnableAmount>1296</EnableAmount>
                                        <WqPersons>0</WqPersons>
                                        <PhotoUrl>
                                        </PhotoUrl>
                                    </Row>  
                                </Rows>
                            </RoomFolio>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlInfo);

            List<HouseXmlNodeResult> list = new List<HouseXmlNodeResult>();

            XmlNodeList topM = doc.SelectNodes("//Row");
            foreach (XmlElement element in topM)
            {
                var item = new HouseXmlNodeResult()
                {
                    RegId = element.GetElementsByTagName("RegId")[0].InnerText,
                    RoomNo = element.GetElementsByTagName("RoomNo")[0].InnerText,
                    GuestCname = element.GetElementsByTagName("GuestCname")[0].InnerText,
                    ArrDate = element.GetElementsByTagName("ArrDate")[0].InnerText,
                    Payment = element.GetElementsByTagName("Payment")[0].InnerText,
                    isTransfer = element.GetElementsByTagName("isTransfer")[0].InnerText,
                    ExcutiveRate = element.GetElementsByTagName("ExcutiveRate")[0].InnerText,

                    //关于金额需要特殊处理一下 2019-08-07
                    Balance = (element.GetElementsByTagName("Balance").Count > 0 ? element.GetElementsByTagName("Balance")[0].InnerText : "0"),
                    ApprovalAmt = (element.GetElementsByTagName("ApprovalAmt").Count > 0 ? element.GetElementsByTagName("ApprovalAmt")[0].InnerText : "0"),
                    ApprovalAdj = (element.GetElementsByTagName("ApprovalAdj").Count > 0 ? element.GetElementsByTagName("ApprovalAdj")[0].InnerText : "0"),
                    LimitAmount = (element.GetElementsByTagName("LimitAmount").Count > 0 ? element.GetElementsByTagName("LimitAmount")[0].InnerText : "0"),
                    Chargeamt = (element.GetElementsByTagName("Chargeamt").Count > 0 ? element.GetElementsByTagName("Chargeamt")[0].InnerText : "0"),
                    EnableAmount = (element.GetElementsByTagName("EnableAmount").Count > 0 ? element.GetElementsByTagName("EnableAmount")[0].InnerText : "0"),
                    Remark = (element.GetElementsByTagName("Remark").Count > 0 ? element.GetElementsByTagName("Remark")[0].InnerText : ""),
                    CashRemark = (element.GetElementsByTagName("CashRemark").Count > 0 ? element.GetElementsByTagName("CashRemark")[0].InnerText : ""),
                    WqPersons = (element.GetElementsByTagName("WqPersons").Count > 0 ? element.GetElementsByTagName("WqPersons")[0].InnerText : ""),
                    Cerid = (element.GetElementsByTagName("Cerid").Count > 0 ? element.GetElementsByTagName("Cerid")[0].InnerText : ""),
                    PhotoUrl = (element.GetElementsByTagName("PhotoUrl").Count > 0 ? element.GetElementsByTagName("PhotoUrl")[0].InnerText : "")
                };

                list.Add(item);
            }

            Console.WriteLine(new JavaScriptSerializer().Serialize(list));
            Console.ReadLine();*/

            #endregion

            Console.WriteLine(CryptHelper.DecryptDES("JekU5x1j+17mBuir4pFcNg=="));
        }

        private static void test(object source, ElapsedEventArgs e)
        {
            if (time <= 0)
            {
                timer.Stop();
            }
            else
            {
                time--;
                Console.WriteLine(time.ToString());
            }
        }

        public class HouseXmlNodeResult
        {
            public string RegId { get; set; }
            public string RoomNo { get; set; }
            public string GuestCname { get; set; }
            public string ArrDate { get; set; }
            public string Payment { get; set; }
            public string isTransfer { get; set; }
            public string ExcutiveRate { get; set; }
            public string Balance { get; set; }
            public string ApprovalAmt { get; set; }
            public string ApprovalAdj { get; set; }
            public string LimitAmount { get; set; }
            public string Chargeamt { get; set; }
            public string EnableAmount { get; set; }
            public string Remark { get; set; }
            public string CashRemark { get; set; }
            public string WqPersons { get; set; }
            public string Cerid { get; set; }
            public string PhotoUrl { get; set; }
        }
    }
}
