using System;

namespace _2.Diagonal_Difference
{
    public class DiagonalDifference
    {
        static int size;
        static int firstDiagonalSum;
        static int secondDiagonalSum;

        public static void Main()
        {
            InitializeCube();
            DiagonalsSum();
            PrintDiference();
        }

        public static void InitializeCube()
        {
            size = Convert.ToInt32(Console.ReadLine());
        }

        public static void DiagonalsSum()
        {
            for (int index = 0; index < size; index++)
            {
                var nums = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                firstDiagonalSum += Convert.ToInt32(nums[index]);
                secondDiagonalSum += Convert.ToInt32(nums[nums.Length - 1 - index]);
            }
        }

        public static void PrintDiference()
        {
            Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));
        }
    }
}