using System.Collections.Generic;

public class Person
{
    public Person()
    {
        this.Children = new List<Person>();
        this.Parents = new List<Person>();
    }

    public Person(string value) : this()
    {
        this.SetProperty(value);
    }

    public string Name { get; set; }

    public string Birthday { get; set; }

    public List<Person> Children { get; set; }

    public List<Person> Parents { get; set; }

    public void SetProperty(string value)
    {
        if (value.Contains("/"))
        {
            this.Birthday = value;
        }
        else
        {
            this.Name = value;
        }
    }

    public Person GetMember(string value)
    {
        if (this.Name == value || this.Birthday == value)
        {
            return this;
        }

        foreach (var member in this.Parents)
        {
            member.GetMember(value);
        }

        foreach (var member in this.Children)
        {
            member.GetMember(value);
        }

        return null;
    }
}
