using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Commando : SpecialisedSoldier
{
    public Commando(params string[] parameters) : base(parameters)
    {
        this.Missions = new List<Mission>();
        this.SetMisions(parameters.Skip(5));
    }

    public ICollection<Mission> Missions { get; private set; }

    private void SetMisions(IEnumerable<string> collection)
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
                try
                {
                    this.Missions.Add(new Mission(name, item));
                }
                catch
                {
                    continue;
                }
            }

            counter++;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.AppendLine("Missions:");

        foreach (var mission in this.Missions.Where(m => m.IsCompleted.ToLower() == "inprogress"))
        {
            sb.AppendLine($"  {mission.ToString()}");
        }

        return sb.ToString().Trim();
    }
}