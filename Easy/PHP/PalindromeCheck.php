<?php

namespace Easy\PHP\PalindromeCheck;

class PalindromeCheck
{
    public $output;
    // O(n^2) time | O(n) space
    public function isPalindrome1($str)
    {
        if ($str === null) {
            return false;
        }

        for ($i = (strlen($str) - 1); $i >= 0; $i--) {
            $this->output = $this->output . $str[$i];
        }

        return strcmp($this->output, $str) == 0;
    }

    // O(n) time | O(n) space
    public function isPalindrome2($str)
    {
        $reversed = strrev($str);
        return $reversed == $str;
    }

    // O(n) time | O(n) space
    public function isPalindrome3($str)
    {
        $input = [];

        for ($i = (strlen($str) - 1); $i >= 0; $i--) {
            array_push($input, $str[$i]);
        }

        return $str == implode("", $input);
    }

    public function isPalindrome4($str)
    {
        if ($str === null) {
            return false;
        }

        return $this->isPalindromeHelper($str, 0);
    }

    public function isPalindromeHelper($str, $i)
    {
        $j = strlen($str)  - (1 + $i);
        return $i >= $j ? true : $str[$i] == $str[$j] && $this->isPalindromeHelper($str, $i + 1);
    }

    // O(n) time | O(1) space
    public function isPalindrome5($str)
    {
        if ($str == null) {
            return false;
        }

        $left = 0;
        $right = strlen($str) - 1;

        while ($left < $right) {
            if ($str[$left++] != $str[$right--]) {
                return false;
            }
        }
        return true;
    }
}

$str = "1234321";
$palindrome = new PalindromeCheck();
$result = $palindrome->isPalindrome5($str);
var_dump($result);
