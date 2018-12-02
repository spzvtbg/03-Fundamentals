using System;
using System.Collections.Generic;

public class PeriodicTable
{
    static SortedSet<string> table = new SortedSet<string>();

    public static void Main()
    {
        var iterations = Convert.ToInt32(Console.ReadLine());

        for (int count = 0; count < iterations; count++)
        {
            var currentElements = Console.ReadLine().Split(' ');
            for (int index = 0; index < currentElements.Length; index++)
            {
                table.Add(currentElements[index]);
            }
        }

        foreach (var item in table)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}
