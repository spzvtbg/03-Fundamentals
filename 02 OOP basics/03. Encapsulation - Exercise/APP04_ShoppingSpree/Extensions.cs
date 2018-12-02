using System;

public static class Extensions
{
    public static string[] SplitBy(this string value, params string[] spliters)
    {
        return value.Split(spliters, StringSplitOptions.RemoveEmptyEntries);
    }
}
