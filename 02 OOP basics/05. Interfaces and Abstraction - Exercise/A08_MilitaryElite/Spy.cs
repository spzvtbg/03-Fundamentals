using System;

public class Spy : Soldier
{
    public Spy(params string[] parameters) : base(parameters)
    {
    }

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}{Environment.NewLine}Code Number: {this.Salary}";
    }
}
