using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var personsSortedByName = new SortedSet<Person>(new NameComperator());
        var personsSortedByAge = new SortedSet<Person>(new AgeComperator());

        var persons = Int32.Parse(Console.ReadLine());

        for (int count = 0; count < persons; count++)
        {
            var info = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var currentPerson = new Person(info);

            personsSortedByName.Add(currentPerson);
            personsSortedByAge.Add(currentPerson);
        }

        var forgroundColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(String.Join(Environment.NewLine, personsSortedByName));
        Console.WriteLine(String.Join(Environment.NewLine, personsSortedByAge));
        Console.ForegroundColor = forgroundColor;
    }
}
