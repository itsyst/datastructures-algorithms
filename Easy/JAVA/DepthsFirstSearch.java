import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

public class DepthsFirstSearch {

    public static class Node {
        private String name;
        private List<Node> children = new ArrayList<Node>();

        public Node(String name) {
            this.name = name;
        }
        
        public List<String> DepthFirstSearch(Node node) {
            return DepthFirstSearch(node, new HashSet<String>());
        }

        private List<String> DepthFirstSearch(Node node, Set<String> visited)
        {
            visited.add(node.name);
            for (var item : node.children)
                if (!visited.contains(item.name))
                    DepthFirstSearch(item, visited);

            return visited.stream().toList();
        }

        public Node addChild(String name) {
            Node child = new Node(name);
            children.add(child);
            return this;
        }
    }
    public static void main(String[] args) {
        var graph = new DepthsFirstSearch.Node("A");
        graph.addChild("B").addChild("C").addChild("D");
        graph.children.get(0).addChild("E").addChild("F");
        graph.children.get(0).children.get(1).addChild("I").addChild("J");
        graph.children.get(2).addChild("G").addChild("H");
        graph.children.get(2).children.get(0).addChild("K");

        var result = graph.DepthFirstSearch(graph);
        System.out.println(result);
    }
}