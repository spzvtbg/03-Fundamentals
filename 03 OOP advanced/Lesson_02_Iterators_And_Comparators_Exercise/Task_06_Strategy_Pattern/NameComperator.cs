using System.Collections.Generic;

public class NameComperator : IComparer<Person>
{
    public int Compare(Person person, Person otherPerson)
    {
        var comparisonResult = person.Name.Length.CompareTo(otherPerson.Name.Length);

        if (comparisonResult != 0)
        {
            return comparisonResult;
        }

        return person.Name.ToLower()[0].CompareTo(otherPerson.Name.ToLower()[0]);
    }
}
