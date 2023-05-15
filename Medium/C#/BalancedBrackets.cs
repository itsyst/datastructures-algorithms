using System;
using System.Collections.Generic;

public class BalancedBrackets
{
    public static bool BalancedBracket(string str)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in str)
        {
            if (IsOpeningBracket(c))
            {
                stack.Push(c);
            }
            else if (IsClosingBracket(c))
            {
                if (stack.Count == 0 || !BracketsMatch(stack.Peek(), c))
                {
                    return false;
                }
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }

    private static bool IsOpeningBracket(char c)
    {
        return c == '(' || c == '[' || c == '{';
    }

    private static bool IsClosingBracket(char c)
    {
        return c == ')' || c == ']' || c == '}';
    }

    private static bool BracketsMatch(char opening, char closing)
    {
        return (opening == '(' && closing == ')')
            || (opening == '[' && closing == ']')
            || (opening == '{' && closing == '}');
    }

    public static void Main(string[] args)
    {
        string str = "([]{()})";
        bool isBalanced = BalancedBracket(str);
        Console.WriteLine($"Is the string balanced? {isBalanced}");
    }
}
