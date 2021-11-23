<?php

namespace Easy\PHP\MinimumWaitingTime;

/**
 * Returns the minimum waiting time.
 *
 * O(nlog(n)) time | O(1) space.
 *
 * @param array $queries  The input array.
 *
 * @return integer minimum waiting time.
 */
function minimumWaitingTime($array)
{
    sort($array);
    $sum = 0;
    for ($i = 0; $i < count($array); $i++) {
        $sum += $array[$i] * ((count($array) - 1) - $i);
    }

    return $sum;
}

$queries = [17, 4, 3];
$result = minimumWaitingTime($queries);
//var_dump($result);
print_r($result);
