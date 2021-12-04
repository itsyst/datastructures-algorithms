public class RunLengthEncoding {
    public static String RunEncoding(String str)
    {
        String output = "";
        int count = 1;

        for( int i = 1;i<str.length();i++)
        {
            if (str.charAt(i) != str.charAt(i - 1) || count == 9) {
                output += count;
                output += str.charAt(i - 1);
                count = 0;
            }
            count++;
        }

        output+=count;
        output += str.charAt(str.length() - 1);

        return output;
    }

   

    public static void main(String[] args) {
        String str = "AAAAAAAAAAAAABBCCCCDD";
        String result = RunLengthEncoding.RunEncoding(str);
        System.out.println(result);
    }
    
}