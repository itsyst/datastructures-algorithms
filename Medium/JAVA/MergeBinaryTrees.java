public class MergeBinaryTrees {
    // This is an input class. Do not edit.
    public class BinaryTree {
        public int value;
        public BinaryTree left = null;
        public BinaryTree right = null;

        public BinaryTree(int value) {
            this.value = value;
        }
    }

    public BinaryTree mergeBinaryTrees(BinaryTree tree1, BinaryTree tree2) {
        if (tree1 == null) {
            return tree2;
        }

        if (tree2 == null) {
            return tree1;
        }

        BinaryTree mergedTree = new BinaryTree(tree1.value + tree2.value);
        mergedTree.left = mergeBinaryTrees(tree1.left, tree2.left);
        mergedTree.right = mergeBinaryTrees(tree1.right, tree2.right);

        return mergedTree;
    }

    public static void main(String[] args) {
        // Test your code here
    }
}
