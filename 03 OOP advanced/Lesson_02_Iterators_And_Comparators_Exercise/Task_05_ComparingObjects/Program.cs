using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var input = string.Empty;
        var persons = new List<Person>();

        while ((input = Console.ReadLine()) != "END")
        {
            persons.Add(new Person(input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));
        }

        var index = int.Parse(Console.ReadLine()) - 1;
        var person = persons[index];
        var equalPersons = 1;

        for (int i = 0; i < persons.Count; i++)
        {
            if (i != index)
            {
                var otherPerson = persons[i];

                if (person.CompareTo(otherPerson) == 0)
                {
                    equalPersons++;
                }
            }
        }

        var personsCount = persons.Count;

        if (equalPersons == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(
                string.Format(
                    "{0} {1} {2}"
                    , equalPersons
                    , personsCount - equalPersons
                    , personsCount));
        }
    }
}
