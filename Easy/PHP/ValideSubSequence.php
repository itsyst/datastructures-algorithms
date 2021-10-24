<?php

/**
 * Check if an array is a subsequence.
 * O(n) time | O(1) space
 *
 * @param array $array    The original array.
 * @param array $sequence The subsequence array.
 *
 * @return boolean
 */
function isValidSubsequence1($array, $sequence)
{
    $arrayIndex = 0;
    $sequenceIndex = 0;
    while ($arrayIndex < count($array) && $sequenceIndex < count($sequence)) {
        if ($array[$arrayIndex] == $sequence[$sequenceIndex]) {
            $sequenceIndex++;
        }
        $arrayIndex++;
    }

    return $sequenceIndex == count($sequence);
}

/**
 * Check if an array is a subsequence.
 * O(n) time | O(1) space
 *
 * @param array $array    The original array.
 * @param array $sequence The subsequence array.
 *
 * @return boolean
 */
function isValidSubsequence2($array, $sequence)
{
    $sequenceIndex = 0;
    foreach ($array as $number) {
        if ($sequenceIndex == count($sequence)) {
            break;
        }
     
        if ($sequence[$sequenceIndex] == $number) {
            $sequenceIndex++;
        }
    }

    return $sequenceIndex == count($sequence);
}


$array = [5, 1, 22, 25, 6, -1, 8, 10];
$sequence1 = [1, 6, -1, 10];  // true
$sequence2 = [6, -1, 10, 13]; // false
$result = isValidSubsequence2($array, $sequence1);
var_dump($result);

//print_r($result);
