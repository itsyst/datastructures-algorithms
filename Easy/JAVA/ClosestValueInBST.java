
class ClosestValueInBST {

    public class Node {
        public int value;
        public Node left;
        public Node right;

        public Node(int value) {
            this.value = value;
        }

    }

    public static Node root;

    public void insert(int value)
    {
        var node = new Node(value);
        if (root == null)
        {
            root = node;
            return;
        }

        var current = root;
        while (true)
        {
            if (value < current.value)
            {
                if (current.left == null)
                {
                    current.left = node;
                    break;
                }
                current = current.left;
            }
            else
            {
                if (current.right == null)
                {
                    current.right = node;
                    break;
                }
                current = current.right;
            }
        }
    }

    public static int findClosestValueInBST(Node node, int target) {
        return findClosestValueInBST(node, target, root.value);
    }

    public static int findClosestValueInBST(Node node, int target, int closest) {
        if (Math.abs(target - node.value) < Math.abs(target - closest))
            closest = node.value;
        if (target < node.value && node.left != null)
            return findClosestValueInBST(node.left, target, closest);
        else if (target > node.value && node.right != null)
            return findClosestValueInBST(node.right, target, closest);
        else
            return closest;
    }

    public static void main(String[] args) {
        var tree = new ClosestValueInBST();
        var values = new int[] { 10, 5, 2, 1, 5, 15, 13, 14, 22 };
        for (var value : values)
        {
        tree.insert(value);
        }

        var result = findClosestValueInBST(ClosestValueInBST.root, 20);
        System.out.println(result);
       
    }
}