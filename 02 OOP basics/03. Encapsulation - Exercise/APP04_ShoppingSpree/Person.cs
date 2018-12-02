using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> bag;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.bag = new List<Product>();
    }

    public ICollection<Product> Bag
    {
        get
        {
            return this.bag;
        }
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            this.name = value;
        }
    }

    private decimal Money
    {
        get
        {
            return this.money;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }
    }

    public void AddProduct(Product product)
    {
        if (this.Money < product.Cost)
        {
            Console.WriteLine($"{this.Name} can't afford {product.Name}");
            return;
        }

        this.bag.Add(product);
        this.Money -= product.Cost;
        Console.WriteLine($"{this.Name} bought {product.Name}");
    }
}
