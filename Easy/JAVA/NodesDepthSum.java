public class NodesDepthsSum {

    private static class Node {
        private int value;
        private Node left;
        private Node right;

        private Node(int value) {
            this.value = value;
        }
    }

    private class BTree {
        private static int NodesDepths(Node root) {
            return NodesDepths(root, 0);
        }

        private static int NodesDepths(Node root, int height) {
            if (root == null)
                return 0;
            return height + NodesDepths(root.left, height + 1) + NodesDepths(root.right, height + 1);
        }
    }

    public static void main(String[] args) {
        var root = new Node(1);
        root.left = new Node(2);
        root.left.left = new Node(4);
        root.left.left.left = new Node(8);
        root.left.left.right = new Node(9);
        root.left.right = new Node(5);
        root.right = new Node(3);
        root.right.left = new Node(6);
        root.right.right = new Node(7);

        var sums = NodesDepthsSum.BTree.NodesDepths(root);
        System.out.println(sums);
    }
}