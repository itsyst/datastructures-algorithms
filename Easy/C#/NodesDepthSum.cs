using System;
using System.Collections.Generic;
using System.Linq;

public class NodesDepthSum
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

    public class Level
    {
        public Node root;
        public int height;

        public Level(Node root, int height)
        {
            this.root = root;
            this.height = height;
        }
    }

    public Node root;

    // Return the depth sum of nodes in binary tree
    public int nodeDepthSum(Node node)
    {
        return nodeDepthSum(node, 0);
    }

    // O(n) time | O(l)  n is number of node and l is the height
    public int nodeDepthSum(Node node, int level)
    {
        if (node == null)
        {
            return 0;
        }

        return level + nodeDepthSum(node.left, level + 1) + nodeDepthSum(node.right, level + 1);
    }

    public int nodeDepthSumIterator(Node root){
        int sumOfDepths = 0;
        Stack<Level> stack = new Stack<Level>();
        stack.Push(new Level(root, 0));
        while(stack.Count() > 0){
            Level info = stack.Pop();

            Node node = info.root;
            int height = info.height;
            if(node == null) continue;

            sumOfDepths += height;
            stack.Push(new Level(node.left, height + 1));
            stack.Push(new Level(node.right, height + 1));
        }

        return sumOfDepths;
    }

    private Boolean isEmpty()
    {
        return root == null;
    }

}