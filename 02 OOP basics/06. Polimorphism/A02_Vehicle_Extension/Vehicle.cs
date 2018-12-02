using System;

public abstract class Vehicle
{
    private double fuelQuantity;

    protected VehicleFactory factory;

    public Vehicle(params string[] parameters)
    {
        this.TankCapacity = double.Parse(parameters[3]);
        this.FuelQuantity = double.Parse(parameters[1]);
        this.FuelConsumption = double.Parse(parameters[2]);

        this.RegisterFactory();
    }

    public double FuelQuantity
    {
        get
        {
            return this.fuelQuantity;
        }
        private set
        {
            if (value > this.TankCapacity)
            {
                this.fuelQuantity = 0;
            }
            else
            {
                this.fuelQuantity = value;
            }
        }
    }

    public virtual double FuelConsumption { get; set; }

    public double TankCapacity { get; private set; }

    public virtual void Refuel(double fuelAmount)
    {
        if (fuelAmount <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
            return;
        }

        var newFuelQuantity = this.FuelQuantity + fuelAmount;

        if (newFuelQuantity > this.TankCapacity)
        {
            Console.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
            return;
        }

        this.FuelQuantity = newFuelQuantity;
    }

    public void Drive(double distance)
    {
        var neededFuel = distance * this.FuelConsumption;

        if (this.FuelQuantity < neededFuel)
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
            return;
        }

        this.FuelQuantity -= neededFuel;

        Console.WriteLine($"{this.GetType().Name} travelled {distance} km"); 
    }

    protected virtual void SetInitialConsumption(double value)
    {
        this.FuelConsumption -= value;
    }

    public void ExecuteCommand(params string[] parameters)
    {
        this.factory.Execute(parameters);
    }

    public string ToString()
    {
        return this.GetType().Name + ": " + this.FuelQuantity.ToString("F2");
    }

    public void DriveEmpty(double distance)
    {
        var neededFuel = distance * (this.FuelConsumption - 1.4);

        if (this.FuelQuantity < neededFuel)
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
            return;
        }

        this.FuelQuantity -= neededFuel;

        Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
    }

    protected virtual void RegisterFactory()
    {
        this.factory = new VehicleFactory();

        this.factory.AddFunction("drive", "car", this.Drive);
        this.factory.AddFunction("drive", "truck", this.Drive);
        this.factory.AddFunction("drive", "bus", this.Drive);
        this.factory.AddFunction("driveempty", "bus", this.DriveEmpty);
        this.factory.AddFunction("refuel", "car", this.Refuel);
        this.factory.AddFunction("refuel", "truck", this.Refuel);
        this.factory.AddFunction("refuel", "bus", this.Refuel);
    }
}
