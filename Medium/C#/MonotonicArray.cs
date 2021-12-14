class MonotonicArray
{
    // O(n) time | O (1) space where n is the length of the array.
    public static bool IsMonotonic(int[] array)
    {
        if (array.Length <= 2)
            return true;

        bool increasing = true;
        bool decreasing = true;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i])
                increasing = false;

            if (array[i - 1] < array[i])
                decreasing = false;
        }

        return increasing || decreasing;
    }
}