
namespace ObfuscateUtility
{
    public static class ObfuscateUtilitiesCaesarCipherUTF8
    {
        private static string s_key = @"0123456789:;<=>?@JFKGOTMYVHSPCANDXLRWEBQUIZ[\]^-'jfkgotmyvhspcandxlrwebquiz";
        public static string EncryptString(string plainText)
        {
            char[] chars = new char[plainText.Length];
            for (int i = 0; i < plainText.Length; i++)
            {
                if (plainText[i] == ' ')
                {
                    chars[i] = ' ';
                }
                else
                {
                    int j = plainText[i] - 48;
                    chars[i] = s_key[j];
                }
            }

            return new string(chars);
        }

        public static string DecryptString(string obfuscatedString)
        {
            char[] chars = new char[obfuscatedString.Length];
            for (int i = 0; i < obfuscatedString.Length; i++)
            {
                if (obfuscatedString[i] == ' ')
                {
                    chars[i] = ' ';
                }
                else
                {
                    //int j = obfuscatedString[i] + 48;
                    //chars[i] = s_key[j];

                    int j = s_key.IndexOf(obfuscatedString[i]) + 48;
                    chars[i] = (char)j;
                }
            }
            return new string(chars);
        }
    }
}
