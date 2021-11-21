<?php 
namespace Easy\PHP\NodesDepthSum;

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

class BTee
{
    public $root;

    public function __construct()
    {
        $this->root = null;
    }
    // Return the sum of nodes in binary tree
    public function nodesDepthSum(Node $root)
    {
        if ($root == null) {
            return;
        }

        return $this->nodesDepthSumHelper($root, 0);
    }

    public function nodesDepthSumHelper($root, $height) {
        if ($root == null) {
            return 0;
        }

        return $height + $this->nodesDepthSumHelper($root->left, $height + 1) + $this->nodesDepthSumHelper($root->right, $height +1);
    }
}

$tree = new BTee();
$tree->root = new Node(10);
$tree->root->left = new Node(5);
$tree->root->left->left = new Node(2);
$tree->root->left->right = new Node(5);
$tree->root->right = new Node(11);
$tree->root->right->left = new Node(13);
$tree->root->right->left->right = new Node(14);

$result = $tree->nodesDepthSum($tree->root);
//var_dump("$result");
print_r("Sum: ".$result);
