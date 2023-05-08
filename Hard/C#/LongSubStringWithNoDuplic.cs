using System;
using System.Collections.Generic;

public class LongSubStringWithNoDuplic
{
    public static string LongestSubstringWithoutDuplication(string str)
    {
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
        int longestSubstringStart = 0;
        int longestSubstringLength = 0;
        int currentSubstringStart = 0;
        int currentSubstringLength = 0;

        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (charIndexMap.ContainsKey(c) && charIndexMap[c] >= currentSubstringStart)
            {
                currentSubstringStart = charIndexMap[c] + 1;
                currentSubstringLength = i - currentSubstringStart;
            }

            charIndexMap[c] = i;
            currentSubstringLength++;

            if (currentSubstringLength > longestSubstringLength)
            {
                longestSubstringStart = currentSubstringStart;
                longestSubstringLength = currentSubstringLength;
            }
        }

        return str.Substring(longestSubstringStart, longestSubstringLength);
    }
}
