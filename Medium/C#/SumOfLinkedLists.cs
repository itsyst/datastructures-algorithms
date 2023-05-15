using System;

public class SumOfLinkedLists
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

    public static LinkedList SumOfLinkedList(LinkedList linkedListOne, LinkedList linkedListTwo)
    {
        LinkedList dummy = new LinkedList(0); // Dummy node to simplify the code
        LinkedList current = dummy;
        int carry = 0;

        while (linkedListOne != null || linkedListTwo != null || carry != 0)
        {
            int valueOne = linkedListOne?.value ?? 0;
            int valueTwo = linkedListTwo?.value ?? 0;
            int total = valueOne + valueTwo + carry;
            carry = total / 10;
            int digit = total % 10;

            current.next = new LinkedList(digit);
            current = current.next;

            if (linkedListOne != null)
                linkedListOne = linkedListOne.next;
            if (linkedListTwo != null)
                linkedListTwo = linkedListTwo.next;
        }

        return dummy.next;
    }

    public static void Main(string[] args)
    {
        // Example usage
        // Linked List 1: 2 -> 4 -> 7 (representing the number 742)
        // Linked List 2: 9 -> 4 -> 5 (representing the number 549)
        // Sum: 742 + 549 = 1291
        // Resulting Linked List: 1 -> 9 -> 2 -> 1
        LinkedList listOne = new LinkedList(2);
        listOne.next = new LinkedList(4);
        listOne.next.next = new LinkedList(7);

        LinkedList listTwo = new LinkedList(9);
        listTwo.next = new LinkedList(4);
        listTwo.next.next = new LinkedList(5);

        LinkedList result = SumOfLinkedList(listOne, listTwo);

        // Printing the resulting linked list
        LinkedList current = result;
        while (current != null)
        {
            Console.Write(current.value + " ");
            current = current.next;
        }
    }
}
