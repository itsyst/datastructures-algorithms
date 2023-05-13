using System;

public class KadanesAlgorithm
{
    public static int KadanesAlgorithms(int[] array)
    {
        int maxEndingHere = array[0];
        int maxSoFar = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            maxEndingHere = Math.Max(array[i], maxEndingHere + array[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }
        return maxSoFar;
    }
}
