using System;
using System.Collections.Generic;

public class ReverseStrings
{
    static Stack<char> reversedString = new Stack<char>();

    public static void Main()
    {
        var inputStrings = Console.ReadLine();

        Push(inputStrings);
        PrintReversedString();
    }

    static void Push(string inputStrings)
    {
        for (int index = 0; index < inputStrings.Length; index++)
        {
            var currendString = inputStrings[index];
            reversedString.Push(currendString);
        }
    }

    static void PrintReversedString()
    {
        for (int index = 0; index < reversedString.Count;)
        {
            Console.Write(reversedString.Pop());
        }
        Console.WriteLine();
    }
}
