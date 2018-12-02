using System;
using System.Collections.Generic;

public class HotPotato
{
    static Queue<string> standingPlayers = new Queue<string>();

    static int countInCircleTo;

    public static void Main()
    {
        var playersNames = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        countInCircleTo = Convert.ToInt32(Console.ReadLine());

        EnqueueAll(playersNames);
        StartTheGameAndPrintResult();

        Console.WriteLine($"Last is {standingPlayers.Dequeue()}");
    }

    static void EnqueueAll(string[] playersNames)
    {
        foreach (var name in playersNames)
        {
            standingPlayers.Enqueue(name);
        }
    }

    static void StartTheGameAndPrintResult()
    {
        while (standingPlayers.Count > 1)
        {
            for (int i = 0; i < countInCircleTo - 1; i++)
            {
                var playerOut = standingPlayers.Dequeue();
                standingPlayers.Enqueue(playerOut);
            }
            Console.WriteLine($"Removed {standingPlayers.Dequeue()}");
        }
    }
}
