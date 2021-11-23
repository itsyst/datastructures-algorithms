<?php

namespace Easy\PHP\DepthFirstSearch;

class Node
{
    public $name;
    public $children = array();
    public $visited = array();
 
    public function __construct($name)
    {
        $this->name = $name;
    }

    
 
    public function depthFirstSearch($node)
    {
        array_push($this->visited, $node->name);
        foreach ($node->children as $child) {
            if (in_array($node->name, $this->visited)) {
                $this->depthFirstSearch($child);
            }
        }

        return $this->visited;
    }

    public function addChild($name)
    {
        array_push($this->children, new Node($name));
        return $this;
    }
}

$graph = new Node('A');
$graph->addChild('B')->addChild('C')->addChild('D');
$graph->children[0]->addChild('E')->addChild('F');
$graph->children[2]->addChild('G')->addChild('H');
$graph->children[0]->children[1]->addChild('I')->addChild('J');
$graph->children[2]->children[0]->addChild('K');

$result = $graph->depthFirstSearch($graph);
//var_dump("$result");
// print_r("Graph: ".json_encode($result));
print_r("Graph: ".implode(",", $result));
 