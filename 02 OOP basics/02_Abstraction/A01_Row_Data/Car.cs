using System;
using System.Collections.Generic;
using System.Linq;

public class Car
{
    public Car(params string[] parameters)
    {
        this.Model = parameters[0];

        this.Engine = this.CreateEngine(parameters[1], parameters[2]);
        this.Cargo = this.CreateCargo(parameters[3], parameters[4]);
        this.Tyres = CreateTyres(parameters.Skip(5));
    }

    public string Model { get; private set; }

    public Engine Engine { get; private set; }

    public Cargo Cargo { get; private set; }

    public ICollection<Tyre> Tyres { get; private set; }

    private Engine CreateEngine(string valueForSpeed, string valueForPower)
    {
        var power = default(int);

        if (!int.TryParse(valueForPower, out power))
        {
            throw new ArgumentException();
        }

        var speed = default(int);

        if (!int.TryParse(valueForSpeed, out speed))
        {
            throw new ArgumentException();
        }

        return new Engine(power, speed);
    }

    private Cargo CreateCargo(string valueForWeight, string type)
    {
        var weight = default(int);

        if (!int.TryParse(valueForWeight, out weight))
        {
            throw new ArgumentException();
        }

        return new Cargo(type, weight);
    }

    private ICollection<Tyre> CreateTyres(IEnumerable<string> collection)
    {
        var tyres = new List<Tyre>();

        var count = 1;
        var age = default(int);
        var pressure = default(double);

        foreach (var value in collection)
        {
            if (count % 2 != 0)
            {
                if (!double.TryParse(value, out pressure))
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                if (!int.TryParse(value, out age))
                {
                    throw new ArgumentException();
                }

                tyres.Add(new Tyre(age, pressure));
            }

            count++;
        }

        return tyres;
    }
}
