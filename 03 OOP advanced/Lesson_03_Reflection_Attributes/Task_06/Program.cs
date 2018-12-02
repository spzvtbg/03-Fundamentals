using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var lights = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            lights = new string[] { "Red", "Green", "Yellow"};

            var times = Int32.Parse(Console.ReadLine());

            for (int count = 0; count < times; count++)
            {
                var temp = lights[lights.Length - 1];
                for (int index = lights.Length - 1; index > 0; index--)
                {
                    lights[index] = lights[index - 1];
                }
                lights[0] = temp;
                Console.WriteLine(string.Join(" ", lights));
            }
        }
    }
}
