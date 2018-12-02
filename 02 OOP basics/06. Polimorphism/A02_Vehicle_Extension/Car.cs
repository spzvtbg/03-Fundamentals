public class Car : Vehicle
{
    public Car(params string[] parameters) : base(parameters)
    {
    }

    public override double FuelConsumption => base.FuelConsumption + 0.9;
}
