using System;
using System.Collections.Generic;

public class FixEmails
{
    static Dictionary<string, string> emails = new Dictionary<string, string>();

    public static void Main()
    {
        ReadData(Console.ReadLine());
        PrintResources();
    }

    public static void PrintResources()
    {
        foreach (var item in emails)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }

    public static void ReadData(string input)
    {
        if (input != "stop")
        {
            var email = Console.ReadLine();
            if (IsValid(email))
            {
                if (!emails.ContainsKey(input))
                {
                    emails[input] = string.Empty;
                }
                emails[input] = email;
            }

            ReadData(Console.ReadLine());
        }
    }

    private static bool IsValid(string email)
    {
        if (email.EndsWith(".us"))
        {
            return false;
        }
        if (email.EndsWith(".uk"))
        {
            return false;
        }
        else return true;
    }
}
