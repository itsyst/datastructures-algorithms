using System.Collections.Generic;
using System;

public class Program
{
    public List<int> SortStack(List<int> stack)
    {
        if (stack.Count == 0 || stack.Count == 1)
        {
            return stack; // already sorted
        }
        int top = stack[stack.Count - 1]; // peek at the top element
        stack.RemoveAt(stack.Count - 1); // pop the top element
        SortStack(stack); // recursively sort the rest of the stack
        InsertSorted(stack, top); // insert the top element at the right position
        return stack;
    }

    private void InsertSorted(List<int> stack, int value)
    {
        if (stack.Count == 0 || value >= stack[stack.Count - 1])
        {
            stack.Add(value); // base case: append the value at the end
            return;
        }
        int top = stack[stack.Count - 1]; // peek at the top element
        stack.RemoveAt(stack.Count - 1); // pop the top element
        InsertSorted(stack, value); // recursively insert the value
        stack.Add(top); // push back the top element
    }
}
