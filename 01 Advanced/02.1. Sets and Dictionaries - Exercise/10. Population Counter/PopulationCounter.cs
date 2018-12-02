using System;
using System.Collections.Generic;
using System.Linq;

public class PopulationCounter
{
    public static void Main(string[] args)
    {
        var data = new Dictionary<string, Dictionary<string, long>>();

        var input = Console.ReadLine();
        while (input != "report")
        {
            var splited = input.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            var country = splited[1];
            var town = splited[0];
            var population = Convert.ToInt64(splited[2]);

            if (!data.ContainsKey(country))
            {
                data[country] = new Dictionary<string, long>();
            }
            if (!data[country].ContainsKey(town))
            {
                data[country][town] = 0L;
            }
            data[country][town] += population;

            input = Console.ReadLine();
        }

        foreach (var country in data.OrderByDescending(x => x.Value.Values.Sum()))
        {
            Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

            foreach (var town in country.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"=>{town.Key}: {town.Value}");
            }
        }
    }
}
