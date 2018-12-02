using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = default(string);

        var personsOfInterest = new List<Person>(); 

        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            var parameters = input.SplitWithStringSplitOptions(" ");

            var name = parameters[0];

            var person = personsOfInterest.FirstOrDefault(x => x.Name == name);

            if (person == null)
            {
                person = new Person(name);
                personsOfInterest.Add(person);
            }

            var property = parameters[1];

            if (property == "car")
            {
                person.Car = new Car(parameters[2], parameters[3]);
            }
            if (property == "company")
            {
                person.Company = new Company(parameters[2], parameters[3], parameters[4]);
            }
            if (property == "children")
            {
                person.Children.Add(new Child(parameters[2], parameters[3]));
            }
            if (property == "parents")
            {
                person.Parents.Add(new Parent(parameters[2], parameters[3]));
            }
            if (property == "pokemon")
            {
                person.Pokemons.Add(new Pokemon(parameters[2], parameters[3]));
            }
        }

        input = Console.ReadLine();

        Console.WriteLine(personsOfInterest.FirstOrDefault(x => x.Name == input).ToString());
    }
}
