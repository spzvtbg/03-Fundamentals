using System;
using System.Collections.Generic;
using System.Linq;

public class RowDataSolution
{
    public static void Main()
    {
        var cars = new List<Car>();
        var carsToRead = int.Parse(Console.ReadLine());

        for (int line = 0; line < carsToRead; line++)
        {
            cars.Add(new Car((Console.ReadLine().SplitBy(" "))));
        }

        var searched = Console.ReadLine();

        foreach (var car in cars)
        {
            if (searched == "fragile" && car.Tyres.Any(x => x.Pressure < 1))
            {
                Console.WriteLine(car.Model);
            }
            else if (searched == "flamable" && car.Engine.Power > 250)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
