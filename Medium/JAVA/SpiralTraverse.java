import java.util.ArrayList;
import java.util.List;

class SpiralTraverse {
    // O(m*n) time | O(1) space
    public static List<Integer> spiralTraverse(int[][] matrix) {
       List<Integer> numbers = new ArrayList<Integer>();

        if(matrix.length == 0 )
            return numbers;

        int i = 0;
        int startRowIndex = 0;
        int endRowIndex = matrix.length;
        int startColIndex = 0;
        int endColIndex = matrix[0].length;

        while (startRowIndex < endRowIndex && startColIndex < endColIndex)
        {
            // Print the first row
            // from the remaining rows
            for (i = startColIndex; i < endColIndex; ++i)
                numbers.add(matrix[startRowIndex][i]);
       
            startRowIndex++;

            // Print the last column from the
            // remaining columns
            for (i = startRowIndex; i < endRowIndex; ++i)
                numbers.add(matrix[i][endColIndex - 1]);
     
            endColIndex--;

            // Print the last row from
            // the remaining rows
            if (startRowIndex < endRowIndex)
                for (i = endColIndex - 1; i >= startColIndex; --i)
                    numbers.add(matrix[endRowIndex - 1][ i]);
         
                endRowIndex--;
          

            // Print the first column from
            // the remaining columns
            if (startColIndex < endColIndex)
                for (i = endRowIndex - 1; i >= startRowIndex; --i)
                    numbers.add(matrix[i][ startColIndex]);
             
                startColIndex++;
        
        }


        return numbers;
    }

    public static void main(String[] args) {
        int[][] matrix = {
            {1, 2, 3, 4},
            {12, 13, 14, 5},
            {11, 16, 15, 6},
            {10, 9, 8, 7},
        };
        List<Integer> result = SpiralTraverse.spiralTraverse(matrix);
        System.out.println(result);
    }
}