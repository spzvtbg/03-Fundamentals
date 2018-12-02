using System;
using System.Collections.Generic;

public class CountSameValuesInArray
{
    public static void Main()
    {
        var stringArrayOfDoubles = Console.ReadLine()
            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        var doubles = new double[stringArrayOfDoubles.Length];
        for (int index = 0; index < stringArrayOfDoubles.Length; index++)
        {
            doubles[index] = Convert.ToDouble(stringArrayOfDoubles[index]);
        }

        var statistic = new SortedDictionary<double, int>();
        foreach (var item in doubles)
        {
            if (!statistic.ContainsKey(item))
            {
                statistic[item] = 0;
            }
            statistic[item]++;
        }

        foreach (var item in statistic)
        {
            Console.WriteLine($"{item.Key} - {item.Value} times");
        }
    }
}
