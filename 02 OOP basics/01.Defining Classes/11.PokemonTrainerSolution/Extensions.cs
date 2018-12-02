using System;

public static class Extensions
{
    public static string[] SplitWithStringSplitOptions(this string value, params string[] spliters)
    {
        return value.Split(spliters, StringSplitOptions.RemoveEmptyEntries);
    }
}
