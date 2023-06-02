using System;

public class NumberOfWaysToMakeChanges
{
    public static int NumberOfWaysToMakeChange(int n, int[] denoms)
    {
        int[] ways = new int[n + 1];
        ways[0] = 1;

        foreach (int denom in denoms)
        {
            for (int amount = 1; amount <= n; amount++)
            {
                if (denom <= amount)
                {
                    ways[amount] += ways[amount - denom];
                }
            }
        }

        return ways[n];
    }

    public static void Main(string[] args)
    {
        int targetAmount = 10;
        int[] coinDenominations = { 1, 2, 5 };

        int numberOfWays = NumberOfWaysToMakeChange(targetAmount, coinDenominations);
        Console.WriteLine("Number of ways to make change: " + numberOfWays);
    }
}
