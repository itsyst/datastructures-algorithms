using System;
using System.Collections.Generic;

public class ZeroSumSubarrays
{
    public bool ZeroSumSubarray(int[] nums)
    {
        HashSet<int> prefixSums = new HashSet<int> { 0 };
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (prefixSums.Contains(sum))
            {
                return true;
            }
            prefixSums.Add(sum);
        }

        return false;
    }
}
