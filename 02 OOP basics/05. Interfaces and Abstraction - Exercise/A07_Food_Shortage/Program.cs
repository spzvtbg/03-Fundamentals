using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var citizens = new HashSet<string>();
        var rebelions = new HashSet<string>();

        var peoples = int.Parse(Console.ReadLine());

        for (int count = 0; count < peoples; count++)
        {
            var input = Console.ReadLine().Split(' ');

            if (input.Length == 3 && !citizens.Contains(input[0]))
            {
                rebelions.Add(input[0]);
            }
            else if (input.Length == 4 && !rebelions.Contains(input[0]))
            {
                citizens.Add(input[0]);
            }
        }

        var food = 0;

        var name = string.Empty;

        while ((name = Console.ReadLine()).ToLower() != "end")
        {
            food += citizens.Contains(name) ? 10
                    : rebelions.Contains(name) ? 5
                    : 0;
        }

        Console.WriteLine(food);
    }
}
