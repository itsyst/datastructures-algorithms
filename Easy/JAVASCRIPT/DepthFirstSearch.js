class Node {
    constructor(name) {
        this.name = name;
        this.children = [];
        this.visited = new Set();
    }

    addChild(name) {
        this.children.push(new Node(name));
        return this;
    }

  
    depthFirstSearch(node) {
        this.visited.add(node.name);
        for (const child of node.children) {
            if (this.visited.has(node.name))
                this.depthFirstSearch(child);   
        }

        return this.visited;
    }
}


const graph = new Node('A');
graph.addChild('B').addChild('C').addChild('D');
graph.children[0].addChild('E').addChild('F');
graph.children[2].addChild('G').addChild('H');
graph.children[0].children[1].addChild('I').addChild('J');
graph.children[2].children[0].addChild('K');

var result = graph.depthFirstSearch(graph);
console.log(result);
