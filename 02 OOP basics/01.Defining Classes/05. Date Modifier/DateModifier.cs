using System;

public static class DateModifier
{
    public static int GetDiference(string firstDate, string secondDate)
    {
        DateTime first;
        DateTime second;

        if (!DateTime.TryParse(firstDate, out first))
        {

        }

        if (!DateTime.TryParse(secondDate, out second))
        {
            
        }

        TimeSpan diference = first - second;
        return Math.Abs(diference.Days);
    }
}
