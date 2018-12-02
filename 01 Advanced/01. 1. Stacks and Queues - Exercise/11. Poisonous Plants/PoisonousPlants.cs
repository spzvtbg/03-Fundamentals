using System;
using System.Collections.Generic;
using System.Linq;

public class PoisonousPlants
{
    public static void Main()
    {
        var plantsQuantity = Convert.ToInt32(Console.ReadLine());
        var plantsAsString = Console.ReadLine().Split(' ');
        var plantsPesticide = ConvertToIntegers(plantsAsString);

        var daysInWitchPlantsDies = new int[plantsQuantity];
        var previousPlants = new Stack<int>();
        previousPlants.Push(0);

        for (int x = 1; x < plantsQuantity; x++)
        {
            var lastDay = 0;
            while (IsValid(x, previousPlants, plantsPesticide))
            {
                lastDay = Math.Max(lastDay, daysInWitchPlantsDies[previousPlants.Pop()]);
            }

            if (previousPlants.Count() > 0)
            {
                daysInWitchPlantsDies[x] = lastDay + 1;
            }
            previousPlants.Push(x);
        }
        Console.WriteLine(daysInWitchPlantsDies.Max());
    }

    public static bool IsValid(int x, Stack<int> previousPlants, int[] plantsPesticide)
    {
        return previousPlants.Count() > 0 && plantsPesticide[previousPlants.Peek()] >= plantsPesticide[x];
    }

    public static int[] ConvertToIntegers(string[] plantsAsString)
    {
        var temporaryArray = new int[plantsAsString.Length];
        for (int index = 0; index < plantsAsString.Length; index++)
        {
            temporaryArray[index] = Convert.ToInt32(plantsAsString[index]);
        }
        return temporaryArray;
    }
}
