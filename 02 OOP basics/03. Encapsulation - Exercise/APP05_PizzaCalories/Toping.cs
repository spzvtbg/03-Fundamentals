using System;
using System.Collections.Generic;

public class Toping
{
    private const int calories = 2;

    private readonly Dictionary<string, double> modifires = new Dictionary<string, double>()
    {
        {"meat", 1.2}, {"veggies", 0.8}, {"cheese", 1.1}, {"sauce", 0.9},
    };

    private string name;
    private double type;
    private double weight;

    public Toping(params string[] parameters)
    {
        this.SetModifires(parameters[1]);
        this.SetWeight(parameters[2]);
    }

    public double TotalCalories => (calories * this.weight) * this.type;

    private void SetModifires(string type)
    {
        if (!this.modifires.ContainsKey(type.ToLower()))
        {
            throw new ArgumentException($"Cannot place {type} on top of your pizza.");
        }

        this.name = type;
        this.type = this.modifires[this.name.ToLower()];
    }

    private void SetWeight(string weight)
    {
        var value = double.Parse(weight);

        if (value < 1 || value > 50)
        {
            throw new ArgumentException($"{this.name} weight should be in the range [1..50].");
        }

        this.weight = value;
    }
}