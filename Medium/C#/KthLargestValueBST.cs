using System;

public class KthLargestValueBST
{
    // This is an input class. Do not edit.
    public class BST
    {
        public int value;
        public BST left = null;
        public BST right = null;

        public BST(int value)
        {
            this.value = value;
        }
    }

    public int FindKthLargestValueInBst(BST tree, int k)
    {
        int count = CountNodes(tree.right);
        if (k == count + 1)
        {
            return tree.value;
        }
        else if (k <= count)
        {
            return FindKthLargestValueInBst(tree.right, k);
        }
        else
        {
            return FindKthLargestValueInBst(tree.left, k - count - 1);
        }
    }

    private int CountNodes(BST node)
    {
        if (node == null)
        {
            return 0;
        }
        else
        {
            return 1 + CountNodes(node.left) + CountNodes(node.right);
        }
    }
}
