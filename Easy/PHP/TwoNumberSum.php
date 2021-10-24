<?php

/**
 * Get the sum of numbers.
 * O(n^2) time | O(1) space
 *
 * @param array     $array     The input array.
 * @param targetSum $targetSum The target number.
 *
 * @return array
 */
function twoNumberSum1($array, $targetSum)
{
    for ($x = 0; $x <= count($array) - 1; $x++) {
        $first = $array[$x];
        for ($y = $x + 1; $y <= count($array); $y++) {
            $second = $array[$y];
            if ($first + $second == $targetSum) {
                return array($first, $second);
            }
        }
    }

    return [];
}

/**
 * Get the sum of numbers.
 * O(n^2) time | O(1) space
 *
 * @param array     $array     The input array.
 * @param targetSum $targetSum The target number.
 *
 * @return array
 */
function twoNumberSum2($array, $targetSum)
{
    $numbers = array();
    foreach ($array as $number) {
        $complement = $targetSum - $number;
        if (in_array($complement, $numbers)) {
            return array($number, $complement );
        } else {
            array_push($numbers, $number);
        }
    }
  
    return [];
}

/**
 * Get the sum of numbers.
 * O(n log(n)) | O(1) space
 *
 * @param array     $array     The input array.
 * @param targetSum $targetSum The target number.
 *
 * @return array
 */
function twoNumberSum3($array, $targetSum)
{
    arsort($array);
    $left = 0;
    $right = count($array) -1;
    while ($left < $right) {
        $currentSum = $array[$left] + $array[$right];
        if ($currentSum < $targetSum) {
            $left++;
        } elseif ($currentSum > $targetSum) {
            $right--;
        } elseif ($currentSum == $targetSum) {
            return array($array[$left], $array[$right]);
        }
    }

    return [];
}

/**
 * Get the sum of numbers.
 * // O(n) | O(n) space
 *
 * @param array     $array     The input array.
 * @param targetSum $targetSum The target number.
 *
 * @return array
 */
function twoNumberSum4($array, $targetSum)
{
    $set = new \Ds\Set();
    foreach ($array as $number) {
        $complement = $targetSum - $number;
        if ($set->contains($complement)) {
            return array($number, $complement);
        } else {
            $set->add($number);
        }
    }

    return [];
}

/**
 * Get the sum of numbers.
 * // O(n) | O(n) space
 *
 * @param array     $array     The input array.
 * @param targetSum $targetSum The target number.
 *
 * @return array
 */
function twoNumberSum5($array, $targetSum)
{
    $map = new \Ds\Map();
    for ($x = 0; $x <= count($array) - 1; $x++) {
        $complement = $targetSum - $array[$x];
        if ($map->hasKey($complement)) {
            return array($array[$x], $complement);
        } else {
            $map->put($array[$x], $complement);
        }
    }

    return [];
}

$result = twoNumberSum5([3, 5, -4, 8, 11, 1, -1, 6], 10);
//var_dump($result);

print_r($result);








 

