using System;
using System.Collections.Generic;

public class FourNumberSum
{
    public static List<int[]> FourNumberSums(int[] array, int targetSum)
    {
        // Create a dictionary to store pairs and their sums
        Dictionary<int, List<int[]>> pairSums = new Dictionary<int, List<int[]>>();
        List<int[]> quadruplets = new List<int[]>();

        // Loop through the array, starting from the second element
        for (int i = 1; i < array.Length - 1; i++)
        {
            // Loop through the elements after the current element to find pairs that sum to the target
            for (int j = i + 1; j < array.Length; j++)
            {
                int currentSum = array[i] + array[j];
                int difference = targetSum - currentSum;

                // Check if the difference is in the dictionary, meaning a quadruplet is found
                if (pairSums.ContainsKey(difference))
                {
                    // Add the found quadruplet to the list
                    foreach (int[] pair in pairSums[difference])
                    {
                        int[] newQuadruplet = { pair[0], pair[1], array[i], array[j] };
                        quadruplets.Add(newQuadruplet);
                    }
                }
            }

            // Loop through the elements before the current element to find pairs
            for (int k = 0; k < i; k++)
            {
                int currentSum = array[i] + array[k];

                // If the pair sum is not in the dictionary, add a new list of pairs
                if (!pairSums.ContainsKey(currentSum))
                {
                    pairSums[currentSum] = new List<int[]>();
                }

                // Add the pair to the dictionary
                int[] newPair = { array[k], array[i] };
                pairSums[currentSum].Add(newPair);
            }
        }

        return quadruplets;
    }
}
