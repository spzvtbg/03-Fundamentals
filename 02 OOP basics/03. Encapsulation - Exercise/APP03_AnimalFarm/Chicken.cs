using System;

public class Chicken
{
    private int age;
    private string name;

    public Chicken(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        private set
        {
            if (value < 0 || value > 15)
            {
                throw new ArgumentException("Age should be between 0 and 15.");
            }

            this.age = value;
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
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            this.name = value;
        }
    }

    public void CalculateProductPerDay()
    {
        double egs = 0;

        if (this.Age >= 0 && this.Age <= 3)
        {
            egs = 1.5;
        }
        else if (this.Age >= 4 && this.Age <= 7)
        {
            egs = 2;
        }
        else if (this.Age >= 8 && this.Age <= 11)
        {
            egs = 1;
        }
        else
        {
            egs = 0.75;
        }

        Console.WriteLine($"Chicken {this.Name} (age {this.Age}) can produce {egs} eggs per day.");
    }
}
