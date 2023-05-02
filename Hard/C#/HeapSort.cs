using System;

public class Program
{
    public static int[] HeapSort(int[] array)
    {
        int n = array.Length;

        // Build the max-heap
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(array, n, i);
        }

        // Extract elements from the heap
        for (int i = n - 1; i > 0; i--)
        {
            // Swap the current root with the end element
            Swap(array, 0, i);

            // Heapify the reduced heap
            Heapify(array, i, 0);
        }

        return array;
    }

    // Utility function to perform heapify operation
    private static void Heapify(int[] array, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && array[left] > array[largest])
        {
            largest = left;
        }

        if (right < n && array[right] > array[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            Swap(array, i, largest);
            Heapify(array, n, largest);
        }
    }

    // Utility function to swap elements in the array
    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
