using System;

public class Car
{
    public Car(params string[] parameters)
    {
        this.Model = parameters[0];
        this.FuelAmount = double.Parse(parameters[1]);
        this.FuelConsumptionFor1km = double.Parse(parameters[2]);
    }

    public string Model { get; set; }

    public double FuelAmount { get; set; }

    public double FuelConsumptionFor1km { get; set; }

    public double DistanceTraveled { get; private set; }

    public void Move(string[] commandTokens)
    {
        double kilometers = double.Parse(commandTokens[2]);
        double temporaryFuelConsumption = kilometers * this.FuelConsumptionFor1km;

        if (temporaryFuelConsumption > this.FuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
            return;
        }

        this.DistanceTraveled += kilometers;
        this.FuelAmount -= temporaryFuelConsumption;
    }

    public override string ToString()
    {
        return $"{this.Model} {this.FuelAmount:F2} {this.DistanceTraveled}";
    }
}
