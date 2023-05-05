using System;
using System.Collections.Generic;

public class Powerset
{
    public static List<List<int>> Powersets(List<int> array)
    {
        return GetPowerset(array, 0);
    }

    private static List<List<int>> GetPowerset(List<int> array, int index)
    {
        if (index == array.Count)
        {
            return new List<List<int>> { new List<int>() };
        }

        int currentElement = array[index];
        List<List<int>> subsets = GetPowerset(array, index + 1);
        int length = subsets.Count;

        for (int i = 0; i < length; i++)
        {
            List<int> currentSubset = new List<int>(subsets[i]);
            currentSubset.Add(currentElement);
            subsets.Add(currentSubset);
        }

        return subsets;
    }

    public static void Main(string[] args)
    {
        List<int> array = new List<int> { 1, 2, 3 };
        List<List<int>> result = Powersets(array);

        Console.WriteLine("Powerset: ");
        foreach (List<int> subset in result)
        {
            Console.Write("[");
            foreach (int element in subset)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine("]");
        }
    }
}
