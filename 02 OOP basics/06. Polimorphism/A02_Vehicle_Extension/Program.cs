using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var car = VehicleFactory.GetNew(Console.ReadLine().SplitToLower(" "));
        var truck = VehicleFactory.GetNew(Console.ReadLine().SplitToLower(" "));
        var bus = VehicleFactory.GetNew(Console.ReadLine().SplitToLower(" "));

        var commandsCount = int.Parse(Console.ReadLine());

        for (int count = 0; count < commandsCount; count++)
        {
            var input = Console.ReadLine().SplitToLower(" ");

            if (input.Contains("car"))
            {
                car.ExecuteCommand(input);
            }
            else if (input.Contains("bus"))
            {
                bus.ExecuteCommand(input);
            }
            else
            {
                truck.ExecuteCommand(input);
            }
        }

        Console.WriteLine(car.ToString());
        Console.WriteLine(truck.ToString());
        Console.WriteLine(bus.ToString());
    }
}

public static class Extensions
{
    public static string[] SplitToLower(this string input, params string[] parameters)
    {
        return input.ToLower().Split(parameters, StringSplitOptions.RemoveEmptyEntries);
    }
}
