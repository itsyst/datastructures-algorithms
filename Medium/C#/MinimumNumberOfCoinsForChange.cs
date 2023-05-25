using System;

public class MinimumNumberOfCoinsForChange
{
    public static int MinNumberOfCoinsForChange(int n, int[] denoms)
    {
        int[] minCoins = new int[n + 1];
        Array.Fill(minCoins, int.MaxValue);
        minCoins[0] = 0;

        foreach (int denom in denoms)
        {
            for (int amount = denom; amount <= n; amount++)
            {
                if (minCoins[amount - denom] != int.MaxValue)
                {
                    minCoins[amount] = Math.Min(minCoins[amount], minCoins[amount - denom] + 1);
                }
            }
        }

        return minCoins[n] == int.MaxValue ? -1 : minCoins[n];
    }

    public static void Main(string[] args)
    {
        int n = 7;
        int[] denoms = { 1, 5, 10 };
        Console.WriteLine(MinNumberOfCoinsForChange(n, denoms)); // Output: 3
    }
}
