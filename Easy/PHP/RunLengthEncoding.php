<?php 

namespace Easy\PHP\RunLengthEncoding;

function runEncoding($str) {
    $output = "";
    $count = 1;

    for ($i = 1; $i < strlen($str); $i++) {
        if ($str[$i] != $str[$i - 1] || $count == 9) {
            $output .= $count;
            $output .= $str[$i - 1];
            $count = 0;
        }
        $count++;
    }

    $output .= $count;
    $output .= $str[strlen($str) - 1];

    return $output;
}


$str = "AAAAAAAAAAAAABBCCCCDD";
$result = runEncoding($str);
print_r($result);
