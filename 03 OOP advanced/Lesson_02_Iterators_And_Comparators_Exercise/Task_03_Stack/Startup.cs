using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    private static string input;
    private static Stack<string> stack = new Stack<string>();

    public static void Main()
    {
        while ((input = Console.ReadLine()) != "END")
        {
            var commandLine = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = commandLine[0];

            try
            {
                if (command == "Push")
                {
                    ExecutePushCommand(commandLine.Skip(1));
                }
                else if (command == "Pop")
                {
                    ExecutePopCommand();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        PrintResult();
    }

    private static void PrintResult()
    {
        IterateOverStack();
        IterateOverStack();
    }

    private static void IterateOverStack()
    {
        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }
    }

    private static void ExecutePopCommand()
    {
        stack.Pop();
    }

    private static void ExecutePushCommand(IEnumerable<string> enumerable)
    {
        foreach (var element in enumerable)
        {
            stack.Push(element.Trim(','));
        }
    }
}
