using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int commingPeoples = int.Parse(Console.ReadLine());
        ICollection<Person> peoples = new List<Person>();

        for (int count = 0; count < commingPeoples; count++)
        {
            string[] data = Console.ReadLine().SplitBy(true, " ");

            string name = data[0];
            int age = int.Parse(data[1]);

            peoples.Add(new Person(name, age));
        }

        Console.WriteLine(
              string.Join(
                Environment.NewLine, 
                peoples
                    .Where(x => x.Age > 30)
                    .OrderBy(x => x.Name)));
    }
}
