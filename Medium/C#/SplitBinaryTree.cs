using System;

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
        int totalSum = CalculateTreeSum(tree);
        if (totalSum % 2 == 1)
        {
            // If the total sum of the Binary Tree is odd, it cannot be split into two Binary Trees of equal sum.
            return 0;
        }
        int targetSum = totalSum / 2;
        Tuple<int, bool> result = CheckSubtreeSum(tree, targetSum);
        if (result.Item2)
        {
            // If we found a subtree with the target sum, we can split the Binary Tree into two Binary Trees of equal sum.
            return result.Item1;
        }
        else
        {
            return 0;
        }
    }

    private int CalculateTreeSum(BinaryTree tree)
    {
        if (tree == null)
        {
            return 0;
        }
        return tree.value + CalculateTreeSum(tree.left) + CalculateTreeSum(tree.right);
    }

    private Tuple<int, bool> CheckSubtreeSum(BinaryTree tree, int targetSum)
    {
        if (tree == null)
        {
            return new Tuple<int, bool>(0, false);
        }
        int leftSum = CheckSubtreeSum(tree.left, targetSum).Item1;
        int rightSum = CheckSubtreeSum(tree.right, targetSum).Item1;
        int subtreeSum = leftSum + rightSum + tree.value;
        if (subtreeSum == targetSum)
        {
            // If the subtree sum is equal to the target sum, we have found a subtree that can be split into two Binary Trees of equal sum.
            return new Tuple<int, bool>(subtreeSum, true);
        }
        else
        {
            return new Tuple<int, bool>(subtreeSum, false);
        }
    }
}