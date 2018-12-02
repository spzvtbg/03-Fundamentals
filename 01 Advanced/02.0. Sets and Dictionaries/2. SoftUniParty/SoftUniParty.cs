using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniParty
{
    static SortedSet<string> partyList = new SortedSet<string>();

    public static void Main()
    {
        ReadNextInputLinesFrom(Console.ReadLine());
        RemoveAllCommendeGueste(Console.ReadLine());

        PrintHwoDidNotComm();
    }

    public static void ReadNextInputLinesFrom(string input)
    {
        if (input != "PARTY")
        {
            partyList.Add(input);
            ReadNextInputLinesFrom(Console.ReadLine());
        }
    }

    public static void RemoveAllCommendeGueste(string input)
    {
        if (input != "END")
        {
            if (partyList.Contains(input))
            {
                partyList.Remove(input);
                RemoveAllCommendeGueste(Console.ReadLine());
            }
        }
    }

    public static void PrintHwoDidNotComm()
    {
        Console.WriteLine(partyList.Count());
        foreach (var guest in partyList)
        {
            Console.WriteLine(guest);
        }
    }
}
