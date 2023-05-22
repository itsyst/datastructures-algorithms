using System;

public class WaterAreas
{
    public static int WaterArea(int[] heights)
    {
        int[] maxLeftHeights = new int[heights.Length];
        int[] maxRightHeights = new int[heights.Length];

        int maxLeftHeight = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            maxLeftHeights[i] = maxLeftHeight;
            maxLeftHeight = Math.Max(maxLeftHeight, heights[i]);
        }

        int maxRightHeight = 0;
        for (int i = heights.Length - 1; i >= 0; i--)
        {
            maxRightHeights[i] = maxRightHeight;
            maxRightHeight = Math.Max(maxRightHeight, heights[i]);
        }

        int waterArea = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            int minHeight = Math.Min(maxLeftHeights[i], maxRightHeights[i]);
            if (minHeight > heights[i])
            {
                waterArea += minHeight - heights[i];
            }
        }

        return waterArea;
    }

    public static void Main(string[] args)
    {
        int[] heights = { 0, 1, 0, 2, 1, 0, 3, 1, 0, 1, 2 };

        int surfaceArea = WaterArea(heights);
        Console.WriteLine("Surface Area of Water: " + surfaceArea);
    }
}
