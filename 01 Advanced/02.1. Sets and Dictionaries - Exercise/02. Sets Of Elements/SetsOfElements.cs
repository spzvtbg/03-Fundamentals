using System;
using System.Collections.Generic;
using System.Linq;

public class SetsOfElements
{
    static HashSet<int> nNumbers = new HashSet<int>();
    static HashSet<int> mNumbers = new HashSet<int>();

    public static void Main()
    {
        var splited = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        var first = Convert.ToInt32(splited[0]);
        var second = Convert.ToInt32(splited[1]);
        var number = 0;

        for (int iterations = 0; iterations < first; iterations++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            nNumbers.Add(number);
        }

        for (int iterations = 0; iterations < second; iterations++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            mNumbers.Add(number);
        }

        var result = nNumbers.Intersect(mNumbers);
        Console.WriteLine(string.Join(" ", result));
    }
}
