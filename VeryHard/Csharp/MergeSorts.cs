using System;

public class MergeSorts
{
    public static int[] MergeSort(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int mid = array.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, array.Length - mid);

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

    public static int[] Merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                result[k++] = left[i++];
            }
            else
            {
                result[k++] = right[j++];
            }
        }

        while (i < left.Length)
        {
            result[k++] = left[i++];
        }

        while (j < right.Length)
        {
            result[k++] = right[j++];
        }

        return result;
    }

    public static void Main(string[] args)
    {
        int[] array = new int[] { 3, 7, 1, 9, 2, 8, 5, 6 };
        array = MergeSort(array);
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }
}
