<?php

namespace Easy\PHP\NthFibonacci;

function getNthFibonacci($n)
{
    if ($n <= 1) {
        return 0;
    } elseif ($n == 2) {
        return 1;
    } else {
        return getNthFibonacci($n - 1) + getNthFibonacci($n -2);
    }
}

$result = getNthFibonacci(6);
print_r($result);
