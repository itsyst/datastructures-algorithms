using System;
using System.Collections.Generic;
class SmallestDifference
{
    // O(n^2) time | O(1) space
    public static int[] SmallestDifferences1(int[] arrayOne, int[] arrayTwo)
    {
        int[] smallestDiffPair = new int[2];
        int smallestDiff = Int32.MaxValue;

        for (int i = 0; i < arrayOne.Length; i++)
            for (int j = 0; j < arrayTwo.Length; j++)
            {
                int difference = Math.Abs(arrayOne[i] - arrayTwo[j]);
                if (difference < smallestDiff)
                {
                    smallestDiff = difference;
                    smallestDiffPair[0] = arrayOne[i];
                    smallestDiffPair[1] = arrayTwo[j];
                }
            }

        return smallestDiffPair;
    }

    // O(nlog(n) +mlog(m)) time | O(1) space
    public static int[] SmallestDifferences2(int[] arrayOne, int[] arrayTwo)
    {
        Array.Sort(arrayOne);
        Array.Sort(arrayTwo);

        int[] smallestDiffPair = new int[2];
        int smallestDiff = Int32.MaxValue;

        int arrayOneIndex = 0;
        int arrayTwoIndex = 0;

        while (arrayOneIndex < arrayOne.Length && arrayTwoIndex < arrayTwo.Length)
        {
            int difference = Math.Abs(arrayOne[arrayOneIndex] - arrayTwo[arrayTwoIndex]);
            if (difference < smallestDiff)
            {
                smallestDiff = difference;
                smallestDiffPair[0] = arrayOne[arrayOneIndex];
                smallestDiffPair[1] = arrayTwo[arrayTwoIndex];
            }
            if (arrayOne[arrayOneIndex] < arrayTwo[arrayTwoIndex])
                arrayOneIndex++;
            else
                arrayTwoIndex++;
        }
 
        return smallestDiffPair;
    }
}