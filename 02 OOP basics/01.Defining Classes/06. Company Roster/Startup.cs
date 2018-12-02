using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int inputLines = int.Parse(Console.ReadLine());

        IDictionary<string, ICollection<Employee>> departments = new Dictionary<string, ICollection<Employee>>();

        for (int count = 0; count < inputLines; count++)
        {
            string[] data = Console.ReadLine().SplitBy(true, " ");

            string department = data[3];

            if (!departments.ContainsKey(department))
            {
                departments[department] = new List<Employee>();
            }

            departments[department].Add(new Employee(data));
        }

        var dep = departments
            .OrderByDescending(x => x.Value.Average(s => s.Salary))
            .First();

        Console.WriteLine($"Highest Average Salary: {dep.Key}");
        
        foreach (var employee in dep.Value.OrderByDescending(s => s.Salary))
        {
            Console.WriteLine(employee.ToString());
        }
    }
}
