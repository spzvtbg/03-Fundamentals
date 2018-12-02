using System;
using System.Collections.Generic;

public class Program
{
    static string IP;
    static string user;

    static int lines;
    static long duration;

    static Dictionary<string, SortedSet<string>> userIPs = new Dictionary<string, SortedSet<string>>();
    static SortedDictionary<string, long> userDuration = new SortedDictionary<string, long>();

    public static void Main()
    {
        lines = Convert.ToInt32(Console.ReadLine());
        ReadData(Console.ReadLine());
        PrintUserInfo();
    }

    public static void ReadData(string data)
    {
        lines--;
        if (lines >= 0)
        {
            Divide(data);
            Rule();
            ReadData(Console.ReadLine());
        }
        else return;
    }

    public static void Divide(string data)
    {
        var splited = data.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        IP = splited[0];
        user = splited[1];
        duration = Convert.ToInt64(splited[2]);
    }

    private static void Rule()
    {
        if (!userIPs.ContainsKey(user))
        {
            userIPs[user] = new SortedSet<string>();
        }
        userIPs[user].Add(IP);

        if (!userDuration.ContainsKey(user))
        {
            userDuration[user] = 0L;
        }
        userDuration[user] += duration;
    }

    public static void PrintUserInfo()
    {
        foreach (var user in userDuration)
        {
            Console.WriteLine($"{user.Key}: {user.Value} [{string.Join(", ", userIPs[user.Key])}]");
        }
    }
}
