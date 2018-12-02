using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Animal
{
    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
    }

    public string Name { get; private set; }

    public double Weight { get; private set; }

    public virtual double WeightGrowValue { get; }

    public virtual string SoundProduced { get; }

    public int FoodQuantity { get; private set; }

    public virtual Type[] FoodEaten { get; }

    public virtual void Eat(Food food)
    {
        var typeOfFood = food.GetType();

        if (this.FoodEaten.Contains(typeOfFood))
        {
            this.Weight += (food.Quantity * this.WeightGrowValue);
            this.FoodQuantity = food.Quantity;
        }
        else
        {
            Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}{{0}}, {this.Weight}{{1}}, {this.FoodQuantity}]";
    }
}
