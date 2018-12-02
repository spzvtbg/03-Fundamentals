using System;
using System.Collections.Generic;

public class MinersTask
{
    static Dictionary<string, long> resources = new Dictionary<string, long>();

    public static void Main()
    {
        ReadData(Console.ReadLine());
        PrintResources();
    }

    public static void PrintResources()
    {
        foreach (var item in resources)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }

    public static void ReadData(string input)
    {
        if (input != "stop")
        {
            var quantity = Convert.ToInt64(Console.ReadLine());
            if (!resources.ContainsKey(input))
            {
                resources[input] = 0L;
            }
            resources[input] += quantity;

            ReadData(Console.ReadLine());
        }
    }
}
