using System;

public class SearchInSortedMatrixes
{
    public static int[] SearchInSortedMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int row = 0;
        int col = cols - 1;

        while (row < rows && col >= 0)
        {
            int current = matrix[row, col];

            if (current == target)
            {
                return new int[] { row, col };
            }
            else if (current > target)
            {
                col--;
            }
            else
            {
                row++;
            }
        }

        return new int[] { -1, -1 };
    }

    public static void Main(string[] args)
    {
        int[,] matrix = {
            { 1, 4, 7, 12, 15 },
            { 2, 5, 9, 13, 18 },
            { 3, 6, 11, 16, 22 },
            { 10, 14, 17, 20, 24 }
        };
        int target = 11;

        int[] result = SearchInSortedMatrix(matrix, target);

        Console.WriteLine($"Row: {result[0]}, Column: {result[1]}");
        // Output: Row: 2, Column: 2
    }
}
