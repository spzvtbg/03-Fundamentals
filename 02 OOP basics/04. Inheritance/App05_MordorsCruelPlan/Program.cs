using System;

public class Program
{
    public static void Main(string[] args)
    {
        var collection = Console.ReadLine().Split();
        var pointsOfHapyness = 0;

        foreach (var item in collection)
        {
            pointsOfHapyness += FoodFactory.GetFood(item.ToLower());
        }

        Console.WriteLine(pointsOfHapyness);
        Console.WriteLine(MoodFactory.GetMode(pointsOfHapyness));
    }
}
