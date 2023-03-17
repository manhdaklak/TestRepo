using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace GIT
{
    public partial class MN : Form
    {
        public MN()
        {
            InitializeComponent();
        }
        private string strUserName = ConfigurationManager.AppSettings["UserName"];
        private string strFolder = ConfigurationManager.AppSettings["Folder"];
        private string strTitle = string.Empty;

        public object StandardCharsets { get; private set; }

        private void btnCreateBranch_Click(object sender, EventArgs e)
        {
            GetDateTime(ref strTitle);
            txtNameBranch.Text = strTitle + "-";
            Clipboard.SetText(txtNameBranch.Text);
            string a = "{\"merchantId\":\"{MerchantId}\",\"reqData\":\"{reqData}\"}";
            string c = "{" + "MerchantId" + "}";
            string b = a.Replace(c, "1222222222");

        }
        private void btnBranchCherry_Click(object sender, EventArgs e)
        {
            GetDateTime(ref strTitle);
            txtBranchCherry.Text = strTitle + "-Cherry-";
            Clipboard.SetText(txtBranchCherry.Text);
            string str = "{\"serviceName\":\"ADD_ORDER_INFOR\",\"orderId\":\"o1\",\"posId\":\"p1\", \"amount\":\"1000\", \"description\" : \"mo ta 1\" }";
            string key = "0123456789ABCDEF";
            string strEn = EncryptAES128(key, str);
            string strDe = DecryptAES128(key, strEn);

            var date1 = new DateTime(2022, 7, 15);
            var date2 = new DateTime(2023, 10, 13);
            var diff = date2- date1;

        }
        private void GetDateTime(ref string strTitle)
        {
            string strGetDay = DateTime.Now.ToString("dd-MM");
            string strGetTime = DateTime.Now.ToString("HH.mm.ss");
            strTitle = strFolder + "/" + strUserName + "/Day." + strGetDay + ".Time." + strGetTime;
        }
        public static string EncryptAES128(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = ASCIIEncoding.ASCII.GetBytes(key);
                aes.IV = iv;
                aes.Mode = CipherMode.ECB;
                aes.BlockSize = 128;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(array);
        }
        public static string DecryptAES128(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);
            using (Aes aes = Aes.Create())
            {
                aes.Key = ASCIIEncoding.ASCII.GetBytes(key);
                aes.IV = iv;
                aes.Mode = CipherMode.ECB;
                aes.BlockSize = 128;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

    }
}
