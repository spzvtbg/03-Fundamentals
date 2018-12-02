using System;

public class Startup
{
    public static void Main()
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        int diference = DateModifier.GetDiference(firstDate, secondDate);
        Console.WriteLine(diference);
    }
}
