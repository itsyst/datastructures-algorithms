
function getClosetValueInBST(node, target) {
    if (node === null) return;
    return getClosetValueInBSTHelper(node, target, node.value);
}

function getClosetValueInBSTHelper(node, target, closest) {
    if (node === null) return closest;
    if (Math.abs(target - node.value) < Math.abs(target - closest)) {
        closest = node.value;
    }
    if (target < node.value) {
        return getClosetValueInBSTHelper(node.left, target, closest);
    }
    else if (target > node.value) {
        return getClosetValueInBSTHelper(node.right, target, closest);
    }
    else {
        return closest;
    }
}

class Node {
    constructor(value) {
        this.value = value;
        this.left = null;
        this.right = null;
    }
}

const root = new Node(10);
root.left = new Node(5);
root.left.left = new Node(2);
root.left.left.left = new Node(1);
root.left.right = new Node(5);
root.right = new Node(15);
root.right.left = new Node(13);
root.right.left.right = new Node(14);
root.right.right = new Node(22);


let result = getClosetValueInBST(root, 11);
console.log(result);