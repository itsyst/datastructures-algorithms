using System;

public class ThreeNumberSort
{
    public int[] ThreeNumberSorts(int[] array, int[] order)
    {
        // Initialize pointers for each of the three distinct integers
        int firstPointer = 0;
        int secondPointer = 0;
        int thirdPointer = array.Length - 1;

        // Use the Dutch National Flag algorithm to sort the array
        while (secondPointer <= thirdPointer)
        {
            int currentVal = array[secondPointer];

            if (currentVal == order[0])
            {
                Swap(array, firstPointer, secondPointer);
                firstPointer++;
                secondPointer++;
            }
            else if (currentVal == order[1])
            {
                secondPointer++;
            }
            else
            {
                Swap(array, secondPointer, thirdPointer);
                thirdPointer--;
            }
        }

        return array;
    }

    // Utility function to swap elements in the array
    private void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
