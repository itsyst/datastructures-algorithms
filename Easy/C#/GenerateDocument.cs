using System.Collections.Generic;

class GenerateDocuments
{
    // O(n+m) time | O(c) space
    // n is number of characters and m is the length of the document.
    public static bool GenerateDocument2(string characters, string document)
    {
        Dictionary<char, int> charsCount = new Dictionary<char, int>();

        for (int i = 0; i < characters.Length; i++)
        {
            char character = characters[i];
            charsCount[character] = charsCount.GetValueOrDefault(character, 0) + 1;
        }

        for (int i = 0; i < document.Length; i++)
        {
            char character = document[i];
            if (!charsCount.ContainsKey(character) || charsCount[character] == 0)
                return false;

            charsCount[character] = charsCount[character] - 1;
        }

        return true;
    }

    // O(m*(n+m)) time | O(1) space
    // n is number of characters and m is the length of the document.
    public static bool GenerateDocument1(string characters, string document)
    {
        for (int i = 0; i < document.Length; i++)
        {

            int documentCount = CharacterFrequency(document, document[i]);
            int charactersCount = CharacterFrequency(characters, document[i]);

            if (documentCount > charactersCount)
                return false;

        }

        return true;
    }
    private static int CharacterFrequency(string toScan, char character)
    {
        int count = 0;
        for (int i = 0; i < toScan.Length; i++)
        {
            if (toScan[i] == character)
                count++;
        }
        return count;
    }

}