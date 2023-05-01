using System;

class SortedSquaredArrays
{

    // O(nlogn) time | O(n) space
    public static int[] SortedSquaredArray1(int[] array)
    {
        int[] squared = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
            squared[i] = (int)Math.Pow(array[i], 2);

        Array.Sort(squared);

        return squared;
    }


    // O(n) time | O(n) space
    public static int[] SortedSquaredArray2(int[] array)
    {
        int[] squared = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
            squared[i] = (int)Math.Pow(array[i], 2);

        Array.Sort(squared);

        return squared;
    }

    // O(n) time | O(n) space - Where n is the length of the input array.
    public static int[] SortedSquaredArray3(int[] array)
    {
        int[] squared = new int[array.Length];
        int start = 0;
        int end = array.Length - 1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[start] < array[end])
            {
                squared[i] = (int)Math.Pow(array[end], 2);
                end--;
            }
            else
            {
                squared[i] = (int)Math.Pow(array[start], 2);
                start++;
            }
        }

        return squared;
    }
}

