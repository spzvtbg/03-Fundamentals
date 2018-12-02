using System;
using System.Collections.Generic;
using System.Linq;

public class UserLogs
{
    static string IP;
    static string message;
    static string userName;
    static string[] splited;

    static Dictionary<string, Dictionary<string, List<string>>> userData =
        new Dictionary<string, Dictionary<string, List<string>>>();

    public static void Main(string[] args)
    {
        ReadData(Console.ReadLine());
        PrintUserDataStatistic();
    }

    public static void PrintUserDataStatistic()
    {
        foreach (var user in userData.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{user.Key}: ");

            var count = user.Value.Count;
            foreach (var ip in user.Value)
            {
                count--;
                if (count > 0)
                {
                    Console.Write($"{ip.Key} => {ip.Value.Count}, ");
                }
                else
                {
                    Console.WriteLine($"{ip.Key} => {ip.Value.Count}.");
                }
            }
        }
    }

    public static void ReadData(string input)
    {
        if (input != "end")
        {
            Split(input);
            ReadData(Console.ReadLine());
        }
    }

    public static void Split(string input)
    {
        var pattern = new[] { "IP=", "message=", "user=", " " };
        splited = input.Split(pattern, StringSplitOptions.RemoveEmptyEntries);

        IP = splited[0];
        message = splited[1];
        userName = splited[2];

        DivideAndRule();
    }

    public static void DivideAndRule()
    {
        if (!userData.ContainsKey(userName))
        {
            userData[userName] = new Dictionary<string, List<string>>();
        }
        if (!userData[userName].ContainsKey(IP))
        {
            userData[userName][IP] = new List<string>();
        }
        userData[userName][IP].Add(message);
    }
}
