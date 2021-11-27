class Node {
    constructor(value) {
        this.value = value;
        this.next = null;
    }

    addMany(values) {
        let current = this;
        while (current.next !== null)
            current = current.next;

        for (const value of values) {
            current.next = new Node(value);
            current = current.next;
        }

        return this;
    }

    getNodes() {
        const nodes = [];
        let current = this;
        while (current !== null) {
            nodes.push(current.value);
            current = current.next;
        }

        return nodes;
    }
}



const removeDuplicatesFromLinkedList = (node) => {
    let current = node;
    while (current !== null & current.next !== null) {
        let nextUniqueNode = current.next;
        while (nextUniqueNode !== null && nextUniqueNode.value === current.value) {
            nextUniqueNode = nextUniqueNode.next;
        }
        current.next = nextUniqueNode;
        current = nextUniqueNode;
    }

    return node;
}


const node = new Node(1);
let values = [1, 1, 2, 3, 8, 8, 8, 9, 12];
node.addMany(values);

const before = node.getNodes();
console.log(before.toString());

removeDuplicatesFromLinkedList(node);

const after = node.getNodes(node);
console.log(after.toString());
