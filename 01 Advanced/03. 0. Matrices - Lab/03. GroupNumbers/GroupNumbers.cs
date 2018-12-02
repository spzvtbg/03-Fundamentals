using System;

public class GroupNumbers
{
    static int row;

    static int[] integers;
    static int[][] matrix = new int[3][];

    static string[] splited;

    public static void Main()
    {
        //var watch = System.Diagnostics.Stopwatch.StartNew();

        ReadSequenceOfIntegers(Console.ReadLine());
        InitializeMatrix();
        DivideAndRule();
        PrintMatrix();

        //watch.Stop();
        //Console.WriteLine($"\n{watch.ElapsedTicks}");
    }

    public static void InitializeMatrix()
    {
        for (int count = 0; count < 3; count++)
        {
            matrix[count] = new int[0];
        }
    }

    public static void ReadSequenceOfIntegers(string integersAsString)
    {
        var pattern = new[] { ", ", " " };
        splited = integersAsString.Split(pattern, StringSplitOptions.RemoveEmptyEntries);
        ConvertToIntArray(); 
    }

    public static void ConvertToIntArray()
    {
        integers = new int[splited.Length];
        for (int index = 0; index < splited.Length; index++)
        {
            integers[index] = Convert.ToInt32(splited[index]);
        }
    }

    public static void DivideAndRule()
    {
        foreach (var number in integers)
        {
            if (Math.Abs(number % 3) == 0)
            {
                row = 0;
                AddToGivenRow(row, number);
            }
            if (Math.Abs(number % 3) == 1)
            {
                row = 1;
                AddToGivenRow(row, number);
            }
            if (Math.Abs(number % 3) == 2)
            {
                row = 2;
                AddToGivenRow(row, number);
            }
        }
    }

    public static void AddToGivenRow(int row, int number)
    {
        var tempRow = matrix[row];
        matrix[row] = new int[matrix[row].Length + 1];
        MakeNewArrayRow(row, number, tempRow);
    }

    public static void MakeNewArrayRow(int row, int number, int[] tempRow)
    {
        for (int index = 0; index < tempRow.Length; index++)
        {
            matrix[row][index] = tempRow[index];
        }
        matrix[row][matrix[row].Length - 1] = number;
    }

    public static void PrintMatrix()
    {
        foreach (var array in matrix)
        {
            foreach (var number in array)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
