using System;
using System.Collections.Generic;
using System.Linq;

public class LegendaryFarming
{
    static string material;
    static string winner;

    static int quantity;

    static bool isObtained = false;

    static Dictionary<string, string> items = new Dictionary<string, string>();
    static Dictionary<string, int> resources = new Dictionary<string, int>();
    static Dictionary<string, int> junks = new Dictionary<string, int>();

    public static void Main()
    {
        InitializeValues();
        ReadFrom(Console.ReadLine().ToLower());
        PrintWinner();
    }

    public static void InitializeValues()
    {
        items = new Dictionary<string, string>()
        {
            { "shards", "Shadowmourne" },
            { "fragments", "Valanyr" },
            { "motes", "Dragonwrath" }
        };

        resources = new Dictionary<string, int>()
        {
            { "shards", 0 },
            { "fragments", 0 },
            { "motes", 0 }
        };
    }

    public static void ReadFrom(string data)
    {
        var splited = data.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        for (int index = 1; index < splited.Length; index += 2)
        {
            material = splited[index];
            quantity = Convert.ToInt32(splited[index - 1]);

            RuleGivenResource();
            if (isObtained) { return; }
        }
        ReadFrom(Console.ReadLine().ToLower());
    }

    public static void RuleGivenResource()
    {
        if (resources.ContainsKey(material))
        {
            resources[material] += quantity;
            if (resources[material] >= 250)
            {
                winner = material;
                isObtained = true;
                return;
            }
        }
        else
        {
            AddOrUpdateJunks();
        }
    }

    public static void AddOrUpdateJunks()
    {
        if (!junks.ContainsKey(material))
        {
            junks[material] = 0;
        }
        junks[material] += quantity;
    }

    public static void PrintWinner()
    {
        Console.WriteLine($"{items[winner]} obtained!");

        resources[winner] -= 250;
        foreach (var item in resources.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        foreach (var item in junks.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
