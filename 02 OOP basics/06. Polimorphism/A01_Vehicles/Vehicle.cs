public abstract class Vehicle
{
    public Vehicle(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }

    public double FuelQuantity { get; private set; }

    public virtual double FuelConsumption { get; private set; }

    public virtual void Refuel(double fuelAmount)
    {
        this.FuelQuantity += fuelAmount;
    }

    public string Drive(double distance)
    {
        var usedFuel = distance * this.FuelConsumption;

        if (this.FuelQuantity < usedFuel)
        {
            return $"{this.GetType().Name} needs refueling";
        }

        this.FuelQuantity -= usedFuel;

        return $"{this.GetType().Name} travelled {distance} km";
    }

    public override string ToString()
    {
        return this.GetType().Name + ": " + this.FuelQuantity.ToString("F2");
    }
}
