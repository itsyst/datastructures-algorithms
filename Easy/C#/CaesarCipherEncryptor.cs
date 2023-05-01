using System;
using System.Text;

class CaesarCipherEncryption
{
    public const int ENGLISH_ALPHABET = 26;
    public static string Encrypt(string str, int key)
    {
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsLower(str[i]))
            {
                int aToDec = Convert.ToInt16('a');
                int charToDec = Convert.ToInt16(str[i]);
                int character = (charToDec - aToDec + key) % ENGLISH_ALPHABET + aToDec;

                char ch = (char)(character);
                output.Append(ch);
            }
        }
        return output.ToString();
    }
}