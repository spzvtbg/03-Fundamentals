using System;
using System.Collections.Generic;

public class BalancedParenthesis
{
    public static void Main()
    {
        var parenthesesAsString = Console.ReadLine();
        if (parenthesesAsString.Length % 2 != 0)
        {
            Console.WriteLine("NO");
            return;
        }

        var parenthesInStack = new Stack<char>();
        parenthesInStack.Push(parenthesesAsString[0]);

        for (int index = 1; index < parenthesesAsString.Length; index++)
        {
            if (parenthesInStack.Count > 0)
            {
                if (parenthesInStack.Peek() == parenthesesAsString[index] - 1
                || parenthesInStack.Peek() == parenthesesAsString[index] - 2)
                {
                    parenthesInStack.Pop();
                }
                else
                {
                    parenthesInStack.Push(parenthesesAsString[index]);
                }
            }
            else
            {
                parenthesInStack.Push(parenthesesAsString[index]);
            }
        }

        if (parenthesInStack.Count == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
