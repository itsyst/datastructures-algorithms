using System;
using System.Collections.Generic;
using System.Text;

public class ReverseWordsInStrings
{
    public static string ReverseWordsInString(string str)
    {
        int start = 0;
        int end = 0;
        List<string> words = new List<string>();

        while (end <= str.Length)
        {
            if (end == str.Length || str[end] == ' ')
            {
                words.Add(str.Substring(start, end - start));
                start = end + 1;
            }
            end++;
        }

        StringBuilder reversedString = new StringBuilder();
        for (int i = words.Count - 1; i >= 0; i--)
        {
            reversedString.Append(words[i]);
            if (i > 0)
            {
                reversedString.Append(' ');
            }
        }

        return reversedString.ToString();
    }

    public static void Main(string[] args)
    {
        string input = "trim is great";
        string reversedWords = ReverseWordsInString(input);
        Console.WriteLine($"Reversed words: {reversedWords}");
    }
}
