using System;
using System.Collections.Generic;

public class LargestRange
{
    public static int[] LargestRanges(int[] array)
    {
        int[] bestRange = new int[2];
        int longestLength = 0;
        Dictionary<int, bool> nums = new Dictionary<int, bool>();

        foreach (int num in array)
        {
            nums[num] = true;
        }

        foreach (int num in array)
        {
            if (!nums[num])
            {
                continue;
            }

            nums[num] = false;
            int currentLength = 1;
            int left = num - 1;
            int right = num + 1;

            while (nums.ContainsKey(left))
            {
                nums[left] = false;
                currentLength++;
                left--;
            }

            while (nums.ContainsKey(right))
            {
                nums[right] = false;
                currentLength++;
                right++;
            }

            if (currentLength > longestLength)
            {
                longestLength = currentLength;
                bestRange = new int[] { left + 1, right - 1 };
            }
        }

        return bestRange;
    }
}
