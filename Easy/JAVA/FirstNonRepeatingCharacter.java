import java.util.HashMap;

public class FirstNonRepeatingCharacter {

    public static int firstNonRepeatingCharacter2(String str)
    {
        HashMap<Character, Integer> visited = new HashMap<>();
        char[] chars = str.toLowerCase().toCharArray();

        for (var ch : chars)
            visited.put(ch, visited.getOrDefault(ch, 0) +1); 

        for (int i = 0; i < str.length(); i++)
            if (visited.get(chars[i]) == 1)
                return i;

        return -1;
    }

    // O(n^2) time | O(1) space where n is the length of the input string
    public static int firstNonRepeatingCharacter1(String str) {
        for (int i = 0; i < str.length(); i++) {
            Boolean visited = false;
            for (int j = 0; j < str.length(); j++)
                if (str.charAt(i) == str.charAt(j) && i != j)
                    visited = true;

            if (!visited)
                return i;
        }
        return -1;
    }
    public static void main(String[] args) {
        String str = "faad*^?abcbb*?ebdf";
        var result = firstNonRepeatingCharacter2(str);
        System.out.println(result);
    }
}