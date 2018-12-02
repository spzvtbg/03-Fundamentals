using System;

public class Program
{
    public static void Main()
    {
        Vehicle car = null;
        Vehicle truck = null;

        int counter = int.MaxValue;
        bool isCommand = false;
        string input = string.Empty;

        while (true)
        {
            input = Console.ReadLine();
            var parameters = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parameters.Length == 1)
            {
                counter = int.Parse(input);
                isCommand = true;
                continue;
            }

            if (!isCommand)
            {
                var fuelAmount = double.Parse(parameters[1]);
                var fuelConsumption = double.Parse(parameters[2]);

                if (parameters[0].ToLower() == "car")
                {
                    car = new Car(fuelAmount, fuelConsumption);
                }
                else
                {
                    truck = new Truck(fuelAmount, fuelConsumption);
                }
            }
            else
            {
                var command = parameters[0];
                var type = parameters[1];
                var amount = double.Parse(parameters[2]);


                if (type.ToLower() == "car")
                {
                    if (command.ToLower() == "drive")
                    {
                        Console.WriteLine(car.Drive(amount));
                    }
                    else
                    {
                        car.Refuel(amount);
                    }
                }
                else
                {
                    if (command.ToLower() == "drive")
                    {
                        Console.WriteLine(truck.Drive(amount));
                    }
                    else
                    {
                        truck.Refuel(amount);
                    }
                }

                counter--;
            }

            if (counter <= 0)
            {
                Console.WriteLine(car.ToString());
                Console.WriteLine(truck.ToString());
                return;
            }
        }
    }
}
