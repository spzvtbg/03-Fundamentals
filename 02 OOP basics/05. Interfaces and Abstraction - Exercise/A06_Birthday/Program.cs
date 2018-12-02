using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = string.Empty;
        var dates = new List<string>();

        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            var last = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Last();

            if (last.Contains("/"))
            {
                dates.Add(last);
            }
        }

        var end = Console.ReadLine();
        Console.WriteLine(string.Join(Environment.NewLine, dates.Where(x => x.EndsWith(end))));
    }
}
