using System;
using System.Collections.Generic;

public class SequenceWithQueue
{
    public static void Main()
    {
        var startNumber = Convert.ToInt64(Console.ReadLine());

        var helpQueue = new Queue<long>();
        helpQueue.Enqueue(startNumber);

        var resultSequence = new Queue<long>();
        resultSequence.Enqueue(helpQueue.Peek());

        while (resultSequence.Count <= 50)
        {
            for (int count = 0; count < 4; count++)
            {
                var currentNumber = helpQueue.Peek() + 1;
                helpQueue.Enqueue(currentNumber);
                resultSequence.Enqueue(currentNumber);

                currentNumber = 2* helpQueue.Peek() + 1;
                helpQueue.Enqueue(currentNumber);
                resultSequence.Enqueue(currentNumber);

                currentNumber = helpQueue.Dequeue() + 2;
                helpQueue.Enqueue(currentNumber);
                resultSequence.Enqueue(currentNumber);
            }
        }

        var outputSequence = resultSequence.ToArray();

        for (int i = 0; i < 50; i++)
        {
            Console.Write(outputSequence[i] + " ");
        }
        Console.WriteLine();
    }
}