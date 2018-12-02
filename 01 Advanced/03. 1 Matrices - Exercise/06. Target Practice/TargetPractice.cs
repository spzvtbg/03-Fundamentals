namespace _06.Target_Practice
{
    using System;

    public class TargetPractice
    {
        static int rows;
        static int cols;
        static int radius;
        static int impactRow;
        static int impactCol;
        static int index = 0;

        static string snake;
        static string[] input;

        static char[] targetElements;
        static char[,] target;

        public static void Main()
        {
            InitializeCurrentTarget();
            InitializeCurrentSnake();
            InitializeShotParameters();
            InitializeTargetArray();
            LoadTargetArrayIntoTarget();
            SetAllPlacesInRadiusAsEmpty();
            SwapAllEmptyElements();
            ShowCurrentTarget();
        }

        private static void InitializeCurrentTarget()
        {
            input = Console.ReadLine().Split();
            rows = Convert.ToInt32(input[0]);
            cols = Convert.ToInt32(input[1]);
            target = new char[rows, cols];
        }

        public static void InitializeCurrentSnake()
        {
            snake = Console.ReadLine();
        }

        public static void InitializeShotParameters()
        {
            input = Console.ReadLine().Split();
            impactRow = Convert.ToInt32(input[0]);
            impactCol = Convert.ToInt32(input[1]);
            radius = Convert.ToInt32(input[2]);
        }

        public static void InitializeTargetArray()
        {
            targetElements = new char[rows * cols];
            for (int index = 0; index < targetElements.Length; index++)
            {
                targetElements[index] = snake[index % snake.Length];
            }
        }

        public static void LoadTargetArrayIntoTarget()
        {
            bool statrtsToLeft = true;
            for (int row = rows - 1; row >= 0; row--)
            {
                if (statrtsToLeft)
                {
                    LoadToLeft(row);
                }
                else
                {
                    LoadToRight(row);
                }
                statrtsToLeft = !statrtsToLeft;
            }
        }

        public static void LoadToLeft(int row)
        {
            for (int col = cols - 1; col >= 0; col--)
            {
                target[row, col] = targetElements[index];
                index++;
            }
        }

        public static void LoadToRight(int row)
        {
            for (int col = 0; col < cols; col++)
            {
                target[row, col] = targetElements[index];
                index++;
            }
        }

        public static void SetAllPlacesInRadiusAsEmpty()
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (IsInRadius(row - impactRow, col - impactCol))
                    {
                        target[row, col] = ' ';
                    }
                }
            }
        }

        public static bool IsInRadius(int row, int col)
        {
            return row * row + col * col <= radius * radius;
        }

        public static void SwapAllEmptyElements()
        {
            for (int col = 0; col < cols; col++)
            {
                int row;
                string symbols = string.Empty;
                for (row = rows - 1; row >= 0; row--)
                {
                    if (target[row, col] != ' ')
                    {
                        symbols += target[row, col];
                        target[row, col] = ' ';
                    }
                }
                for (int i = 0; i < symbols.Length; i++)
                {
                    target[rows - i - 1, col] = symbols[i];
                }
            }
        }

        public static void ShowCurrentTarget()
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(target[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
