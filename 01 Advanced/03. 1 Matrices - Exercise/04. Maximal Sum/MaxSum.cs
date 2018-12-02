namespace _04.Maximal_Sum
{
    using System;

    public class MaxSum
    {
        static int rows;
        static int cols;
        static int sum;
        static int currentRowIndex;
        static int currentColIndex;
        static int[,] matrix;

        public static void Main()
        {
            CreateMatrix();
            FillMatrix();
            FindMaxSum();
            ShowOutput();
        }

        public static void CreateMatrix()
        {
            string[] matrixSize = Console.ReadLine().Split();
            rows = Convert.ToInt32(matrixSize[0]);
            cols = Convert.ToInt32(matrixSize[1]);
            matrix = new int[rows, cols];
        }

        public static void FillMatrix()
        {
            for (int count = 0; count < rows; count++)
            {
                string[] row = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int index = 0; index < row.Length; index++)
                {
                    matrix[count, index] = Convert.ToInt32(row[index]);
                }
            }
        }

        public static void FindMaxSum()
        {
            int rowSum = 0;
            int colSum = 0;
            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    rowSum = 0;
                    for (int a = i; a < 3 + i; a++)
                    {
                        colSum = 0;
                        for (int b = j; b < 3 + j; b++)
                        {
                            colSum += matrix[a, b];
                        }
                        rowSum += colSum;
                    }
                    if (rowSum > sum)
                    {
                        sum = rowSum;
                        currentRowIndex = i;
                        currentColIndex = j;
                    }
                }
            }
        }

        public static void ShowOutput()
        {
            Console.WriteLine($"Sum = {sum}");
            for (int i = currentRowIndex; i < currentRowIndex + 3; i++)
            {
                for (int j = currentColIndex; j < currentColIndex + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
