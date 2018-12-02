using System;

public class RecursiveFibonacci
{
    private static ulong[] lookupArray;

    public static void Main()
    {
        var N = ulong.Parse(Console.ReadLine());
        lookupArray = new ulong[N + 1];
        lookupArray[0] = 1;
        lookupArray[1] = 1;

        var result = GetFibonacci(N);
        Console.WriteLine(result);
    }

    public static ulong GetFibonacci(ulong n)
    {
        if (n <= 2)
        {
            return 1;
        }

        if (lookupArray[n - 1] != 0)
        {
            return lookupArray[n - 1];
        }

        lookupArray[n - 1] = GetFibonacci(n - 1) + GetFibonacci(n - 2);
        return lookupArray[n - 1];
    }
}
