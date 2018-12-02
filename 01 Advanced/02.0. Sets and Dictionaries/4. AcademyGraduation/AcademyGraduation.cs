using System;
using System.Collections.Generic;
using System.Linq;

public class AcademyGraduation
{
    public static void Main()
    {
        var grades = new SortedDictionary<string, string>();

        var students = Convert.ToInt16(Console.ReadLine());
        for (int i = 0; i < students; i++)
        {
            var name = Console.ReadLine();
            var currentGrades = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray().Average();

            if (!grades.ContainsKey(name))
            {
                grades[name] = string.Empty;
            }
            grades[name] = $"{currentGrades}";
        }

        foreach (var item in grades)
        {
            Console.WriteLine($"{item.Key} is graduated with {item.Value}");
        }
    }
}
