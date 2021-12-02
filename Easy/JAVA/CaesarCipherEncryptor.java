public class CaesarCipherEncryptor {

    final static int ENGLISH_ALPHABET = 26;

    public static String Encrypt(String str, int key) {
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < str.length(); i++) {
            if (Character.isLowerCase(str.charAt(i))) {
                int character = (str.charAt(i) - 'a' + key) % ENGLISH_ALPHABET + 'a';
                char ch = (char) (character);
                output.append(ch);
            } else {
                int character = (str.charAt(i) - 'A' + key) % ENGLISH_ALPHABET + 'A';
                char ch = (char) (character);
                output.append(ch);
            }
        }
        
        return output.toString();
    }

    public static void main(String[] args) {
        String str = "shajklxyz";
        String result = Encrypt(str, 10);
        System.out.println(result);
    }

}