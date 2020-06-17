using FluentFTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppForm.EquipmentService;
using AppForm.HisService;

namespace AppForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HisServiceClient hisClient = new HisServiceClient();
            EquipmentServiceClient equclient = new EquipmentServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteFile();
            ConnectionFtp("139.9.43.82", 30000, "xzh", "xzh");
            //ConnectionFtp("10.101.71.147", 30000, "payment", "payment");
        }

        private void ConnectionFtp(string ip, int port, string user, string password)
        {
            try
            {
                using (var conn = new FtpClient())
                {
                    conn.Host = ip;
                    conn.Port = port;
                    conn.Credentials = new NetworkCredential(user, password);

                    conn.EncryptionMode = FtpEncryptionMode.None;

                    conn.SslProtocols = SslProtocols.Default | SslProtocols.Tls11 | SslProtocols.Tls12;
                    conn.ValidateCertificate += OnValidateCertificate;

                    conn.Connect();

                    if (!conn.UploadFile(Application.StartupPath + "/test.txt", "/test_by_xzh.txt"))
                    {
                        MessageBox.Show("上传不成功！", "提示");
                    }

                    conn.Disconnect();

                    MessageBox.Show("上传成功！", "提示", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void OnValidateCertificate(FtpClient control, FtpSslValidationEventArgs e)
        {
            e.Accept = true;
        }

        //注册
        public void WriteFile()
        {
            string path = Path.Combine(Application.StartupPath, "FileLog", DateTime.Now.ToString("yyyy-MM-dd"));

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path += "/test.txt";
            FileStream fs = new FileStream(path, FileMode.Append);
            StreamWriter sr = new StreamWriter(fs);
            sr.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));//开始写入值
            sr.Close();
            fs.Close();
        }
    }
}
