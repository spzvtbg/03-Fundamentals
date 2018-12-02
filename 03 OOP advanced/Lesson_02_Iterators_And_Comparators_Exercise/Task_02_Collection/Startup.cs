using System;
using System.Linq;

public class Startup
{
    private static string input;
    private static ListyIterator<string> listyIterator;
    private static ConsoleColor color = Console.ForegroundColor;

    public static void Main()
    {
        Create(Console.ReadLine());

        while ((input = Console.ReadLine()) != "END")
        {
            try
            {
                if (input == "Move")
                {
                    ResultFromMoveComand();
                }
                else if (input == "HasNext")
                {
                    ResultFromHasNextCommand();
                }
                else if (input == "Print")
                {
                    ResultFromPrintCommand();
                }
                else if (input == "PrintAll")
                {
                    ResultFromPrintAllCommand();
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = color;
            }
        }
    }

    private static void ResultFromPrintAllCommand()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        listyIterator.PrintAll();
        Console.ForegroundColor = color;
    }

    private static void ResultFromPrintCommand()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        listyIterator.Print();
        Console.ForegroundColor = color;
    }

    private static void ResultFromHasNextCommand()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(listyIterator.HasNext());
        Console.ForegroundColor = color;
    }

    private static void ResultFromMoveComand()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(listyIterator.Move());
        Console.ForegroundColor = color;
    }

    private static void Create(string value)
    {
        var collection = value.Split().Skip(1).ToArray();
        listyIterator = new ListyIterator<string>(collection);
    }
}
