using System;
using System.Collections.Generic;

public class ZigzagTraverse {
    public static List<int> ZigzagTraverses(List<List<int>> array) {
        int numRows = array.Count;
        int numCols = array[0].Count;
        List<int> result = new List<int>();

        int row = 0;
        int col = 0;
        bool goingDown = true;

        while (IsValidPosition(row, col, numRows, numCols)) {
            result.Add(array[row][col]);

            if (goingDown) {
                if (col == 0 || row == numRows - 1) {
                    goingDown = false;
                    if (row == numRows - 1)
                        col++;
                    else
                        row++;
                }
                else {
                    row++;
                    col--;
                }
            }
            else {
                if (row == 0 || col == numCols - 1) {
                    goingDown = true;
                    if (col == numCols - 1)
                        row++;
                    else
                        col++;
                }
                else {
                    row--;
                    col++;
                }
            }
        }

        return result;
    }

    private static bool IsValidPosition(int row, int col, int numRows, int numCols) {
        return row >= 0 && row < numRows && col >= 0 && col < numCols;
    }
}
