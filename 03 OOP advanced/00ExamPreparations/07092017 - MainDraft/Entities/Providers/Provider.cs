public class Provider : IProvider
{
    const double INITIAL_DURABILITY = 1000;

    protected Provider(int id, double energyOutput)
    {
        this.ID = id;
        this.EnergyOutput = energyOutput;
        this.Durability = INITIAL_DURABILITY;
    }

    public int ID { get; }

    public double EnergyOutput { get; }

    public double Durability { get; protected set; }

    public void Broke()
    {
        throw new System.NotImplementedException();
    }

    public double Produce()
    {
        throw new System.NotImplementedException();
    }

    public void Repair(double val)
    {
        throw new System.NotImplementedException();
    }
}