using System;

public class BinaryTreeDiameter
{
    public int BinaryTreeDiameters(BinaryTree tree)
    {
        // Call a recursive helper function to calculate the diameter of the tree.
        return BinaryTreeDiameterHelper(tree).diameter;
    }

    // Recursive helper function to calculate the diameter of the tree.
    private (int height, int diameter) BinaryTreeDiameterHelper(BinaryTree tree)
    {
        // Base case: a null tree has height 0 and diameter 0.
        if (tree == null)
        {
            return (0, 0);
        }

        // Recursively calculate the heights and diameters of the left and right subtrees.
        (int leftHeight, int leftDiameter) = BinaryTreeDiameterHelper(tree.left);
        (int rightHeight, int rightDiameter) = BinaryTreeDiameterHelper(tree.right);

        // The height of the current tree is one more than the maximum height of its subtrees.
        int height = Math.Max(leftHeight, rightHeight) + 1;

        // The diameter of the current tree is the maximum of the following:
        // 1. The diameter of the left subtree.
        // 2. The diameter of the right subtree.
        // 3. The length of the path that passes through the root node, which is the sum of the heights of the left and right subtrees.
        int diameter = Math.Max(leftDiameter, rightDiameter);
        diameter = Math.Max(diameter, leftHeight + rightHeight);

        // Return the height and diameter of the current tree.
        return (height, diameter);
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
