using System.Collections.Generic;
using System.Linq;

public class Family
{
    private IEnumerable<Person> people;

    private Person oldestMember;

    private int index = 0;

    public Family(int length = 0)
    {
        if (this.people == null)
        {
            this.people = new Person[length];
        }

        this.Members = length;
    }

    public int Members { get; set; }

    public void AddMember(Person member)
    {
        if (this.people.ToArray().Length <= 0)
        {
            return;
        }

        if (this.oldestMember == null || member.Age > this.oldestMember.Age)
        {
            this.oldestMember = member;
        }
    }

    public Person GetOldestMember()
    {
        return this.oldestMember;
    }
}
