class RunLengthEncoding
{
    public static string RunEncoding(string str)
    {
        string output = "";
        int count = 1;

        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] != str[i - 1] || count == 9)
            {
                output += (count).ToString();
                output += str[i - 1];
                count = 0;
            }
            count++;
        }
        output += (count).ToString();
        output += str[str.Length - 1];
        
        return output;
    }

}