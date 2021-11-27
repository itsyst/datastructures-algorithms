import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/**
 * RemoveDuplicatesLinkedList
 */
public class RemoveDuplicatesLinkedList {

    public static class Node {
        private int value;
        private Node next;

        public Node(int value) {
            this.value = value;
            this.next = null;
        }
    }

    public static Node addMany(Node linkedList, List<Integer> values) {
        Node current = linkedList;
        while (current.next != null)
            current = current.next;

        for (var value : values) {
            current.next = new Node(value);
            current = current.next;
        }

        return linkedList;
    }

    public static List<Integer> getNodes(Node node)
    {
        List<Integer> nodes = new ArrayList<Integer>();
        Node current = node;
        while (current != null)
        {
            nodes.add(current.value);
            current = current.next;
        }
        
        return nodes;
    }

    public static Node removeDuplicatesFromLinkedList(Node node) {
        Node current = node;
        while (current != null && current.next != null) {
            Node nextUniqueNode = current.next;
            while (nextUniqueNode != null && nextUniqueNode.value == current.value) {
                nextUniqueNode = nextUniqueNode.next;
            }
            current.next = nextUniqueNode;
            current = nextUniqueNode;

        }
        return node;
    }

    public static void main(String[] args) {
        var input = new Node(1);
        var values = new ArrayList<Integer>(Arrays.asList(1, 1, 2, 3, 8, 8, 8, 9, 12));
        addMany(input, values);

        var before = getNodes(input);
        System.out.println(before);

        removeDuplicatesFromLinkedList(input);

        var after = getNodes(input);
        System.out.println(after);
    }
}