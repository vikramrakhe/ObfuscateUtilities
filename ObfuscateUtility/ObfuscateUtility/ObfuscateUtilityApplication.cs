using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ObfuscateUtility
{
    public partial class ObfuscateUtilityApplication : Form
    {
        const int HandlestringLength = 20;
        const int ListSize = 10000000;
        //const int ListSize = 100;
        Aes localAes = Aes.Create();
        List<string> lstStringHandles = new List<string>(ListSize);
        List<string> lstEncryptedHandles = new List<string>(ListSize);
        List<string> lstDecryptedHandles = new List<string>(ListSize);
        public ObfuscateUtilityApplication()
        {
            InitializeComponent();
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            lstEncryptedHandles.Clear();
            lstDecryptedHandles.Clear();
            //deStringHandlePB.Value = 0;

            //Encrypt the string handles
            var stopWatchEn = Stopwatch.StartNew();
            foreach (var handle in lstStringHandles)
            {
                lstEncryptedHandles.Add(ObfuscateUtilitiesAes.EncryptString(handle, localAes.Key, localAes.IV));
                //enStringHandlePB.Value = enStringHandlePB.Value + 1;
            }
            stopWatchEn.Stop();
            var elapsedMsEn = stopWatchEn.ElapsedMilliseconds;
//            txtEncryptedStr.Text = elapsedMsEn.ToString();
//            txtTimeTaken.Text = lstEncryptedHandles.Max(s => s.Length).ToString();

            //Decrypt the string handles
            var stopWatchDe = Stopwatch.StartNew();
            foreach (var handle in lstEncryptedHandles)
            {
                lstDecryptedHandles.Add(ObfuscateUtilitiesAes.DecryptString(handle, localAes.Key, localAes.IV));
                //deStringHandlePB.Value = deStringHandlePB.Value + 1;
            }
            stopWatchDe.Stop();
            var elapsedMsDe = stopWatchDe.ElapsedMilliseconds;
            
            //show values on form
            //txtDecryptedStr.Text = elapsedMsDe.ToString();
        }

        private void btnCCASCII_Click(object sender, EventArgs e)
        {
            lstEncryptedHandles.Clear();
            lstDecryptedHandles.Clear();
            //deStringHandlePB.Value = 0;
            lstStringHandles.Clear();
            lstStringHandles.Add("WelcometoJapanChinaa");//English
            lstStringHandles.Add("日本中国へようこそ");//Japanese
            lstStringHandles.Add("Velkommen til Japan Kina");//Danish
            lstStringHandles.Add("जापान चीन के लिए आपका स्वागत है");//Hindi
            lstStringHandles.Add("ಜಪಾನ್ ಚೀನಾ ಸ್ವಾಗತ");//kannada
            lstStringHandles.Add("Welcome to Japan Sinis");//Latin
            lstStringHandles.Add("مرحبا بكم في اليابان الصين");//Arabic
            lstStringHandles.Add("歡迎來到日本中國");//Chinese
            lstStringHandles.Add("Bienvenue au Japon Chine");//French
            lstStringHandles.Add("ברוכים הבאים יפן סין");//Hebrew
            
            //Encrypt the string handles
            var stopWatchEn = Stopwatch.StartNew();
            foreach (var handle in lstStringHandles)
            {
                lstEncryptedHandles.Add(ObfuscateUtilitiesCaesarCipherASCII.EncryptString(handle));
                //enStringHandlePB.Value = enStringHandlePB.Value + 1;
            }
            stopWatchEn.Stop();
            var elapsedMsEn = stopWatchEn.ElapsedMilliseconds;
            
            //txtEncryptedStr.Text = elapsedMsEn.ToString();
            //txtTimeTaken.Text = lstEncryptedHandles.Max(s => s.Length).ToString();

            //Decrypt the string handles
            var stopWatchDe = Stopwatch.StartNew();
            foreach (var handle in lstEncryptedHandles)
            {
                lstDecryptedHandles.Add(ObfuscateUtilitiesCaesarCipherASCII.DecryptString(handle));
                //deStringHandlePB.Value = deStringHandlePB.Value + 1;
            }
            stopWatchDe.Stop();
            var elapsedMsDe = stopWatchDe.ElapsedMilliseconds;

            for (int i = 0; i < 10; i++)
            {
                string[] row = new string[] {lstStringHandles[i], Encoding.UTF8.GetByteCount(lstStringHandles[i]).ToString(), lstEncryptedHandles[i], Encoding.UTF8.GetByteCount(lstEncryptedHandles[i]).ToString(), lstDecryptedHandles[i], Encoding.UTF8.GetByteCount(lstDecryptedHandles[i]).ToString()};
                dataGridView1.Rows.Add(row);
            }


            //show values on form
            //txtDecryptedStr.Text = elapsedMsDe.ToString();
        }

        private void btnCCUTF8_Click(object sender, EventArgs e)
        {
            lstEncryptedHandles.Clear();
            lstDecryptedHandles.Clear();
            //deStringHandlePB.Value = 0;

            //Encrypt the string handles
            var stopWatchEn = Stopwatch.StartNew();
            foreach (var handle in lstStringHandles)
            {
                lstEncryptedHandles.Add(ObfuscateUtilitiesCaesarCipherUTF8.EncryptString(handle));
                //enStringHandlePB.Value = enStringHandlePB.Value + 1;
            }
            stopWatchEn.Stop();
            var elapsedMsEn = stopWatchEn.ElapsedMilliseconds;
            //.Text = elapsedMsEn.ToString();
            //txtTimeTaken.Text = lstEncryptedHandles.Max(s => s.Length).ToString();

            //Decrypt the string handles
            var stopWatchDe = Stopwatch.StartNew();
            foreach (var handle in lstEncryptedHandles)
            {
                lstDecryptedHandles.Add(ObfuscateUtilitiesCaesarCipherUTF8.DecryptString(handle));
                //deStringHandlePB.Value = deStringHandlePB.Value + 1;
            }
            stopWatchDe.Stop();
            var elapsedMsDe = stopWatchDe.ElapsedMilliseconds;

            //show values on form
            //txtDecryptedStr.Text = elapsedMsDe.ToString();
        }

        private void btnGenHandles_Click(object sender, EventArgs e)
        {
            lstStringHandles.Clear();
            //deStringHandlePB.Value = 0;
            var stopWatch = Stopwatch.StartNew();
            for (int i = 0; i <= ListSize; i++)
            {
                lstStringHandles.Add(RandomStringKeyGenerator.GetUniqueStringKey(HandlestringLength));
            }
            stopWatch.Stop();
            var elapsedMs = stopWatch.ElapsedMilliseconds;
            //txtOriginalStr.Text = elapsedMs.ToString();
        }

        private void ObfuscateUtilityApplication_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
