using System;

public class Program
{
    public static void Main()
    {
        try
        {
            var person = new Child(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Console.WriteLine(person.ToString());
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}
