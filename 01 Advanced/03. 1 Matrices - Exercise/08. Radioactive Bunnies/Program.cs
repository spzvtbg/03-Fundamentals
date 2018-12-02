namespace _08.Radioactive_Bunnies
{
    using System;
    using System.Linq;

    public class Program
    {
        static int playerRow = -1;
        static int playerCol = -1;

        public static void Main()
        {
            var sizesAsString = Console.ReadLine().Split();
            var rows = Convert.ToInt32(sizesAsString[0]);
            var cols = Convert.ToInt32(sizesAsString[1]);

            var bunnyHole = new char[rows][];
            var bunniesPositions = new int[rows * cols + 1][];

            for (int row = 0; row < rows; row++)
            {
                var content = Console.ReadLine();

                var colPlayerIndex = content.IndexOf("P");

                if (colPlayerIndex >= 0)
                {
                    playerRow = row;
                    playerCol = colPlayerIndex;
                }

                for (int col = 0; col < content.Length; col++)
                {
                    if (content[col] == 'B')
                    {
                        bunniesPositions[row + 1 * col + 1 + col] = new int[] { row, col };
                    }
                }

                bunnyHole[row] = content.ToCharArray();
            }

            //Console.WriteLine(bunnyHole.Length);

            var commands = Console.ReadLine().ToCharArray();
            var playResult = string.Empty;
            var isOut = false;

            foreach (var command in commands)
            {
                bunnyHole[playerRow][playerCol] = '.';

                if (command == 'U')
                {
                    playerRow--;
                }
                if (command == 'L')
                {
                    playerCol--;
                }
                if (command == 'R')
                {
                    playerCol++;
                }
                if (command == 'D')
                {
                    playerRow++;
                }

                bool isValidPlayerRow = playerRow >= 0 && playerRow < rows;
                bool isValidPlayerCol = playerCol >= 0 && playerCol < cols;

                if (isValidPlayerRow && isValidPlayerCol)
                {
                    if (bunnyHole[playerRow][playerCol] == '.')
                    {
                        bunnyHole[playerRow][playerCol] = 'P';
                    }
                    else
                    {
                        playResult = "dead:";
                        isOut = true;
                    }
                }
                else
                {
                    playResult = "won:";
                    isOut = true;
                }

                var fullPositions = bunniesPositions.Where(x => x != null).ToArray();

                foreach (var position in fullPositions)
                {
                    var bunnyRow = position[0];
                    var bunnyCol = position[1];

                    var isValidBunnyRow = bunnyRow - 1 >= 0 && bunnyRow - 1 < rows;
                    var isValidBunnyCol = bunnyCol >= 0 && bunnyCol < cols;

                    if (isValidBunnyRow && isValidBunnyCol)
                    {
                        if (bunnyHole[bunnyRow - 1][bunnyCol] == 'P')
                        {
                            playResult = "dead:";
                            isOut = true;
                        }
                        bunnyHole[bunnyRow - 1][bunnyCol] = 'B';
                        bunniesPositions[(bunnyRow - 1) * cols + bunnyCol] = new int[] { bunnyRow - 1, bunnyCol };
                    }

                    isValidBunnyRow = bunnyRow >= 0 && bunnyRow < rows;
                    isValidBunnyCol = bunnyCol - 1 >= 0 && bunnyCol - 1 < cols;

                    if (isValidBunnyRow && isValidBunnyCol)
                    {
                        if (bunnyHole[bunnyRow][bunnyCol - 1] == 'P')
                        {
                            playResult = "dead:";
                            isOut = true;
                        }
                        bunnyHole[bunnyRow][bunnyCol - 1] = 'B';
                        bunniesPositions[bunnyRow * cols + bunnyCol - 1] = new int[] { bunnyRow, bunnyCol - 1 };
                    }

                    isValidBunnyRow = bunnyRow >= 0 && bunnyRow < rows;
                    isValidBunnyCol = bunnyCol + 1 >= 0 && bunnyCol + 1 < cols;

                    if (isValidBunnyRow && isValidBunnyCol)
                    {
                        if (bunnyHole[bunnyRow][bunnyCol + 1] == 'P')
                        {
                            playResult = "dead:";
                            isOut = true;
                        }
                        bunnyHole[bunnyRow][bunnyCol + 1] = 'B';
                        bunniesPositions[bunnyRow * cols + bunnyCol + 1] = new int[] { bunnyRow, bunnyCol + 1 };
                    }

                    isValidBunnyRow = bunnyRow + 1 >= 0 && bunnyRow + 1 < rows;
                    isValidBunnyCol = bunnyCol >= 0 && bunnyCol < cols;

                    if (isValidBunnyRow && isValidBunnyCol)
                    {
                        if (bunnyHole[bunnyRow + 1][bunnyCol] == 'P')
                        {
                            playResult = "dead:";
                            isOut = true;
                        }
                        bunnyHole[bunnyRow + 1][bunnyCol] = 'B';
                        bunniesPositions[(bunnyRow + 1) * cols + bunnyCol] = new int[] { bunnyRow + 1, bunnyCol };
                    }
                }

                if (isOut)
                {
                    break;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(bunnyHole[row][col]);
                }
                Console.WriteLine();
            }

            playerRow = Math.Max(playerRow, 0);
            playerRow = Math.Min(playerRow, rows - 1);

            playerCol = Math.Max(playerCol, 0);
            playerCol = Math.Min(playerCol, cols - 1);

            Console.WriteLine($"{playResult} {playerRow} {playerCol}");
        }
    }
}