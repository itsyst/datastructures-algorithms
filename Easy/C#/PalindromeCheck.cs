using System;
using System.Text;
class PalindromeCheck
{
    // O(n^2) time | O(n) space
    public static bool IsPalindrome1(string str)
    {
        if (str == null)
            return false;

        string input = " ";

        for (int i = str.Length - 1; i >= 0; i--)
            input += str[i];

        return str.Equals(input);
    }

    // O(n) time | O(n) space
    public static bool IsPalindrome2(string str)
    {
        StringBuilder input = new StringBuilder(str);

        char[] charArray = input.ToString().ToCharArray();
        Array.Reverse(charArray);

        string newString = new string(charArray);
        input.Replace(input.ToString(), newString);

        return input.Equals(str);
    }

    // O(n) time | O(n) space
    public static bool IsPalindrome3(string str)
    {
        StringBuilder input = new StringBuilder(str);

        for (int i = str.Length - 1; i >= 0; i--)
            input.Append(str[i]);

        return str.Equals(input.ToString());
    }

    // O(n) time | O(n) space
    public static bool IsPalindrome4(string str)
    {
        if (str == null)
            return false;

        return IsPalindrome4(str, 0);
    }

    private static bool IsPalindrome4(string str, int i)
    {
        int j = str.Length - (1 + i);
        return i >= j ? true : str[i] == str[j] && IsPalindrome4(str, i + 1);
    }


    // O(n) time | O(1) space
    public static bool IsPalindrome5(String str)
    {
        if (str == null)
            return false;

        var left = 0;
        var right = str.Length  - 1;

        while (left < right)
        {
            if (str[left++] != str[right--])
                return false;
        }
        return true;
    }
}
