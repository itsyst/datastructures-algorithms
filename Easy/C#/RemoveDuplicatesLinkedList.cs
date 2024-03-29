using System.Collections.Generic;
using System.Linq;

class LinkedList
{// This is an input class. Do not edit.
    public class Node
    {
        public int value;
        public Node next;

        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }

        public override string ToString()
        {
            return "" + value;
        }
    }

    // O(n) time | O(1) space n  is the number of nodes in the linkedlist 
    public Node addMany(Node likedList, List<int> values)
    {
        Node current = likedList;
        while (current.next != null)
        {
            current = current.next;
        }
        foreach (var value in values)
        {
            current.next = new Node(value);
            current = current.next;
        }
        return likedList;
    }

    public List<int> getNodes(Node node)
    {
        List<int> nodes = new List<int>();
        Node current = node;
        while (current != null)
        {
            nodes.Add(current.value);
            current = current.next;
        }
        
        return nodes;
    }

    public List<int> GetUniqueNodesFromLinkedList(Node node)
    {
        var listNodes = getNodes(node);
        HashSet<int> set = new HashSet<int>();
        foreach (var item in  listNodes)
            if(!set.Contains(item))
                set.Add(item);

        return listNodes = set.ToList();
    }

    public Node RemoveDuplicatesFromLinkedList(Node node)
    {
        Node current = node;
        while(current != null && current.next != null){
            Node nextUniqueNode = current.next;
            while(nextUniqueNode != null && nextUniqueNode.value == current.value){
                nextUniqueNode = nextUniqueNode.next;
            }
            current.next = nextUniqueNode;
            current = nextUniqueNode;
        }

        return  node;
    }

}