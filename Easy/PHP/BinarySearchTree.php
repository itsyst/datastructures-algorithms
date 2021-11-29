<?php

namespace Easy\PHP\BinarySearch;

function binarySearch($array, $target)
{
    return binarySearchHelper($array, $target, 0, count($array) - 1);
}

function binarySearchHelper($array, $target, $left, $right)
{
    if ($left > $right) {
        return -1;
    }

    $middle = ceil(($left + $right) / 2);

    if ($target == $array[$middle]) {
        return $middle;
    }

    if ($target < $array[$middle]) {
        return binarySearchHelper($array, $target, $left, $middle - 1);
    } else {
        return binarySearchHelper($array, $target, $middle + 1, $right);
    }
}

$array = [0, 1, 21, 33, 45, 45, 61, 71, 72, 73];
$result = binarySearch($array, 33);
print_r($result);
