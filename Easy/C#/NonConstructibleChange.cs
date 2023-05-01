using System;

class NonConstructibleChange
{

    // O(nlogn) time | O(1) space
    public static int NonConstructibleChanges(int[] coins)
    {
        Array.Sort(coins);
        int currentCoinChange = 0;
        foreach (var coin in coins)
        {
            if (coin > currentCoinChange +1)
                return currentCoinChange += 1;

            currentCoinChange += coin;
        }

        return currentCoinChange + 1;
    }

}