using System;
using System.Text;

public class SquareWithMaximumSum
{
    static int rows;
    static int cols;
    static int count;
    static int tempSum;
    static int sumSquare = int.MinValue;
           
    static int[,] matrix;

    static StringBuilder square = new StringBuilder();
    static string[] splited;

    public static void Main()
    {
        //var watch = System.Diagnostics.Stopwatch.StartNew();
        ReadMatrixSize(Console.ReadLine());

        for (count = 0; count < rows; count++)
        {
            ReadAllElements(Console.ReadLine());
        }

        FindSquareWithMaxSum();

        PrintMaxSquareSum();
        //watch.Stop();
        //Console.WriteLine();
        //Console.WriteLine(watch.ElapsedTicks);
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
            matrix[count, index] = Convert.ToInt32(splited[index]);
        }
    }

    public static void FindSquareWithMaxSum()
    {
        for (count = 0; count < rows - 1; count++)
        {
            SumElements();
        }
    }

    public static void SumElements()
    {
        for (int index = 0; index < cols - 1; index++)
        {
            tempSum = 0;
            tempSum += matrix[count, index] + matrix[count, index + 1];
            tempSum += matrix[count + 1, index] + matrix[count + 1, index + 1];
            SumSquareEquals(index);
        }
    }

    public static void SumSquareEquals(int index)
    {
        if (tempSum > sumSquare)
        {
            sumSquare = tempSum;
            square.Clear();
            square.Append($"{matrix[count, index]} {matrix[count, index + 1]}\n");
            square.Append($"{matrix[count + 1, index]} {matrix[count + 1, index + 1]}");
        }
    }

    public static void PrintMaxSquareSum()
    {
        Console.WriteLine(square);
        Console.WriteLine(sumSquare);
    }
}
