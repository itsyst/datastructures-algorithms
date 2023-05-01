<?php

function mergeSort($array) {
    if (count($array) <= 1) {
        return $array;
    }

    $mid = floor(count($array) / 2);
    $left = array_slice($array, 0, $mid);
    $right = array_slice($array, $mid);

    return merge(mergeSort($left), mergeSort($right));
}

function merge($left, $right) {
    $result = array();
    $i = 0;
    $j = 0;

    while ($i < count($left) && $j < count($right)) {
        if ($left[$i] <= $right[$j]) {
            array_push($result, $left[$i++]);
        } else {
            array_push($result, $right[$j++]);
        }
    }

    while ($i < count($left)) {
        array_push($result, $left[$i++]);
    }

    while ($j < count($right)) {
        array_push($result, $right[$j++]);
    }

    return $result;
}

// Example usage:
$array = array(3, 7, 1, 9, 2, 8, 5, 6);
$sortedArray = mergeSort($array);
print_r($sortedArray);
