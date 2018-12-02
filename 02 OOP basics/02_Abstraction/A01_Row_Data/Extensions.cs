using System;
using System.Collections.Generic;

public static class Extensions
{
    public static string[] SplitBy(this string value, params string[] parameters)
    {
        return value.Split(parameters, System.StringSplitOptions.RemoveEmptyEntries);
    }
}
