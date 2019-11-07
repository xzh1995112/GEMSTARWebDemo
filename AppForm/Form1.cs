using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Threading.Tasks;
using System.Net.Http;

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
			var url = "https://openapi.bestsign.info/openapi/v2/storage/contract/download/?developerId=1552635811012161536&rtick=15711111702850&signType=rsa&sign=IVbtnBJ%2BVXBpONZM6VCjRJNPOT1KFcElANfdTYtDvCkA4LJo5dD8IlU%2BMINKCwt1kXLrUixYBdalBynWRVU5XE%2FEQ6nRkYkYDMI1hkgZp277NV4EJ0QbPOeVYVLoJlaIgRbJZ8AZUZANVYyLd9UaMCvCrkq5BtlkBLDSSR%2BoF4wPFJ5U0esx6gE3c%2F59BRNdRpz0LcxKDGHJKfMbvdSryfoyhD9cBT3FA4hB%2F%2F8KYVEQ5IlOF9Spiy5olbK7Pqt3sN3DFWUW82ZZu6DvH8TFYwU5DvyNnaBLwzkyE2Rxij7SiTRP7So1K%2B%2BpbS5jbovyVqE7J4JdAMCd5Hp1H1mwGQ%3D%3D&contractId=156151051001000001";
			Change(url);
		}

		public async void Change(string url)
		{
			byte[] buffer = await GetStream(url);
			string text = ExtractTextFromPdf(buffer);
			this.richTextBox1.Text = text;
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
			return await new HttpClient().GetByteArrayAsync(url);
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
