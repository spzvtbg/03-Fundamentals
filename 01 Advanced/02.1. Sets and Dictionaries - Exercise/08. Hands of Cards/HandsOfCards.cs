using System;
using System.Collections.Generic;

public class HandsOfCards
{
    static string name;
    static string[] splited;

    static Dictionary<string, HashSet<Tuple<string, string>>> score = 
        new Dictionary<string, HashSet<Tuple<string, string>>>();

    static Dictionary<string, int> colode = new Dictionary<string, int>() {
        { "2", 2 },
        { "3", 3 },
        { "4", 4 },
        { "5", 5 },
        { "6", 6 },
        { "7", 7 },
        { "8", 8 },
        { "9", 9 },
        { "10", 10 },
        { "J", 11 },
        { "Q", 12 },
        { "K", 13 },
        { "A", 14 },
        { "C", 1 },
        { "D", 2 },
        { "H", 3 },
        { "S", 4 },
    };

    public static void Main()
    {
        ReadData(Console.ReadLine());
        PrintResult();
    }

    public static void ReadData(string input)
    {
        if (input != "JOKER")
        {
            DivideAndRule(input);
            ReadData(Console.ReadLine());
        }
    }

    public static void DivideAndRule(string input)
    {
        Split(input);
        AddOrUpdate();
    }

    public static void Split(string input)
    {
        splited = input.Split(new[] { ":", }, StringSplitOptions.RemoveEmptyEntries);
        name = splited[0];
        var cards = splited[1].Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
        splited = new string[cards.Length];
        splited = cards;
    }

    public static void AddOrUpdate()
    {
        if (!score.ContainsKey(name))
        {
            score[name] = new HashSet<Tuple<string, string>>();
        }
        AddRange();
    }

    public static void AddRange()
    {
        for (int count = 0; count < splited.Length; count++)
        {
            var last = splited[count].Length - 1;
            if (IsValidCard(splited[count]))
            {
                var rightSide = splited[count][last].ToString();
                var leftSide = string.Empty;
                if (splited[count].StartsWith("10"))
                {
                    leftSide = "10";
                }
                else leftSide = splited[count][0].ToString();
                score[name].Add(new Tuple<string, string>(leftSide, rightSide));
            }
        }
    }

    public static bool IsValidCard(string x)
    {
        var last = x.Length - 1;
        return ((x[0] >= '0' && x[0] <= '9') ||
            (x.StartsWith("10") || x[0] == 'J' || x[0] == 'Q' || x[0] == 'K' || x[0] == 'A')) &&
            (x[last] == 'S' || x[last] == 'H' || x[last] == 'D' || x[last] == 'C');
    }

    public static void PrintResult()
    {
        foreach (var player in score)
        {
            var sum = 0;
            foreach (var item in player.Value)
            {
                sum += colode[item.Item1] * colode[item.Item2];
            }
            Console.WriteLine($"{player.Key}: {sum}");
        }
    }
}
