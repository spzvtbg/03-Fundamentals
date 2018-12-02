using System;

public class Program
{
    public static void Main()
    {
        var input = string.Empty;

        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            var data = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            IPerson person = new Cityzen(data[0], data[1], int.Parse(data[2]));
            IResident resident = new Cityzen(data[0], data[1], int.Parse(data[2]));

            Console.WriteLine(person.GetName());
            Console.WriteLine(resident.GetName());
        }
    }
}
