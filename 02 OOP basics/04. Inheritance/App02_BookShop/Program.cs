using System;

public class Program
{
    public static void Main()
    {
        try
        {
            var author = Console.ReadLine();
            var titel = Console.ReadLine();
            var price = decimal.Parse(Console.ReadLine());

            var normalBook = new Book(author, titel, price);
            var editionBook = new GoldenEditionBook(author, titel, price);

            Console.WriteLine(normalBook);
            Console.WriteLine();
            Console.WriteLine(editionBook);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}
