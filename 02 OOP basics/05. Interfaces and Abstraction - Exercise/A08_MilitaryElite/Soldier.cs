public abstract class Soldier : ISoldier
{
    public Soldier(params string[] parameters)
    {
        this.Id = parameters[0];
        this.FirstName = parameters[1];
        this.LastName = parameters[2];
        this.Salary = decimal.Parse(parameters[3]);
    }

    public string Id { get; private set;}

    public string FirstName { get; private set;}

    public string LastName { get; private set;}

    public decimal Salary { get; private set;}

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";
    }
}
