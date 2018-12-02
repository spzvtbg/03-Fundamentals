using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        var collection = Console.ReadLine().Split();
        var removeOperations = int.Parse(Console.ReadLine());

        IAddCollection one = new CustomCollection();
        IAddRemoveCollection two = new CustomCollection();
        IMyList three = new CustomCollection();

        StringBuilder[] lines = new StringBuilder[5];
        lines[0] = new StringBuilder();
        lines[1] = new StringBuilder();
        lines[2] = new StringBuilder();
        lines[3] = new StringBuilder();
        lines[4] = new StringBuilder();

        bool isFirst = true;

        foreach (var item in collection)
        {
            if (isFirst)
            {
                lines[0].Append(one.Add(item).ToString());
                lines[1].Append(two.Add(item).ToString());
                lines[2].Append(three.Add(item).ToString());
                isFirst = false;
                continue;
            }

            lines[0].Append($" {one.Add(item)}");
            lines[1].Append($" {two.Add(item)}");
            lines[2].Append($" {three.Add(item)}");
        }

        for (int count = 0; count < removeOperations; count++)
        {
            if (count == 0)
            {
                lines[3].Append(two.Remove());
                lines[4].Append(three.Remove());
                continue;
            }

            lines[3].Append($" {two.Remove()}");
            lines[4].Append($" {three.Remove()}");
        }

        foreach (var line in lines)
        {
            Console.WriteLine(line.ToString());
        }
    }
}
