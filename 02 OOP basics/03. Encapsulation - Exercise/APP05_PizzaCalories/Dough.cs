using System;
using System.Collections.Generic;

public class Dough
{
    private const int calories = 2;

    private readonly Dictionary<string, double> modifires = new Dictionary<string, double>()
    {
        { "white", 1.5 }, { "wholegrain", 1.0 }, { "crispy",  0.9 }, { "chewy", 1.1 }, { "homemade", 1.0 }
    };
    
    private double type;
    private double factor;
    public double weight;

    public Dough(params string[] parameters)
    {
        this.SetWeight(parameters[3]);
        this.SetDoughTypeAndFactor(parameters[1], parameters[2]);
    }

    public double TotalCalories
    {
        get
        {
            return (calories * this.weight) * this.type * this.factor;
        }
    }

    private void SetWeight(string weight)
    {
        var value = double.Parse(weight);

        if (value < 1 || value > 200)
        {
            throw new ArgumentException("Dough weight should be in the range [1..200].");
        }

        this.weight = value;
    }

    private void SetDoughTypeAndFactor(string type, string factor)
    {
        if (!this.modifires.ContainsKey(type.ToLower()) || !this.modifires.ContainsKey(factor.ToLower()))
        {
            throw new ArgumentException("Invalid type of dough.");
        }

        this.type = this.modifires[type.ToLower()];
        this.factor = this.modifires[factor.ToLower()];
    }
}