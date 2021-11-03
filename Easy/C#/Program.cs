// See https://aka.ms/new-console-template for more informationusing System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Two Number Sum
            // int[] array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            // int targetSum = 10;
            // int[] result = TwoNumbersSum.TwoNumberSum3(array, targetSum);
            // Console.WriteLine("[{0}]", string.Join(", ", result));

            // Validate Sub Sequence
            // List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            // List<int> sequence = new List<int> { 1, 6, -1, 10 };
            // Boolean result = ValidateSubSequence.IsValidSubsequence2(array, sequence);
            // Console.WriteLine(result);

            // Sorted Squared Array
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] result = SortedSquaredArrays.SortedSquaredArray3(array);
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
    }
}


