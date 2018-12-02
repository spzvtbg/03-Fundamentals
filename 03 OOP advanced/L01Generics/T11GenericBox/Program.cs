using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    //// System.String
    //public static void Main()
    //{
    //    var lines = int.Parse(Console.ReadLine());

    //    for (int count = 0; count < lines; count++)
    //    {
    //        Console.WriteLine(new Box<string>(Console.ReadLine()).ToString());
    //    }
    //}

    //// System.Int32
    //public static void Main()
    //{
    //    var lines = int.Parse(Console.ReadLine());

    //    for (int count = 0; count < lines; count++)
    //    {
    //        Console.WriteLine(new Box<int>(int.Parse(Console.ReadLine())).ToString());
    //    }
    //}

    //// Swap method string
    //public static void Main()
    //{
    //    var lines = int.Parse(Console.ReadLine());
    //    var collection = new List<Box<string>>();

    //    for (int count = 0; count < lines; count++)
    //    {
    //        collection.Add(new Box<string>(Console.ReadLine()));
    //    }

    //    var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

    //    Swap(collection, indexes[0], indexes[1]);

    //    collection.ForEach(x => Console.WriteLine(x));
    //}

    // Swap method int
    //public static void Main()
    //{
    //    var lines = int.Parse(Console.ReadLine());
    //    var collection = new List<Box<int>>();

    //    for (int count = 0; count < lines; count++)
    //    {
    //        collection.Add(new Box<int>(int.Parse(Console.ReadLine())));
    //    }

    //    var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

    //    Swap(collection, indexes[0], indexes[1]);

    //    collection.ForEach(x => Console.WriteLine(x));
    //}

    //public static void Swap<T>(List<T> collection, int fromIndex, int toIndex)
    //{
    //    var temporaryElement = collection[fromIndex];
    //    collection[fromIndex] = collection[toIndex];
    //    collection[toIndex] = temporaryElement;
    //}

    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var collection = new List<double>();

        for (int count = 0; count < lines; count++)
        {
            collection.Add(double.Parse(Console.ReadLine()));
        }

        var element = double.Parse(Console.ReadLine());

       var greaterElementsCount = CountStrings(collection, element);

        Console.WriteLine(greaterElementsCount);
    }

    public static int CountStrings<T>(List<T> collection, double element) where T : IComparable<T>
    {
        var count = 0;
        foreach (var item in collection)
        {
            if (element.CompareTo(item) < 0)
            {
                count++;
            }
        }
        return count;
    }
}
