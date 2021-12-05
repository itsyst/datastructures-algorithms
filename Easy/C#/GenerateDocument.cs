class GenerateDocuments
{
    public static bool GenerateDocument(string characters, string document)
    {
        if(document.Length == 0){
            return true;
        }

        bool output = false;

        for (int i = 0; i < document.Length; i++){
            int documentCount = CharacterFrequency(document, document[i]);
            int charactersCount = CharacterFrequency(characters, document[i]);

            if (documentCount <= charactersCount )
                output =   true;
            else 
                return false;
        }

        return output;
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