using System.Collections.Generic;

public class Car
{
    public Car(string model)
    {
        this.Model = model;
        this.Tires = new Tire[4];
    }

    public string Model { get; set; }

    public Engine Engine { get; set; }

    public Cargo Cargo { get; set; }

    public Tire[] Tires { get; set; }
}
