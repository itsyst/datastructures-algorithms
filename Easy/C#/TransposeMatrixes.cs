using System;

public class TransposeMatrixes {
    public int[,] TransposeMatrix(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        int[,] transposedMatrix = new int[columns, rows];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        return transposedMatrix;
    }
}
