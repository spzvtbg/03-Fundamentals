using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var length = input.Length;
        var result = new List<int>();

        for (int index = 0; index < length; index += 2)
        {
            result.Add(input[index]);
        }

        for (int index = length - 1; index >= 0; index--)
        {
            if (index % 2 == 1)
            {
                result.Add(input[index]);
            }
        }

        Console.WriteLine(string.Join(", ", result));
    }
}
