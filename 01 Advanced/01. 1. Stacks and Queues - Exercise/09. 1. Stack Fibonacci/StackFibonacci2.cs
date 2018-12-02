using System;
using System.Collections.Generic;

public class StackFibonacci2
{
    public static void Main()
    {
        var N = Convert.ToInt32(Console.ReadLine());

        var fibonaccis = new Stack<ulong>();

        var first = 0UL;
        fibonaccis.Push(first);

        var second = 1UL;
        fibonaccis.Push(second);

        var sum = 0UL;

        while (fibonaccis.Count <= N)
        {
            sum = first + second;
            fibonaccis.Push(sum);

            first = second;
            second = sum;
        }
        Console.WriteLine(fibonaccis.Peek());
    }
}
