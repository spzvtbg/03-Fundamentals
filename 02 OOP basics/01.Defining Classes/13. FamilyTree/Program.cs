using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static string input;
    public static string parent;
    public static string child;
    public static string name;
    public static string birthday;

    public static Person person;
    public static List<Person> members = new List<Person>();

    public static void Main()
    {
        input = Console.ReadLine();
        person = new Person(input);
        members.Add(person);
        CreateFamilyTree();
        GetMembers();
        PrintInfo(person);
    }

    public static void GetMembers()
    {
        person = members.FirstOrDefault(x => x.Name == person.Name || x.Birthday == person.Birthday);

        person.Parents.AddRange(members
            .Where(x => x.Children.Count > 0 && (
                        x.Children.FirstOrDefault().Name == person.Name || 
                        x.Children.FirstOrDefault().Birthday == person.Birthday))
            .ToList());

        person.Children.AddRange(members.Where(x => x.Name == person.Name || x.Birthday == person.Birthday).ToList());
    }

    public static void CreateFamilyTree()
    {
        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            if (input.Contains("-"))
            {
                WriteToFamily(input.SplitWithStringSplitOptions(" "));
            }
            else
            {
                UpdateMember(input.SplitWithStringSplitOptions(" "));
            }
        }
    }

    public static void WriteToFamily(string[] parameters)
    {
        if (parameters[0].Contains("/"))
        {
            parent = parameters[0];

            if (parameters.Length == 3)
            {
                child = parameters[2];
            }
            else
            {
                child = $"{parameters[2]} {parameters[3]}";
            }
        }
        else
        {
            parent = $"{parameters[0]} {parameters[1]}";

            if (parameters.Length == 4)
            {
                child = parameters[3];
            }
            else
            {
                child = $"{parameters[3]} {parameters[4]}";
            }
        }

        var member = new Person(parent);
        member.Children.Add(new Person(child));
        members.Add(member);
    }

    public static void UpdateMember(string[] parameters)
    {
        name = $"{parameters[0]} {parameters[1]}";
        birthday = parameters[2];

        foreach (var member in members)
        {
            var temporary = member.GetMember(name);
            if (temporary == null)
            {
                temporary = member.GetMember(birthday);

                if (temporary == null)
                {
                    continue;
                }
            }

            if (temporary != null)
            {
                temporary.Name = name;
                temporary.Birthday = birthday;
                return;
            }
        }
    }

    public static void PrintInfo(Person person)
    {
        Console.WriteLine($"{person.Name} {person.Birthday}");

        Console.WriteLine("Parents:");
        foreach (var parent in person.Parents)
        {
            Console.WriteLine($"{parent.Name} {parent.Birthday}");
        }

        Console.WriteLine("Children:");
        foreach (var child in person.Children)
        {
            Console.WriteLine($"{child.Name} {child.Birthday}");
        }
    }
}
