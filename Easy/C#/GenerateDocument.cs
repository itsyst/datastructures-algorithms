class GenerateDocuments
{
    // O(m*(n+m)) time | O(1) space
    // n is number of characters and m is the length of the document.
    public static bool GenerateDocument(string characters, string document)
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