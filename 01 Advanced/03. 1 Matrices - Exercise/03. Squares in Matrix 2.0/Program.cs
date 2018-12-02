using System;

namespace _3.Squares_in_Matrix
{
    public class SquareMatrix
    {
        static int rows;
        static int rowIndex;

        static int cols;
        static int colIndex;

        static int subMatrixesCount = 0;

        static string[,] matrix;

        public static void Main()
        {
            InitializeMatrix();
            TakeValues();
            TakeEqualSubMatrixesCount();
            PrintEqualSubMatrixesCount();
        }

        public static void InitializeMatrix()
        {
            var size = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            rows = Convert.ToInt32(size[0]);
            cols = Convert.ToInt32(size[1]);
            matrix = new string[rows, cols];
        }

        public static void TakeValues()
        {
            for (rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                var strings = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                MakeNextRow(strings);
            }
        }

        public static void MakeNextRow(string[] strings)
        {
            for (colIndex = 0; colIndex < strings.Length; colIndex++)
            {
                matrix[rowIndex, colIndex] = strings[colIndex];
            }
        }

        public static void TakeEqualSubMatrixesCount()
        {
            for (rowIndex = 0; rowIndex < rows - 1; rowIndex++)
            {
                SubCols();
            }
        }

        public static void SubCols()
        {
            for (colIndex = 0; colIndex < cols - 1; colIndex++)
            {
                if (isEqual())
                {
                    subMatrixesCount++;
                }
            }
        }

        public static bool isEqual()
        {
            return matrix[rowIndex, colIndex] == matrix[rowIndex, colIndex + 1] &&
                matrix[rowIndex, colIndex + 1] == matrix[rowIndex + 1, colIndex] &&
                matrix[rowIndex + 1, colIndex] == matrix[rowIndex + 1, colIndex + 1];
        }

        private static void PrintEqualSubMatrixesCount()
        {
            Console.WriteLine(subMatrixesCount);
        }
    }
}