using System;
using System.Collections.Generic;

public class SameBTS
{
    public static bool SameBsts(List<int> arrayOne, List<int> arrayTwo)
    {
        if (arrayOne.Count != arrayTwo.Count)
        {
            return false;
        }
        return AreSameBsts(arrayOne, arrayTwo, 0, 0, Int32.MinValue, Int32.MaxValue);
    }

    private static bool AreSameBsts(List<int> arrayOne, List<int> arrayTwo,
        int rootIdxOne, int rootIdxTwo, int minVal, int maxVal)
    {
        if (rootIdxOne == -1 || rootIdxTwo == -1)
        {
            return rootIdxOne == rootIdxTwo;
        }
        if (arrayOne[rootIdxOne] != arrayTwo[rootIdxTwo])
        {
            return false;
        }
        int leftRootIdxOne = GetIdxOfFirstSmaller(arrayOne, rootIdxOne, minVal);
        int leftRootIdxTwo = GetIdxOfFirstSmaller(arrayTwo, rootIdxTwo, minVal);
        int rightRootIdxOne = GetIdxOfFirstGreaterOrEqual(arrayOne, rootIdxOne, maxVal);
        int rightRootIdxTwo = GetIdxOfFirstGreaterOrEqual(arrayTwo, rootIdxTwo, maxVal);
        bool areLeftSubtreesSame = AreSameBsts(arrayOne, arrayTwo, leftRootIdxOne, leftRootIdxTwo, minVal, arrayOne[rootIdxOne]);
        bool areRightSubtreesSame = AreSameBsts(arrayOne, arrayTwo, rightRootIdxOne, rightRootIdxTwo, arrayOne[rootIdxOne], maxVal);
        return areLeftSubtreesSame && areRightSubtreesSame;
    }

    private static int GetIdxOfFirstSmaller(List<int> array, int startingIdx, int minVal)
    {
        for (int i = startingIdx + 1; i < array.Count; i++)
        {
            if (array[i] < array[startingIdx] && array[i] >= minVal)
            {
                return i;
            }
        }
        return -1;
    }

    private static int GetIdxOfFirstGreaterOrEqual(List<int> array, int startingIdx, int maxVal)
    {
        for (int i = startingIdx + 1; i < array.Count; i++)
        {
            if (array[i] >= array[startingIdx] && array[i] < maxVal)
            {
                return i;
            }
        }
        return -1;
    }
}
