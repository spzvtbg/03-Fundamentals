public static class MoodFactory
{
    public static string GetMode(int points)
    {
        if (points < -5)
        {
            return "Angry";
        }
        else if (points < 1)
        {
            return "Sad";
        }
        else if (points < 16)
        {
            return "Happy";
        }
        else 
        {
            return "JavaScript";
        }
    }
}
