namespace _05.Rubiks_Matrix
{
    using System;

    public class RubickCube
    {
        static int rows;
        static int cols;

        public static void Main(string[] args)
        {
            int[,] initialCube = InitializeCube();
            int[,] operatingCube = new int[rows, cols];
            int commands = TakeCommandsNumber();

            CreateValues(initialCube);
            CreateValues(operatingCube);
            Run(commands, operatingCube);
            OrderByElements(operatingCube, initialCube);
        }

        public static int[,] InitializeCube()
        {
            string[] size = Console.ReadLine().Split();
            rows = Convert.ToInt32(size[0]);
            cols = Convert.ToInt32(size[0]);
            return new int[rows, cols];
        }

        public static int TakeCommandsNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void CreateValues(int[,] initialCube)
        {
            int currentNumber = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    currentNumber++;
                    initialCube[i, j] = currentNumber;
                }
            }
        }

        public static void Run(int commands, int[,] operatingCube)
        {
            for (int count = 0; count < commands; count++)
            {
                string[] command = Console.ReadLine().Split();
                int rowcol = Convert.ToInt32(command[0]);
                int move = Convert.ToInt32(command[2]);
                string direction = command[1];
                RowColDirectionMove(operatingCube, rowcol, direction, move);
            }
        }

        public static void RowColDirectionMove(int[,] cube, int rowcol, string direction, int move)
        {
            if (direction == "up")
            {
                MoveUp(cube, rowcol, move);
            }
            if (direction == "down")
            {
                MoveDown(cube, rowcol, move);
            }
            if (direction == "left")
            {
                MoveLeft(cube, rowcol, move);
            }
            if (direction == "right")
            {
                MoveRight(cube, rowcol, move);
            }
        }

        public static void MoveUp(int[,] cube, int rowcol, int moves)
        {
            for (int count = 0; count < moves % rows; count++)
            {
                int temporaryElement = cube[0, rowcol];
                for (int row = 0; row < rows - 1; row++)
                {
                    cube[row, rowcol] = cube[row + 1, rowcol];
                }
                cube[rows - 1, rowcol] = temporaryElement;
            }
        }

        public static void MoveDown(int[,] cube, int rowcol, int moves)
        {
            for (int count = 0; count < moves % rows; count++)
            {
                int temporaryElement = cube[rows - 1, rowcol];
                for (int row = rows - 1; row > 0; row--)
                {
                    cube[row, rowcol] = cube[row - 1, rowcol];
                }
                cube[0, rowcol] = temporaryElement;
            }
        }

        public static void MoveLeft(int[,] cube, int rowcol, int moves)
        {
            for (int count = 0; count < moves % cols; count++)
            {
                int temporaryElement = cube[rowcol, 0];
                for (int col = 0; col < cols - 1; col++)
                {
                    cube[rowcol, col] = cube[rowcol, col + 1];
                }
                cube[rowcol, cols - 1] = temporaryElement;
            }
        }

        public static void MoveRight(int[,] cube, int rowcol, int moves)
        {
            for (int count = 0; count < moves % cols; count++)
            {
                int temporaryElement = cube[rowcol, cols - 1];
                for (int col = cols - 1; col > 0; col--)
                {
                    cube[rowcol, col] = cube[rowcol, col - 1];
                }
                cube[rowcol, 0] = temporaryElement;
            }
        }

        public static void OrderByElements(int[,] operatingCube, int[,] initialCube)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (operatingCube[row, col] == initialCube[row, col])
                    {
                        Console.WriteLine("No swap required");
                    }
                    else FindAndSwap(initialCube, operatingCube, row, col);
                }
            }
        }

        public static void FindAndSwap(int[,] initialCube, int[,] operatingCube, int row, int col)
        {
            var toSwap = operatingCube[row, col];
            var toFind = initialCube[row, col];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (operatingCube[i, j] == toFind)
                    {
                        operatingCube[row, col] = toFind;
                        operatingCube[i, j] = toSwap;
                        Console.WriteLine($"Swap ({row}, {col}) with ({i}, {j})");
                    }
                }
            }
        }
    }
}
