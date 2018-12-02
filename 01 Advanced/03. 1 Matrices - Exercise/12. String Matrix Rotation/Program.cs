using System;

public class Program
{
    private static int rotationMode;
    private static int maxRowLength;
    private static int rows = 4;
    private static int cols = 8;
    private static int index;

    private static char[,] matrix;

    public static void Main()
    {
        maxRowLength = cols;
        matrix = new char[rows, cols];
        ParseRotationMode(Console.ReadLine());
        ReadNextLine(Console.ReadLine());
    }

    private static void ParseRotationMode(string value)
    {
        int startIndex = value.IndexOf("(") + 1;
        int endIndex = value.IndexOf(")");
        int length = (endIndex - startIndex);

        string modeValueAsString = value.Substring(startIndex, length);
        rotationMode = Convert.ToInt32(modeValueAsString);
    }

    private static void ReadNextLine(string value)
    {
        if (value == "END")
        {
            Resize(index, maxRowLength);
            Print();
            return;
        }

        if (maxRowLength < value.Length)
        {
            maxRowLength = value.Length;
        }

        if (maxRowLength > cols)
        {
            Resize(rows, maxRowLength * 2);
            cols = maxRowLength * 2;
        }

        if (index >= matrix.GetLength(0))
        {
            Resize(rows *= 2, cols);
        }

        AddCurrentRow(value);
        index++;

        ReadNextLine(Console.ReadLine());
    }

    private static void Resize(int tRows, int tCols)
    {
        char[,] temporary = new char[tRows, tCols];

        for (int r = 0; r < temporary.GetLength(0); r++)
        {
            for (int c = 0; c < temporary.GetLength(1); c++)
            {
                if (r < matrix.GetLength(0) && c < matrix.GetLength(1))
                {
                    temporary[r, c] = matrix[r, c];
                }
                else
                {
                    temporary[r, c] = ' ';
                }
            }
        }

        matrix = temporary;
    }

    private static void AddCurrentRow(string value)
    {
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            if (c < value.Length)
            {
                matrix[index, c] = value[c];
            }
            else
            {
                matrix[index, c] = ' ';
            }
        }
    }

    private static void Print()
    {
        int rotation = rotationMode % 360;

        if (rotation == 90)
        {
            PrintWith90Rotation();
        }
        else if(rotation == 180)
        {
            PrintWith180Rotation();
        }
        else if (rotation == 270)
        {
            PrintWith270Rotation();
        }
        else
        {
            PrintWithoutRotation();
        }
    }

    private static void PrintWith90Rotation()
    {
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            for (int r = matrix.GetLength(0) - 1; r >= 0; r--)
            {
                Console.Write(matrix[r, c]);
            }
            Console.WriteLine();
        }
    }

    private static void PrintWith180Rotation()
    {
        for (int r = matrix.GetLength(0) - 1; r >= 0; r--)
        {
            for (int c = matrix.GetLength(1) - 1; c >= 0; c--)
            {
                Console.Write(matrix[r, c]);
            }
            Console.WriteLine();
        }
    }

    private static void PrintWith270Rotation()
    {
        for (int c = matrix.GetLength(1) - 1; c >= 0; c--)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                Console.Write(matrix[r, c]);
            }
            Console.WriteLine();
        }
    }

    private static void PrintWithoutRotation()
    {
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                Console.Write(matrix[r, c]);
            }
            Console.WriteLine();
        }
    }
}
