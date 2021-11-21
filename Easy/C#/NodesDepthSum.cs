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

    private Boolean isEmpty()
    {
        return root == null;
    }
 
}