using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        ICollection<Car> cars = new List<Car>();

        int carsCount = int.Parse(Console.ReadLine());

        for (int count = 0; count < carsCount; count++)
        {
            string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            string model = input[0];
            Car car = new Car(model);

            int speed = int.Parse(input[1]);
            int power = int.Parse(input[2]);
            car.Engine = new Engine(power, speed);

            int weight = int.Parse(input[3]);
            string type = input[4];
            car.Cargo = new Cargo(type, weight);

            double press1 = double.Parse(input[5]);
            int age1 = int.Parse(input[6]);
            car.Tires[0] = new Tire(age1, press1);

            double press2 = double.Parse(input[7]);
            int age2 = int.Parse(input[8]);
            car.Tires[1] = new Tire(age2, press2);

            double press3 = double.Parse(input[9]);
            int age3 = int.Parse(input[10]);
            car.Tires[2] = new Tire(age3, press3);

            double press4 = double.Parse(input[11]);
            int age4 = int.Parse(input[12]);
            car.Tires[3] = new Tire(age4, press4);

            cars.Add(car);
        }

        string command = Console.ReadLine().ToLower();
        ICollection<Car> carsToPrint = new List<Car>();

        if (command == "fragile")
        {
            carsToPrint = cars
                .Where(x => x.Cargo.CargoType.ToLower() == command &&
                            x.Tires.Any(t => t.Pressure < 1)).ToList();
        }
        else if (command == "flamable")
        {
            carsToPrint = cars
                .Where(x => x.Cargo.CargoType.ToLower() == command &&
                            x.Engine.EnginePower > 250).ToList();
        }

        foreach (var car in carsToPrint)
        {
            Console.WriteLine(car.Model);
        }
    }
}
