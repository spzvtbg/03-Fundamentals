public class Bus : Vehicle
{
    public Bus(params string[] parameters) : base(parameters)
    {
        base.factory.AddFunction(nameof(this.DriveEmpty).ToLower(), this.GetType().Name.ToLower(), this.DriveEmpty);
    }

    public override double FuelConsumption => base.FuelConsumption + 1.4;
}
