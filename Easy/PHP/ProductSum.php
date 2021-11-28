<?php 

namespace Easy\PHP\ProductSum;

function productSum($array)
{
    return productSumHelper(1, $array);
}

function productSumHelper($factor, $array)
{
    $sum = 0;
    foreach ($array as $element) {
        if (is_array($element)) {
            $sum += productSumHelper($factor + 1, $element);
        } else {
            $sum += $element;
        }
    }

    return $sum * $factor;
}

$specialArray = [5, 2, [7, -1], 3, [6, [-13, 8], 4]];
$result = productSum($specialArray);
print_r($result);
