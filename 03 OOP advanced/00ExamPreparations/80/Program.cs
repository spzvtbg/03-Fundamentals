using System;

public class Program
{
    public static void Main()
    {
        var input = default(string);
        var collection = new CustomList<string>();

        while ((input = Console.ReadLine()) != "END")
        {
            var commandArgs = input.Split();
            var command = commandArgs[0];

            if (command == "Add")
            {
                collection.Add(commandArgs[1]);
            }
            else if (command == "Remove")
            {
                var element = collection.Remove(int.Parse(commandArgs[1]));
            }
            else if (command == "Contains")
            {
                Console.WriteLine(collection.Contains(commandArgs[1])? "True" : "False");
            }
            else if (command == "Swap")
            {
                collection.Swap(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
            }
            else if (command == "Greater")
            {
                Console.WriteLine(collection.CountGreaterThan(commandArgs[1]));
            }
            else if (command == "Max")
            {
                Console.WriteLine(collection.Max());
            }
            else if (command == "Min")
            {
                Console.WriteLine(collection.Min());
            }
            else if (command == "Print")
            {
                foreach (var item in collection.Content)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
