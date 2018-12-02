public class SolarProvider : Provider
{
    private const double ADDITIONAL_DURABILITY = 500;

    protected SolarProvider(int id, double energyOutput) 
        : base(id, energyOutput)
    {
        this.Durability += ADDITIONAL_DURABILITY;
    }
}
