using System;

public static class Extensions
{
    public static string[] SplitBy(this string value, bool useOptions, params string[] spliters)
    {
        if (!useOptions)
        {
            return value.Split(spliters, StringSplitOptions.None);
        }

        return value.Split(spliters, StringSplitOptions.RemoveEmptyEntries);
    }
}
