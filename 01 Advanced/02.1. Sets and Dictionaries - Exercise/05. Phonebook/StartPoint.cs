using System;
using System.Collections.Generic;

public class StartPoint
{
    public static void Main()
    {
        Phonebook.InitializeData();
        Phonebook.SearchData(Console.ReadLine());
    }
}

public static class Phonebook
{
    private static bool isInitialized = false;

    private static string name;
    private static string number;

    public static Dictionary<string, string> MyPhonebook;

    public static void InitializeData()
    {
        if (!isInitialized)
        {
            isInitialized = true;
            MyPhonebook = new Dictionary<string, string>();
        }
        ReadData(Console.ReadLine());
    }

    public static void ReadData(string input)
    {
        if (input != "search")
        {
            DivideAndRule(input);
            ReadData(Console.ReadLine());
        }
    }

    public static void DivideAndRule(string input)
    {
        var splited = input.Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

        name = splited[0];
        number = splited[1];

        AddOrUpdate();
    }

    public static void AddOrUpdate()
    {
        if (!IsTrue.HasName(name))
        {
            MyPhonebook[name] = string.Empty;
        }
        MyPhonebook[name] = number;
    }

    public static void SearchData(string input)
    {
        if (input != "stop")
        {
            PrintMessage(input);
            SearchData(Console.ReadLine());
        }
    }

    private static void PrintMessage(string input)
    {
        if (IsTrue.HasName(input))
        {
            OutputWriter.PrintNumber(input, MyPhonebook[input]);
        }
        else OutputWriter.ContactDontExist(input);
    }
}

public static class IsTrue
{
    public static bool HasName(string name)
    {
        if (Phonebook.MyPhonebook.ContainsKey(name))
        {
            return true;
        }
        else return false;
    }
}

public static class OutputWriter
{
    public static void ContactDontExist(string name)
    {
        Console.WriteLine($"Contact {name} does not exist.");
    }

    public static void PrintNumber(string name, string number)
    {
        Console.WriteLine($"{name} -> {number}");
    }
}
