using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private Dough dough;
    private ICollection<Toping> topings;

    public Pizza(params string[] parameters)
    {
        this.Name = parameters[1];
        this.topings = new List<Toping>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrEmpty(value) || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }

            this.name = value;
        }
    }

    public void SetDough(Dough dough)
    {
        this.dough = dough;
    }

    public void AddToping(Toping toping)
    {
        if (this.topings.Count > 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }

        this.topings.Add(toping);
    }

    public override string ToString()
    {
        return $"{this.Name} - {(this.dough.TotalCalories + this.topings.Sum(x => x.TotalCalories)):F2} Calories."; 
    }
}
