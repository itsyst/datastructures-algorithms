using System;

public class MaxSubsetSumNotAdjacent
{
    public static int MaxSubsetSumNoAdjacent(int[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }

        if (array.Length == 1)
        {
            return array[0];
        }

        int[] dp = new int[array.Length];
        dp[0] = array[0];
        dp[1] = Math.Max(array[0], array[1]);

        for (int i = 2; i < array.Length; i++)
        {
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + array[i]);
        }

        return dp[array.Length - 1];
    }

    public static void Main(string[] args)
    {
        int[] array = { 75, 105, 120, 75, 90, 135 };
        int maxSum = MaxSubsetSumNoAdjacent(array);
        Console.WriteLine(maxSum);  // Output: 330
    }
}
