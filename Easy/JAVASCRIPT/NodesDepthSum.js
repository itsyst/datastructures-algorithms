function nodesDepthSum(root) {
    if (root === null) return;

    return nodesDepthSumHelper(root, 0);
}

function nodesDepthSumHelper(root, height) {
    if (root === null) return 0;

    return height + nodesDepthSumHelper(root.left, height + 1) + nodesDepthSumHelper(root.right, height + 1);
}

function nodeDepths(root) {
    sumOfDepths = 0;
    const stack = [{ "node": root, "height": 0 }];

    while(stack.length > 0){
        const { node, height } = stack.pop();
        if (node === null) continue;
        sumOfDepths += height
        stack.push({ "node": node.left, "height": height + 1 })
        stack.push({ "node": node.right, "height": height + 1 })
    }

    return sumOfDepths
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


// const result = nodesDepthSum(root);
// console.log(result);

const result = nodeDepths(root);
console.log(result);