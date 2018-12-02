using System;
using System.Collections.Generic;

public class ParkingLot
{
    static SortedSet<string> parkingLot = new SortedSet<string>();

    public static void Main()
    {
        ReadNextInputLinesFrom(Console.ReadLine());

        if (parkingLot.Count == 0)
        {
            Console.WriteLine("Parking Lot is Empty"); return;
        }

        foreach (var carNumber in parkingLot)
        {
            Console.WriteLine(carNumber);
        }
    }

    public static void ReadNextInputLinesFrom(string input)
    {
        if (input != "END")
        {
            DivideAndRuleCurrent(input);
            ReadNextInputLinesFrom(Console.ReadLine());
        }
    }

    public static void DivideAndRuleCurrent(string input)
    {
        var splited = input.Split(new[] { ",", " "}, StringSplitOptions.RemoveEmptyEntries);

        var direction = splited[0];
        var carNumber = splited[1];

        if (direction == "IN")
        {
            parkingLot.Add(carNumber);
        }
        else if (parkingLot.Contains(carNumber))
        {
            parkingLot.Remove(carNumber);
        }
    }
}
