using System;

public class RemoveKthNodeFromTheEnd
{
    public static void RemoveKthNodeFromEnd(LinkedList head, int k)
    {
        LinkedList slow = head;
        LinkedList fast = head;

        // Move the fast pointer k nodes ahead
        for (int i = 0; i < k; i++)
        {
            fast = fast.Next;
        }

        // If the fast pointer becomes null, it means the head node is the kth node from the end
        if (fast == null)
        {
            head.Value = head.Next.Value;
            head.Next = head.Next.Next;
            return;
        }

        // Move both pointers together until the fast pointer reaches the end
        while (fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next;
        }

        // Remove the kth node by updating the pointers
        slow.Next = slow.Next.Next;
    }

    public class LinkedList
    {
        public int Value;
        public LinkedList Next = null;

        public LinkedList(int value)
        {
            this.Value = value;
        }
    }

    public static void Main(string[] args)
    {
        LinkedList head = new LinkedList(1);
        head.Next = new LinkedList(2);
        head.Next.Next = new LinkedList(3);
        head.Next.Next.Next = new LinkedList(4);
        head.Next.Next.Next.Next = new LinkedList(5);

        int k = 2;

        RemoveKthNodeFromEnd(head, k);

        // Print the updated linked list
        LinkedList current = head;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
    }
}
