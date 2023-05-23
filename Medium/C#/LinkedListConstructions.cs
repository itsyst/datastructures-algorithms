using System;

public class DoublyLinkedLists
{
    public class DoublyLinkedList
    {
        public Node Head;
        public Node Tail;

        public void SetHead(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            InsertBefore(Head, node);
        }

        public void SetTail(Node node)
        {
            if (Tail == null)
            {
                SetHead(node);
                return;
            }

            InsertAfter(Tail, node);
        }

        public void InsertBefore(Node node, Node nodeToInsert)
        {
            if (nodeToInsert == Head && nodeToInsert == Tail)
            {
                return;
            }

            Remove(nodeToInsert);

            nodeToInsert.Prev = node.Prev;
            nodeToInsert.Next = node;

            if (node.Prev == null)
            {
                Head = nodeToInsert;
            }
            else
            {
                node.Prev.Next = nodeToInsert;
            }

            node.Prev = nodeToInsert;
        }

        public void InsertAfter(Node node, Node nodeToInsert)
        {
            if (nodeToInsert == Head && nodeToInsert == Tail)
            {
                return;
            }

            Remove(nodeToInsert);

            nodeToInsert.Prev = node;
            nodeToInsert.Next = node.Next;

            if (node.Next == null)
            {
                Tail = nodeToInsert;
            }
            else
            {
                node.Next.Prev = nodeToInsert;
            }

            node.Next = nodeToInsert;
        }

        public void InsertAtPosition(int position, Node nodeToInsert)
        {
            if (position == 1)
            {
                SetHead(nodeToInsert);
                return;
            }

            Node currentNode = Head;
            int currentPosition = 1;

            while (currentNode != null && currentPosition != position)
            {
                currentNode = currentNode.Next;
                currentPosition++;
            }

            if (currentNode != null)
            {
                InsertBefore(currentNode, nodeToInsert);
            }
            else
            {
                SetTail(nodeToInsert);
            }
        }

        public void RemoveNodesWithValue(int value)
        {
            Node currentNode = Head;

            while (currentNode != null)
            {
                Node nodeToRemove = currentNode;
                currentNode = currentNode.Next;

                if (nodeToRemove.Value == value)
                {
                    Remove(nodeToRemove);
                }
            }
        }

        public void Remove(Node node)
        {
            if (node == Head)
            {
                Head = Head.Next;
            }

            if (node == Tail)
            {
                Tail = Tail.Prev;
            }

            if (node.Prev != null)
            {
                node.Prev.Next = node.Next;
            }

            if (node.Next != null)
            {
                node.Next.Prev = node.Prev;
            }

            node.Prev = null;
            node.Next = null;
        }

        public bool ContainsNodeWithValue(int value)
        {
            Node currentNode = Head;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }

            return false;
        }
    }

    // Do not edit the class below.
    public class Node
    {
        public int Value;
        public Node Prev;
        public Node Next;

        public Node(int value)
        {
            this.Value = value;
        }
    }
}
