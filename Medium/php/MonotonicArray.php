<?php

namespace Medium\PHP\MonotonicArray;

function isMonotonic1($array)
{
    if (count($array) <= 2) {
        return true;
    }

    $increasing = true;
    $decreasing = true;

    for ($i = 1; $i < count($array); $i++) {
        if ($array[$i] < $array[$i - 1]) {
            $increasing = false;
        }
        if ($array[$i] > $array[$i - 1]) {
            $decreasing = false;
        }
    }

    return $increasing || $decreasing;
}


$array = [-1, -5, -10, -1100, -1100, -1101, -1102, -9001];
$result = isMonotonic1($array);
var_dump($result);
