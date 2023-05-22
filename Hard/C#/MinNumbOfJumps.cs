using System;

public class MinNumbOfJumps
{
    public static int MinNumberOfJumps(int[] array)
    {
        if (array.Length == 1)
        {
            return 0; // If there is only one element, no jumps are needed
        }

        int jumps = 0;
        int maxReach = array[0]; // Maximum index that can be reached
        int steps = array[0]; // Remaining steps in the current jump

        for (int i = 1; i < array.Length - 1; i++)
        {
            maxReach = Math.Max(maxReach, i + array[i]); // Update the maximum reachable index

            steps--; // Use one step

            if (steps == 0)
            {
                jumps++; // Need to jump

                if (i >= maxReach)
                {
                    return -1; // Cannot reach the end
                }

                steps = maxReach - i; // Update the steps for the next jump
            }
        }

        return jumps + 1; // Add one jump for the last index
    }

    public static void Main(string[] args)
    {
        int[] array = { 3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3 };

        int minJumps = MinNumberOfJumps(array);
        Console.WriteLine("Minimum number of jumps: " + minJumps);
    }
}
