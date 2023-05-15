using System;

public class ValidateBSTs
{
    public static bool ValidateBST(BST tree)
    {
        return ValidateBST(tree, int.MinValue, int.MaxValue);
    }

    private static bool ValidateBST(BST node, int minValue, int maxValue)
    {
        if (node == null)
            return true;

        if (node.value < minValue || node.value >= maxValue)
            return false;

        bool isLeftValid = ValidateBST(node.left, minValue, node.value);
        bool isRightValid = ValidateBST(node.right, node.value, maxValue);

        return isLeftValid && isRightValid;
    }

    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }
    }
}
