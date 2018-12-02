public class Employee
{
    private int age = -1;

    public Employee(string[] information)
    {
        ParseEmployeeData(information);
    }

    public  string Name { get; set; }

    public decimal Salary { get; set; }

    public string Position { get; set; }

    public string Department { get; set; }

    public string Email { get; set; }

    public int Age { get => this.age; set => this.age = value; }

    public void ParseEmployeeData(string[] information)
    {
        this.Name = information[0];
        this.Salary = decimal.Parse(information[1]);
        this.Position = information[2];
        this.Department = information[3];
        this.Email = "n/a";

        int length = information.Length;

        if (length > 4)
        {
            if (!int.TryParse(information[4], out this.age))
            {
                this.age = -1;
                this.Email = information[4];
            }

            if (length > 5)
            {
                this.age = int.Parse(information[5]);
            }
        }
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Salary:F2} {this.Email} {this.Age}";
    }
}
