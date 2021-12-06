<?php 

namespace Easy\PHP\FirstNonRepeatingCharacter;

function firstNonRepeatingCharacter3($str)
{
    $visited = [];
    $chars = str_split(strtolower($str));

    foreach ($chars as $char) {
        if (array_key_exists($char, $visited)) {
            $count = $visited[$char];
        } else {
            $count = 0;
        }
        $visited[$char] = $count + 1;
    }

    for ($i = 0; $i < count($chars); $i++) {
        if ($visited[$chars[$i]] == 1) {
            return $i;
        }
    }

    return -1;
}

function firstNonRepeatingCharacter2($str)
{
    $visited = new \Ds\Map();
    $chars = str_split(strtolower($str));

    foreach ($chars as $char) {
        if ($visited->hasKey($char)) {
            $count = $visited->get($char);
        } else {
            $count = 0;
        }
        $visited[$char] = $count + 1;
    }

    for ($i=0; $i < count($chars); $i++) {
        if ($visited->get($chars[$i]) == 1) {
            return $i;
        }
    }

    return -1;
}

/* O(n ^ 2) time | O(1) space where n is the length of the input string*/
function firstNonRepeatingCharacter1($str)
{
    for ($i=0; $i<strlen($str); $i++) {
        $visited = false;
        for ($j = 0; $j < strlen($str); $j++) {
            if ($str[$i] == $str[$j] and $i != $j) {
                $visited = true;
            }
        }
        if (!$visited) {
            return $i;
        }
    }
    return -1;
}


$str = "faad*^?Abcbb*?ebdf";
$result = firstNonRepeatingCharacter3($str);
print_r($result);
