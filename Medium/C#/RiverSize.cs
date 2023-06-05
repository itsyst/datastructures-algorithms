using System;
using System.Collections.Generic;

public class RiverSize {
    public static List<int> RiverSizes(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        bool[,] visited = new bool[rows, columns];
        List<int> riverSizes = new List<int>();

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                if (matrix[i, j] == 1 && !visited[i, j]) {
                    int size = TraverseRiver(matrix, visited, i, j);
                    riverSizes.Add(size);
                }
            }
        }

        return riverSizes;
    }

    private static int TraverseRiver(int[,] matrix, bool[,] visited, int row, int column) {
        int size = 0;
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        if (row < 0 || row >= rows || column < 0 || column >= columns || visited[row, column])
            return size;

        visited[row, column] = true;

        if (matrix[row, column] == 1) {
            size++;

            // Explore the adjacent cells (top, right, bottom, left)
            size += TraverseRiver(matrix, visited, row - 1, column);
            size += TraverseRiver(matrix, visited, row, column + 1);
            size += TraverseRiver(matrix, visited, row + 1, column);
            size += TraverseRiver(matrix, visited, row, column - 1);
        }

        return size;
    }
}
