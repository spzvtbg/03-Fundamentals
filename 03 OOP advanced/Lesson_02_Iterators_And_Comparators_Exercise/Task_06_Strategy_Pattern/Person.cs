using System;

public class Person
{
    public Person(params string[] parameters)
    {
        this.Name = parameters[0];
        this.Age = Int32.Parse(parameters[1]);
    }

    public int Age { get; set; }

    public string Name { get; set; }

    public override string ToString()
    {
        return $"{this.Name} {this.Age}";
    }
}
