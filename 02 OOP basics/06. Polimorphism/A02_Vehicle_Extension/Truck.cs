public class Truck : Vehicle
{
    public Truck(params string[] parameters) : base(parameters)
    {
    }

    public override double FuelConsumption => base.FuelConsumption + 1.6;

    public override void Refuel(double fuelAmount)
    {
        if (base.TankCapacity < fuelAmount)
        {
            base.Refuel(fuelAmount);
            return;
        }

        base.Refuel(fuelAmount * 0.95);
    }
}
