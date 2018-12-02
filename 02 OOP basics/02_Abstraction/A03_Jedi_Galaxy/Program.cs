using System;

public class Program
{
    public static long sumStarsValues;

    public static Galaxy galaxy;

    public static void Main()
    {
        galaxy = new Galaxy(Console.ReadLine().SplitBy(" "));

        var position = string.Empty;

        while ((position = Console.ReadLine()) != "Let the Force be with you")
        {
            var hero = new AvatarPoint(position.SplitBy(" "));
            var evil = new AvatarPoint(Console.ReadLine().SplitBy(" "));

            while (evil.Col >= 0 && evil.Row >= 0)
            {
                if (IsValidPositionInThisGalaxy(evil))
                {
                    galaxy.SetAtPosition(evil.Row, evil.Col, 0);
                }

                evil.Next(-1, -1);
            }

            while (hero.Col < galaxy.Dimensions.Col && hero.Row >= 0)
            {
                if (IsValidPositionInThisGalaxy(hero))
                {
                    sumStarsValues += galaxy.GetValue(hero.Row, hero.Col);
                }
                hero.Next(-1, 1);
            }
        }

        Console.WriteLine(sumStarsValues);
    }

    private static bool IsValidEvilPosition(AvatarPoint evil)
    {
        var col = evil.Col;
        var row = evil.Row;

        return col >= 0 && col < galaxy.Dimensions.Col * 2 - 2 && row >= 0 && row < galaxy.Dimensions.Row * 2 - 2;
    }

    private static bool IsValidHeroPosition(AvatarPoint hero)
    {
        var col = hero.Col;
        var row = hero.Row;

        return col > galaxy.Dimensions.Col * - 1 + 1 && col < galaxy.Dimensions.Col
            && row >= 0 && row < galaxy.Dimensions.Row * 2 - 2;
    }

    private static bool IsValidPositionInThisGalaxy(AvatarPoint avatar)
    {
        var col = avatar.Col;
        var row = avatar.Row;

        return col >= 0 && col < galaxy.Dimensions.Col && row >= 0 && row < galaxy.Dimensions.Row;
    }
}
