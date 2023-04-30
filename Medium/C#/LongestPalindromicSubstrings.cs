using System;

public class LongestPalindromicSubstrings
{
    public static string LongestPalindromicSubstring(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return "";
        }

        int start = 0;
        int maxLength = 1;

        for (int i = 0; i < str.Length; i++)
        {
            int len1 = ExpandAroundCenter(str, i, i); // Check for odd-length palindrome
            int len2 = ExpandAroundCenter(str, i, i + 1); // Check for even-length palindrome
            int currLength = Math.Max(len1, len2);

            if (currLength > maxLength)
            {
                maxLength = currLength;
                start = i - (currLength - 1) / 2;
            }
        }

        return str.Substring(start, maxLength);
    }

    private static int ExpandAroundCenter(string str, int left, int right)
    {
        while (left >= 0 && right < str.Length && str[left] == str[right])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }

    public static void Main(string[] args)
    {
        string input = "babad";
        string longestPalindrome = LongestPalindromicSubstring(input);
        Console.WriteLine($"Longest palindromic substring: {longestPalindrome}");
    }
}
