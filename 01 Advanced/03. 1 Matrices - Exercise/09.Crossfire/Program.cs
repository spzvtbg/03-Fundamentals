using System;

public class Program
{
    private const StringSplitOptions options = StringSplitOptions.RemoveEmptyEntries;

    private static int rows;
    private static int cols;
    private static int counter;
    private static int row;
    private static int col;
    private static int radius;
    private static int length;
    private static int rowLength;
    private static int rowStartIndex;
    private static int rowEndIndex;
    private static int colStartIndex;
    private static int colEndIndex;
    private static int nullableRows;
    private static int tCounter;

    private static bool hasChanges;
    private static bool hasNullableRows;

    private static int[] temporary;
    private static char[] separator = new char[] { ' ' };

    private static int[][] matrix;
    private static int[][] tMatrix;

    public static void Main()
    {
        ReadSize(Console.ReadLine().Split(separator, options));
        ReadCommand(Console.ReadLine().Split(separator, options));
    }

    private static void ReadCommand(string[] input)
    {
        if (input[0].ToLower() == "nuke")
        {
            Print();
            return;
        }
        ParseAndRule(input);
        ReadCommand(Console.ReadLine().Split(separator, options));
    }

    private static void ReadSize(string[] input)
    {
        rows = Convert.ToInt32(input[0]);
        cols = Convert.ToInt32(input[1]);
        InitializeFirstMatrixState();
    }

    private static void InitializeFirstMatrixState()
    {
        matrix = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            counter = row * cols + 1;
            matrix[row] = new int[cols];

            for (int col = 0; col < cols; col++)
            {
                matrix[row][col] = counter++;
            }
        }
    }

    private static void ParseAndRule(string[] input)
    {
        row = Convert.ToInt32(input[0]);
        col = Convert.ToInt32(input[1]);
        radius = Convert.ToInt32(input[2]);
        PrepairCommandToShoot();
    }

    private static void PrepairCommandToShoot()
    {
        hasChanges = false;
        if (IsValidRow(matrix.Length))
        {
            hasChanges = true;
            PrepareTargetRow();
            SetRowElementsToRemove();

            if (IsValidCol(matrix[row].Length))
            {
                PrepairTargetCol();
                SetColElementsToRemove();
            }
        }
        else if (IsValidCol(cols))
        {
            hasChanges = true;
            PrepairTargetCol();
            SetColElementsToRemove();
        }

        if (hasChanges)
        {
            Resize();
        }
    }

    private static bool IsValidRow(int maxValue)
    {
        return row >= 0 && row < maxValue;
    }

    private static bool IsValidCol(int maxValue)
    {
        return col >= 0 && col < maxValue;
    }

    private static void PrepareTargetRow()
    {
        length = col - radius;
        colStartIndex = length < 0 ? 0 : length;
        length = col + radius + 1;
        rowLength = matrix[row].Length;
        colEndIndex = length >= rowLength ? rowLength : length;
        SetRowElementsToRemove();
    }

    private static void PrepairTargetCol()
    {
        length = row - radius;
        rowStartIndex = length < 0 ? 0 : length;
        length = row + radius + 1;
        rowEndIndex = length >= matrix.Length ? matrix.Length : length;
        SetColElementsToRemove();
    }

    private static void SetRowElementsToRemove()
    {
        for (int c = colStartIndex; c < colEndIndex; c++)
        {
            if (c < matrix[row].Length)
            {
                matrix[row][c] = -1;
            }
        }
    }

    private static void SetColElementsToRemove()
    {
        for (int r = rowStartIndex; r < rowEndIndex; r++)
        {
            if (matrix[r].Length > col)
            {
                matrix[r][col] = -1;
            }
        }
    }

    private static void Resize()
    {
        nullableRows = 0;
        hasNullableRows = false;

        for (int r = 0; r < matrix.Length; r++)
        {
            SetCurrentRow(r);
        }

        if (hasNullableRows)
        {
            RemoveNullableRows();
        }
    }

    private static void SetCurrentRow(int r)
    {
        tCounter = 0;
        rowLength = matrix[r].Length;

        CountElementsToRemove(r);

        int temporaryLength = rowLength - tCounter;

        if (temporaryLength <= 0)
        {
            nullableRows++;
            hasNullableRows = true;
            matrix[r] = null;
            return;
        }

        counter = 0;
        temporary = new int[temporaryLength];

        SetTemporarayRow(r);

        matrix[r] = temporary;
    }

    private static void SetTemporarayRow(int r)
    {
        for (int c = 0; c < rowLength; c++)
        {
            if (matrix[r][c] != -1)
            {
                temporary[counter++] = matrix[r][c];
            }
        }
    }

    private static void CountElementsToRemove(int r)
    {
        for (int c = 0; c < matrix[r].Length; c++)
        {
            if (matrix[r][c] == -1)
            {
                tCounter++;
            }
        }
    }

    private static void RemoveNullableRows()
    {
        tCounter = 0;
        tMatrix = new int[matrix.Length - nullableRows][];

        for (int r = 0; r < matrix.Length; r++)
        {
            if (matrix[r] != null)
            {
                tMatrix[tCounter++] = matrix[r];
            }
        }

        matrix = tMatrix;
    }

    private static void Print()
    {
        for (int r = 0; r < matrix.Length; r++)
        {
            for (int c = 0; c < matrix[r].Length; c++)
            {
                Console.Write($"{matrix[r][c]} ");
            }
            Console.WriteLine();
        }
    }
}