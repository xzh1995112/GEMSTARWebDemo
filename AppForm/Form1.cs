using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Spire.Pdf;
using Spire.Pdf.General.Find;
using System.Drawing;
using System.Collections.Generic;
using iTextSharp.xmp.impl;

namespace AppForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //Main
        private void button1_Click(object sender, EventArgs e)
        {
            var url = "https://openapi.bestsign.info/openapi/v2/storage/contract/download/?developerId=1552635811012161536&rtick=15879678721290&signType=rsa&sign=o9eCg0Zr0y6FdMv%2Balpr9C3H66R6YCAT2a1VvUBCzpLvlckTAX4SBdef8Ae2Xq%2FoGUFA66t0N%2BrUObrni%2BXDn8XGVpjzqq4DrEFeHwc7lyqJNVnFQHprrSY%2Fv4c3qG6BHbuMUGTXzvIJZFRKqSSetIoh2qDxvGG1%2BYNl3FsBaASf7ZybVSWTKnLOTVAQCJIhMpJ9GrqI4N3%2B%2FdmZKYbMKm5P1moa7ULpuLi3o6Tn1cQVKWogjW5r6q3Prw2rFR50o%2FEX2y0sqpkwHCN7tuRuSWPpe5o9vcQGM%2FkxhjZCIE4EVmLlh%2B4R3%2BDibnyH3M0tX3V0nX5VUkWPFwnfWsORoQ%3D%3D&contractId=156151051001000001";
          //var url = "https://openapi.bestsign.info/openapi/v2/storage/contract/download/?developerId=1552635811012161536&rtick=15879587315540&signType=rsa&sign=P8TeJMF8Ur0qc53yI%2BbCuXGUE39mSBHuGdV2AOGVYEQ4qCKyDck7lIAnjLSvrmI%2F8tS%2Bt0EDRTJ6uguBO%2FolPsAcWMNuHAEE24rv5K0EwCRfLcg69sqbng5FHbsHkdjotDcqgKbpNsoNFCcl5ynHF%2Bm3cZun76qTd6WRUL%2F3oUd%2B6P2xiVldRn5eXyfUejWSduMUbGKnpPOrVBQZu3IoxoNf0yBD%2Boaz9p%2BPQLMxnT38ppfjF2ysZWeLFsp3laj%2BwZSjO7B%2FjvJiKDEkmjjpPgkqz9ehXIgkTCsY5l4brucxQDcC8LyhTAjYC2j4RBoKfVXN6tDZzIG2bygLq3sKkA%3D%3D&contractId=158795552001000001";
          //iTextChange(url);

            /*PdfReader readerTemp = new PdfReader(@"D:\桌面备份\目录\Git\GEMSTARWebDemo\AppForm\长租合同.pdf");
            PdfHelper.LocationTextExtractionStrategyEx pz = new PdfHelper.LocationTextExtractionStrategyEx();
            PdfReaderContentParser p = new PdfReaderContentParser(readerTemp);
            p.ProcessContent(1, pz);

            this.richTextBox1.Text = pz.GetResultantText();//文字坐标信息等
            this.richTextBox1.Text = "";//文字坐标信息等
            var textInfos = pz.TextLocationInfo;
            foreach (var item in textInfos)
            {
                if (item.Text.Contains("使用人确认签字"))
                {
                    this.richTextBox1.Text += item.Text + " Bottom：" + item.BottomRight + " Top：" + item.TopLeft + " " + Environment.NewLine;
                }
            }*/

            SpireChange(url);
        }

        public async void iTextChange(string url)
        {
            byte[] buffer = await GetStream(url);
            string text = ExtractTextFromPdf(buffer);
            this.richTextBox1.Text = text;
        }

        public async void SpireChange(string url)
        {
            //url = "https://openapi.bestsign.info/openapi/v2/storage/contract/download/?developerId=1552635811012161536&rtick=15879806269530&signType=rsa&sign=QIAwfvzYdj2VyEZiPQq10TkDhxxwnBPZQzuvfjSeER9qNcuff6fp6zI34UrnRyM8FQURyRaEt98H37Ntnccdv12SZ0KN1CRu1w3%2F0EODcZVfUMFucotHOGgoAagBHrZQS6Zc9rvDWaNazYQFRW8hYS3XnmDaQkCqSJ%2FOt%2BRqcNVX8hvyZkYqSuU6GDz7JbtdKV%2B2glUfGJyeNPQcLuzTFTqrLGwOIwRrela6f0CafNkwfpOURvkiTUgf0Hd4Gt5OXw22%2FL2EDYvEaXlIjyastkGc2WXLcNGMnTAk7HTKfULcmEFyBzVKYeuvhAt6pCDW01M7kQQPXi%2Fi6KA5KhZ%2F%2Bw%3D%3D&contractId=158797930501000001";
            url = "https://openapi.bestsign.info/openapi/v2/storage/contract/download/?developerId=1552635811012161536&rtick=15895128046650&signType=rsa&sign=Gh6GoWVXqfB%2FvGSn1TcXKfr%2Fjl4TdaQggmDSLfDHaUoduJXvns1r7ZlVFi9Q2HVtipuSiqYl0DnfTSoRDdd42LQOgB9BL56N9UJXB0D8tK4u3CZd7xtNCi%2Fwr%2BeyXi%2FvaiupJeIZnaXGL1rfsE%2BowLGJyFmbBhnpWMZze9v2Q3rXm49YvXrVZam0yYXU56v3UfLAwZh1zwGj5mVbLgW1UMAqfLRJnP%2FJVfRJZQrJ7Zl1uQxgZGRQjjilghbijTkA3Z3%2Fy9I1fV4JCW7QPbciBFyrg7wXFSAnKnuqGPbBRXsQpxdEdYYRAyw4H%2Be3kOE1ccOoROpxH%2Bc7qEiJRdVgkA%3D%3D&contractId=158797930501000001";
            //加载文档
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            byte[] buffer = await GetStream(url);

            doc.LoadFromBytes(buffer);
            StringBuilder str = new StringBuilder();
            List<Image> ListImage = new List<Image>();
            foreach (PdfPageBase page in doc.Pages)
            {
                // 获取所有pages里面的图片
                Image[] images = page.ExtractImages();
                if (images != null && images.Length > 0)
                {
                    ListImage.AddRange(images);
                }

                str.Append(page.ExtractText().Replace("Evaluation Warning : The document was created with Spire.PDF for .NET.",""));
                
                /*PdfTextFind[] result = page.FindText("使用人确认签字", TextFindParameter.None).Finds;
                foreach (PdfTextFind text in result)
                {
                    //获取文字的坐标，宽度和高度
                    PointF pf = text.Position;
                    SizeF size = text.Size;
                    pf.X = pf.X;
                    pf.Y = pf.Y;
                    str.Append(pf + " size：" + size + Environment.NewLine);
                }*/
            }

            // 将提取到的图片保存到本地路径
            //if (ListImage.Count > 0)
            {
                for (int i = 0; i < ListImage.Count; i++)
                {
                    Image image = ListImage[i];
                    image.Save("image" + (i + 1).ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                }

            }

            doc.SaveToFile("PDF.html", FileFormat.HTML);
            doc.SaveToFile("下载.pdf", FileFormat.PDF);
            this.richTextBox1.Text = str.ToString();
        }

        public static string ExtractTextFromPdf(byte[] data)
        {
            using (PdfReader reader = new PdfReader(data))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                return text.ToString();
            }
        }

        public static string ExtractTextFromPdf(string path)
        {
            using (PdfReader reader = new PdfReader(path))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                return text.ToString();
            }
        }

        #region Tools

        /// <summary>
        /// 通用方法
        /// </summary>
        /// <returns></returns>
        private async Task<byte[]> GetStream(string url)
        {
            var buffer = await new HttpClient().GetByteArrayAsync(url);
            return buffer;
        }

        /// <summary>
        /// 将文件转换成byte[] 数组
        /// </summary>
        /// <param name="fileUrl">文件路径文件名称</param>
        /// <returns>byte[]</returns>
        protected byte[] GetFileData(string fileUrl)
        {
            FileStream fs = new FileStream(fileUrl, FileMode.Open, FileAccess.Read);
            try
            {
                byte[] buffur = new byte[fs.Length];
                fs.Read(buffur, 0, (int)fs.Length);

                return buffur;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (fs != null)
                {
                    //关闭资源
                    fs.Close();
                }
            }
        }


        /// <summary>
        /// 将文件转换成byte[] 数组
        /// </summary>
        /// <param name="fileUrl">文件路径文件名称</param>
        /// <returns>byte[]</returns>

        protected byte[] AuthGetFileData(string fileUrl)
        {
            using (FileStream fs = new FileStream(fileUrl, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] buffur = new byte[fs.Length];
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(buffur);
                    bw.Close();
                }
                return buffur;
            }
        }

        #endregion
    }
}
