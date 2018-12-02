namespace P01_HarvestingFields
{
    using System;

    public static class OutputManager
    {
        public static void Print(string[] values, ConsoleColor color)
        {
            var forgroundColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(String.Join(Environment.NewLine, values));
            Console.ForegroundColor = forgroundColor;
        }
    }
}
