class Node {
    constructor(value) {
        this.value = value;
        this.left = null;
        this.right = null;
    }
}

function branchSum(node) {
    const sum = []
    branchSumHelper(node, 0, sum);
    return sum;
}

function branchSumHelper(node, currentSum, sum) {
    if (node == null) return;

    let endSum = currentSum + node.value;
    if (node.left == null && node.right == null) {
        sum.push(endSum);
        return;
    }

    branchSumHelper(node.left, endSum, sum)
    branchSumHelper(node.right, endSum, sum)
}


const tree = new Node(10);
tree.left = new Node(5);
tree.left.left = new Node(2);
tree.left.left.left = new Node(1);
tree.left.right = new Node(5);
tree.right = new Node(15);
tree.right.left = new Node(13);
tree.right.left.right = new Node(14);
tree.right.right = new Node(22);


const result = branchSum(tree);
console.log(result);