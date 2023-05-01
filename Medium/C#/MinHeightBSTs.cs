using System;
using System.Collections.Generic;

public class MinHeightBsts
{
    public static BST MinHeightBst(List<int> array)
    {
        return ConstructMinHeightBst(array, 0, array.Count - 1);
    }

    private static BST ConstructMinHeightBst(List<int> array, int start, int end)
    {
        if (start > end)
        {
            return null;
        }

        int mid = start + (end - start) / 2;
        BST node = new BST(array[mid]);
        node.left = ConstructMinHeightBst(array, start, mid - 1);
        node.right = ConstructMinHeightBst(array, mid + 1, end);

        return node;
    }

    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }

        public void insert(int value)
        {
            if (value < this.value)
            {
                if (left == null)
                {
                    left = new BST(value);
                }
                else
                {
                    left.insert(value);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new BST(value);
                }
                else
                {
                    right.insert(value);
                }
            }
        }
    }
}
