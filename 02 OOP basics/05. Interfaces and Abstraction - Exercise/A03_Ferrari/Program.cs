using System;

public class Program
{
    public static void Main()
    {
        ICar car = new Ferarri(Console.ReadLine());
        Console.WriteLine(car.ToString());
    }
}
