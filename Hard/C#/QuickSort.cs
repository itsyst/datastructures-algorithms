using System;

public class QuickSort
{
    public static int[] QuickSorts(int[] array)
    {
        // Call the helper function to sort the array
        QuickSortHelper(array, 0, array.Length - 1);
        return array;
    }

    public static void QuickSortHelper(int[] array, int start, int end)
    {
        if (start < end)
        {
            int pivotIndex = Partition(array, start, end);
            QuickSortHelper(array, start, pivotIndex - 1);
            QuickSortHelper(array, pivotIndex + 1, end);
        }
    }

    public static int Partition(int[] array, int start, int end)
    {
        int pivot = array[end];
        int i = start - 1;

        for (int j = start; j <= end - 1; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }
        Swap(array, i + 1, end);
        return i + 1;
    }

    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void Main(string[] args)
    {
        int[] array = new int[] { 3, 7, 1, 9, 2, 8, 5, 6 };
        array = QuickSorts(array);
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }
}
