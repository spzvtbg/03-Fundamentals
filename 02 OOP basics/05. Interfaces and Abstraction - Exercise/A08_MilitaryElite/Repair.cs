public class Repair
{
    public Repair(params string[] parameters)
    {
        this.Name = parameters[0];
        this.WorkHouers = int.Parse(parameters[1]);
    }

    public string Name { get; private set; }

    public int WorkHouers { get; private set; }

    public override string ToString()
    {
        return $"Part Name: {this.Name} Hours Worked: {this.WorkHouers}";
    }
}
