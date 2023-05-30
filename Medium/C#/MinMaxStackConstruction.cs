using System;

public class MinMaxStackConstruction
{
    // Feel free to add new properties and methods to the class.
    public class MinMaxStack
    {
        private class StackNode
        {
            public int value;
            public int min;
            public int max;

            public StackNode(int value, int min, int max)
            {
                this.value = value;
                this.min = min;
                this.max = max;
            }
        }

        private StackNode[] stack;
        private int top;

        public MinMaxStack()
        {
            stack = new StackNode[10]; // initial capacity of the stack
            top = -1;
        }

        public int Peek()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return stack[top].value;
        }

        public int Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int value = stack[top].value;
            top--;

            return value;
        }

        public void Push(int number)
        {
            int min = number;
            int max = number;

            if (top >= 0)
            {
                min = Math.Min(min, stack[top].min);
                max = Math.Max(max, stack[top].max);
            }

            top++;
            if (top >= stack.Length)
            {
                Array.Resize(ref stack, stack.Length * 2); // double the stack capacity
            }

            stack[top] = new StackNode(number, min, max);
        }

        public int GetMin()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return stack[top].min;
        }

        public int GetMax()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return stack[top].max;
        }
    }

    public static void Main(string[] args)
    {
        MinMaxStack stack = new MinMaxStack();
        stack.Push(5);
        Console.WriteLine(stack.GetMin()); // Output: 5
        Console.WriteLine(stack.GetMax()); // Output: 5
        Console.WriteLine(stack.Peek()); // Output: 5
        stack.Push(7);
        Console.WriteLine(stack.GetMin()); // Output: 5
        Console.WriteLine(stack.GetMax()); // Output: 7
    }
}
