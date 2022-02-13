class LongestPeaks
{
    public static int LongestPeak1(int[] array)
    {
        // If the size of array is less than 3,
        // the array won't show peaks.
        if (array.Length < 3)
            return 0;

        int i = 0, j = -1, k = -1, d = 0;
        for (i = 0; i < array.Length - 1; i++)
        {

            if (array[i + 1] > array[i])
            {
                // Set the k, j to -1 in order to
                // calculate the length of new peak.
                if (k != -1)
                {
                    k = -1;
                    j = -1;
                }

                // j is the starting index of a
                // new peak sub-array.
                if (j == -1)
                    j = i;
            }

            else
            {
                if (array[i + 1] < array[i])
                {
                    if (j != -1)
                        k = i + 1;

                    if (k != -1 && j != -1)
                    {
                        if (d < k - j + 1)
                            d = k - j + 1;
                    }
                }
                else
                {
                    k = -1;
                    j = -1;
                }
            }
        }

        if (k != -1 && j != -1)
        {
            if (d < k - j + 1)
                d = k - j + 1;
        }

        return d;
    }
}