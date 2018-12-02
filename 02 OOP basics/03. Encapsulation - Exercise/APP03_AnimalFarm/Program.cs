using System;

public class Program
{
    public static void Main()
    {
        try
        {
            var chicken = new Chicken(Console.ReadLine(), int.Parse(Console.ReadLine()));
            chicken.CalculateProductPerDay();
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}
