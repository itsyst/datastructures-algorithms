<?php

 
class Node
{
    public $value;
    public $left;
    public $right;

    public function __construct($value)
    {
        $this->value = $value;
    }
}

class BST
{
    public $root;

    public function __construct()
    {
        $this->root = null;
    }

    public function getClosetValueInBST($node, $target)
    {
        return $this->getClosetValueInBSTHelper($node->root, $target, $node->root->value);
    }

    public function getClosetValueInBSTHelper($node, $target, $closest)
    {
        if ($node == null) {
            return $closest;
        }
        if (abs($target - $node->value) < abs($target - $closest)) {
            $closest = $node->value;
        }
        if ($target < $node->value&& $node->left != null) {
            return $this->getClosetValueInBSTHelper($node->left, $target, $closest);
        } elseif ($target > $node->value && $node->right!= null) {
            return $this->getClosetValueInBSTHelper($node->right, $target, $closest);
        } else {
            return $closest;
        }

        return $closest;
    }

    /**
     *  adding elements to the binary search tree
     * @param $value
     */
    public function insert($value)
    {

        $node = new Node($value);

        if ($this->root == null) {
            $this->root = $node;
            return;
        }

        $current = $this->root;
        while (true) {
            if ($value < $current->value) {
                if ($current->left == null) {
                    $current->left = $node;
                    break;
                }

                $current = $current->left;
            } else {
                if ($current->right == null) {
                    $current->right = $node;
                    break;
                }
                $current = $current->right;
            }
        }
    }
}






$arr = array(10, 5, 2, 1, 5, 15, 13, 14, 22);

$tree = new BST();
for ($i = 0, $n = count($arr); $i < $n; $i++) {
    $tree->insert($arr[$i]);
}
  
$result = $tree->getClosetValueInBST($tree, 20);
//var_dump("$result");
//echo "Closest value: ". $result;
print_r("Closest value: ". $result);
