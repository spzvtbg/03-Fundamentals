using System;
using System.Text;
using System.Collections.Generic;

public class SimpleTextEditor
{
    static StringBuilder someText = new StringBuilder();
    static Stack<string> lastStandString = new Stack<string>();

    static int countdown;
    static string[] splited;

    public static void Main()
    {
        lastStandString.Push("");
        countdown = Convert.ToInt32(Console.ReadLine());
        ReadUntillCountdownEndFrom(Console.ReadLine());
    }

    public static void ReadUntillCountdownEndFrom(string command)
    {
        for (int count = 0; count < countdown; count++)
        {
            SplitCurrent(command);
            DivideAndRuleBy(command);
            command = Console.ReadLine();
        }
    }

    public static void SplitCurrent(string command)
    {
        splited = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }

    public static void DivideAndRuleBy(string command)
    {
        if (command.StartsWith("1"))
        {
            ApendGivenString();
        }
        else if (command.StartsWith("2"))
        {
            RemoveLastCountElements();
        }
        else if (command.StartsWith("3"))
        {
            PrintElementAt();
        }
        else if (command.StartsWith("4"))
        {
            ReturnLastStand();            
        }
    }

    public static void ApendGivenString()
    {
        someText.Append(splited[1]);
        lastStandString.Push(someText.ToString());
    }

    public static void RemoveLastCountElements()
    {
        var lastStand = someText.ToString();
        someText.Clear();

        var countElements = Convert.ToInt32(splited[1]);
        for (int index = 0; index < lastStand.Length - countElements; index++)
        {
            someText.Append(lastStand[index]);
        }
        lastStandString.Push(someText.ToString());
    }

    public static void PrintElementAt()
    {
        var index = Convert.ToInt32(splited[1]) - 1;
        Console.WriteLine(someText[index]);
    }

    private static void ReturnLastStand()
    {
        lastStandString.Pop();
        someText.Clear();
        someText.Append(lastStandString.Peek());
    }
}
