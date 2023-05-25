using System;

public class SingleCycleChecks
{
    public static bool HasSingleCycle(int[] array)
    {
        int numElementsVisited = 0;
        int currentIndex = 0;

        while (numElementsVisited < array.Length)
        {
            if (numElementsVisited > 0 && currentIndex == 0)
                return false;

            numElementsVisited++;
            currentIndex = GetNextIndex(currentIndex, array);
        }

        return currentIndex == 0;
    }

    private static int GetNextIndex(int currentIndex, int[] array)
    {
        int jump = array[currentIndex];
        int nextIndex = (currentIndex + jump) % array.Length;

        // Handle negative index or wrap around to the end of the array
        return nextIndex >= 0 ? nextIndex : array.Length + nextIndex;
    }

    public static void Main(string[] args)
    {
        int[] array = { 2, 3, 1, -4, -4, 2 };
        Console.WriteLine(HasSingleCycle(array)); // Output: true
    }
}
