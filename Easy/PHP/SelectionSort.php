<?php

namespace Easy\PHP\SelectionSort;

class SelectionSort
{
    public $sorted;
    public $index;

    public function sort($array)
    {
        $this->sorted = $array;
        if (count($this->sorted) == 0) {
            return $this->sorted = [];
        }

        for ($i = 0; $i < count($this->sorted); $i++) {
            $this->index = $this->findMinIndex($this->sorted, $i);
            $this->swap($this->sorted, $this->index, $i);
        }

        return $this->sorted;
    }

    private function findMinIndex($array, $i)
    {
        $this->index = $i;
        for ($j = $i + 1; $j < count($array); $j++) {
            if ($array[$j] < $array[$this->index]) {
                $this->index = $j;
            }
        }

        return $this->index;
    }

    private function swap($array, $index1, $index2)
    {
        $temp = $array[$index1];
        $array[$index1] = $array[$index2];
        $array[$index2] = $temp;
        $this->sorted = $array;
    }
}

$numbers = [141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7];
$selection = new SelectionSort();
$result = $selection->sort($numbers);
print_r($result);
