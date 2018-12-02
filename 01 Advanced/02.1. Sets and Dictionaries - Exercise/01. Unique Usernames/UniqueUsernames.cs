using System;
using System.Collections.Generic;

public class UniqueUsernames
{
    static HashSet<string> users = new HashSet<string>();

    public static void Main(string[] args)
    {
        HowMenyInputsFrom(Console.ReadLine());
        PrintAllUniqueUsers();
    }

    public static void HowMenyInputsFrom(string numberOfInputs)
    {
        var iterations = Convert.ToInt32(numberOfInputs);

        for (int count = 0; count < iterations; count++)
        {
            var line = Console.ReadLine();
            users.Add(line);
        }
    }

    public static void PrintAllUniqueUsers()
    {
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }
}
