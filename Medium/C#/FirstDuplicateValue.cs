using System.Collections.Generic;
using System;

public class FirstDuplicateValue
{
    public int FirstDuplicateValues(int[] array)
    {
        HashSet<int> seenIntegers = new HashSet<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (seenIntegers.Contains(array[i]))
            {
                return array[i];
            }
            else
            {
                seenIntegers.Add(array[i]);
            }
        }

        return -1;
    }
}
