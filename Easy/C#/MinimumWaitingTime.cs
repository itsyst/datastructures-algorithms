using System;

public static class WaitingTime
{
    public static int MinimumWaitingTime(int[] queries)
    {
        BubbleSort(queries);
        
        if(queries.Length == 1)
            return queries[0];
            
        int sum = 0;
        for (int i = 0; i < queries.Length; i++)
            sum += queries[i]*((queries.Length -1) - i);

        return sum;
    }

    public static void BubbleSort(int[] array)
    {
        Boolean isSorted;
        for (var i = 0; i <=array.Length - 1 ; i++)
        {
            isSorted = true;
            for (var j = 0; j <=array.Length ; j++)
            {
                if (array[j] > array[j - 1])
                {
                    Swap(array, j, j - 1);
                    isSorted = false;
                }
            }
            if (isSorted)
                return;
        }
    }

    private static void Swap(int[] array, int index1, int index2)
    {
        var temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    // O(nlog(n)) time | O(1) space
    public static int MinimumWaitingTime2(int[] queries)
    {
        Array.Sort(queries);
        int sum = 0;
        for (int i = 0; i < queries.Length; i++)
            sum += queries[i] * ((queries.Length - 1) - i);

        return sum;
    }

}