using System;

public class SearchForRange
{
    public static int[] SearchForARange(int[] array, int target)
    {
        int leftIdx = BinarySearch(array, target, true);
        int rightIdx = BinarySearch(array, target, false);

        return new int[] { leftIdx, rightIdx };
    }

    private static int BinarySearch(int[] array, int target, bool searchLeft)
    {
        int left = 0;
        int right = array.Length - 1;
        int idx = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] < target)
            {
                left = mid + 1;
            }
            else if (array[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                idx = mid;

                if (searchLeft)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
        }

        return idx;
    }
}
