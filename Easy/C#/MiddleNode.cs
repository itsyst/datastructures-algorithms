using System.Collections.Generic;
using System;

class MiddleNode
{
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

    public LinkedList MiddleNodes(LinkedList linkedList)
    {
        int count = 0;
        LinkedList currentNode = linkedList;
        while (currentNode != null)
        {
            count++;
            currentNode = currentNode.next;
        }

        LinkedList MiddleNode = linkedList;
        for (int i = 0; i < count / 2; i++)
        {
            MiddleNode = MiddleNode.next;
        }
        return MiddleNode;
    }
    
}