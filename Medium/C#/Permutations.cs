using System;
using System.Collections.Generic;

public class Permutations
{
    public static List<List<int>> GetPermutations(List<int> array)
    {
        List<List<int>> permutations = new List<List<int>>();
        GetPermutationsHelper(0, array, permutations);
        return permutations;
    }

    private static void GetPermutationsHelper(int index, List<int> array, List<List<int>> permutations)
    {
        if (index == array.Count - 1)
        {
            permutations.Add(new List<int>(array));
        }
        else
        {
            for (int j = index; j < array.Count; j++)
            {
                Swap(array, index, j);
                GetPermutationsHelper(index + 1, array, permutations);
                Swap(array, index, j);
            }
        }
    }

    private static void Swap(List<int> array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void Main(string[] args)
    {
        List<int> array = new List<int> { 1, 2, 3 };
        List<List<int>> permutations = GetPermutations(array);

        foreach (List<int> permutation in permutations)
        {
            Console.WriteLine($"Permutation: {string.Join(", ", permutation)}");
        }
    }
}
