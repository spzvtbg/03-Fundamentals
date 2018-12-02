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

    public static string Equal<T>(this object value, object toCompare)
    {
        var defaultValue = "n/a";

        if (value == toCompare)
        {
            return defaultValue;
        }

        return ((T)value).ToString();
    }
}
