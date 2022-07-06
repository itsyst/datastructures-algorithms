<?php

namespace Medium\PHP\SmallestDifference;

function smallestDifference1($arrayOne, $arrayTwo)
{
    $smallestDiff = PHP_INT_MAX;

    for ($i = 0; $i < count($arrayOne); $i++) {
        for ($j = 0; $j < count($arrayTwo); $j++) {
            $difference = abs($arrayOne[$i] - $arrayTwo[$j]);
            if ($difference < $smallestDiff) {
                $smallestDiff = $difference;
                $smallestDiffPair = [$arrayOne[$i], $arrayTwo[$j]];
            }
        }
    }

    return $smallestDiffPair;
}

# O(nlog(n) +mlog(m)) time | O(1) space
function smallestDifference2($arrayOne, $arrayTwo)
{
    sort($arrayOne);
    sort($arrayTwo);

    $smallestDiff = PHP_INT_MAX;
    $arrayOneIndex = 0;
    $arrayTwoIndex = 0;

    while ($arrayOneIndex < count($arrayOne) && $arrayTwoIndex < count($arrayTwo)) {
        $difference = abs($arrayOne[$arrayOneIndex] - $arrayTwo[$arrayTwoIndex]);
        if ($difference < $smallestDiff) {
            $smallestDiff = $difference;
            $smallestDiffPair = [$arrayOne[$arrayOneIndex], $arrayTwo[$arrayTwoIndex]];
        } elseif ($arrayOne[$arrayOneIndex] < $arrayTwo[$arrayTwoIndex]) {
            $arrayOneIndex++;
        } else {
            $arrayTwoIndex++;
        }
    }

    return $smallestDiffPair;
}

$one = [10, 1000, 9124, 2142, 59, 24, 596, 591, 124, -123, 530];
$two = [-1441, -124, -25, 1014, 1500, 660, 410, 245, 530];
$result = smallestDifference2($one, $two);
print_r($result);
