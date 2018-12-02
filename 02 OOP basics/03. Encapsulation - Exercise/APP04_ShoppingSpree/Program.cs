using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var shop = default(Shop);

        try
        {
           shop = new Shop(Console.ReadLine().SplitBy(";"), Console.ReadLine().SplitBy(";"));
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
            return;
        }
        
        ShopingTime(shop);

        shop.ShowData();
    }

    private static void ShopingTime(Shop shop)
    {
        var value = string.Empty;

        while ((value = Console.ReadLine()).ToUpper() != "END")
        {
            var data = value.SplitBy(" ");

            var person = shop.Persons.FirstOrDefault(x => x.Name == data[0]);
            var product = shop.Products.FirstOrDefault(x => x.Name == data[1]);

            if (person != null && product != null)
            {
                person.AddProduct(product);
            }
        }
    }
}
