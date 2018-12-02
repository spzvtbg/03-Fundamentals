public class Company
{
    public Company(string name, string department, string salary)
    {
        this.Name = name;
        this.Department = department;
        this.Salary = decimal.Parse(salary);
    }

    public string Name { get; set; }

    public string Department { get; set; }

    public decimal Salary { get; set; }

    public override string ToString()
    {
        return $"{this.Name} {this.Department} {this.Salary:F2}";
    }
}
