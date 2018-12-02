using System;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHouersPerDay) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoersPerDay = workHouersPerDay;
    }

    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException(ExceptionMessages.InvalidValue(nameof(this.weekSalary)));
            }

            this.weekSalary = value;
        }
    }

    public decimal WorkHoersPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException(ExceptionMessages.InvalidValue(nameof(this.workHoursPerDay)));
            }

            this.workHoursPerDay = value;
        }
    }

    public decimal SalaryPerHour
    {
        get
        {
            return this.WeekSalary / 5 / this.WorkHoersPerDay;
        }
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(base.ToString());
        stringBuilder.AppendLine($"Week Salary: {this.WeekSalary:F2}");
        stringBuilder.AppendLine($"Hours per day: {this.WorkHoersPerDay:F2}");
        stringBuilder.AppendLine($"Salary per hour: {this.SalaryPerHour:F2}");

        return stringBuilder.ToString().TrimEnd();
    }
}
