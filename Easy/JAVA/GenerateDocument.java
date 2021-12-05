import java.util.HashMap;

public class GenerateDocument {
    // O((n+m)) time | O(s) space
    // n is number of characters and m is the length of the document.
    public static boolean generateDocument2(String characters, String document) {
        HashMap<Character, Integer> charsCount = new HashMap<>();

        for (int i = 0; i < document.length(); i++) {
            char character = characters.charAt(i);
            charsCount.put(character, charsCount.getOrDefault(character, 0) + 1);
        }

        for (int i = 0; i < document.length(); i++) {
            char character = document.charAt(i);
            if (!charsCount.containsKey(characters) || charsCount.get(character) == 0)
                return false;
            
            charsCount.put(character, charsCount.get(character) - 1);
        }

        return true;
    }

    // O(m*(n+m)) time | O(1) space
    // n is number of characters and m is the length of the document.
    public static boolean generateDocument1(String characters, String document) {
        for (int i = 0; i < document.length(); i++) {

            int documentCount = characterFrequency(document, document.charAt(i));
            int charactersCount = characterFrequency(characters, document.charAt(i));

            if (documentCount > charactersCount)
                return false;

        }

        return true;
    }

    private static int characterFrequency(String toScan, char character) {
        int count = 0;
        for (int i = 0; i < toScan.length(); i++) {
            if (toScan.charAt(i) == character)
                count++;
        }
        return count;
    }

    public static void main(String[] args) {
        String characters = "aheaol";
        String document = "hello";
        boolean result =  GenerateDocument.generateDocument2(characters, document);
        System.out.println(result);
    }
    
}