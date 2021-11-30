<?php

namespace Easy\PHP\ThreeLargestNumbers;

class ThreeLargestNumbers
{
    public $subArray;

    public function getLargestNumbers($array, $capacity)
    {
        sort($array);
        $this->subArray = array_fill(0, $capacity, 0);
        $j = 0;
        for ($i = 0; $i < count($array); $i++) {
            if ($i >= count($array) - $capacity) {
                $replacements = array($j++ => $array[$i]);
                $this->subArray = array_replace($this->subArray, $replacements);
                // $subArray[$j++] = $array[$i];
            }
        }

        return $this->subArray;
    }

    public function getThreeLargestNumbers($array)
    {
        $this->subArray = array(null, null, null);
        foreach ($array as $number) {
            $this->validate($this->subArray, $number);
        }
        return $this->subArray;
    }

    public function validate($array, $number)
    {
        if ($array[2] == null || $number > $array[2]) {
            $this->update($array, $number, 2);
        } elseif ($array[1] == null || $number > $array[1]) {
            $this->update($array, $number, 1);
        } elseif ($array[0] == null || $number > $array[0]) {
            $this->update($array, $number, 0);
        }
    }

    public function update($array, $number, $index)
    {
        for ($i = 0; $i <= $index; $i++) {
            if ($i == $index) {
                $this->subArray[$i] = $number;
            } else {
                $this->subArray[$i] = $array[$i + 1];
            }
        }
    }
}

$numbers = [141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7];
$largest = new ThreeLargestNumbers();
//$result = $largest->getLargestNumbers($numbers, 3);
$result = $largest->getThreeLargestNumbers($numbers);
print_r($result);
