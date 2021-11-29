class ThreeLargestNumbers
{
    public const int CAPACITY = 3;
    public static int[] FindThreeLargetNumbers(int[] array)
    {
        Array.Sort(array);
        int[] subArray = new int[CAPACITY];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
            if (i >= array.Length - CAPACITY)
                subArray[j++] = array[i];

        return subArray;
    }
}
