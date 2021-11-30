<?php

namespace Easy\PHP\BubbleSort;

class BubbleSort
{
    public $isSorted = false;
    public $sorted;

    public function sort($array)
    {
        $this->sorted = $array;
        if (count($this->sorted) == 0) {
            return $this->sorted = [];
        }

        $this->isSorted = false;
        for ($i = 0; $i < count($this->sorted); $i++) {
            $this->isSorted = true;
            for ($j = 1; $j < count($this->sorted) - $i; $j++) {
                if ($this->sorted[$j] < $this->sorted[$j - 1]) {
                    $this->swap($this->sorted, $j, $j - 1);
                    $this->isSorted = false;
                }
            }
            // swapped by inner loop, then break
            if ($this->isSorted == true) {
                break;
            }
        }

        return $this->sorted;
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
$bubble = new BubbleSort();
$result = $bubble->sort($numbers);
print_r($result);
