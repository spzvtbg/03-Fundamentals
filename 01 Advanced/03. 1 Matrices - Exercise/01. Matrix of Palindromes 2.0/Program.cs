using System;

namespace _1.Matrix_of_Palindromes
{
    public class Palindromes
    {
        static int rows;
        static int cols;
        static int rowIndex;
        static int colIndex;

        static int[,,] palindromes;

        public static void Main()
        {
            ReadCubeSize(Console.ReadLine());
            InitializeCube();
            MakePalindromes();
            PrintPalindromesCube();
        }

        public static void ReadCubeSize(string size)
        {
            var splited = size.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            rows = Convert.ToInt32(splited[0]);
            cols = Convert.ToInt32(splited[1]);
        }

        public static void InitializeCube()
        {
            palindromes = new int[rows, cols, 3];
        }

        public static void MakePalindromes()
        {
            for (rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                TakeCols();
            }
        }

        public static void TakeCols()
        {
            for (colIndex = 0; colIndex < cols; colIndex++)
            {
                palindromes[rowIndex, colIndex, 0] = rowIndex + 'a';
                palindromes[rowIndex, colIndex, 2] = rowIndex + 'a';
                palindromes[rowIndex, colIndex, 1] = rowIndex + colIndex + 'a';
            }
        }

        public static void PrintPalindromesCube()
        {
            for (rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                TrougthCols();
                Console.WriteLine();
            }
        }

        public static void TrougthCols()
        {
            for (colIndex = 0; colIndex < cols; colIndex++)
            {
                Console.Write("{0}{1}{2} ",
                    (char)palindromes[rowIndex, colIndex, 0],
                    (char)palindromes[rowIndex, colIndex, 1],
                    (char)palindromes[rowIndex, colIndex, 2]);
            }
        }
    }
}