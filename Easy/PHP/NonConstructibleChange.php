<?php

/**
 * Returns the minimum amount of change
 * that can not br created.
 * O(nlog(n)) time | O(1) space.
 * 
 * @param array $coins  The input array.
 *
 * @return integer minimum amount of change
 */
function nonConstructibleChange($coins)
{
    asort($coins);
    $currentChangeCoin = 0;
    foreach ($coins as $coin) {
        if ($coin > $currentChangeCoin + 1) {
            return $currentChangeCoin + 1;
        }
        $currentChangeCoin += $coin;
    }

    return $currentChangeCoin;
}




$result = nonConstructibleChange([1, 5, 2]);
//var_dump($result);

print_r($result);
