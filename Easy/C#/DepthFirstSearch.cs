public class Graph
{
    public class Node
    {
        public string name;
        public List<Node> children = new List<Node>();

        public Node(string name)
        {
            this.name = name;
        }

        public List<string> DepthFirstSearch(Node node)
        {
            return DepthFirstSearch(node, new HashSet<string>());
        }

        private List<string> DepthFirstSearch(Node node, HashSet<string> visited)
        {
            visited.Add(node.name);
            foreach (var item in node.children)
                if (!visited.Contains(item.name))
                    DepthFirstSearch(item, visited);

            return visited.ToList();
        }

        public Node AddChild(string name)
        {
            Node child = new Node(name);
            children.Add(child);
            return this;
        }
    }
}