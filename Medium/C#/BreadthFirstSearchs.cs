using System;
using System.Collections.Generic;

public class BreadthFirstSearchs {
    // Do not edit the class below except
    // for the BreadthFirstSearch method.
    // Feel free to add new properties
    // and methods to the class.
    public class Node {
        public string name;
        public List<Node> children = new List<Node>();

        public Node(string name) {
            this.name = name;
        }

        public List<string> BreadthFirstSearch(List<string> array) {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(this);

            while (queue.Count > 0) {
                Node current = queue.Dequeue();
                array.Add(current.name);

                foreach (Node child in current.children) {
                    queue.Enqueue(child);
                }
            }

            return array;
        }

        public Node AddChild(string name) {
            Node child = new Node(name);
            children.Add(child);
            return this;
        }
    }

    public static void Main(string[] args) {
        // Create a sample tree
        Node rootNode = new Node("A");
        rootNode.AddChild("B").AddChild("C").AddChild("D");
        rootNode.children[0].AddChild("E").AddChild("F");
        rootNode.children[2].AddChild("G").AddChild("H");
        rootNode.children[0].children[1].AddChild("I").AddChild("J");
        rootNode.children[2].children[0].AddChild("K");

        List<string> result = new List<string>();
        rootNode.BreadthFirstSearch(result);

        Console.WriteLine(string.Join(", ", result));
        // Output: A, B, C, D, E, F, G, H, I, J, K
    }
}
