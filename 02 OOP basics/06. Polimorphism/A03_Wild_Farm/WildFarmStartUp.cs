using System;
using System.Collections.Generic;

public class WildFarmStartUp
{
    public static int count = 0;
    public static string[] parameters;
    public static Animal animal = null;
    public static ICollection<Animal> animals = new List<Animal>();
    public static Food food = null;

    public static void Main()
    {
        ReadInputLines(Console.ReadLine());
    }

    private static void ReadInputLines(string input)
    {
        if (input.ToLower() == "end")
        {
            PrintAnimals();
            return;
        }

        var parameters = input.SplitBy(" ");

        if (count % 2 == 0)
        {
            GetCurrentAnimal(parameters);
        }
        else
        {
            FeedCurrentAnimal(parameters);
        }

        count++;

        ReadInputLines(Console.ReadLine());
    }

    private static void PrintAnimals()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.ToString());
        }
    }

    private static void GetCurrentAnimal(string[] parameters)
    {
        animal = FarmFactory.CreateAnimal(parameters);
        Console.WriteLine(animal.SoundProduced);
    }

    private static void FeedCurrentAnimal(string[] parameters)
    {
        food = FarmFactory.CreateFood(parameters);
        animal.Eat(food);
        animals.Add(animal);
    }
}
