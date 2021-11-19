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

public class BTree
{
    public Node root;

    public List<int> BranchSums(Node root)
    {
        var sum = new List<int>();
        BranchSums(root, 0, sum);
        return sum;
    }

    public void BranchSums(Node root, int currentSum, List<int> sum)
    {
        if (root == null) return;

        int endSum = currentSum + root.value;
        if (root.left == null && root.right == null)
        {
            sum.Add(endSum);
            return;
        }

        BranchSums(root.left, endSum, sum);
        BranchSums(root.right, endSum, sum);
    }
}