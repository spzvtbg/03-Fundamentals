using System;

public class Program
{
    public static void Main()
    {
        try
        {
            var pizza = new Pizza(Console.ReadLine().SplitBy(" "));
            pizza.SetDough(new Dough(Console.ReadLine().SplitBy(" ")));

            var input = string.Empty;
            while ((input = Console.ReadLine()).ToUpper() != "END")
            {
                pizza.AddToping(new Toping(input.SplitBy(" ")));
            }

            Console.WriteLine(pizza.ToString());
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}
