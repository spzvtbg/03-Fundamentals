using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = string.Empty;
        var ids = new List<string>();

        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            ids.Add(input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Last());
        }

        var end = Console.ReadLine();
        Console.WriteLine(string.Join(Environment.NewLine, ids.Where(x => x.EndsWith(end))));
    }
}
