using System;
using System.Collections.Generic;
using System.Linq;

public static class MyDictionary
{
    private static bool IsInitialized = false;

    public static Dictionary<char, int> Symbols;

    public static void InitializeData()
    {
        if (!IsInitialized)
        {
            IsInitialized = true;
            Symbols = new Dictionary<char, int>();
            ReadData();
        }
    }

    public static void ReadData()
    {
        var sentence = Console.ReadLine();
        SetData(sentence);
    }

    public static void SetData(string sentence)
    {
        foreach (var item in sentence)
        {
            if (!Symbols.ContainsKey(item))
            {
                Symbols[item] = 0;
            }
            Symbols[item]++;
        }
    }
}

public static class Result
{
    public static void Print(Dictionary<char, int> symbols)
    {
        foreach (var item in symbols.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value} time/s");
        }
    }
}

public class CountSymbols
{
    public static void Main()
    {
        MyDictionary.InitializeData();
        Result.Print(MyDictionary.Symbols);
    }
}
