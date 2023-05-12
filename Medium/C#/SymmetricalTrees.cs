using System;

public class SymmetricalTrees
{
    // This is an input class. Do not edit.
    public class BinaryTree
    {
        public int value;
        public BinaryTree left = null;
        public BinaryTree right = null;

        public BinaryTree(int value)
        {
            this.value = value;
        }
    }

    public bool SymmetricalTree(BinaryTree tree)
    {
        if (tree == null)
        {
            return true; // empty tree is symmetrical
        }
        return IsMirror(tree.left, tree.right);
    }

    private bool IsMirror(BinaryTree node1, BinaryTree node2)
    {
        if (node1 == null && node2 == null)
        {
            return true; // both empty nodes are mirrors
        }
        if (node1 == null || node2 == null)
        {
            return false; // one empty node, one non-empty node are not mirrors
        }
        if (node1.value != node2.value)
        {
            return false; // nodes with different values are not mirrors
        }
        // recursively check if the subtrees are mirrors
        return IsMirror(node1.left, node2.right) && IsMirror(node1.right, node2.left);
    }
}
