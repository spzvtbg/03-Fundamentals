using System;

public class Program
{
    public static void Main()
    {
        var form = Console.ReadLine();
        Figure figure;

        if (form.ToLower() == "square")
        {
            figure = new Square(int.Parse(Console.ReadLine()));
            figure.Drow();
        }
        else
        {
            figure = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            figure.Drow();
        }
    }
}
