using System.Collections.Generic;

public class ReconstructBst
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

    public BST ReconstructBsts(List<int> preOrderTraversalValues)
    {
        // Call a recursive helper function to reconstruct the BST.
        int index = 0; // Start at the beginning of the pre-order traversal.
        return ReconstructBstHelper(preOrderTraversalValues, ref index, int.MinValue, int.MaxValue);
    }

    // Recursive helper function to reconstruct the BST.
    private BST ReconstructBstHelper(List<int> values, ref int index, int minValue, int maxValue)
    {
        // If we have processed all values or the next value is outside the valid range, return null.
        if (index >= values.Count || values[index] < minValue || values[index] >= maxValue)
        {
            return null;
        }

        // Create a new BST node with the current value, and increment the index to process the next value.
        BST node = new BST(values[index]);
        index++;

        // Recursively construct the left and right subtrees, passing the current node's value as a limit.
        node.left = ReconstructBstHelper(values, ref index, minValue, node.value);
        node.right = ReconstructBstHelper(values, ref index, node.value, maxValue);

        return node;
    }
}
