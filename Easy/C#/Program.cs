﻿// See https://aka.ms/new-console-template for more informationusing System;

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
            // int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // int[] result = SortedSquaredArrays.SortedSquaredArray3(array);
            // Console.WriteLine("[{0}]", string.Join(", ", result));

            // Tournament Winner
            List<List<string>> competitions = new List<List<string>> {
                new List<string>{"HTML", "Java" },
                new List<string>{"Java", "Python" },
                new List<string>{"Python", "HTML" },
                new List<string>{"C#", "Python" },
                new List<string>{"Java", "C#" },
                new List<string>{"C#", "HTML" },
                new List<string>{"SQL", "C#" },
                new List<string>{"HTML", "SQL"},
                new List<string>{"SQL", "Python" },
                new List<string>{"SQL", "Java" }
            };

            List<int> results = new List<int> { 0, 1, 1, 1, 0, 1, 0, 1, 1, 0 };
            string result = TournamentWinner.TournamentWinner1(competitions, results);
            Console.WriteLine("{0}", string.Join(", ", result));

        }
    }
}


