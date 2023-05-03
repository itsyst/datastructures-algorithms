using System;

public class FindLoop
{
    public static LinkedList FindLoops(LinkedList head)
    {
        LinkedList tortoise = head;
        LinkedList hare = head;

        // Find the intersection point
        while (true)
        {
            tortoise = tortoise.next;
            hare = hare.next.next;

            if (tortoise == hare)
            {
                break;
            }
        }

        // Find the loop origin
        tortoise = head;
        while (tortoise != hare)
        {
            tortoise = tortoise.next;
            hare = hare.next;
        }

        return hare;
    }

    public class LinkedList
    {
        public int value;
        public LinkedList next = null;

        public LinkedList(int value)
        {
            this.value = value;
        }
    }
}
