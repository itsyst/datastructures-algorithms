<?php

namespace Easy\PHP\RemoveRemoveDuplicatesFromLinkedList;

class Node
{
    public $value;
    public $next;

    public function __construct($value)
    {
        $this->value = $value;
        $this->next = null;
    }

    public function getNodes()
    {
        $nodes = [];
        $current = $this;
        while ($current != null) {
            array_push($nodes, $current->value);
            $current = $current->next;
        }

        return $nodes;
    }

    public function addMany($values)
    {
        $current = $this;
        while ($current->next != null) {
            $current = $current->next;
        }

        foreach ($values as $value) {
            $current->next = new Node($value);
            $current = $current->next;
        }

        return $this;
    }
}

function removeDuplicatesFromLinkedList($node)
{
    $current = $node;
    while ($current != null && $current->next != null) {
        $nextUniqueNode = $current->next;
        while ($nextUniqueNode != null &&  $nextUniqueNode->value == $current->value) {
            $nextUniqueNode =  $nextUniqueNode->next;
        }
        $current->next =  $nextUniqueNode;
        $current =  $nextUniqueNode;
    }

    return $node;
}

$input = new Node(1);
$values = [1, 1, 2, 3, 8, 8, 8, 9, 12];
$input->addMany($values);

$before = $input->getNodes();
print_r($before);

removeDuplicatesFromLinkedList($input, $values);

$after = $input->getNodes();
print_r($after);
