using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObfuscateUtility
{
    public partial class ObfuscateUtilityApplication : Form
    {
        const int HandlestringLength = 20;
        Aes localAes = Aes.Create();
        public ObfuscateUtilityApplication()
        {
            InitializeComponent();
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            //Generate random strings
            //Encrypt them and monitor the time
            //decrypt them and monitor the time
            //Make sure string matches original after decription

            string OriginalHandleString = RandomStringKeyGenerator.GetUniqueStringKey(HandlestringLength);
            string ObfuscatedHandleString = ObfuscateUtilitiesAes.EncryptString(OriginalHandleString, localAes.Key, localAes.IV);
            string DecryptedString = ObfuscateUtilitiesAes.DecryptString(ObfuscatedHandleString, localAes.Key, localAes.IV);

            //show values on form
            txtOriginalStr.Text = OriginalHandleString;
            txtEncryptedStr.Text = ObfuscatedHandleString;
            txtDecryptedStr.Text = DecryptedString;

            if (!OriginalHandleString.Equals(DecryptedString))
            {
                MessageBox.Show("Error in Program", "ObfuscateUtilityApplication", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void btnCCASCII_Click(object sender, EventArgs e)
        {
            string OriginalHandleString = RandomStringKeyGenerator.GetUniqueStringKey(HandlestringLength);
            string ObfuscatedHandleString = ObfuscateUtilitiesCaesarCipherASCII.EncryptString(OriginalHandleString);
            string DecryptedString = ObfuscateUtilitiesCaesarCipherASCII.DecryptString(ObfuscatedHandleString);

            //show values on form
            txtOriginalStr.Text = OriginalHandleString;
            txtEncryptedStr.Text = ObfuscatedHandleString;
            txtDecryptedStr.Text = DecryptedString;

            if (!OriginalHandleString.Equals(DecryptedString))
            {
                MessageBox.Show("Error in Program", "ObfuscateUtilityApplication", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void btnCCUTF8_Click(object sender, EventArgs e)
        {
            string OriginalHandleString = RandomStringKeyGenerator.GetUniqueStringKey(HandlestringLength);
            string ObfuscatedHandleString = ObfuscateUtilitiesCaesarCipherUTF8.EncryptString(OriginalHandleString);
            string DecryptedString = ObfuscateUtilitiesCaesarCipherUTF8.DecryptString(ObfuscatedHandleString);

            //show values on form
            txtOriginalStr.Text = OriginalHandleString;
            txtEncryptedStr.Text = ObfuscatedHandleString;
            txtDecryptedStr.Text = DecryptedString;

            if (!OriginalHandleString.Equals(DecryptedString))
            {
                MessageBox.Show("Error in Program", "ObfuscateUtilityApplication", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }
    }
}
