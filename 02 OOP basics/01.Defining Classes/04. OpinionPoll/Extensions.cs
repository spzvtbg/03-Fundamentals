using System;

public static class Extensions
{
    public static string[] SplitBy(this string value, bool useStringSplitOptions, params string[] spliters)
    {
        if (!useStringSplitOptions)
        {
            return value.Split(spliters, StringSplitOptions.None);
        }

        return value.Split(spliters, StringSplitOptions.RemoveEmptyEntries);
    }
}
