<?php

/**
 * Sort squared array.
 * O(nlog(n)) time | O(n) space
 *
 * @param array     $array     The input array.
 *
 * @return array
 */
function sortedSquaredArray1($array)
{
    $sorted = array();
    for ($x = 0; $x <= count($array) - 1; $x++) {
        $sorted[$x] = pow($array[$x], 2);
    }
    arsort($sorted);

    return $sorted;
}

/**
 * Sort squared array.
 * O(nlog(n)) time | O(n) space
 *
 * @param array     $array     The input array.
 *
 * @return array
 */
function sortedSquaredArray2($array)
{
    $start = 0;
    $end = count($array) - 1;
    $sorted = array();
    for ($x = count($array) - 1; $x >= 0; $x--) {
        if ($array[$start] < $array[$end]) {
            $sorted[$x] = pow($array[$end], 2);
            $end--;
        } else {
            $sorted[$x] = pow($array[$start], 2);
            $start++;
        }
    }

    return $sorted;
}

$result = sortedSquaredArray2([1, 2, 3, 5, 6, 8, 9]);
//var_dump($result);

print_r($result);
