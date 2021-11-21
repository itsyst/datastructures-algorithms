<?php

namespace Easy\PHP\BranchSumsBT;

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
    public function branchSums($node)
    {
        if ($node == null) {
            return 0;
        }
        // left subtree sum +
        // right subtree sum +
        // current node sum
        return $this->branchSums($node->left) + $this->branchSums($node->right) + $node->value;
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

$result = $tree->branchSums($tree->root);
//var_dump("$result");
print_r("Branches sum: ". $result);
