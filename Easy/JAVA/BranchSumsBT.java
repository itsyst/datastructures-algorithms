import java.util.ArrayList;
import java.util.List;

public class BranchSumsBT {
    public static class Node {
        private int value;
        private Node left;
        private Node right;

        public Node(int value) {
            this.value = value;
        }
    }

    public class BTree {
        public static List<Integer> BrunchSum(Node node) {
            var sum = new ArrayList<Integer>();
            BrunchSum(node, 0, sum);
            return sum;
        }

        private static void BrunchSum(Node node, int currentSum, List<Integer> sum) {
            if (node == null)
                return;
            
            int endSum = currentSum + node.value;
            if (node.left == null && node.right == null) {
                sum.add(endSum);
                return;
            }

            BrunchSum(node.left, endSum, sum);
            BrunchSum(node.right, endSum, sum);
        }
    }
    public static void main(String[] args) {
        var root = new Node(10);
        root.left = new Node(5);
        root.left.left = new Node(2);
        root.left.left.left = new Node(1);
        root.left.right = new Node(5);
        root.right = new Node(15);
        root.right.left = new Node(13);
        root.right.left.right = new Node(14);
        root.right.right = new Node(22);

        var sums = BranchSumsBT.BTree.BrunchSum(root);
        System.out.println(sums.toString());
    }
}
