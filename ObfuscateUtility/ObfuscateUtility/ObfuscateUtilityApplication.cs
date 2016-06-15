using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ObfuscateUtility
{
    public partial class ObfuscateUtilityApplication : Form
    {
        const int HandlestringLength = 20;
        const int ListSize = 10000000;
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

            //Encrypt the string handles
            var stopWatchEn = Stopwatch.StartNew();
            foreach (var handle in lstStringHandles)
            {
                lstEncryptedHandles.Add(ObfuscateUtilitiesAes.EncryptString(handle, localAes.Key, localAes.IV));
                enStringHandlePB.Value = enStringHandlePB.Value + 1;
            }
            stopWatchEn.Stop();
            var elapsedMsEn = stopWatchEn.ElapsedMilliseconds;
            txtEncryptedStr.Text = elapsedMsEn.ToString();
            txtTimeTaken.Text = lstEncryptedHandles.Max(s => s.Length).ToString();

            //Decrypt the string handles
            var stopWatchDe = Stopwatch.StartNew();
            foreach (var handle in lstEncryptedHandles)
            {
                lstDecryptedHandles.Add(ObfuscateUtilitiesAes.DecryptString(handle, localAes.Key, localAes.IV));
                deStringHandlePB.Value = deStringHandlePB.Value + 1;
            }
            stopWatchDe.Stop();
            var elapsedMsDe = stopWatchDe.ElapsedMilliseconds;
            
            //show values on form
            txtDecryptedStr.Text = elapsedMsDe.ToString();
        }

        private void btnCCASCII_Click(object sender, EventArgs e)
        {
            lstEncryptedHandles.Clear();
            lstDecryptedHandles.Clear();

            //Encrypt the string handles
            var stopWatchEn = Stopwatch.StartNew();
            foreach (var handle in lstStringHandles)
            {
                lstEncryptedHandles.Add(ObfuscateUtilitiesCaesarCipherASCII.EncryptString(handle));
            }
            stopWatchEn.Stop();
            var elapsedMsEn = stopWatchEn.ElapsedMilliseconds;


            //Decrypt the string handles
            var stopWatchDe = Stopwatch.StartNew();
            foreach (var handle in lstEncryptedHandles)
            {
                lstDecryptedHandles.Add(ObfuscateUtilitiesCaesarCipherASCII.DecryptString(handle));
            }
            stopWatchDe.Stop();
            var elapsedMsDe = stopWatchDe.ElapsedMilliseconds;

            //show values on form
            txtEncryptedStr.Text = elapsedMsEn.ToString();
            txtDecryptedStr.Text = elapsedMsDe.ToString();
            txtTimeTaken.Text = lstEncryptedHandles.Max(s => s.Length).ToString();
        }

        private void btnCCUTF8_Click(object sender, EventArgs e)
        {
            lstEncryptedHandles.Clear();
            lstDecryptedHandles.Clear();

            //Encrypt the string handles
            var stopWatchEn = Stopwatch.StartNew();
            foreach (var handle in lstStringHandles)
            {
                lstEncryptedHandles.Add(ObfuscateUtilitiesCaesarCipherUTF8.EncryptString(handle));
            }
            stopWatchEn.Stop();
            var elapsedMsEn = stopWatchEn.ElapsedMilliseconds;


            //Decrypt the string handles
            var stopWatchDe = Stopwatch.StartNew();
            foreach (var handle in lstEncryptedHandles)
            {
                lstDecryptedHandles.Add(ObfuscateUtilitiesCaesarCipherUTF8.DecryptString(handle));
            }
            stopWatchDe.Stop();
            var elapsedMsDe = stopWatchDe.ElapsedMilliseconds;

            //show values on form
            txtEncryptedStr.Text = elapsedMsEn.ToString();
            txtDecryptedStr.Text = elapsedMsDe.ToString();
            txtTimeTaken.Text = lstEncryptedHandles.Max(s => s.Length).ToString();
        }

        private void btnGenHandles_Click(object sender, EventArgs e)
        {
            lstStringHandles.Clear();
            var stopWatch = Stopwatch.StartNew();
            for (int i = 0; i <= ListSize; i++)
            {
                lstStringHandles.Add(RandomStringKeyGenerator.GetUniqueStringKey(HandlestringLength));
            }
            stopWatch.Stop();
            var elapsedMs = stopWatch.ElapsedMilliseconds;
            txtOriginalStr.Text = elapsedMs.ToString();
        }
    }
}
