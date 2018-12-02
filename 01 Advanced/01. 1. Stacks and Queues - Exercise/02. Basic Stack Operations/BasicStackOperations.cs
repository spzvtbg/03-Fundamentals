using System;
using System.Collections.Generic;

public class BasicStackOperations
{
    public static void Main()
    {
        var comandNumbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var comandNumbersAsIntegers = ConvertToIntegers(comandNumbers);

        var numbersToPush = comandNumbersAsIntegers[0];
        var numbersToPop = comandNumbersAsIntegers[1];
        var numberToCheck = comandNumbersAsIntegers[2];

        if (numbersToPush == 0 || numbersToPush - numbersToPop <= 0)
        {
            Console.WriteLine(0);
            return;
        }

        var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var numbersAsIntegers = ConvertToIntegers(numbers);

        var minNumber = long.MaxValue;
        var iterations = Math.Min(numbersToPush, numbers.Length);

        var stackFromNumbers = new Stack<int>();
        var stackFromMinNumbers = new Stack<int>();

        for (int index = 0; index < iterations; index++)
        {
            if (numbersAsIntegers[index] < minNumber)
            {
                minNumber = numbersAsIntegers[index];
            }
            stackFromMinNumbers.Push(numbersAsIntegers[index]);

            stackFromNumbers.Push(numbersAsIntegers[index]);
        }

        iterations = Math.Min(numbersToPop, numbers.Length);

        for (int i = 0; i < iterations; i++)
        {
            var popedNumber = stackFromNumbers.Pop();

            if (stackFromMinNumbers.Peek() == popedNumber)
            {
                stackFromMinNumbers.Pop();
            }
        }

        if (stackFromNumbers.Count == 0)
        {
            Console.WriteLine(0);
            return;
        }
        if (stackFromNumbers.Contains(numberToCheck))
        {
            Console.WriteLine("true");
            return;
        }
        if (!stackFromNumbers.Contains(numberToCheck))
        {
            Console.WriteLine(stackFromMinNumbers.Peek());
            return;
        }
    }

    static int[] ConvertToIntegers(string[] numbersAsString)
    {
        var numbers = new int[numbersAsString.Length];
        for (int index = 0; index < numbersAsString.Length; index++)
        {
            numbers[index] = Convert.ToInt32(numbersAsString[index]);
        }
        return numbers;
    }
}
