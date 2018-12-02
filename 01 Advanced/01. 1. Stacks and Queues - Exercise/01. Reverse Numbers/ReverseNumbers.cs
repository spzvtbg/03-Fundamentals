using System;
using System.Collections.Generic;

public class ReverseNumbers
{
    static int[] numbers;
    static Stack<int> reversedNumbers = new Stack<int>();

    public static void Main()
    {
        var numbersToReverseAsString = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        ConvertToIntegers(numbersToReverseAsString);
        PushAllNumbers();
        Print();
    }

    private static void Print()
    {
        var isFirst = true;
        while (reversedNumbers.Count > 0)
        {
            if (isFirst)
            {
                Console.Write(reversedNumbers.Pop());
                isFirst = false;
                continue;
            }
            Console.Write($" {reversedNumbers.Pop()}");
        }
        Console.WriteLine();
    }

    private static void PushAllNumbers()
    {
        for (int index = 0; index < numbers.Length; index++)
        {
            reversedNumbers.Push(numbers[index]);
        }
    }

    static void ConvertToIntegers(string[] numbersToReverseAsString)
    {
        numbers = new int[numbersToReverseAsString.Length];
        for (int index = 0; index < numbersToReverseAsString.Length; index++)
        {
            numbers[index] = Convert.ToInt32(numbersToReverseAsString[index]);
        }
    }
}
