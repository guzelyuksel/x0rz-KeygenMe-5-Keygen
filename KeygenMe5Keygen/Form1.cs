using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace KeygenMe5Keygen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region İsimden Uint Çevirmek İçin

        public uint Rtz(string nms)
        {
            uint num = 0u;
            int num2 = 0;
            for (int i = 0; i < nms.Length; i++)
            {
                bool flag = i == 0;
                if (flag)
                {
                    for (int j = 0; j < nms.Length; j++)
                    {
                        num2 += (int)(Convert.ToChar(nms.Substring(j, 1)) % '\u0002');
                    }
                }
                else
                {
                    bool flag2 = num2 % 2 == 0;
                    if (flag2)
                    {
                        num += (uint)(Convert.ToChar(nms.Substring(i, 1)) * '\u0080') * 262144u;
                    }
                    else
                    {
                        num += (uint)(Convert.ToChar(nms.Substring(i, 1)) * 'Ā') * 262144u;
                    }
                }
            }
            bool flag3 = num2 % 2 == 0 && num < 268435456u;
            if (flag3)
            {
                num ^= 3486317601u;
            }
            else
            {
                num ^= 3756850193u;
            }
            Htr(num.ToString("X8"));
            return num;
        }

        private void Htr(string syz)
        {
            for (int i = 0; i < syz.Length; i += 2)
            {
                xyz[i - i / 2 + 7] = Convert.ToByte(Convert.ToInt32(syz.Substring(syz.Length - i - 2, 1) + syz.Substring(syz.Length - i - 1, 1), 16));
            }
        }

        #endregion İsimden Uint Çevirmek İçin

        private byte[] xyz = new byte[] { 177, 64, 177, 73, 177, 82, 56, 145, 124, 108, 103, 8, 65, 119, 113, 143, 47, 66, 181, 184, 153, 1, 152, 67, 177, 64, 177, 73, 177, 82, 56, 162, 77, 167, 159, 181, 184, 153, 1, 152, 49, 82, 119, 113, 58, 114, 128, 128, 128, 143, 47, 66, 3, 64, 65, 67 };

        public string UcluDesŞifrele(string source, string key)
        {
            TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            byte[] byteHash;
            byte[] byteBuff;
            byteHash = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(key));
            tripleDESCryptoServiceProvider.Key = byteHash;
            tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
            byteBuff = Encoding.ASCII.GetBytes(source);
            string encoded =
                Convert.ToBase64String(tripleDESCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            return encoded;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < xyz.Length; i++)
            {
                xyz[i] ^= 128;
            }
        }

        public static string Random(int length = 8)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var randomString = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < length; i++)
                randomString.Append(chars[random.Next(chars.Length)]);

            return randomString.ToString();
        }

        private void ÜretBtn_Click(object sender, EventArgs e)
        {
            // X fonksiyonu
            uint num1 = Rtz(NameTxt.Text);
            int xCL = Convert.ToInt32(num1.ToString("X8").Substring(6, 2), 16);
            uint xEDX = num1;
            num1 = num1 / (uint)xCL;
            xEDX %= (uint)xCL;
            num1 *= xEDX;
            num1 ^= 0x18811938;

            SerialTxt.Text = num1.ToString();
            string key1 = Random(12);
            string key2 = Random(12);
            string key = key1 + key2;

            string Random1 = Random(5);
            string Random2 = Random(6);
            string Random3 = Random(7);
            string Random4 = Random(8);
            string birinciveri = Random1 + key1 + Random2;
            string ikinciveri = birinciveri + UcluDesŞifrele(num1.ToString("X8"), key);
            string üçüncüveri = ikinciveri + Random3 + key1;
            string dördüncüveri = üçüncüveri + Random4;
            string beşinciveri = dördüncüveri + UcluDesŞifrele(Random2 + xEDX.ToString("X2"), key);
            string altıncıveri = beşinciveri + num1.ToString("X8") + "9" + UcluDesŞifrele(Random2 + xCL.ToString("X2"), key);
            SerialTxt.Text = Convert.ToBase64String(Encoding.ASCII.GetBytes((altıncıveri)));
            if (Otomatikİşlem.Checked)
            {
                if (MessageBox.Show(".Net Keygen Me #5 - by x0rz Açık mı?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process[] Programlar = Process.GetProcessesByName(".Net Keygen Me #5 - by x0rz");
                    if (Programlar.Length == 0)
                    {
                        goto Kopyala;
                    }
                    else
                    {
                        try
                        {
                            IntPtr intPtr = Programlar[0].MainWindowHandle;
                            SendText sendText = new SendText();
                            int NameTxtPtr = Convert.ToInt32(sendText.FindWindowByIndex(intPtr, 5).ToString().Replace("00000000", ""));
                            int SerialTxtPtr = Convert.ToInt32(sendText.FindWindowByIndex(intPtr, 6).ToString().Replace("00000000", ""));
                            int ButonPtr = Convert.ToInt32(sendText.FindWindowByIndex(intPtr, 2).ToString().Replace("00000000", ""));
                            sendText.SetText(intPtr, NameTxtPtr, NameTxt.Text);
                            sendText.SetText(intPtr, SerialTxtPtr, SerialTxt.Text);
                            sendText.SendClick(ButonPtr);
                            return;
                        }
                        catch
                        {
                            goto Kopyala;
                        }
                    }
                }
            }
            Kopyala:
            try
            {
                MessageBox.Show("Sanırım program çalışmıyor. Serial kopyalanacak. CTRL + V yapabilirsiniz.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clipboard.SetText(SerialTxt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}