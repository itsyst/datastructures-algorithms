using System;

public class InterweavingStrings {
    public static bool InterweavingString(string one, string two, string three) {
        // Check if the lengths of one and two add up to the length of three
        if (one.Length + two.Length != three.Length) {
            return false;
        }
        
        // Create a dynamic programming table to store the results
        bool[,] dp = new bool[one.Length + 1, two.Length + 1];
        
        // Initialize the first row and column of the table
        dp[0, 0] = true;
        
        // Fill in the table
        for (int i = 0; i <= one.Length; i++) {
            for (int j = 0; j <= two.Length; j++) {
                // Check if the current position can be interwoven
                if (i > 0 && one[i - 1] == three[i + j - 1]) {
                    dp[i, j] = dp[i, j] || dp[i - 1, j];
                }
                
                if (j > 0 && two[j - 1] == three[i + j - 1]) {
                    dp[i, j] = dp[i, j] || dp[i, j - 1];
                }
            }
        }
        
        // Return the result
        return dp[one.Length, two.Length];
    }

    public static void Main() {
        string one = "abc";
        string two = "123";
        string three = "ab1c23";

        bool result = InterweavingString(one, two, three);
        Console.WriteLine(result);  // Output: True
    }
}
