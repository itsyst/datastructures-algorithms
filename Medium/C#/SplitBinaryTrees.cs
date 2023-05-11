using System;
using System.Collections.Generic;


public class Program
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

    public int SplitBinaryTree(BinaryTree tree)
    {
        List<int> sums = new List<int>();
        int total = Helper(sums, tree);
        if (total % 2 != 0) return 0;
        foreach (int sum in sums) if (sum == total / 2) return sum;
        return 0;
    }

    private int Helper(List<int> sums, BinaryTree tree)
    {
        if (tree == null) return 0;
        int left = Helper(sums, tree.left);
        int right = Helper(sums, tree.right);
        int sum = tree.value + left + right;
        sums.Add(sum);
        return sum;
    }

}
