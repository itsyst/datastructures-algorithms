using System;

public class ValidateBST
{
    public static bool ValidateBsts(BST tree)
    {
        return ValidateBst(tree, int.MinValue, int.MaxValue);
    }

    private static bool ValidateBsts(BST node, int minValue, int maxValue)
    {
        if (node == null)
            return true;

        if (node.value < minValue || node.value >= maxValue)
            return false;

        bool isLeftValid = ValidateBsts(node.left, minValue, node.value);
        bool isRightValid = ValidateBsts(node.right, node.value, maxValue);

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
