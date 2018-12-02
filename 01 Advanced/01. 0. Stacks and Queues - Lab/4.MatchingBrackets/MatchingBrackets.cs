using System;
using System.Collections.Generic;

public class MatchingBrackets
{
    public static void Main()
    {
        var nonSimpleExpression = Console.ReadLine();

        var openBraketsIndexes = new Stack<int>();
        for (int index = 0; index < nonSimpleExpression.Length; index++)
        {
            var currentSymbol = nonSimpleExpression[index];
            if (currentSymbol == '(')
            {
                openBraketsIndexes.Push(index);
            }
            else if (currentSymbol == ')')
            {
                var startIndex = openBraketsIndexes.Pop();
                var count = index - startIndex + 1;
                Console.WriteLine(nonSimpleExpression.Substring(startIndex, count));
            }
        }
    }
}
