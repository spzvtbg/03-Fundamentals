using System.Collections.Generic;
using System.Text;

public class Person
{
    public Person(string name)
    {
        this.Name = name;
        this.Pokemons = new List<Pokemon>();
        this.Parents = new List<Parent>();
        this.Children = new List<Child>();
    }

    public string Name { get; set; }

    public Car Car { get; set; }

    public Company Company { get; set; }

    public ICollection<Pokemon> Pokemons { get; set; }

    public ICollection<Parent> Parents { get; set; }

    public ICollection<Child> Children { get; set; }

    public override string ToString()
    {
        var toString = new StringBuilder();

        toString.AppendLine(this.Name);

        toString.AppendLine("Company:");

        if (this.Company != null)
        {
            toString.AppendLine(this.Company.ToString());
        }

        toString.AppendLine("Car:");

        if (this.Car != null)
        {
            toString.AppendLine(this.Car.ToString());
        }

        toString.AppendLine("Pokemon:");

        foreach (var pokemon in this.Pokemons)
        {
            toString.AppendLine(pokemon.ToString());
        }

        toString.AppendLine("Parents:");

        foreach (var parent in this.Parents)
        {
            toString.AppendLine(parent.ToString());
        }

        toString.AppendLine("Children:");

        foreach (var child in this.Children)
        {
            toString.AppendLine(child.ToString());
        }

        return toString.ToString();
    }
}
