using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var studentData = Console.ReadLine().Split();
            var student = new Student(studentData[0], studentData[1], studentData[2]);

            var workerData = Console.ReadLine().Split();
            var worker = new Worker(workerData[0], workerData[1], decimal.Parse(workerData[2]), decimal.Parse(workerData[3]));

            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine(worker);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}