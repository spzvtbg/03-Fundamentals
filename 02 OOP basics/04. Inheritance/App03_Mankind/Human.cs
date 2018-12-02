using System;
using System.Text;

public abstract class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public virtual string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException(ExceptionMessages.InvalidName(nameof(this.firstName)));
            }

            if (value.Length < 4)
            {
                throw new ArgumentException(ExceptionMessages.InvalidName(4, nameof(this.firstName)));
            }

            this.firstName = value;
        }
    }

    public virtual string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException(ExceptionMessages.InvalidName(nameof(this.lastName)));
            }

            if (value.Length < 3)
            {
                throw new ArgumentException(ExceptionMessages.InvalidName(3, nameof(this.lastName)));
            }

            this.lastName = value;
        }
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"First Name: {this.FirstName}");
        stringBuilder.AppendLine($"Last Name: {this.LastName}");

        return stringBuilder.ToString().TrimEnd();
    }
}
