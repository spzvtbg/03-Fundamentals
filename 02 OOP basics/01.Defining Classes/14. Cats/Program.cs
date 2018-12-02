using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static string input;
    public static string[] parameters;
    public static List<Cat> cats = new List<Cat>();

    public static void Main()
    {
        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            parameters = input.SplitWithStringSplitOptions(" ");

            if (!cats.Any(x => x.Name == parameters[1]))
            {
                cats.Add(new Cat(parameters));
            }
        }

        var name = Console.ReadLine();

        foreach (var cat in cats)
        {
            if (cat.Name == name)
            {
                Console.WriteLine(cat.ToString());
                return;
            }
        }
    }
}
