using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var input = Console.ReadLine().SplitBy(true, " ");

        var rectangles = int.Parse(input[0]);

        Rectangle[] rectanglesCollection = new Rectangle[rectangles];

        for (int count = 0; count < rectangles; count++)
        {
            var tokens = Console.ReadLine().SplitBy(true, " ");

            var id = tokens[0];
            var width = double.Parse(tokens[1]);
            var height = double.Parse(tokens[2]);
            var left = double.Parse(tokens[3]);
            var top = double.Parse(tokens[4]);

            rectanglesCollection[count] = new Rectangle(id, width, height, left, top);
        }


        var qomperisons = int.Parse(input[1]);

        for (int count = 0; count < qomperisons; count++)
        {
            var toQompare = Console.ReadLine().SplitBy(true, " ");

            var first = rectanglesCollection.FirstOrDefault(x => x.Id == toQompare[0]);
            var second = rectanglesCollection.FirstOrDefault(x => x.Id == toQompare[1]);

            Console.WriteLine(first.Intersects(second) || second.Intersects(first) ? "true" : "false");
        }
    }
}
