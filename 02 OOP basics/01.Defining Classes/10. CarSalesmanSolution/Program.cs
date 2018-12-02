using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var list = new Dictionary<string, Engine>();
        var engines = int.Parse(Console.ReadLine());

        for (int count = 0; count < engines; count++)
        {
            var engine = new Engine(Console.ReadLine().SplitBy(true, " "));

            if (list.ContainsKey(engine.Model))
            {
                list[engine.Model] = null;
            }

            list[engine.Model] = engine;
        }

        var carList = new List<Car>();
        var cars = int.Parse(Console.ReadLine());

        for (int count = 0; count < cars; count++)
        {
            var car = new Car(Console.ReadLine().SplitBy(true, " "));
            car.Engine = list[car.EngineModel];
            carList.Add(car);
        }

        foreach (var car in carList)
        {
            Console.WriteLine(car.ToString());
        }
    }
}
