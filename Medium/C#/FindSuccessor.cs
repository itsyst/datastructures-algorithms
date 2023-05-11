using System;

public class Program
{
    // This is an input class. Do not edit.
    public class BinaryTree
    {
        public int value;
        public BinaryTree left = null;
        public BinaryTree right = null;
        public BinaryTree parent = null;

        public BinaryTree(int value)
        {
            this.value = value;
        }
    }

    public BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node)
    {
        if (node.right != null)
        {
            // If node has right child, successor is the leftmost node in its right subtree.
            BinaryTree successor = node.right;
            while (successor.left != null)
            {
                successor = successor.left;
            }
            return successor;
        }
        else
        {
            // If node doesn't have right child, successor is the first ancestor whose left child contains node.
            BinaryTree ancestor = node.parent;
            while (ancestor != null && ancestor.left != node)
            {
                node = ancestor;
                ancestor = node.parent;
            }
            return ancestor;
        }
    }
}
