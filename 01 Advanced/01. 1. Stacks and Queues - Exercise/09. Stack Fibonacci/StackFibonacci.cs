using System;
using System.Collections.Generic;

public class FibonacciNumbers
{
    private ulong first;
    private ulong second;

    public FibonacciNumbers(ulong first, ulong second)
    {
        this.first = first;
        this.second = second;
    }

    public ulong First
    {
        get { return first; }
        set { this.first = value; }
    }

    public ulong Second
    {
        get { return second; }
        set { this.second = value; }
    }

    public ulong Sum
    {
        get { return first + second; }
    }
}

public class StackFibonacci
{
    static ulong first = 0;
    static ulong second = 1;
    static FibonacciNumbers next = new FibonacciNumbers(first, second);

    static Stack<FibonacciNumbers> fibonacciResult = new Stack<FibonacciNumbers>();

    public static void Main()
    {
        var N = Convert.ToInt32(Console.ReadLine());

        fibonacciResult.Push(next);
        for (int index = 0; index < N - 2; index++)
        {
            first = next.Second;
            second = next.Sum;
            next = new FibonacciNumbers(first, second);
            fibonacciResult.Push(next);
        }
        Console.WriteLine(next.Sum);
    }
}
