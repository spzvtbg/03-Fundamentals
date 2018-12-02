public static class ExceptionMessages
{
    public static string InvalidName(string name)
    {
        return $"Expected upper case letter! Argument: {name}";
    }

    public static string InvalidName(int length, string name)
    {
        return $"Expected length at least {length} symbols! Argument: {name}";
    }

    public static string InvalidValue(string name)
    {
        return $"Expected value mismatch! Argument: {name}";
    }
}
