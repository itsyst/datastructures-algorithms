using System;

public class QuickSelect
{
    public static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6, 7 };
        int k = 3;

        int kthSmallest = Quickselect(array, k);
        Console.WriteLine("The " + k + "th smallest element is: " + kthSmallest);
    }

    public static int Quickselect(int[] array, int k)
    {
        return Quickselect(array, 0, array.Length - 1, k - 1);
    }

    private static int Quickselect(int[] array, int left, int right, int k)
    {
        if (left == right)
        {
            return array[left];
        }

        Random random = new Random();
        int pivotIndex = random.Next(left, right + 1);

        pivotIndex = Partition(array, left, right, pivotIndex);

        if (k == pivotIndex)
        {
            return array[k];
        }
        else if (k < pivotIndex)
        {
            return Quickselect(array, left, pivotIndex - 1, k);
        }
        else
        {
            return Quickselect(array, pivotIndex + 1, right, k);
        }
    }

    private static int Partition(int[] array, int left, int right, int pivotIndex)
    {
        int pivotValue = array[pivotIndex];
        Swap(array, pivotIndex, right);

        int storeIndex = left;
        for (int i = left; i < right; i++)
        {
            if (array[i] < pivotValue)
            {
                Swap(array, storeIndex, i);
                storeIndex++;
            }
        }

        Swap(array, right, storeIndex);
        return storeIndex;
    }

    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
