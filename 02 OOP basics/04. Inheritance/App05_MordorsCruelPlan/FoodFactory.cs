public static class FoodFactory
{
    public static int GetFood(string value)
    {
        if (value == "cram")
        {
            return 2;
        }
        else if (value == "lembas")
        {
            return 3;
        }
        else if (value == "apple" || value == "melon")
        {
            return 1;
        }
        else if (value == "honeycake")
        {
            return 5;
        }
        else if (value == "mushrooms")
        {
            return -10;
        }
        else
        {
            return -1;
        }
    }
}
