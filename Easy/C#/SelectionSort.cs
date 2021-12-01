class SelectionSort
{
    // O(n^2) time where n is the length of array | O(1) space
    public static int[] Sort(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var minIndex = FindMaxIndex(array, i);
            Swap(array, minIndex, i);
        }

        return array;
    }

    private static int FindMinIndex(int[] array, int i)
    {
        int minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
            if(array[j] < array[minIndex])
                minIndex = j;

        return minIndex;
    }

    private static int FindMaxIndex(int[] array, int i)
    {
        int maxIndex = i;
        for (int j = i + 1; j < array.Length; j++)
            if (array[j] > array[maxIndex])
                maxIndex = j;

        return maxIndex;
    }

    private static void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}