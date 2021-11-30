class BubbleSort
{
    public static int[] Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 1; j < array.Length - i; j++)
            {
                if (array[j] < array[j - 1])
                {
                    Swap(array, j, j - 1);
                }
            }

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