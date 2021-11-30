class BubbleSort
{
    // O(n^2) time where n is the length of array | O(1) space
    public static int[] Sort(int[] array)
    {
        if (array.Length == 0)
            return new int[] { };

        bool isSorted;
        for (int i = 0; i < array.Length; i++)
        {
            isSorted = true;
            for (int j = 1; j < array.Length - i; j++)
            {
                if (array[j] < array[j - 1])
                {
                    Swap(array, j, j - 1);
                    isSorted = false;
                }
            }
            // swapped by inner loop, then break
            if (isSorted == true)
                break;
        }
        
        return array;
    }

    private static void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}