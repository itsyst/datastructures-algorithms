const spiralTraverse = (matrix) => {
    const numbers = [];

    if (matrix.length === 0)
        return numbers;

    let i = 0;
    let startRowIndex = 0;
    let endRowIndex = matrix.length;
    let startColIndex = 0;
    let endColIndex = matrix[0].length;

    while (startRowIndex < endRowIndex && startColIndex < endColIndex) {
        // Print the first row
        // from the remaining rows
        for (i = startColIndex; i < endColIndex; ++i)
            numbers.push(matrix[startRowIndex][i]);

        startRowIndex++;

        // Print the last column from the
        // remaining columns
        for (i = startRowIndex; i < endRowIndex; ++i)
            numbers.push(matrix[i][endColIndex - 1]);

        endColIndex--;

        // Print the last row from
        // the remaining rows
        if (startRowIndex < endRowIndex)
            for (i = endColIndex - 1; i >= startColIndex; --i)
                numbers.push(matrix[endRowIndex - 1][i]);

        endRowIndex--;


        // Print the first column from
        // the remaining columns
        if (startColIndex < endColIndex)
            for (i = endRowIndex - 1; i >= startRowIndex; --i)
                numbers.push(matrix[i][startColIndex]);

        startColIndex++;

    }


    return numbers;
}

const matrix = [
    [1, 2, 3, 4],
    [12, 13, 14, 5],
    [11, 16, 15, 6],
    [10, 9, 8, 7],
];

const result = spiralTraverse(matrix);
console.log(result);