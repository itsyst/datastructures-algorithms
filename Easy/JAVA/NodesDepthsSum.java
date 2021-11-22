import java.util.ArrayList;
import java.util.List;

public class NodesDepthsSum {

    private static class Node {
        private int value;
        private Node left;
        private Node right;

        private Node(int value) {
            this.value = value;
        }
    }

    private static class Level {
        private Node root;
        private int height;

        private Level(Node root, int height) {
            this.root = root;
            this.height = height;
        }
    }

    private class BTree {
        private static int NodesDepths(Node root) {
            return NodesDepths(root, 0);
        }

        private static int NodesDepths(Node root, int height) {
            if (root == null)
                return 0;
            return height + NodesDepths(root.left, height + 1) + NodesDepths(root.right, height + 1);
        }

 

        private static int  NodesDepth(Node root) {
            int sumOfDepths = 0;
            List<Level> level = new ArrayList<>();
            level.add(new Level(root, 0));

            while(level.size()> 0){
                Level info = level.remove(level.size() -1);
                Node node = info.root;
                int height = info.height;
                if (node == null) continue;
                sumOfDepths += height;
                level.add(new Level(node.left, height + 1));
                level.add(new Level(node.right, height + 1));
            }

            return sumOfDepths;
        }
    }

    public static void main(String[] args) {
        var root = new Node(1);
        root.left = new Node(2);
        root.left.left = new Node(4);
        root.left.left.left = new Node(8);
        root.left.left.right = new Node(9);
        root.left.right = new Node(5);
        root.right = new Node(3);
        root.right.left = new Node(6);
        root.right.right = new Node(7);

        //var sums = NodesDepthsSum.BTree.NodesDepths(root);
        var sums = NodesDepthsSum.BTree.NodesDepth(root);
        System.out.println(sums);
    }
}