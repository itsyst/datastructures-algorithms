<?php

namespace Medium\PHP\SpiralTraverse;

function spiralTraverse($matrix)
{
    $numbers = [];

    if (count($matrix) == 0) {
        return $numbers;
    }

    $i = 0;
    $startRowIndex = 0;
    $endRowIndex = count($matrix);
    $startColIndex = 0;
    $endColIndex = count($matrix[0]);

    while ($startRowIndex < $endRowIndex && $startColIndex < $endColIndex) {
        // Print the first row
        // from the remaining rows
        for ($i = $startColIndex; $i < $endColIndex; ++$i) {
            array_push($numbers, ($matrix[$startRowIndex][$i]));
        }
        $startRowIndex++;

        // Print the last column from the
        // remaining columns
        for ($i = $startRowIndex; $i < $endRowIndex; ++$i) {
            array_push($numbers, ($matrix[$i][$endColIndex - 1]));
        }
        $endColIndex--;

        // Print the last row from
        // the remaining rows
        if ($startRowIndex < $endRowIndex) {
            for ($i = ($endColIndex - 1); $i >= $startColIndex; --$i) {
                array_push($numbers, ($matrix[($endRowIndex - 1)][$i]));
            }
        }
        $endRowIndex--;


        // Print the first column from
        // the remaining columns
        if ($startColIndex < $endColIndex) {
            for ($i = $endRowIndex - 1; $i >= $startRowIndex; --$i) {
                array_push($numbers, ($matrix[$i][$startColIndex]));
            }
        }
        $startColIndex++;
    }

    return $numbers;
}

$matrix = [
    [1, 2, 3, 4],
    [12, 13, 14, 5],
    [11, 16, 15, 6],
    [10, 9, 8, 7],
];
$result = spiralTraverse($matrix);
print_r($result);





