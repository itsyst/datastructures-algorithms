// See https://aka.ms/new-console-template for more informationusing System;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Three Number Sum
            // int[] array = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
            // int target = 0;
            // var result = ThreeNumberSum.ThreeNumbersSum3(array, target);
            // foreach (var item in result)
            // {
            //     // item.ToList().ForEach(Console.Write);
            //     // Array.ForEach(item, Console.Write);
            //     Console.WriteLine("[" + "{0}", string.Join(", ", item)+ "]");
            // }

            // Get the Smallest Diffrance
            // int[] one = new int[] {10, 1000, 9124, 2142, 59, 24, 596, 591, 124, -123, 530 };
            // int[] two = new int[] { -1441, -124, -25, 1014, 1500, 660, 410, 245, 530 };
            // int[] result = SmallestDifference.SmallestDifferences2(one, two);
            // Console.WriteLine("{0}", string.Join(", ", result));

            // Move Element To End
            // List<int> array = new List<int>(){ 2, 1, 2, 2, 2, 3, 4, 2};
            // int toMove = 2;
            // var result = MoveElementToTheEnd.MoveElementToEnd(array, toMove);
            // System.Console.WriteLine("{0}", string.Join(", ", result));

            // Monotonic Array
            // int[] array = new int[] { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 };
            // var result = MonotonicArray.IsMonotonic(array);
            // System.Console.WriteLine(result);

            // Spiral Traverse
            // int[,] matrix = {
            //     {1, 2, 3, 4},
            //     {12, 13, 14, 5},
            //     {11, 16, 15, 6},
            //     {10, 9, 8, 7},
            // };
            // List<int> result = SpiralTraverse.MatrixTraverse(matrix);
            // System.Console.WriteLine("{0}", string.Join(", ", result));


            // Longest Peak
            int[] array = new int[] { 1, 3, 2 };
            int result = LongestPeaks.LongestPeak1(array);
            Console.WriteLine(result);

        }
    }
}


