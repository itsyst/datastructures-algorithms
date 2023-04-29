using System;
using System.Collections.Generic;

public class MissingNumbers
{
    public int[] MissingNumber(int[] nums)
    {
        int n = nums.Length + 2; // Calculate the value of n
        int totalSum = n * (n + 1) / 2; // Calculate the sum of integers from 1 to n
        int numsSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            numsSum += nums[i]; // Calculate the sum of integers in nums
        }

        int sumOfTwoMissingNumbers = totalSum - numsSum; // Calculate the sum of the two missing numbers
        int limit = sumOfTwoMissingNumbers / 2; // Find a limit to separate the two missing numbers

        // Calculate the sum of integers from 1 to limit
        int partialSum = limit * (limit + 1) / 2;
        int numsPartialSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= limit)
            {
                numsPartialSum += nums[i]; // Calculate the sum of integers in nums that are less than or equal to limit
            }
        }

        int firstMissingNumber = partialSum - numsPartialSum; // Calculate the first missing number
        int secondMissingNumber = sumOfTwoMissingNumbers - firstMissingNumber; // Calculate the second missing number

        return new int[] { firstMissingNumber, secondMissingNumber };
    }
}
