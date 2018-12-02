using System;

public class PascalTriangle
{
    static int row;
    static int number;

    static long[][] pascalPiramid;

    public static void Main()
    {
        number = Convert.ToInt32(Console.ReadLine());

        InizializePascalPiramid();
        MakeAllRows();
        PrintResult();
    }

    public static void InizializePascalPiramid()
    {
        pascalPiramid = new long[number][];
        for (long index = 1; index <= number; index++)
        {
            pascalPiramid[index - 1] = new long[index];
        }
    }

    public static void MakeAllRows()
    {
        pascalPiramid[0][0] = 1;
        for (row = 1; row < number; row++)
        {
            pascalPiramid[row][0] = 1;

            TakeSumAllTowElements();

            pascalPiramid[row][pascalPiramid[row].Length - 1] = 1;
        }
    }

    public static void TakeSumAllTowElements()
    {
        for (int index = 1; index < pascalPiramid[row - 1].Length; index++)
        {
            pascalPiramid[row][index] = pascalPiramid[row - 1][index - 1]
                 + pascalPiramid[row - 1][index];
        }
    }

    public static void PrintResult()
    {
        foreach (var row in pascalPiramid)
        {
            foreach (var number in row)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
