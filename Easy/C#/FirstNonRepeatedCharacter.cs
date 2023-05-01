using System.Collections.Generic;

class FirstNonRepeatedCharacter
{
    public static int FirstNonRepeatingCharacter2(string str)
    {
        Dictionary<char, int> visited = new Dictionary<char, int>();
        char[] chars = str.ToLower().ToCharArray();

        foreach (var ch in chars)
            visited[ch] = visited.GetValueOrDefault(ch, 0) + 1;

        for (int i = 0; i < str.Length; i++)
            if (visited[chars[i]] == 1)
                return i;

        return -1;
    }


    // O(n^2) time | O(1) space where n is the length of the input string
    public static int FirstNonRepeatingCharacter1(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            bool visited = false;
            for (int j = 0; j < str.Length; j++)
                if (str[i] == str[j] && i != j)
                    visited = true;
            
            if(!visited)
                return i;
        }
        return -1;
    }
}
