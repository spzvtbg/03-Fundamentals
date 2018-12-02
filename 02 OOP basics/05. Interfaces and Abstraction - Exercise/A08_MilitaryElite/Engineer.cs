using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engineer : SpecialisedSoldier
{
    public Engineer(params string[] parameters) : base(parameters)
    {
        this.Repairs = new List<Repair>();
        this.SetRepairs(parameters.Skip(5));
    }

    public ICollection<Repair> Repairs { get; private set; }

    private void SetRepairs(IEnumerable<string> collection)
    {
        var name = string.Empty;
        var counter = 0;

        foreach (var item in collection)
        {
            if (counter % 2 == 0)
            {
                name = item;
            }
            else
            {
                this.Repairs.Add(new Repair(name, item));
            }

            counter++;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.AppendLine("Repairs:");

        foreach (var repair in this.Repairs)
        {
            sb.AppendLine($"  {repair.ToString()}");
        }

        return sb.ToString().Trim();
    }
}
