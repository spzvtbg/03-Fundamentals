using System;

public class SumOfAllElementsOfMatrix
{
    static int rows;
    static int cols;
    static int count;
    static int sumOfAllElements;

    static string[] splited;
    static int[,] matrix;

    public static void Main()
    {
        ReadMatrixSize(Console.ReadLine());
        for (count = 0; count < rows; count++)
        {
            ReadAllElements(Console.ReadLine());
        }
        PrintMatrixParameters();
    }

    public static void ReadMatrixSize(string size)
    {
        splited = size.Split(new[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries);
        rows = Convert.ToInt32(splited[0]);
        cols = Convert.ToInt32(splited[1]);
        matrix = new int[rows, cols];
    }

    public static void ReadAllElements(string elsements)
    {
        DivideAndRule(elsements);
        AddGivenElementsToMatrix();
    }

    public static void DivideAndRule(string elsements)
    {
        splited = elsements.Split(new[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries);
    }

    public static void AddGivenElementsToMatrix()
    {
        for (int index = 0; index < splited.Length; index++)
        {
            var currentElement = Convert.ToInt32(splited[index]);
            matrix[count, index] = currentElement;
            sumOfAllElements += currentElement;
        }
    }

    public static void PrintMatrixParameters()
    {
        Console.WriteLine(rows);
        Console.WriteLine(cols);
        Console.WriteLine(sumOfAllElements);
    }
}
