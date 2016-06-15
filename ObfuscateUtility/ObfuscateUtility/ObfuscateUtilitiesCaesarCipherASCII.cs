using System.Text;

namespace ObfuscateUtility
{
    public static class ObfuscateUtilitiesCaesarCipherASCII
    {
        public static string EncryptString(string plainText)
        {
            //plainText = "MyHandleStringForTesting";

            //encrypt the ASCII String now.
            return Rot47(Encoding.ASCII.GetBytes(plainText));
        }

        public static string DecryptString(string obfuscatedString)
        {
            return Rot47(Encoding.ASCII.GetBytes(obfuscatedString)); ;
        }
        
        private static char Rot47(char chr)
        {
            if (chr == ' ') return ' ';
            int ascii = chr;
            ascii += 47;
            if (ascii > 126) ascii -= 94;
            if (ascii < 33) ascii += 94;
            return (char)ascii;
        }

        private static string Rot47(byte[] str)
        {
            string RetStr = "";
            foreach (char c in str)
                RetStr += Rot47(c).ToString();
            return RetStr;
        }

    }
}
