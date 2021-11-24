<?php

namespace Easy\PHP\RangeStudents;

function rowRange($redShirtStudents, $blueShirtStudents)
{
    //sorts the elements of the array in descending numerical order
    rsort($redShirtStudents);
    rsort($blueShirtStudents);

    for ($i = 0; $i < count($redShirtStudents); $i++) {
        if ($redShirtStudents[0] > $blueShirtStudents[0]) {
            if ($redShirtStudents[$i] <= $blueShirtStudents[$i]) {
                return false;
            }
        } else {
            if ($redShirtStudents[$i] >= $blueShirtStudents[$i]) {
                return false;
            }
        }
    }
    return true;
}

 
$redRow = [19, 19, 21, 1, 1, 1, 1, 1];
$blueRow = [20, 5, 4, 4, 4, 4, 4, 4];
$result = rowRange($redRow, $blueRow);
var_dump($result);
