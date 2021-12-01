public class PalindromeCheck {

    // O(n^2) time | O(n) space
    public static boolean isPalindrome1(String str) {
        if (str == null)
            return false;

        String input = " ";

        for (int i = str.length() - 1; i >= 0; i--)
            input += str.charAt(i);

        return str.equals(input);
    }

    // O(n) time | O(n) space
    public static boolean isPalindrome2(String str) {
        StringBuilder input = new StringBuilder(str);
        input.reverse();
        return input.toString().equals(str);
    }

    // O(n) time | O(n) space
    public static boolean isPalindrome3(String str) {
        StringBuilder input = new StringBuilder(str);

        for (int i = str.length() - 1; i >= 0; i--)
            input.append(str.charAt(i));

        return str.equals(input.toString());
    }

    // O(n) time | O(n) space
    public static boolean isPalindrome4(String str) {
        if (str == null)
            return false;

        return isPalindrome4(str, 0);
    }

    private static boolean isPalindrome4(String str, int i) {
        int j = str.length() - (1 + i);
        return i >= j ? true : str.charAt(i) == str.charAt(j) && isPalindrome4(str, i + 1);
    }

    // O(n) time | O(1) space
    public static boolean isPalindrome5(String str) {
        if (str == null)
            return false;

        var left = 0;
        var right = str.length() - 1;

        while (left < right) {
            if (str.charAt(left++) != str.charAt(right--))
                return false;
        }
        return true;
    }
    public static void main(String[] args) {
        String str = "abcdcba";
        Boolean result = PalindromeCheck.isPalindrome5(str);
        System.out.println(result);
    }
}
