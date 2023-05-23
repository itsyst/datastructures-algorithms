using System;
using System.Collections.Generic;
using System.Linq;

public class RadixSort
{
    // First Solution
    public List<int> RadixSortsOne(List<int> array)
    {
        if (array == null || array.Count < 2)
        {
            return array;
        }
        int maxDigits = array.Max().ToString().Length;
        for (int i = 0; i < maxDigits; i++)
        {
            array = array.OrderBy(x => (x / (int)Math.Pow(10, i)) % 10).ToList();
        }
        return array;
    }

    // Second Solution
    public List<int> RadixSortTwo(List<int> array)
    {
        if (array == null || array.Count < 2)
        {
            return array;
        }
        int maxVal = GetMaxValue(array);
        int exp = 1;
        while (maxVal / exp > 0)
        {
            array = CountingSort(array, exp);
            exp *= 10;
        }
        return array;
    }

    private int GetMaxValue(List<int> array)
    {
        int maxVal = array[0];
        for (int i = 1; i < array.Count; i++)
        {
            if (array[i] > maxVal)
            {
                maxVal = array[i];
            }
        }
        return maxVal;
    }

    private List<int> CountingSort(List<int> array, int exp)
    {
        int n = array.Count;
        int[] output = new int[n];
        int[] count = new int[10];
        for (int i = 0; i < n; i++)
        {
            int digit = (array[i] / exp) % 10;
            count[digit]++;
        }
        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }
        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (array[i] / exp) % 10;
            output[count[digit] - 1] = array[i];
            count[digit]--;
        }
        for (int i = 0; i < n; i++)
        {
            array[i] = output[i];
        }
        return array;
    }
}

 