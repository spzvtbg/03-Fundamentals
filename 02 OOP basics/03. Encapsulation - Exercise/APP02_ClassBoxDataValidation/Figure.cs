using System;

public class Figure
{
    private double lenght;
    private double width;
    private double height;

    public double Length
    {
        get
        {
            return this.lenght;
        }
        set
        {
            this.Validate(value, nameof(this.Length));
            this.lenght = value;
        }
    }

    public double Width
    {
        get
        {
            return this.width;
        }
        set
        {
            this.Validate(value, nameof(this.Width));
            this.width = value;
        }
    }

    public double Height
    {
        get
        {
            return this.height;
        }
        set
        {
            this.Validate(value, nameof(this.Height));
            this.height = value;
        }
    }

    public void Print()
    {
        Console.WriteLine($"Surface Area - {(2 * this.Height * this.Width + 2 * this.Height * this.Length + 2 * this.Length * this.Width):F2}");
        Console.WriteLine($"Lateral Surface Area - {(2 * this.Length * this.Height + 2 * this.Width * this.Height):F2}");
        Console.WriteLine($"Volume - {(this.Length * this.Height * this.Width):F2}");
    }

    private void Validate(double value, string name)
    {
        if (value <= 0)
        {
            throw new ArgumentException($"{name} cannot be zero or negative.");
        }
    }
}
