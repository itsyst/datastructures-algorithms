using System;

public class MergingLinkedLists
{
    // This is an input class. Do not edit.
    public class LinkedList
    {
        public int value;
        public LinkedList next;

        public LinkedList(int value)
        {
            this.value = value;
            this.next = null;
        }
    }

    public static LinkedList MergingLinkedList(LinkedList linkedListOne, LinkedList linkedListTwo)
    {
        int lengthOne = GetLinkedListLength(linkedListOne);
        int lengthTwo = GetLinkedListLength(linkedListTwo);

        int diff = Math.Abs(lengthOne - lengthTwo);

        if (lengthOne > lengthTwo)
            linkedListOne = MovePointer(linkedListOne, diff);
        else
            linkedListTwo = MovePointer(linkedListTwo, diff);

        while (linkedListOne != null && linkedListTwo != null)
        {
            if (linkedListOne == linkedListTwo)
                return linkedListOne;

            linkedListOne = linkedListOne.next;
            linkedListTwo = linkedListTwo.next;
        }

        return null;
    }

    private static int GetLinkedListLength(LinkedList head)
    {
        int length = 0;
        LinkedList current = head;

        while (current != null)
        {
            length++;
            current = current.next;
        }

        return length;
    }

    private static LinkedList MovePointer(LinkedList head, int steps)
    {
        LinkedList current = head;

        while (steps > 0)
        {
            current = current.next;
            steps--;
        }

        return current;
    }

    public static void Main(string[] args)
    {
        // Example usage
        // Linked List 1: 1 -> 2 -> 3 -> 6 -> 7
        // Linked List 2: 4 -> 5 -> 6 -> 7
        // Intersection: 6 -> 7
        LinkedList listOne = new LinkedList(1);
        listOne.next = new LinkedList(2);
        listOne.next.next = new LinkedList(3);
        listOne.next.next.next = new LinkedList(6);
        listOne.next.next.next.next = new LinkedList(7);

        LinkedList listTwo = new LinkedList(4);
        listTwo.next = new LinkedList(5);
        listTwo.next.next = listOne.next.next.next; // Intersection node

        LinkedList intersection = MergingLinkedList(listOne, listTwo);

        if (intersection != null)
            Console.WriteLine("Intersection Node: " + intersection.value);
        else
            Console.WriteLine("No Intersection");
    }
}
