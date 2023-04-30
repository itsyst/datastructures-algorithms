using System;
using System.Linq;
using System.Collections.Generic;

class GroupAnagramss
{
    public static List<List<string>> GroupAnagrams(List<string> words)
    {
        Dictionary<string, List<string>> anagramDict = new Dictionary<string, List<string>>();

        foreach (string word in words)
        {
            char[] charArray = word.ToCharArray();
            Array.Sort(charArray);
            string sortedWord = new string(charArray);

            if (anagramDict.ContainsKey(sortedWord))
            {
                anagramDict[sortedWord].Add(word);
            }
            else
            {
                anagramDict[sortedWord] = new List<string> { word };
            }
        }

        return anagramDict.Values.ToList();
    }

    static void Main(string[] args)
    {
        List<string> words = new List<string> { "cinema", "iceman", "foo", "ofo", "listen", "silent", "foos", "soof" };
        List<List<string>> anagramGroups = GroupAnagrams(words);

        foreach (List<string> group in anagramGroups)
        {
            Console.WriteLine($"Anagram group: {string.Join(", ", group)}");
        }
    }
}
