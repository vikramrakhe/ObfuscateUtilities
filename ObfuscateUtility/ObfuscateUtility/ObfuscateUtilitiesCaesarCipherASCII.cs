using System;
using System.Text;


namespace ObfuscateUtility
{
    public static class ObfuscateUtilitiesCaesarCipherASCII
    {
        private static int m_key = 1820943356;

        public static string EncryptString(string plainText)
        {
            //plainText = "あいうえお";
            byte[] obsicatedbytes = EncryptDecrypt(Encoding.UTF8.GetBytes(plainText));
            return Convert.ToBase64String(obsicatedbytes);
        }

        public static string DecryptString(string obfuscatedString)
        {
           byte[] decryptedbytes = EncryptDecrypt(Convert.FromBase64String(obfuscatedString));
           return Encoding.UTF8.GetString(decryptedbytes);
        }

        private static byte[] EncryptDecrypt(byte[] toEncrypt)
        {
            byte[] output = new byte[toEncrypt.Length];
            for (int i = 0; i < toEncrypt.Length; i++)
            {
                output[i] = (byte)(toEncrypt[i] ^ m_key);
            }

            return output;
        }
    }
}
