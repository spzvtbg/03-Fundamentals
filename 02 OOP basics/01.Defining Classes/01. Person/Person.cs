public class Person
{
    public Person() { }

    public Person(string name = "No name", int age = 1)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }
}
