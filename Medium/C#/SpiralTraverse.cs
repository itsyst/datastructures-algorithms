class SpiralTraverse
{
    // O(m*n) time | O(1) space 
    public static List<int> MatrixTraverse(int[,] matrix) {
        List<int> numbers = new List<int>();

        if(matrix.Length == 0 )
            return numbers;

        int i = 0;
        int startRowIndex = 0;
        int endRowIndex = matrix.GetLength(0);
        int startColIndex = 0;
        int endColIndex = matrix.GetLength(1);

        while (startRowIndex < endRowIndex && startColIndex < endColIndex)
        {
            // Print the first row
            // from the remaining rows
            for (i = startColIndex; i < endColIndex; ++i)
                numbers.Add(matrix[startRowIndex, i]);
       
            startRowIndex++;

            // Print the last column from the
            // remaining columns
            for (i = startRowIndex; i < endRowIndex; ++i)
                numbers.Add(matrix[i, endColIndex - 1]);
     
            endColIndex--;

            // Print the last row from
            // the remaining rows
            if (startRowIndex < endRowIndex)
                for (i = endColIndex - 1; i >= startColIndex; --i)
                    numbers.Add(matrix[endRowIndex - 1, i]);
         
                endRowIndex--;
          

            // Print the first column from
            // the remaining columns
            if (startColIndex < endColIndex)
                for (i = endRowIndex - 1; i >= startRowIndex; --i)
                    numbers.Add(matrix[i, startColIndex]);
             
                startColIndex++;
        
        }


        return numbers;
    }
    
}