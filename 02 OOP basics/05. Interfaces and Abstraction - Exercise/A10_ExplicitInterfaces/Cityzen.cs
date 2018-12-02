﻿public class Cityzen : IPerson, IResident
{
    public Cityzen(string name, string country, int age)
    {
        this.Name = name;
        this.Country = country;
        this.Age = age;
    }

    public string Name { get; set;}

    public int Age { get; set;}

    public string Country { get; set;}

    string IPerson.GetName()
    {
        return this.Name;
    }

    string IResident.GetName()
    {
        return $"Mr/Ms/Mrs {this.Name}";
    }
}
