using System;

public class MergeLinkedList
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

    public static LinkedList mergeLinkedLists(LinkedList headOne, LinkedList headTwo)
    {
        LinkedList dummyNode = new LinkedList(0);
        LinkedList current = dummyNode;

        while (headOne != null && headTwo != null)
        {
            if (headOne.value <= headTwo.value)
            {
                current.next = headOne;
                headOne = headOne.next;
            }
            else
            {
                current.next = headTwo;
                headTwo = headTwo.next;
            }
            current = current.next;
        }

        if (headOne != null)
        {
            current.next = headOne;
        }
        else if (headTwo != null)
        {
            current.next = headTwo;
        }

        return dummyNode.next;
    }

    public static void Main(string[] args)
    {
        // Example usage
        LinkedList headOne = new LinkedList(2);
        headOne.next = new LinkedList(6);
        headOne.next.next = new LinkedList(6);
        headOne.next.next.next = new LinkedList(7);
        headOne.next.next.next.next = new LinkedList(8);

        LinkedList headTwo = new LinkedList(1);
        headTwo.next = new LinkedList(3);
        headTwo.next.next = new LinkedList(4);
        headTwo.next.next.next = new LinkedList(5);
        headTwo.next.next.next.next = new LinkedList(9);
        headTwo.next.next.next.next.next = new LinkedList(10);

        LinkedList mergedHead = mergeLinkedLists(headOne, headTwo);

        // Print the merged list
        while (mergedHead != null)
        {
            Console.Write(mergedHead.value + " ");
            mergedHead = mergedHead.next;
        }
    }
}
