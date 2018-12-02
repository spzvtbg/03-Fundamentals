using System;
using System.Collections.Generic;

public class SimpleCalculator
{
    static double expressionResult;
    static string currentElement = string.Empty;
    static Stack<string> givenExpression = new Stack<string>();

    public static void Main()
    {
        PushToStack($@"{Console.ReadLine()}");
        CalculateExpression();
        Console.WriteLine(expressionResult);
    }

    static void PushToStack(string expression)
    {
        for (int symbol = 0; symbol < expression.Length; symbol++)
        {
            if (expression[symbol] != ' ')
            {
                currentElement += expression[symbol];
            }
            if (expression[symbol] == ' ' || symbol == expression.Length - 1)
            {
                givenExpression.Push(currentElement);
                currentElement = string.Empty;
            }
        }
    }

    static void CalculateExpression()
    {
        var number = 0.0;
        var lastnumber = 0.0;
        while (givenExpression.Count > 0)
        {
            var currentElement = givenExpression.Pop();
            if (double.TryParse(currentElement, out number))
            {
                lastnumber = number;
                expressionResult += number;
            }
            else if (currentElement == "-")
            {
                expressionResult -= 2 * lastnumber;
            }
        }
    }
}
