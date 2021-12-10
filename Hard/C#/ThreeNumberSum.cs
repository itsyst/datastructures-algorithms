class ThreeNumberSum
{
    // O(n^3) time | O(n) space
    // This is a naive approach
    public static List<int[]> ThreeNumbersSum1(int[] array, int targetSum)
    {
        List<int[]> triples = new List<int[]>();
        Array.Sort(array);

        for (int i = 0; i < array.Length - 2; i++)
            for (int j = i + 1; j < array.Length - 1; j++)
                for (int k = j + 1; k < array.Length; k++)
                {
                    int currentSum = array[i] + array[j] + array[k];
                    if (currentSum == targetSum)
                    {
                        triples.Add(new int[] { array[i], array[j], array[k] });
                    }

                }

        return triples;
    }

    // O(n^2) time | O(n) space
    public static List<int[]> ThreeNumbersSum2(int[] array, int targetSum)
    {
        List<int[]> triples = new List<int[]>();
        Array.Sort(array);

        for (int i = 0; i < array.Length - 2; i++)
        {
            int left = i + 1;
            int right = array.Length - 1;
            while (left < right)
            {
                int currentSum = array[left] + array[i] + array[right];
                if (currentSum == targetSum)
                {
                    triples.Add(new int[] { array[i], array[left], array[right] });
                    left++;
                    right--;
                }
                else if (currentSum < targetSum)
                    left++;
                else
                    right--;
            }
        }

        return triples;
    }
    // O(n^2) time | O(n) space
    public static List<int[]> ThreeNumbersSum3(int[] array, int targetSum)
    {
        List<int[]> triples = new List<int[]>();
        for (int i = 0; i < array.Length - 2; i++)
        {
            // Find pair in subarray array[i+1..n-1]
            // with targetSum equal to currentSum - array[i]
            HashSet<int> set = new HashSet<int>();
            int currentSum = targetSum - array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                if (set.Contains(currentSum - array[j]))
                    triples.Add(new int[] { array[i], currentSum - array[j], array[j] });

                set.Add(array[j]);
            }
        }

        return triples;
    }
}