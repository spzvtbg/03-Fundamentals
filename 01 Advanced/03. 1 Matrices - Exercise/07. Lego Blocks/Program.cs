namespace _07.Lego_Blocks
{
    using System;

    public class Program
    {
        static int numberOfRows;
        static int minLength = int.MaxValue;
        static int maxLength = int.MinValue;

        static string reversed;

        static bool isFirst = true;

        static string[] joinedJaggedArray;
        static string[][] resultJaggedArray;

        public static void Main()
        {
            numberOfRows = Convert.ToInt32(Console.ReadLine());
            joinedJaggedArray = new string[numberOfRows];
            resultJaggedArray = new string[numberOfRows][];
            InitializeJoinedJaggedArray();
            InitializeJoinedJaggedArray();
            InitializeResultJaggedArray();
            ValidateRectangulareJaggedArray();
        }

        public static void InitializeJoinedJaggedArray()
        {
            if (isFirst)
            {
                JoinArray();
                isFirst = false;
            }
            else
            {
                JoinRevercedArray();
            }
        }

        public static void JoinArray()
        {
            for (int count = 0; count < numberOfRows; count++)
            {
                joinedJaggedArray[count] += $" {Console.ReadLine()}";
            }
        }

        public static void JoinRevercedArray()
        {
            for (int count = 0; count < numberOfRows; count++)
            {
                reversed = string.Empty;
                joinedJaggedArray[count] += " " + ReversedString(Console.ReadLine());
            }
        }

        public static string ReversedString(string input)
        {
            for(int index = input.Length - 1; index >= 0; index--)
            {
                reversed += input[index];
            }
            return reversed;
        }

        public static void InitializeResultJaggedArray()
        {
            for (int count = 0; count < numberOfRows; count++)
            {
                resultJaggedArray[count] = joinedJaggedArray[count]
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                ValidateMinLingth(resultJaggedArray[count].Length);
                validateMaxLength(resultJaggedArray[count].Length);
            }
        }

        public static void ValidateMinLingth(int length)
        {
            if (minLength > length)
            {
                minLength = length;
            }
        }

        public static void validateMaxLength(int length)
        {
            if (maxLength < length)
            {
                maxLength = length;
            }
        }

        public static void ValidateRectangulareJaggedArray()
        {
            if (minLength == maxLength)
            {
                PrintJaggedArrayContent();
            }
            else PrintJaggedArrayValuesCount();
        }

        public static void PrintJaggedArrayContent()
        {
            for (int row = 0; row < resultJaggedArray.Length; row++)
            {
                Console.WriteLine($"[{string.Join(", ", resultJaggedArray[row])}]");
            }
        }

        public static void PrintJaggedArrayValuesCount()
        {
            numberOfRows = 0;
            for (int row = 0; row < resultJaggedArray.Length; row++)
            {
                numberOfRows += resultJaggedArray[row].Length;
            }
            Console.WriteLine($"The total number of cells is: {numberOfRows}");
        }
    }
}
