using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace AppForm
{
    public partial class Form3 : Form
    {
        public class RoomInfo
        {
            public string roomId { get; set; }
            public string roomNo { get; set; }
            public decimal? roomPriceByDay { get; set; }
            public decimal? roomPriceByMonth { get; set; }
            public decimal? roomPriceByQuarter { get; set; }
            public decimal? roomPriceByHalfYear { get; set; }
            public decimal? roomPriceByYear { get; set; }
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /*MessageBox.Show("要想获得帮助。请按F1");
            HP = new HelpProvider();
            string Source = "Help.txt";
            HP.HelpNamespace = Source;
            HP.SetShowHelp(this, true);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
             requestId	请求方系统编号	string (20)	Y	服务请求方系统编号
             targetId	目标系统编号	string (20)	Y	交易处理系统需指定目标系统编号。
             serviceId	服务编号	string (50)	Y	服务编号
             timestamp	消息发送日期	string (30)	Y	消息发送的时间。格式为yyyy-MM-dd HH:mm:ss.mmm,24小时制精确到毫秒
             userId	服务请求方身份	string (30)	N	服务请求方的身份（可使用虚拟人员编号）
             password	服务请求方密码	string (30)	N	服务请求方的访问密码（需要为密文）
             seqNo	交易流水号	string (50)	Y	业务系统的流水号，由业务系统填写。
			 	
             transNo	全局交易流水号	string (50)	Y	业务系统的全局交易流水号，由业务系统填写。
				

             */
            /*ZLEFM_SD_CUSTOMER2 x = new ZLEFM_SD_CUSTOMER2();
            ZLEFM_SD_CUSTOMER21 w = new ZLEFM_SD_CUSTOMER21();
            x.Url = "https://lyesb-test.evergrande.com:18813/SAPID/SAP/TGzlefmficreateacc2?wsdl=ZLEFM_FI_CREATE_ACC2.wsdl";
            x.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            w.SHEAD = new ZSCOMM_0005()
            {
                REQUESTID = "HMS",
                TARGETID = "SAP",
                SERVICEID = "TGzlefmsdcustomer2",
                TIMESTAMP = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.mmm"),
                USERID = "",
                PASSWORD = "",
                SEQNO = "",
                TRANSNO = ""
            };
            w.SBODY = "{\"VKORG\":\"1000\",\"DATEFROM\":\"2020-03-01\",\"DATETO\":\"2020-03-13\",\"ZXTBS\":\"\",\"KTOKD\":\"\"}";
            var result = x.CallZLEFM_SD_CUSTOMER2(w).RESULT;
            string s = "";*/

            /*List<RoomInfo> list = new List<RoomInfo>();
            int floor = 100;
            for (int i = 0; i < floor; i++)
            {
                string index = (i + 1) <= 9 ? "0" + (i + 1) : (i + 1).ToString();
                for (int j = 0; j < 50; j++)
                {
                    RoomInfo roomInfo = new RoomInfo();
                    roomInfo.roomNo = ((j + 1) > 9 ? index : index + "0") + (j + 1);
                    //roomInfo.roomId = "000825" + roomInfo.roomNo;
                    list.Add(roomInfo);
                }
            }
            Dictionary<string, string> columnInfo = new Dictionary<string, string>();
            columnInfo.Add("roomNo", "房号");
            columnInfo.Add("roomPriceByMonth", "月租");
            columnInfo.Add("roomPriceByDay", "日租");
            columnInfo.Add("roomPriceByQuarter", "季度租");
            columnInfo.Add("roomPriceByHalfYear", "半年租");
            columnInfo.Add("roomPriceByYear", "年租");

            ExportExcelTest(list, Application.StartupPath + @"/Export.xlsx", columnInfo);*/
        }

        #region  NPOI大数据量多个sheet导出

        /// <summary>
        /// 大数据量多个sheet导出
        /// </summary>
        /// <typeparam name="T">数据源实体类</typeparam>
        /// <param name="objList">数据源</param>
        /// <param name="fileName">文件名称</param>
        /// <param name="btyBytes">导出数据流</param>
        /// <param name="columnInfo">显示列对应数据字典</param>
        /// <param name="listCount">每个sheet包含数据条数</param>
        /// <returns></returns>
        public void ExportExcelTest<T>(List<T> objList, string fileName, Dictionary<string, string> columnInfo = null)
        {
            //在内存中生成一个Excel文件：
            IWorkbook book = new HSSFWorkbook();
            if (objList != null && objList.Count > 0)
            {
                var sheetName = new string[] { "日租", "月租", "季度租", "半年租", "年租" };
                double sheetCount = sheetName.Count();
                for (int i = 0; i < sheetCount - 1; i++)
                {
                    ISheet sheet = book.CreateSheet(sheetName[i]);
                    List<T>  list = objList.ToList();

                    int rowIndex = 0;
                    Type myType = objList[0].GetType();

                    //创建表头样式
                    ICellStyle style = book.CreateCellStyle();
                    style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    style.WrapText = true;
                    IFont font = book.CreateFont();
                    font.FontHeightInPoints = 16;
                    font.Boldweight = (short)FontBoldWeight.Bold;
                    font.FontName = "微软雅黑";
                    style.SetFont(font);//HEAD 样式

                    //根据反射从传递进来的属性名信息得到要显示的属性
                    List<PropertyInfo> myPro = new List<PropertyInfo>();

                    #region 定义表头
                    int m = 0;
                    if (columnInfo != null)
                    {
                        var rowheader = sheet.CreateRow(0);
                        rowheader.Height = 20 * 20;
                        foreach (string cName in columnInfo.Keys)
                        {
                            PropertyInfo p = myType.GetProperty(cName);
                            if (p != null)
                            {
                                myPro.Add(p);
                                rowheader.CreateCell(m).SetCellValue(columnInfo[cName]);
                                m++;
                            }
                        }
                    }
                    #endregion
                    #region 定义表体并赋值
                    //如果没有找到可用的属性则结束
                    if (myPro.Count == 0) { return ; }
                    foreach (T obj in list)
                    {
                        int n = 0;
                        if (sheet != null)
                        {
                            rowIndex++;
                            var sheetrow = sheet.CreateRow(rowIndex);
                            sheetrow.Height = 20 * 20;
                            foreach (PropertyInfo p in myPro)
                            {
                                dynamic val = p.GetValue(obj, null) ?? "";
                                string valtype = val.GetType().ToString();
                                if (valtype.ToLower().IndexOf("decimal", StringComparison.Ordinal) > -1)
                                {
                                    val = Convert.ToDouble(val);
                                }
                                sheetrow.CreateCell(n).SetCellValue(val);
                                n++;
                            }
                        }

                    }
                    #endregion
                }
            }
            else
            {
                //在工作薄中建立工作表
                XSSFSheet sheet = book.CreateSheet() as XSSFSheet;
                sheet.SetColumnWidth(0, 30 * 256);
                if (sheet != null) sheet.CreateRow(0).CreateCell(0).SetCellValue("暂无数据！");
            }

            if (File.Exists(fileName))
            {
                //存在 
                File.Delete(fileName);
             }

            var fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fs.Flush();
            book.Write(fs);
            fs.Close();
        }

        #endregion
    }
}
