using System;

public class BSTree
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int value)
        {
            this.value = value;
        }

    }

    public Node root;

    public void insert(int value)
    {
        var node = new Node(value);
        if (isEmpty())
        {
            root = node;
            return;
        }

        var current = root;
        while (true)
        {
            if (value < current?.value)
            {
                if (current.left == null)
                {
                    current.left = node;
                    break;
                }
                current = current?.left;
            }
            else
            {
                if (current.right == null)
                {
                    current.right = node;
                    break;
                }
                current = current.right;
            }
        }
    }

    private Boolean isEmpty()
    {
        return root == null;
    }

    public int FindClosestValueInBST(Node node, int target)
    {
        return FindClosestValueInBST(node, target, root.value);
    }

    public int FindClosestValueInBST(Node node, int target, int closest)
    {
        if (Math.Abs(target - node.value) < Math.Abs(target - closest))
            closest = node.value;
        if (target < node.value && node.left != null)
            return FindClosestValueInBST(node.left, target, closest);
        else if (target > node.value && node.right != null)
            return FindClosestValueInBST(node.right, target, closest);
        else
            return closest;
    }
}