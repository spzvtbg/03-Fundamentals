using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        Car[] cars = new Car[rows];

        for (int index = 0; index < rows; index++)
        {
            cars[index] = new Car(Console.ReadLine().SplitBy(true, " "));
        }

        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            string[] commandTokens = command.SplitBy(true, " ");
            Car car = cars.Where(x => x.Model == commandTokens[1]).FirstOrDefault();
            car.Move(commandTokens);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }
}
