using System;
using System.Collections.Generic;

public class MergeSortedArrays
{
    public class Element
    {
        public int Value;
        public int ArrayIndex;
        public int ElementIndex;

        public Element(int value, int arrayIndex, int elementIndex)
        {
            Value = value;
            ArrayIndex = arrayIndex;
            ElementIndex = elementIndex;
        }
    }

    public class ElementComparer : IComparer<Element>
    {
        public int Compare(Element x, Element y)
        {
            int valueComparison = x.Value.CompareTo(y.Value);
            if (valueComparison != 0)
            {
                return valueComparison;
            }
            int arrayIndexComparison = x.ArrayIndex.CompareTo(y.ArrayIndex);
            if (arrayIndexComparison != 0)
            {
                return arrayIndexComparison;
            }
            return x.ElementIndex.CompareTo(y.ElementIndex);
        }
    }

    public static List<int> MergeSortedArray(List<List<int>> arrays)
    {
        List<int> result = new List<int>();
        SortedSet<Element> minHeap = new SortedSet<Element>(new ElementComparer());

        for (int i = 0; i < arrays.Count; i++)
        {
            if (arrays[i].Count > 0)
            {
                minHeap.Add(new Element(arrays[i][0], i, 0));
            }
        }

        while (minHeap.Count > 0)
        {
            Element smallestElement = minHeap.Min;
            minHeap.Remove(smallestElement);
            int smallestValue = smallestElement.Value;
            int smallestArrayIndex = smallestElement.ArrayIndex;
            int smallestElementIndex = smallestElement.ElementIndex;

            result.Add(smallestValue);

            if (smallestElementIndex + 1 < arrays[smallestArrayIndex].Count)
            {
                minHeap.Add(new Element(arrays[smallestArrayIndex][smallestElementIndex + 1], smallestArrayIndex, smallestElementIndex + 1));
            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        List<List<int>> testArrays = new List<List<int>> {
            new List<int> {1, 5, 9},
            new List<int> {2, 6, 10},
            new List<int> {3, 7, 11},
            new List<int> {4, 8, 12}
        };

        List<int> mergedArray = MergeSortedArray(testArrays);
        Console.WriteLine("Merged array:");
        foreach (int number in mergedArray)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
