using System;

public class Startup
{
    public static void Main()
    {
        var figure = new Figure
        {
            Length = double.Parse(Console.ReadLine()),
            Width = double.Parse(Console.ReadLine()),
            Height = double.Parse(Console.ReadLine()),
        };

        figure.Print();
    }
}
