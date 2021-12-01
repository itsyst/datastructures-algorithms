<?php

namespace Easy\PHP\InsertSort;

class InsertionSort
{
    public $sorted;

    public function sort($array)
    {
        $this->sorted = $array;

        for ($i = 1; $i < count($this->sorted); $i++) {
            $current = $this->sorted[$i];
            $j = $i - 1;

            while ($j >= 0 && $this->sorted[$j] > $current) {
                $this->swap($this->sorted, $j + 1, $j);
                $j--;
            }
            $this->sorted[$j + 1] = $current;
        }

        return $this->sorted;
    }

    public function swap($array, $index1, $index2)
    {
        $temp = $array[$index1];
        $array[$index1] = $array[$index2];
        $array[$index2] = $temp;
        $this->sorted = $array;
    }
}


$numbers = [141, 0, 12, -1, -10, -27, 18, 233, 8, 7, 7];
$sorted = new InsertionSort();
print_r($sorted->sort($numbers));
