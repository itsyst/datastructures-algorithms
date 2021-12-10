<?php

namespace Medium\PHP\ThreeNumberSum;

function threeNumberSum1($array, $targetSum)
{
    $triplets = [];
    sort($array);
    $count = count($array);

    for ($i = 0; $i < $count - 2; $i++) {
        for ($j = $i + 1; $j < $count - 1; $j++) {
            for ($k = $j + 1; $k < $count; $k++) {
                $currentSum = $array[$i] + $array[$j] + $array[$k];
                if ($currentSum == $targetSum) {
                    array_push($triplets, [$array[$i], $array[$j], $array[$k]]);
                }
            }
        }
    }
    return $triplets;
}

function threeNumberSum2($array, $targetSum)
{
    $triples = [];
    sort($array);
    for ($i = 0; $i < count($array) - 2; $i++) {
        $left = $i + 1;
        $right = count($array) - 1;
        while ($left < $right) {
            $currentSum = $array[$left] + $array[$i] + $array[$right];
            if ($currentSum == $targetSum) {
                array_push($triples, [$array[$i], $array[$left], $array[$right]]);
                $left++;
                $right--;
            } elseif ($currentSum < $targetSum) {
                $left++;
            } else {
                $right--;
            }
        }
    }

    return $triples;
}

function threeNumberSum3($array, $targetSum)
{
    $triplets = [];
    sort($array);

    for ($i = 0; $i < count($array) - 2; $i++) {
        // Find pair in sub array array[i+1..n-1]s
        // with targetSum equal to currentSum - array[i]
        $set = new \DS\Set();
        $currentSum = $targetSum - $array[$i];
        for ($j = $i + 1; $j < count($array); $j++) {
            if ($set->contains($currentSum - $array[$j])) {
                array_push($triplets, [$array[$i], $currentSum - $array[$j], $array[$j]]);
            }
            $set->add($array[$j]);
        }
    }

    return $triplets;
}

$array = [12, 3, 1, 2, -6, 5, -8, 6];
$target = 0;
$result = threeNumberSum3($array, $target);
print_r($result);
// var_export($result);


