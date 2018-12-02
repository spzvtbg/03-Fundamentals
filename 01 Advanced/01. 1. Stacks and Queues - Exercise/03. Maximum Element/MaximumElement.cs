using System;
using System.Collections.Generic;

public class MaximumElement
{
    public static void Main()
    {
        var maxNumber = int.MinValue;

        var numbers = new Stack<int>();
        var maxNumbers = new Stack<int>();

        var iterations = Convert.ToInt32(Console.ReadLine());
        for (int index = 0; index < iterations; index++)
        {
            var comands = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var comand = comands[0];
            if (comand == "1")
            {
                var number = Convert.ToInt32(comands[1]);
                numbers.Push(number);

                if (number > maxNumber)
                {
                    maxNumber = number;
                    maxNumbers.Push(maxNumber);
                }
            }
            else if (comand == "2")
            {
                var popedNumber = 0;
                if (numbers.Count > 0)
                {
                    popedNumber = numbers.Pop();
                }

                if (maxNumbers.Count > 0 && maxNumbers.Peek() == popedNumber)
                {
                    maxNumbers.Pop();
                }

                if (maxNumbers.Count > 0)
                {
                    maxNumber = maxNumbers.Peek();
                }
                else
                {
                    maxNumber = int.MinValue;
                }
            }
            else if (comand == "3")
            {
                if (maxNumbers.Count > 0)
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
