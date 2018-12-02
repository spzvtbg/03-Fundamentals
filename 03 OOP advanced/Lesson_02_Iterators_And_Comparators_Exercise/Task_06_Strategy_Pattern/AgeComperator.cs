using System.Collections.Generic;

public class AgeComperator : IComparer<Person>
{
    public int Compare(Person person, Person otherPerson)
    {
        return person.Age.CompareTo(otherPerson.Age);
    }
}
