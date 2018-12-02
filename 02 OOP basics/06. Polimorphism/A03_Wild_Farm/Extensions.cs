using System;

public static class Extensions
{
    public static string[] SplitBy(this string input, params string[] parameters)
    {
        return input.Split(parameters, StringSplitOptions.RemoveEmptyEntries);
    }
}