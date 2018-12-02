using System;

public class Startup
{
    public static void Main()
    {
        Family family = new Family(int.Parse(Console.ReadLine()));
        for (int count = 0; count < family.Members; count++)
        {
            string[] tokens = Console.ReadLine().SplitBy(true, " ");

            string name = tokens[0];
            int age = int.Parse(tokens[1]);

            family.AddMember(new Person(name, age));
        }

        Person oldestMember = family.GetOldestMember();
        Console.WriteLine(oldestMember.ToString());
    }
}
