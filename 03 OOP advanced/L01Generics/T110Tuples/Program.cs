using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var first = Console.ReadLine().Split();
        var t1 = new CustomTuple<string, string, string>();
        t1.Value1 = string.Join(" ", first.Take(first.Length - 2));
        t1.Value2 = first[first.Length - 2];
        t1.Value3 = first[first.Length - 1];
        Console.WriteLine((t1.ToString()) + (t1.Value3));

        var second = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var t2 = new CustomTuple<string, int, string>();
        t2.Value1 = string.Join(" ", second.Take(second.Length - 2));
        t2.Value2 = int.Parse(second[second.Length - 2]);
        t2.Value3 = second[second.Length - 1];
        Console.WriteLine((t2.ToString()) + (t2.Value3 == "drunk" ? "True" : "False"));

        var third = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var t3 = new CustomTuple<string, double, string>();
        t3.Value1= string.Join(" ", third.Take(third.Length - 2));
        t3.Value2 = double.Parse(third[third.Length - 2]);
        t3.Value3 = third[third.Length - 1];
        Console.WriteLine((t3.ToString()) + (t3.Value3));
    }
}
