using System;
using System.Collections.Generic;

public class DecimalToBinaryConverter
{
    static Stack<int> numberAsBinary = new Stack<int>();

    public static void Main()
    {
        var number = Convert.ToInt32(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine(0);
            return;
        }
        PushToNumberAsBinary(number);
        PrintNumberAsBinary();
    }

    static void PrintNumberAsBinary()
    {
        if (numberAsBinary.Count > 0)
        {
            Console.Write(numberAsBinary.Pop());
            PrintNumberAsBinary();
        }
        else Console.WriteLine();
    }

    static void PushToNumberAsBinary(int number)
    {
        var remainder = number % 2;
        numberAsBinary.Push(remainder);
        number /= 2;
        if (number > 0)
        {
            PushToNumberAsBinary(number);
        }
    }
}
