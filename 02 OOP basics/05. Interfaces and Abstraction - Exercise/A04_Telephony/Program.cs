using System;

public class Program
{
    public static void Main()
    {
        var phone = new Smartphone(SplitedInput(" "), SplitedInput(" "));
        phone.Show();
    }

    public static string[] SplitedInput(params string[] parameters)
    {
        return Console.ReadLine().Split(parameters, StringSplitOptions.None);
    }
}
