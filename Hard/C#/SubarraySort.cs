using System;

public class SubarraySort
{
    public static int[] SubarraySorts(int[] array)
    {
        int minOutOfOrder = int.MaxValue;
        int maxOutOfOrder = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            int num = array[i];
            if (IsOutOfOrder(i, num, array))
            {
                minOutOfOrder = Math.Min(minOutOfOrder, num);
                maxOutOfOrder = Math.Max(maxOutOfOrder, num);
            }
        }

        if (minOutOfOrder == int.MaxValue)
        {
            return new int[] { -1, -1 };
        }

        int subarrayStart = 0;
        while (minOutOfOrder >= array[subarrayStart])
        {
            subarrayStart++;
        }

        int subarrayEnd = array.Length - 1;
        while (maxOutOfOrder <= array[subarrayEnd])
        {
            subarrayEnd--;
        }

        return new int[] { subarrayStart, subarrayEnd };
    }

    public static bool IsOutOfOrder(int i, int num, int[] array)
    {
        if (i == 0)
        {
            return num > array[i + 1];
        }

        if (i == array.Length - 1)
        {
            return num < array[i - 1];
        }

        return num > array[i + 1] || num < array[i - 1];
    }
}
