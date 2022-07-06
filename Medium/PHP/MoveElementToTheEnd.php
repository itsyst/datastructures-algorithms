<?php

namespace Medium\PHP\MoveElementToTheEnd;

function moveElementToEnd($array, $toMove)
{
    $index = count($array) - 1;
    for ($i = count($array); $i >= 0, $i--;) {
        if ($array[$i] == $toMove) {
            $array = swap($array, $i, $index--);
        }
    }

    return $array;
}

function swap($array, $index1, $index2)
{
    $temp = $array[$index1];
    $array[$index1] = $array[$index2];
    $array[$index2] = $temp;

    return $array;
}

$array = [2, 1, 2, 2, 2, 3, 4, 2];
$toMove = 2;
$result = moveElementToEnd($array, $toMove);
print_r($result);
