public class EvaluateExpression
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree left = null, right = null;
        public BinaryTree(int value) { this.value = value; }
    }

    public int EvaluateExpressionTree(BinaryTree tree)
    {
        return tree.left == null && tree.right == null ? tree.value :
               Eval(tree.value, EvaluateExpressionTree(tree.left), EvaluateExpressionTree(tree.right));
    }

    private static int Eval(int op, int left, int right)
    {
        switch (op)
        {
            case -1: return left + right;
            case -2: return left - right;
            case -3: return left / right;
            case -4: return left * right;
            default: return 0;
        }
    }
}
