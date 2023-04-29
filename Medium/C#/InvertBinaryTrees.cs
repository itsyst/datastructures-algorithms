using System;

public class InvertBinaryTrees
{
    public static void InvertBinaryTree(BinaryTree tree)
    {
        if (tree == null)
        {
            return;
        }

        // Swap the left and right child nodes
        BinaryTree temp = tree.left;
        tree.left = tree.right;
        tree.right = temp;

        // Invert the left subtree
        InvertBinaryTree(tree.left);

        // Invert the right subtree
        InvertBinaryTree(tree.right);
    }

    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
        }
    }
}